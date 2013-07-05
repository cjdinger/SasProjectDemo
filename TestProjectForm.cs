using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SAS.Shared.AddIns;

namespace SasProjectDemo
{
    public partial class TestProjectForm : SAS.Tasks.Toolkit.Controls.TaskForm
    {
        public TestProjectForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ImageList il = new ImageList();
            lvFlows.SmallImageList = il;
            lvFlows.LargeImageList = il;
            string projName = "None", taskName = "Unknown", flowName="Unknown";

            // get the handle to the project
            ISASProject proj = Consumer.GetProject();
            if (proj != null)
            {
                projName = proj.Name;
                // iterate through each process flow in the project
                foreach (ISASProjectProcessFlow f in proj.ProcessFlows)
                {
                    // create a top level group in the listview
                    ListViewGroup grp = new ListViewGroup(f.Name);
                    lvFlows.Groups.Add(grp);

                    // for each task in the project, add an item
                    foreach (ISASProjectTask t in f.GetTasks())
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { ((ISASProjectItem)t).Name, t.TaskType });
                        il.Images.Add(((ISASProjectItem)t).Name + t.TaskType, ((ISASProjectItem)t).GetIcon(true));
                        lvi.ImageKey = ((ISASProjectItem)t).Name + t.TaskType;
                        lvi.Group = grp;
                        lvi.Tag = t;
                        lvFlows.Items.Add(lvi);
                    }
                }
            }

            // get the current process flow
            ISASProjectProcessFlow flow = Consumer.GetThisProcessFlow();
            if (flow != null)
            {
                flowName = flow.Name;
            }

            // get properties for this task
            ISASProjectTask task = Consumer.GetThisTask();
            if (task != null)
            {
                taskName = ((ISASProjectItem)task).Name;
            }

            lblProjectName.Text = string.Format("THIS task is \"{1}\" in project \"{0}\", within process flow \"{2}\"", projName, taskName, flowName);

        }

        private void btnGetCode_Click(object sender, EventArgs e)
        {
            ISASProjectProcessFlow flow = Consumer.GetThisProcessFlow();
            string code = flow.GetAllSasCode(eSasCodeOptions.IncludeCustomCode | eSasCodeOptions.IncludeHeaders);
            SAS.Tasks.Toolkit.Controls.SASCodeViewDialog dlg = new SAS.Tasks.Toolkit.Controls.SASCodeViewDialog(this, flow.Name, code);
            dlg.ShowDialog();
        }

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            if (lvFlows.SelectedItems.Count == 2)
            {
                ISASProjectItem p1 = lvFlows.SelectedItems[0].Tag as ISASProjectItem;
                ISASProjectItem p2 = lvFlows.SelectedItems[1].Tag as ISASProjectItem;
                ISASProjectProcessFlow flow = Consumer.GetThisProcessFlow();

                if (flow.CanLink(p1, p2))
                    flow.AddLink(p1, p2);
                else
                    MessageBox.Show("Cannot link these two items");

            }
        }

        // check whether two selected items can be linked
        private bool canLinkItems()
        {
            if (lvFlows.SelectedItems.Count == 2)
            {
                ISASProjectItem p1 = lvFlows.SelectedItems[0].Tag as ISASProjectItem;
                ISASProjectItem p2 = lvFlows.SelectedItems[1].Tag as ISASProjectItem;
                ISASProjectProcessFlow flow = Consumer.GetThisProcessFlow();

                return flow.CanLink(p1, p2);
            }
            return false;
        }

        // check whether certain items can be linked and if they can, link them.
        private void OnTaskSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnAddLink.Enabled = (lvFlows.SelectedItems.Count == 2);
            if (btnAddLink.Enabled)
                btnAddLink.ForeColor = canLinkItems() ? Color.Navy : Color.Red;
            btnIsAncestorBtn.Enabled = (lvFlows.SelectedItems.Count == 2);
            btnShowCodeForPath.Enabled = (lvFlows.SelectedItems.Count == 1);
            if (e.IsSelected)
            {
                lvProperties.Items.Clear();
                if (e.Item.Tag is ISASProjectTask)
                {
                    ISASProjectTask pt = e.Item.Tag as ISASProjectTask;
                    lblSelection.Text = string.Format("Details for {0}", ((ISASProjectItem)pt).Name);
                    lvProperties.Items.Add(new ListViewItem(new string[] { "Type", "Project Task" }));
                    lvProperties.Items.Add(new ListViewItem(new string[] { "Name", ((ISASProjectItem)pt).Name }));
                    lvProperties.Items.Add(new ListViewItem(new string[] { "Task type", pt.TaskType }));
                    lvProperties.Items.Add(new ListViewItem(new string[] { "Modified by", ((ISASProjectItem)pt).ModifiedByUserId }));
                    lvProperties.Items.Add(new ListViewItem(new string[] { "Internal state", pt.InternalState }));

                    // get a list of input data sources according to project relationships
                    ListViewGroup grp = new ListViewGroup("Data in");
                    lvProperties.Groups.Add(grp);
                    try
                    {
                        List<ISASProjectData> dl = pt.GetInputDataList();
                        foreach (ISASProjectData pd in dl)
                        {
                            ListViewItem lvi = new ListViewItem(new string[] { pd.Name, pd.InputType.ToString() + "," + pd.Path + "," + pd.Server });
                            lvi.Group = grp;
                            lvProperties.Items.Add(lvi);
                        }
                    }
                    catch
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { "Error: Cannot access data properties" });
                    }
                }
            }
        }

        // get the SAS program code up to the point of the selected task
        private void btnGetCodeToHere_Click(object sender, EventArgs e)
        {
            if (lvFlows.SelectedItems.Count == 1)
            {
                ISASProjectTask p1 = lvFlows.SelectedItems[0].Tag as ISASProjectTask;
                if (p1 != null)
                {
                    ISASProjectProcessFlow flow = Consumer.GetThisProcessFlow();
                    string code = flow.GetSasCodeUpToHere(p1, true, eSasCodeOptions.IncludeCustomCode | eSasCodeOptions.IncludeHeaders);
                    SAS.Tasks.Toolkit.Controls.SASCodeViewDialog dlg = new SAS.Tasks.Toolkit.Controls.SASCodeViewDialog(this, flow.Name, code);
                    dlg.ShowDialog();
                }
            }

        }
        
        // get the SAS program code for this task and all of its ancestors
        private void btnShowCodeForPath_Click(object sender, EventArgs e)
        {
            if (lvFlows.SelectedItems.Count == 1)
            {
                ISASProjectTask p1 = lvFlows.SelectedItems[0].Tag as ISASProjectTask;
                if (p1 != null)
                {
                    ISASProjectProcessFlow flow = Consumer.GetThisProcessFlow();
                    string code = flow.GetSasCodeForThisPath(p1, true, eSasCodeOptions.IncludeCustomCode | eSasCodeOptions.IncludeHeaders);
                    SAS.Tasks.Toolkit.Controls.SASCodeViewDialog dlg = new SAS.Tasks.Toolkit.Controls.SASCodeViewDialog(this, flow.Name, code);
                    dlg.ShowDialog();
                }
            }
        }

        // check whether there is an "Ancestor" relationship between two selected items.
        private void btnIsAncestorBtn_Click(object sender, EventArgs e)
        {
            if (lvFlows.SelectedItems.Count == 2)
            {
                ISASProjectItem p1 = lvFlows.SelectedItems[0].Tag as ISASProjectItem;
                ISASProjectItem p2 = lvFlows.SelectedItems[1].Tag as ISASProjectItem;
                ISASProjectProcessFlow flow = Consumer.GetThisProcessFlow();

                if (flow.IsAncestor(p2, p1) == true)
                    MessageBox.Show(String.Format("{0} is an ancestor of {1}.", p1.Name, p2.Name));
                else
                    MessageBox.Show(String.Format("{0} is NOT an ancestor of {1}.", p1.Name, p2.Name));

            }
        }
    }
}