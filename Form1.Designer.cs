namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonbProcessImages = new System.Windows.Forms.Button();
            this.txtFolderLoc = new System.Windows.Forms.TextBox();
            this.bChooseFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbLogoLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonbProcessImages
            // 
            this.buttonbProcessImages.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonbProcessImages.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonbProcessImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbProcessImages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonbProcessImages.Location = new System.Drawing.Point(22, 161);
            this.buttonbProcessImages.Name = "buttonbProcessImages";
            this.buttonbProcessImages.Size = new System.Drawing.Size(727, 53);
            this.buttonbProcessImages.TabIndex = 0;
            this.buttonbProcessImages.Text = "Process Images";
            this.buttonbProcessImages.UseVisualStyleBackColor = false;
            this.buttonbProcessImages.Click += new System.EventHandler(this.buttonbProcessImages_Click);
            // 
            // txtFolderLoc
            // 
            this.txtFolderLoc.Location = new System.Drawing.Point(22, 93);
            this.txtFolderLoc.Name = "txtFolderLoc";
            this.txtFolderLoc.Size = new System.Drawing.Size(591, 20);
            this.txtFolderLoc.TabIndex = 1;
            // 
            // bChooseFolder
            // 
            this.bChooseFolder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChooseFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bChooseFolder.Location = new System.Drawing.Point(620, 93);
            this.bChooseFolder.Name = "bChooseFolder";
            this.bChooseFolder.Size = new System.Drawing.Size(129, 23);
            this.bChooseFolder.TabIndex = 2;
            this.bChooseFolder.Text = "Choose Folder";
            this.bChooseFolder.UseVisualStyleBackColor = false;
            this.bChooseFolder.Click += new System.EventHandler(this.bChooseFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "IMAGE DECODING TOOL ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(601, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cbLogoLocation
            // 
            this.cbLogoLocation.FormattingEnabled = true;
            this.cbLogoLocation.Items.AddRange(new object[] {
            "TOP-LEFT",
            "BOTTOM-RIGHT",
            "BOTTOM-LEFT",
            "TOP-RIGHT"});
            this.cbLogoLocation.Location = new System.Drawing.Point(220, 126);
            this.cbLogoLocation.Name = "cbLogoLocation";
            this.cbLogoLocation.Size = new System.Drawing.Size(163, 21);
            this.cbLogoLocation.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Location Of Logo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.buttonbProcessImages;
            this.ClientSize = new System.Drawing.Size(800, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLogoLocation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bChooseFolder);
            this.Controls.Add(this.txtFolderLoc);
            this.Controls.Add(this.buttonbProcessImages);
            this.Name = "Form1";
            this.Text = "Image Processor ( Foodies Terminal)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonbProcessImages;
        private System.Windows.Forms.TextBox txtFolderLoc;
        private System.Windows.Forms.Button bChooseFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbLogoLocation;
        private System.Windows.Forms.Label label2;
    }
}

