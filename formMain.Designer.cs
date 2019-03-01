namespace CS_PDF_Tools
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.labelPathAndFileName1 = new System.Windows.Forms.Label();
            this.textboxPathAndFileName1 = new System.Windows.Forms.TextBox();
            this.buttonPathAndFileName1 = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.openfiledialogPDFFile = new System.Windows.Forms.OpenFileDialog();
            this.checkboxPDFFileBackup = new System.Windows.Forms.CheckBox();
            this.groupboxProcessType = new System.Windows.Forms.GroupBox();
            this.radiobuttonProcessTypeMergeFiles = new System.Windows.Forms.RadioButton();
            this.radiobuttonProcessTypePagesOrderInvert = new System.Windows.Forms.RadioButton();
            this.buttonPathAndFileName2 = new System.Windows.Forms.Button();
            this.textboxPathAndFileName2 = new System.Windows.Forms.TextBox();
            this.labelPathAndFileName2 = new System.Windows.Forms.Label();
            this.groupboxAppliesTo = new System.Windows.Forms.GroupBox();
            this.labelAppliesToPagesRangeTo = new System.Windows.Forms.Label();
            this.numericupdownAppliesToPagesRangeTo = new System.Windows.Forms.NumericUpDown();
            this.numericupdownAppliesToPagesRangeFrom = new System.Windows.Forms.NumericUpDown();
            this.radiobuttonAppliesToPagesRange = new System.Windows.Forms.RadioButton();
            this.radiobuttonAppliesToPagesAll = new System.Windows.Forms.RadioButton();
            this.groupboxProcessType.SuspendLayout();
            this.groupboxAppliesTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownAppliesToPagesRangeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownAppliesToPagesRangeFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPathAndFileName1
            // 
            this.labelPathAndFileName1.AutoSize = true;
            this.labelPathAndFileName1.Location = new System.Drawing.Point(12, 21);
            this.labelPathAndFileName1.Name = "labelPathAndFileName1";
            this.labelPathAndFileName1.Size = new System.Drawing.Size(65, 13);
            this.labelPathAndFileName1.TabIndex = 0;
            this.labelPathAndFileName1.Text = "PDF File - 1:";
            // 
            // textboxPathAndFileName1
            // 
            this.textboxPathAndFileName1.Location = new System.Drawing.Point(83, 18);
            this.textboxPathAndFileName1.Name = "textboxPathAndFileName1";
            this.textboxPathAndFileName1.Size = new System.Drawing.Size(367, 20);
            this.textboxPathAndFileName1.TabIndex = 1;
            // 
            // buttonPathAndFileName1
            // 
            this.buttonPathAndFileName1.Location = new System.Drawing.Point(452, 17);
            this.buttonPathAndFileName1.Name = "buttonPathAndFileName1";
            this.buttonPathAndFileName1.Size = new System.Drawing.Size(22, 22);
            this.buttonPathAndFileName1.TabIndex = 2;
            this.buttonPathAndFileName1.Text = "…";
            this.buttonPathAndFileName1.UseVisualStyleBackColor = true;
            this.buttonPathAndFileName1.Click += new System.EventHandler(this.buttonPathAndFileName1_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(371, 247);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(103, 32);
            this.buttonProcess.TabIndex = 8;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // openfiledialogPDFFile
            // 
            this.openfiledialogPDFFile.Filter = "Adobe PDF files|*.pdf|All files|*.*";
            this.openfiledialogPDFFile.ReadOnlyChecked = true;
            this.openfiledialogPDFFile.RestoreDirectory = true;
            // 
            // checkboxPDFFileBackup
            // 
            this.checkboxPDFFileBackup.AutoSize = true;
            this.checkboxPDFFileBackup.Checked = true;
            this.checkboxPDFFileBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxPDFFileBackup.Location = new System.Drawing.Point(15, 262);
            this.checkboxPDFFileBackup.Name = "checkboxPDFFileBackup";
            this.checkboxPDFFileBackup.Size = new System.Drawing.Size(177, 17);
            this.checkboxPDFFileBackup.TabIndex = 9;
            this.checkboxPDFFileBackup.Text = "Backup file(s) before processing";
            this.checkboxPDFFileBackup.UseVisualStyleBackColor = true;
            // 
            // groupboxProcessType
            // 
            this.groupboxProcessType.Controls.Add(this.radiobuttonProcessTypeMergeFiles);
            this.groupboxProcessType.Controls.Add(this.radiobuttonProcessTypePagesOrderInvert);
            this.groupboxProcessType.Location = new System.Drawing.Point(12, 83);
            this.groupboxProcessType.Name = "groupboxProcessType";
            this.groupboxProcessType.Size = new System.Drawing.Size(462, 77);
            this.groupboxProcessType.TabIndex = 6;
            this.groupboxProcessType.TabStop = false;
            this.groupboxProcessType.Text = "Process type:";
            // 
            // radiobuttonProcessTypeMergeFiles
            // 
            this.radiobuttonProcessTypeMergeFiles.AutoSize = true;
            this.radiobuttonProcessTypeMergeFiles.Location = new System.Drawing.Point(15, 48);
            this.radiobuttonProcessTypeMergeFiles.Name = "radiobuttonProcessTypeMergeFiles";
            this.radiobuttonProcessTypeMergeFiles.Size = new System.Drawing.Size(160, 17);
            this.radiobuttonProcessTypeMergeFiles.TabIndex = 1;
            this.radiobuttonProcessTypeMergeFiles.Text = "Merge files alternating pages";
            this.radiobuttonProcessTypeMergeFiles.UseVisualStyleBackColor = true;
            // 
            // radiobuttonProcessTypePagesOrderInvert
            // 
            this.radiobuttonProcessTypePagesOrderInvert.AutoSize = true;
            this.radiobuttonProcessTypePagesOrderInvert.Location = new System.Drawing.Point(15, 25);
            this.radiobuttonProcessTypePagesOrderInvert.Name = "radiobuttonProcessTypePagesOrderInvert";
            this.radiobuttonProcessTypePagesOrderInvert.Size = new System.Drawing.Size(111, 17);
            this.radiobuttonProcessTypePagesOrderInvert.TabIndex = 0;
            this.radiobuttonProcessTypePagesOrderInvert.Text = "Invert pages order";
            this.radiobuttonProcessTypePagesOrderInvert.UseVisualStyleBackColor = true;
            this.radiobuttonProcessTypePagesOrderInvert.CheckedChanged += new System.EventHandler(this.ProcessTypeChanged);
            // 
            // buttonPathAndFileName2
            // 
            this.buttonPathAndFileName2.Location = new System.Drawing.Point(452, 43);
            this.buttonPathAndFileName2.Name = "buttonPathAndFileName2";
            this.buttonPathAndFileName2.Size = new System.Drawing.Size(22, 22);
            this.buttonPathAndFileName2.TabIndex = 5;
            this.buttonPathAndFileName2.Text = "…";
            this.buttonPathAndFileName2.UseVisualStyleBackColor = true;
            this.buttonPathAndFileName2.Visible = false;
            this.buttonPathAndFileName2.Click += new System.EventHandler(this.buttonPathAndFileName2_Click);
            // 
            // textboxPathAndFileName2
            // 
            this.textboxPathAndFileName2.Location = new System.Drawing.Point(83, 44);
            this.textboxPathAndFileName2.Name = "textboxPathAndFileName2";
            this.textboxPathAndFileName2.Size = new System.Drawing.Size(367, 20);
            this.textboxPathAndFileName2.TabIndex = 4;
            this.textboxPathAndFileName2.Visible = false;
            // 
            // labelPathAndFileName2
            // 
            this.labelPathAndFileName2.AutoSize = true;
            this.labelPathAndFileName2.Location = new System.Drawing.Point(12, 47);
            this.labelPathAndFileName2.Name = "labelPathAndFileName2";
            this.labelPathAndFileName2.Size = new System.Drawing.Size(65, 13);
            this.labelPathAndFileName2.TabIndex = 3;
            this.labelPathAndFileName2.Text = "PDF File - 2:";
            this.labelPathAndFileName2.Visible = false;
            // 
            // groupboxAppliesTo
            // 
            this.groupboxAppliesTo.Controls.Add(this.labelAppliesToPagesRangeTo);
            this.groupboxAppliesTo.Controls.Add(this.numericupdownAppliesToPagesRangeTo);
            this.groupboxAppliesTo.Controls.Add(this.numericupdownAppliesToPagesRangeFrom);
            this.groupboxAppliesTo.Controls.Add(this.radiobuttonAppliesToPagesRange);
            this.groupboxAppliesTo.Controls.Add(this.radiobuttonAppliesToPagesAll);
            this.groupboxAppliesTo.Enabled = false;
            this.groupboxAppliesTo.Location = new System.Drawing.Point(12, 175);
            this.groupboxAppliesTo.Name = "groupboxAppliesTo";
            this.groupboxAppliesTo.Size = new System.Drawing.Size(261, 75);
            this.groupboxAppliesTo.TabIndex = 7;
            this.groupboxAppliesTo.TabStop = false;
            this.groupboxAppliesTo.Text = "Applies to:";
            // 
            // labelAppliesToPagesRangeTo
            // 
            this.labelAppliesToPagesRangeTo.AutoSize = true;
            this.labelAppliesToPagesRangeTo.Location = new System.Drawing.Point(163, 44);
            this.labelAppliesToPagesRangeTo.Name = "labelAppliesToPagesRangeTo";
            this.labelAppliesToPagesRangeTo.Size = new System.Drawing.Size(19, 13);
            this.labelAppliesToPagesRangeTo.TabIndex = 3;
            this.labelAppliesToPagesRangeTo.Text = "to:";
            // 
            // numericupdownAppliesToPagesRangeTo
            // 
            this.numericupdownAppliesToPagesRangeTo.Location = new System.Drawing.Point(188, 42);
            this.numericupdownAppliesToPagesRangeTo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericupdownAppliesToPagesRangeTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericupdownAppliesToPagesRangeTo.Name = "numericupdownAppliesToPagesRangeTo";
            this.numericupdownAppliesToPagesRangeTo.Size = new System.Drawing.Size(56, 20);
            this.numericupdownAppliesToPagesRangeTo.TabIndex = 4;
            this.numericupdownAppliesToPagesRangeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericupdownAppliesToPagesRangeTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericupdownAppliesToPagesRangeFrom
            // 
            this.numericupdownAppliesToPagesRangeFrom.Location = new System.Drawing.Point(101, 42);
            this.numericupdownAppliesToPagesRangeFrom.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericupdownAppliesToPagesRangeFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericupdownAppliesToPagesRangeFrom.Name = "numericupdownAppliesToPagesRangeFrom";
            this.numericupdownAppliesToPagesRangeFrom.Size = new System.Drawing.Size(56, 20);
            this.numericupdownAppliesToPagesRangeFrom.TabIndex = 2;
            this.numericupdownAppliesToPagesRangeFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericupdownAppliesToPagesRangeFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radiobuttonAppliesToPagesRange
            // 
            this.radiobuttonAppliesToPagesRange.AutoSize = true;
            this.radiobuttonAppliesToPagesRange.Location = new System.Drawing.Point(15, 42);
            this.radiobuttonAppliesToPagesRange.Name = "radiobuttonAppliesToPagesRange";
            this.radiobuttonAppliesToPagesRange.Size = new System.Drawing.Size(78, 17);
            this.radiobuttonAppliesToPagesRange.TabIndex = 1;
            this.radiobuttonAppliesToPagesRange.Text = "From page:";
            this.radiobuttonAppliesToPagesRange.UseVisualStyleBackColor = true;
            // 
            // radiobuttonAppliesToPagesAll
            // 
            this.radiobuttonAppliesToPagesAll.AutoSize = true;
            this.radiobuttonAppliesToPagesAll.Checked = true;
            this.radiobuttonAppliesToPagesAll.Location = new System.Drawing.Point(15, 19);
            this.radiobuttonAppliesToPagesAll.Name = "radiobuttonAppliesToPagesAll";
            this.radiobuttonAppliesToPagesAll.Size = new System.Drawing.Size(68, 17);
            this.radiobuttonAppliesToPagesAll.TabIndex = 0;
            this.radiobuttonAppliesToPagesAll.TabStop = true;
            this.radiobuttonAppliesToPagesAll.Text = "All pages";
            this.radiobuttonAppliesToPagesAll.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 291);
            this.Controls.Add(this.groupboxAppliesTo);
            this.Controls.Add(this.buttonPathAndFileName2);
            this.Controls.Add(this.textboxPathAndFileName2);
            this.Controls.Add(this.labelPathAndFileName2);
            this.Controls.Add(this.checkboxPDFFileBackup);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.groupboxProcessType);
            this.Controls.Add(this.buttonPathAndFileName1);
            this.Controls.Add(this.textboxPathAndFileName1);
            this.Controls.Add(this.labelPathAndFileName1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.groupboxProcessType.ResumeLayout(false);
            this.groupboxProcessType.PerformLayout();
            this.groupboxAppliesTo.ResumeLayout(false);
            this.groupboxAppliesTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownAppliesToPagesRangeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownAppliesToPagesRangeFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPathAndFileName1;
        private System.Windows.Forms.TextBox textboxPathAndFileName1;
        private System.Windows.Forms.Button buttonPathAndFileName1;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.OpenFileDialog openfiledialogPDFFile;
        private System.Windows.Forms.CheckBox checkboxPDFFileBackup;
        private System.Windows.Forms.GroupBox groupboxProcessType;
        private System.Windows.Forms.RadioButton radiobuttonProcessTypePagesOrderInvert;
        private System.Windows.Forms.RadioButton radiobuttonProcessTypeMergeFiles;
        private System.Windows.Forms.Button buttonPathAndFileName2;
        private System.Windows.Forms.TextBox textboxPathAndFileName2;
        private System.Windows.Forms.Label labelPathAndFileName2;
        private System.Windows.Forms.GroupBox groupboxAppliesTo;
        private System.Windows.Forms.Label labelAppliesToPagesRangeTo;
        private System.Windows.Forms.NumericUpDown numericupdownAppliesToPagesRangeTo;
        private System.Windows.Forms.NumericUpDown numericupdownAppliesToPagesRangeFrom;
        private System.Windows.Forms.RadioButton radiobuttonAppliesToPagesRange;
        private System.Windows.Forms.RadioButton radiobuttonAppliesToPagesAll;
    }
}

