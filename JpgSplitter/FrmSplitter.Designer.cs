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
            this.txtZoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.txtInputJpg.Location = new System.Drawing.Point(98, 19);
            this.txtInputJpg.Name = "txtInputJpg";
            this.txtInputJpg.Size = new System.Drawing.Size(330, 20);
            this.txtInputJpg.TabIndex = 1;
            this.txtInputJpg.Text = "C:\\Users\\eric\\Desktop\\Nouveau dossier\\Scan_famille.jpg";
            // 
            // picInput
            // 
            this.picInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picInput.Location = new System.Drawing.Point(20, 66);
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
            this.panInput.Size = new System.Drawing.Size(1013, 564);
            this.panInput.TabIndex = 0;
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.label1);
            this.grpControls.Controls.Add(this.txtZoom);
            this.grpControls.Controls.Add(this.butLoad);
            this.grpControls.Controls.Add(this.txtInputJpg);
            this.grpControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpControls.Location = new System.Drawing.Point(0, 0);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(1013, 51);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            // 
            // txtZoom
            // 
            this.txtZoom.Location = new System.Drawing.Point(499, 20);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Size = new System.Drawing.Size(51, 20);
            this.txtZoom.TabIndex = 2;
            this.txtZoom.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zoom :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 564);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.panInput);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

