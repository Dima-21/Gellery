using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class FormGallery : Form
    {
        List<PictureInfo> Pictures = new List<PictureInfo>();
        public FormGallery()
        {
            InitializeComponent();
        }

        private void BFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                TPath.Text = folderBrowserDialog1.SelectedPath;
            UpdateListFiles();
        }

        private void UpdateListFiles()
        {
            DirectoryInfo InfoDir = new DirectoryInfo(TPath.Text);
            ListFiles.Items.Clear();
            foreach (var item in InfoDir.EnumerateFiles())
            {
                if (item.Extension == ".png" || item.Extension == ".jpg")
                {
                    ListFiles.Items.Add(item.Name);
                    Pictures.Add(new PictureInfo { FullName = item.FullName, NamePicture = item.Name });
                }
            }
        }

        private void ListFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var picture = Pictures.First(x => x.NamePicture == ListFiles.Text);
            PictureBox.Size = new Size(SizeImage.FromFile(picture.FullName));
            PictureBox.Image = Image.FromFile(picture.FullName).Width;
        
        }
    }
}
