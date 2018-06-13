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
            this.BNext = new System.Windows.Forms.Button();
            this.Mark1 = new System.Windows.Forms.RadioButton();
            this.Mark4 = new System.Windows.Forms.RadioButton();
            this.Mark3 = new System.Windows.Forms.RadioButton();
            this.Mark5 = new System.Windows.Forms.RadioButton();
            this.Mark2 = new System.Windows.Forms.RadioButton();
            this.LComment = new System.Windows.Forms.Label();
            this.TBComment = new System.Windows.Forms.TextBox();
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
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(229, 76);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(212, 217);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.BPrev.Click += new System.EventHandler(this.BPrev_Click);
            // 
            // BNext
            // 
            this.BNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BNext.Location = new System.Drawing.Point(447, 76);
            this.BNext.Name = "BNext";
            this.BNext.Size = new System.Drawing.Size(51, 217);
            this.BNext.TabIndex = 7;
            this.BNext.Text = "►";
            this.BNext.UseVisualStyleBackColor = true;
            this.BNext.Click += new System.EventHandler(this.BNext_Click);
            // 
            // Mark1
            // 
            this.Mark1.AutoSize = true;
            this.Mark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mark1.Location = new System.Drawing.Point(238, 299);
            this.Mark1.Name = "Mark1";
            this.Mark1.Size = new System.Drawing.Size(34, 20);
            this.Mark1.TabIndex = 8;
            this.Mark1.TabStop = true;
            this.Mark1.Text = "1";
            this.Mark1.UseVisualStyleBackColor = true;
            this.Mark1.Visible = false;
            this.Mark1.CheckedChanged += new System.EventHandler(this.Mark1_CheckedChanged);
            // 
            // Mark4
            // 
            this.Mark4.AutoSize = true;
            this.Mark4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mark4.Location = new System.Drawing.Point(358, 299);
            this.Mark4.Name = "Mark4";
            this.Mark4.Size = new System.Drawing.Size(34, 20);
            this.Mark4.TabIndex = 9;
            this.Mark4.TabStop = true;
            this.Mark4.Text = "4";
            this.Mark4.UseVisualStyleBackColor = true;
            this.Mark4.Visible = false;
            this.Mark4.CheckedChanged += new System.EventHandler(this.Mark4_CheckedChanged);
            // 
            // Mark3
            // 
            this.Mark3.AutoSize = true;
            this.Mark3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mark3.Location = new System.Drawing.Point(318, 299);
            this.Mark3.Name = "Mark3";
            this.Mark3.Size = new System.Drawing.Size(34, 20);
            this.Mark3.TabIndex = 10;
            this.Mark3.TabStop = true;
            this.Mark3.Text = "3";
            this.Mark3.UseVisualStyleBackColor = true;
            this.Mark3.Visible = false;
            this.Mark3.CheckedChanged += new System.EventHandler(this.Mark3_CheckedChanged);
            // 
            // Mark5
            // 
            this.Mark5.AutoSize = true;
            this.Mark5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mark5.Location = new System.Drawing.Point(398, 299);
            this.Mark5.Name = "Mark5";
            this.Mark5.Size = new System.Drawing.Size(34, 20);
            this.Mark5.TabIndex = 11;
            this.Mark5.TabStop = true;
            this.Mark5.Text = "5";
            this.Mark5.UseVisualStyleBackColor = true;
            this.Mark5.Visible = false;
            this.Mark5.CheckedChanged += new System.EventHandler(this.Mark5_CheckedChanged);
            // 
            // Mark2
            // 
            this.Mark2.AutoSize = true;
            this.Mark2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mark2.Location = new System.Drawing.Point(278, 299);
            this.Mark2.Name = "Mark2";
            this.Mark2.Size = new System.Drawing.Size(34, 20);
            this.Mark2.TabIndex = 12;
            this.Mark2.TabStop = true;
            this.Mark2.Text = "2";
            this.Mark2.UseVisualStyleBackColor = true;
            this.Mark2.Visible = false;
            this.Mark2.CheckedChanged += new System.EventHandler(this.Mark2_CheckedChanged);
            // 
            // LComment
            // 
            this.LComment.AutoSize = true;
            this.LComment.Location = new System.Drawing.Point(86, 320);
            this.LComment.Name = "LComment";
            this.LComment.Size = new System.Drawing.Size(80, 13);
            this.LComment.TabIndex = 13;
            this.LComment.Text = "Комментарий:";
            this.LComment.Visible = false;
            // 
            // TBComment
            // 
            this.TBComment.Location = new System.Drawing.Point(172, 320);
            this.TBComment.Multiline = true;
            this.TBComment.Name = "TBComment";
            this.TBComment.Size = new System.Drawing.Size(326, 61);
            this.TBComment.TabIndex = 14;
            this.TBComment.Visible = false;
            this.TBComment.Leave += new System.EventHandler(this.TBComment_Leave);
            // 
            // FormGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 393);
            this.Controls.Add(this.TBComment);
            this.Controls.Add(this.LComment);
            this.Controls.Add(this.Mark2);
            this.Controls.Add(this.Mark5);
            this.Controls.Add(this.Mark3);
            this.Controls.Add(this.Mark4);
            this.Controls.Add(this.Mark1);
            this.Controls.Add(this.BNext);
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
        private System.Windows.Forms.Button BNext;
        private System.Windows.Forms.RadioButton Mark1;
        private System.Windows.Forms.RadioButton Mark4;
        private System.Windows.Forms.RadioButton Mark3;
        private System.Windows.Forms.RadioButton Mark5;
        private System.Windows.Forms.RadioButton Mark2;
        private System.Windows.Forms.Label LComment;
        private System.Windows.Forms.TextBox TBComment;
    }
}

