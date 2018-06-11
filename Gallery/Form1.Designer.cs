namespace Gallery
{
    partial class FormGallery
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
            this.TPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ListFiles = new System.Windows.Forms.ListBox();
            this.BPrev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TPath
            // 
            this.TPath.Location = new System.Drawing.Point(71, 17);
            this.TPath.Name = "TPath";
            this.TPath.ReadOnly = true;
            this.TPath.Size = new System.Drawing.Size(152, 20);
            this.TPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Папка:";
            // 
            // BFolder
            // 
            this.BFolder.Location = new System.Drawing.Point(229, 15);
            this.BFolder.Name = "BFolder";
            this.BFolder.Size = new System.Drawing.Size(36, 23);
            this.BFolder.TabIndex = 2;
            this.BFolder.Text = "•••";
            this.BFolder.UseVisualStyleBackColor = true;
            this.BFolder.Click += new System.EventHandler(this.BFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Файлы:";
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(229, 76);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(212, 217);
            this.PictureBox.TabIndex = 4;
            this.PictureBox.TabStop = false;
            // 
            // ListFiles
            // 
            this.ListFiles.FormattingEnabled = true;
            this.ListFiles.Location = new System.Drawing.Point(16, 81);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(115, 212);
            this.ListFiles.TabIndex = 5;
            this.ListFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListFiles_MouseDoubleClick);
            // 
            // BPrev
            // 
            this.BPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BPrev.Location = new System.Drawing.Point(172, 76);
            this.BPrev.Name = "BPrev";
            this.BPrev.Size = new System.Drawing.Size(51, 217);
            this.BPrev.TabIndex = 6;
            this.BPrev.Text = "◄";
            this.BPrev.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(447, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 217);
            this.button1.TabIndex = 7;
            this.button1.Text = "►";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BPrev);
            this.Controls.Add(this.ListFiles);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TPath);
            this.Name = "FormGallery";
            this.Text = "Галерея";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ListBox ListFiles;
        private System.Windows.Forms.Button BPrev;
        private System.Windows.Forms.Button button1;
    }
}

