namespace SasProjectDemo
{
    partial class TestProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnGetCode = new System.Windows.Forms.Button();
            this.lvProperties = new System.Windows.Forms.ListView();
            this.chProperty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddLink = new System.Windows.Forms.Button();
            this.lblSelection = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lvFlows = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGetCodeToHere = new System.Windows.Forms.Button();
            this.btnIsAncestorBtn = new System.Windows.Forms.Button();
            this.btnShowCodeForPath = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(11, 10);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(80, 13);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "<project name>";
            // 
            // btnGetCode
            // 
            this.btnGetCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCode.Location = new System.Drawing.Point(286, 236);
            this.btnGetCode.Name = "btnGetCode";
            this.btnGetCode.Size = new System.Drawing.Size(130, 23);
            this.btnGetCode.TabIndex = 4;
            this.btnGetCode.Text = "Show code for flow";
            this.btnGetCode.UseVisualStyleBackColor = true;
            this.btnGetCode.Click += new System.EventHandler(this.btnGetCode_Click);
            // 
            // lvProperties
            // 
            this.lvProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProperty,
            this.chValue});
            this.lvProperties.Location = new System.Drawing.Point(14, 296);
            this.lvProperties.Name = "lvProperties";
            this.lvProperties.Size = new System.Drawing.Size(671, 157);
            this.lvProperties.TabIndex = 7;
            this.lvProperties.UseCompatibleStateImageBehavior = false;
            this.lvProperties.View = System.Windows.Forms.View.Details;
            // 
            // chProperty
            // 
            this.chProperty.Text = "Property";
            this.chProperty.Width = 181;
            // 
            // chValue
            // 
            this.chValue.Text = "Value";
            this.chValue.Width = 486;
            // 
            // btnAddLink
            // 
            this.btnAddLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddLink.Location = new System.Drawing.Point(14, 236);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(130, 23);
            this.btnAddLink.TabIndex = 2;
            this.btnAddLink.Text = "Link these items";
            this.btnAddLink.UseVisualStyleBackColor = true;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // lblSelection
            // 
            this.lblSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(14, 277);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(74, 13);
            this.lblSelection.TabIndex = 9;
            this.lblSelection.Text = "Details for {0}:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 466);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(699, 35);
            this.pnlButtons.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(613, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(532, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lvFlows
            // 
            this.lvFlows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFlows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chType});
            this.lvFlows.FullRowSelect = true;
            this.lvFlows.HideSelection = false;
            this.lvFlows.Location = new System.Drawing.Point(14, 30);
            this.lvFlows.Name = "lvFlows";
            this.lvFlows.Size = new System.Drawing.Size(671, 200);
            this.lvFlows.TabIndex = 1;
            this.lvFlows.UseCompatibleStateImageBehavior = false;
            this.lvFlows.View = System.Windows.Forms.View.Details;
            this.lvFlows.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OnTaskSelectionChanged);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 314;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 352;
            // 
            // btnGetCodeToHere
            // 
            this.btnGetCodeToHere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCodeToHere.Location = new System.Drawing.Point(422, 236);
            this.btnGetCodeToHere.Name = "btnGetCodeToHere";
            this.btnGetCodeToHere.Size = new System.Drawing.Size(130, 23);
            this.btnGetCodeToHere.TabIndex = 5;
            this.btnGetCodeToHere.Text = "Show code up to point";
            this.btnGetCodeToHere.UseVisualStyleBackColor = true;
            this.btnGetCodeToHere.Click += new System.EventHandler(this.btnGetCodeToHere_Click);
            // 
            // btnIsAncestorBtn
            // 
            this.btnIsAncestorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIsAncestorBtn.Location = new System.Drawing.Point(150, 236);
            this.btnIsAncestorBtn.Name = "btnIsAncestorBtn";
            this.btnIsAncestorBtn.Size = new System.Drawing.Size(130, 23);
            this.btnIsAncestorBtn.TabIndex = 3;
            this.btnIsAncestorBtn.Text = "Is this an ancestor?";
            this.btnIsAncestorBtn.UseVisualStyleBackColor = true;
            this.btnIsAncestorBtn.Click += new System.EventHandler(this.btnIsAncestorBtn_Click);
            // 
            // btnShowCodeForPath
            // 
            this.btnShowCodeForPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowCodeForPath.Location = new System.Drawing.Point(558, 236);
            this.btnShowCodeForPath.Name = "btnShowCodeForPath";
            this.btnShowCodeForPath.Size = new System.Drawing.Size(130, 23);
            this.btnShowCodeForPath.TabIndex = 6;
            this.btnShowCodeForPath.Text = "Show code for path";
            this.btnShowCodeForPath.UseVisualStyleBackColor = true;
            this.btnShowCodeForPath.Click += new System.EventHandler(this.btnShowCodeForPath_Click);
            // 
            // TestProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 501);
            this.Controls.Add(this.btnShowCodeForPath);
            this.Controls.Add(this.btnIsAncestorBtn);
            this.Controls.Add(this.btnGetCodeToHere);
            this.Controls.Add(this.lvFlows);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.btnAddLink);
            this.Controls.Add(this.lvProperties);
            this.Controls.Add(this.btnGetCode);
            this.Controls.Add(this.lblProjectName);
            this.Name = "TestProjectForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestProjectForm";
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnGetCode;
        private System.Windows.Forms.ListView lvProperties;
        private System.Windows.Forms.ColumnHeader chProperty;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lvFlows;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.Button btnGetCodeToHere;
        private System.Windows.Forms.Button btnIsAncestorBtn;
        private System.Windows.Forms.Button btnShowCodeForPath;
    }
}