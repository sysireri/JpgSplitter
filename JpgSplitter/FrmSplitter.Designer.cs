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
            this.label2 = new System.Windows.Forms.Label();
            this.cboSplit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZoom = new System.Windows.Forms.TextBox();
            this.txtOutPutDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNextId = new System.Windows.Forms.TextBox();
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
            this.picInput.Location = new System.Drawing.Point(27, 109);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 23);
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
            // txtOutPutDirectory
            // 
            this.txtOutPutDirectory.Location = new System.Drawing.Point(770, 20);
            this.txtOutPutDirectory.Name = "txtOutPutDirectory";
            this.txtOutPutDirectory.Size = new System.Drawing.Size(330, 20);
            this.txtOutPutDirectory.TabIndex = 6;
            this.txtOutPutDirectory.Text = "C:\\Users\\eric\\Desktop\\Nouveau dossier\\";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Next Id :";
            // 
            // txtNextId
            // 
            this.txtNextId.Location = new System.Drawing.Point(770, 42);
            this.txtNextId.Name = "txtNextId";
            this.txtNextId.Size = new System.Drawing.Size(42, 20);
            this.txtNextId.TabIndex = 9;
            this.txtNextId.Text = "9";
            // 
            // FrmSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 553);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.panInput);
            this.Name = "FrmSplitter";
            this.Text = "Form1";
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
    }
}

