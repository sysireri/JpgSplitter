namespace JpgSplitter
{
    partial class FrmSplitter
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
            this.butLoad = new System.Windows.Forms.Button();
            this.txtInputJpg = new System.Windows.Forms.TextBox();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.panInput = new System.Windows.Forms.Panel();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.butBrowseOutputDirectory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LblInputImageInfo = new System.Windows.Forms.Label();
            this.ButSplitt = new System.Windows.Forms.Button();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.txtNextId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutPutDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSplit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZoom = new System.Windows.Forms.TextBox();
            this.FolOutput = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            this.panInput.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // butLoad
            // 
            this.butLoad.Location = new System.Drawing.Point(5, 16);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(75, 23);
            this.butLoad.TabIndex = 0;
            this.butLoad.Text = "Load";
            this.butLoad.UseVisualStyleBackColor = true;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // txtInputJpg
            // 
            this.txtInputJpg.Location = new System.Drawing.Point(90, 19);
            this.txtInputJpg.Name = "txtInputJpg";
            this.txtInputJpg.Size = new System.Drawing.Size(330, 20);
            this.txtInputJpg.TabIndex = 1;
            this.txtInputJpg.Text = "C:\\Users\\eric\\Desktop\\Nouveau dossier\\Scan_famille.jpg";
            // 
            // picInput
            // 
            this.picInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picInput.Location = new System.Drawing.Point(0, 76);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(317, 170);
            this.picInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picInput.TabIndex = 2;
            this.picInput.TabStop = false;
            // 
            // panInput
            // 
            this.panInput.AutoScroll = true;
            this.panInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panInput.Controls.Add(this.picInput);
            this.panInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panInput.Location = new System.Drawing.Point(0, 0);
            this.panInput.Name = "panInput";
            this.panInput.Size = new System.Drawing.Size(1215, 553);
            this.panInput.TabIndex = 0;
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.butBrowseOutputDirectory);
            this.grpControls.Controls.Add(this.label5);
            this.grpControls.Controls.Add(this.LblInputImageInfo);
            this.grpControls.Controls.Add(this.ButSplitt);
            this.grpControls.Controls.Add(this.chkOverwrite);
            this.grpControls.Controls.Add(this.txtNextId);
            this.grpControls.Controls.Add(this.label4);
            this.grpControls.Controls.Add(this.label3);
            this.grpControls.Controls.Add(this.txtOutPutDirectory);
            this.grpControls.Controls.Add(this.label2);
            this.grpControls.Controls.Add(this.cboSplit);
            this.grpControls.Controls.Add(this.label1);
            this.grpControls.Controls.Add(this.txtZoom);
            this.grpControls.Controls.Add(this.butLoad);
            this.grpControls.Controls.Add(this.txtInputJpg);
            this.grpControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpControls.Location = new System.Drawing.Point(0, 0);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(1215, 71);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            // 
            // butBrowseOutputDirectory
            // 
            this.butBrowseOutputDirectory.Location = new System.Drawing.Point(981, 40);
            this.butBrowseOutputDirectory.Name = "butBrowseOutputDirectory";
            this.butBrowseOutputDirectory.Size = new System.Drawing.Size(75, 23);
            this.butBrowseOutputDirectory.TabIndex = 14;
            this.butBrowseOutputDirectory.Text = "Browse";
            this.butBrowseOutputDirectory.UseVisualStyleBackColor = true;
            this.butBrowseOutputDirectory.Click += new System.EventHandler(this.butBrowseOutputDirectory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Image info :";
            // 
            // LblInputImageInfo
            // 
            this.LblInputImageInfo.AutoSize = true;
            this.LblInputImageInfo.Location = new System.Drawing.Point(155, 45);
            this.LblInputImageInfo.Name = "LblInputImageInfo";
            this.LblInputImageInfo.Size = new System.Drawing.Size(62, 13);
            this.LblInputImageInfo.TabIndex = 12;
            this.LblInputImageInfo.Text = "Image info :";
            // 
            // ButSplitt
            // 
            this.ButSplitt.Location = new System.Drawing.Point(651, 40);
            this.ButSplitt.Name = "ButSplitt";
            this.ButSplitt.Size = new System.Drawing.Size(75, 23);
            this.ButSplitt.TabIndex = 11;
            this.ButSplitt.Text = "Splitt";
            this.ButSplitt.UseVisualStyleBackColor = true;
            this.ButSplitt.Click += new System.EventHandler(this.ButSplitt_Click);
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Location = new System.Drawing.Point(885, 44);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(77, 17);
            this.chkOverwrite.TabIndex = 10;
            this.chkOverwrite.Text = "Over Write";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // txtNextId
            // 
            this.txtNextId.Location = new System.Drawing.Point(811, 42);
            this.txtNextId.Name = "txtNextId";
            this.txtNextId.Size = new System.Drawing.Size(42, 20);
            this.txtNextId.TabIndex = 9;
            this.txtNextId.Text = "0001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Next Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Split to :";
            // 
            // txtOutPutDirectory
            // 
            this.txtOutPutDirectory.Location = new System.Drawing.Point(811, 20);
            this.txtOutPutDirectory.Name = "txtOutPutDirectory";
            this.txtOutPutDirectory.Size = new System.Drawing.Size(330, 20);
            this.txtOutPutDirectory.TabIndex = 6;
            this.txtOutPutDirectory.Text = "C:\\Users\\eric\\Desktop\\Nouveau dossier\\OutPut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output directory :";
            // 
            // cboSplit
            // 
            this.cboSplit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSplit.FormattingEnabled = true;
            this.cboSplit.Location = new System.Drawing.Point(600, 18);
            this.cboSplit.Name = "cboSplit";
            this.cboSplit.Size = new System.Drawing.Size(59, 21);
            this.cboSplit.TabIndex = 4;
            this.cboSplit.DropDownClosed += new System.EventHandler(this.cboSplit_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zoom % :";
            // 
            // txtZoom
            // 
            this.txtZoom.Location = new System.Drawing.Point(489, 20);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Size = new System.Drawing.Size(42, 20);
            this.txtZoom.TabIndex = 2;
            this.txtZoom.Text = "25";
            // 
            // FolOutput
            // 
            this.FolOutput.SelectedPath = "C:\\Users\\eric\\Desktop\\Nouveau dossier\\OutPut";
            // 
            // FrmSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 553);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.panInput);
            this.Name = "FrmSplitter";
            this.Text = "Jpg Splitter Version : ";
            this.Load += new System.EventHandler(this.FrmSplitter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            this.panInput.ResumeLayout(false);
            this.panInput.PerformLayout();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.TextBox txtInputJpg;
        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.Panel panInput;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.TextBox txtZoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSplit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutPutDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNextId;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.Button ButSplitt;
        private System.Windows.Forms.Label LblInputImageInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog FolOutput;
        private System.Windows.Forms.Button butBrowseOutputDirectory;
    }
}

