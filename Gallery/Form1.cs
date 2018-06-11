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
        List<PictureInfo> PicturesSave = new List<PictureInfo>();
        List<PictureInfo> Pictures = new List<PictureInfo>();
        int CurrentPictures;
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
            CurrentPictures = 0;
            DirectoryInfo InfoDir = new DirectoryInfo(TPath.Text);
            ListFiles.Items.Clear();
            foreach (var item in InfoDir.EnumerateFiles())
            {
                if (item.Extension == ".png" || item.Extension == ".jpg" || item.Extension == ".bmp" || item.Extension == ".gif")
                {
                    ListFiles.Items.Add(item.Name);
                    Pictures.Add(new PictureInfo { FullName = item.FullName, NamePicture = item.Name });
                }
            }
            if(Pictures.Count > 0)
            {
                Mark1.Visible = Mark2.Visible = Mark3.Visible = Mark4.Visible = Mark5.Visible = true;
                TBComment.Visible = LComment.Visible = true;
                PictureBox.Image = Image.FromFile(Pictures[0].FullName);
                PicturesSave.AddRange(Pictures);
            }
            else
            {
                Mark1.Visible = Mark2.Visible = Mark3.Visible = Mark4.Visible = Mark5.Visible = false;
                TBComment.Visible = LComment.Visible = false;
            }
            
            FilterPicture();
        }

        private void FilterPicture()
        {
            var filter = PicturesSave.Distinct() as List<PictureInfo>;
            PicturesSave = filter;
        }

        private void BNext_Click(object sender, EventArgs e)
        {
            if (CurrentPictures < Pictures.Count()-1)
            {
                CurrentPictures++;
                PictureBox.Image = Image.FromFile(Pictures[CurrentPictures].FullName);
            }
        }

        private void BPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPictures > 0)
            {
                CurrentPictures--;
                PictureBox.Image = Image.FromFile(Pictures[CurrentPictures].FullName);
            }
        }

        private void TBComment_Leave(object sender, EventArgs e)
        {
            var selItem = Pictures.First(x => x.NamePicture == Pictures[CurrentPictures].NamePicture);
            selItem.Comment = TBComment.Text;
        }
    }
}
