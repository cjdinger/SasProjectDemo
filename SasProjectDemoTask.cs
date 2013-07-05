using System;
using System.Text;
using SAS.Shared.AddIns;
using SAS.Tasks.Toolkit;

namespace SasProjectDemo
{
    // unique identifier for this task
    [ClassId("288B45D2-2E6A-4EC3-9F41-8436C81D9818")]
    // location of the task icon to show in the menu and process flow
    [IconLocation("SasProjectDemo.task.ico")]
    // does this task require input data? 
    // InputResourceType.Data for data set, or 
    // InputResourceType.None for none required
    [InputRequired(InputResourceType.None)]
    public class SasProjectDemoTask : SAS.Tasks.Toolkit.SasTask
    {

        #region Initialization
        public SasProjectDemoTask()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // 
            // SasProjectDemoTask
            // 
            this.GeneratesSasCode = false;
            this.TaskCategory = "SAS Examples";
            this.TaskDescription = "Demonstrate ISASProject APIs";
            this.TaskName = "Test ISASProject APIs";

        }
        #endregion

        #region overrides
        public override bool Initialize()
        {
            return true;
        }

        /// <summary>
        /// Show the task user interface
        /// </summary>
        /// <param name="Owner"></param>
        /// <returns>whether to cancel the task, or run now</returns>
        public override ShowResult Show(System.Windows.Forms.IWin32Window Owner)
        {
            TestProjectForm dlg = new TestProjectForm();
            dlg.Consumer = this.Consumer;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return SAS.Shared.AddIns.ShowResult.RunLater;
            else return ShowResult.Canceled;
        }

        #endregion

    }
}
