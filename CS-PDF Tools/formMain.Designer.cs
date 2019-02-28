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
            this.radiobuttonMergeFiles = new System.Windows.Forms.RadioButton();
            this.radiobuttonPagesOrderInvert = new System.Windows.Forms.RadioButton();
            this.buttonPathAndFileName2 = new System.Windows.Forms.Button();
            this.textboxPathAndFileName2 = new System.Windows.Forms.TextBox();
            this.labelPathAndFileName2 = new System.Windows.Forms.Label();
            this.groupboxProcessType.SuspendLayout();
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
            this.buttonProcess.TabIndex = 7;
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
            this.checkboxPDFFileBackup.TabIndex = 8;
            this.checkboxPDFFileBackup.Text = "Backup file(s) before processing";
            this.checkboxPDFFileBackup.UseVisualStyleBackColor = true;
            // 
            // groupboxProcessType
            // 
            this.groupboxProcessType.Controls.Add(this.radiobuttonMergeFiles);
            this.groupboxProcessType.Controls.Add(this.radiobuttonPagesOrderInvert);
            this.groupboxProcessType.Location = new System.Drawing.Point(12, 90);
            this.groupboxProcessType.Name = "groupboxProcessType";
            this.groupboxProcessType.Size = new System.Drawing.Size(462, 135);
            this.groupboxProcessType.TabIndex = 6;
            this.groupboxProcessType.TabStop = false;
            this.groupboxProcessType.Text = "Process type:";
            // 
            // radiobuttonMergeFiles
            // 
            this.radiobuttonMergeFiles.AutoSize = true;
            this.radiobuttonMergeFiles.Location = new System.Drawing.Point(15, 55);
            this.radiobuttonMergeFiles.Name = "radiobuttonMergeFiles";
            this.radiobuttonMergeFiles.Size = new System.Drawing.Size(160, 17);
            this.radiobuttonMergeFiles.TabIndex = 1;
            this.radiobuttonMergeFiles.Text = "Merge files alternating pages";
            this.radiobuttonMergeFiles.UseVisualStyleBackColor = true;
            // 
            // radiobuttonPagesOrderInvert
            // 
            this.radiobuttonPagesOrderInvert.AutoSize = true;
            this.radiobuttonPagesOrderInvert.Location = new System.Drawing.Point(15, 25);
            this.radiobuttonPagesOrderInvert.Name = "radiobuttonPagesOrderInvert";
            this.radiobuttonPagesOrderInvert.Size = new System.Drawing.Size(111, 17);
            this.radiobuttonPagesOrderInvert.TabIndex = 0;
            this.radiobuttonPagesOrderInvert.Text = "Invert pages order";
            this.radiobuttonPagesOrderInvert.UseVisualStyleBackColor = true;
            // 
            // buttonPathAndFileName2
            // 
            this.buttonPathAndFileName2.Location = new System.Drawing.Point(452, 43);
            this.buttonPathAndFileName2.Name = "buttonPathAndFileName2";
            this.buttonPathAndFileName2.Size = new System.Drawing.Size(22, 22);
            this.buttonPathAndFileName2.TabIndex = 5;
            this.buttonPathAndFileName2.Text = "…";
            this.buttonPathAndFileName2.UseVisualStyleBackColor = true;
            this.buttonPathAndFileName2.Click += new System.EventHandler(this.buttonPathAndFileName2_Click);
            // 
            // textboxPathAndFileName2
            // 
            this.textboxPathAndFileName2.Location = new System.Drawing.Point(83, 44);
            this.textboxPathAndFileName2.Name = "textboxPathAndFileName2";
            this.textboxPathAndFileName2.Size = new System.Drawing.Size(367, 20);
            this.textboxPathAndFileName2.TabIndex = 4;
            // 
            // labelPathAndFileName2
            // 
            this.labelPathAndFileName2.AutoSize = true;
            this.labelPathAndFileName2.Location = new System.Drawing.Point(12, 47);
            this.labelPathAndFileName2.Name = "labelPathAndFileName2";
            this.labelPathAndFileName2.Size = new System.Drawing.Size(65, 13);
            this.labelPathAndFileName2.TabIndex = 3;
            this.labelPathAndFileName2.Text = "PDF File - 2:";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 291);
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
        private System.Windows.Forms.RadioButton radiobuttonPagesOrderInvert;
        private System.Windows.Forms.RadioButton radiobuttonMergeFiles;
        private System.Windows.Forms.Button buttonPathAndFileName2;
        private System.Windows.Forms.TextBox textboxPathAndFileName2;
        private System.Windows.Forms.Label labelPathAndFileName2;
    }
}

