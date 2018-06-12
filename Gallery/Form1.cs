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

            if (TPath.Text != "" && Directory.Exists(TPath.Text))
            {
                DirectoryInfo InfoDir = new DirectoryInfo(TPath.Text);
                Pictures.Clear();
                ListFiles.Items.Clear();
                foreach (var item in InfoDir.EnumerateFiles())
                {
                    if (item.Extension == ".png" || item.Extension == ".jpg" || item.Extension == ".gif")
                    {
                        ListFiles.Items.Add(item.Name);
                        Pictures.Add(new PictureInfo { FullName = item.FullName, NamePicture = item.Name });
                    }
                }

                if (Pictures.Count > 0)
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
        }

        private void FilterPicture()
        {
            var filter = PicturesSave.Distinct() as List<PictureInfo>;
            PicturesSave = filter;
        }

        private void BNext_Click(object sender, EventArgs e)
        {
            if (CurrentPictures < Pictures.Count() - 1)
            {
                CurrentPictures++;
                PictureBox.Image = Image.FromFile(Pictures[CurrentPictures].FullName);
                SetValue();
            }
        }

        private void BPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPictures > 0)
            {
                CurrentPictures--;
                PictureBox.Image = Image.FromFile(Pictures[CurrentPictures].FullName);
                SetValue();
            }
        }

        private void SetValue()
        {
            if (PicturesSave.Exists(x => x.NamePicture == Pictures[CurrentPictures].NamePicture))
            {
                var SelItem = PicturesSave.First(x => x == Pictures[CurrentPictures]);
                this.LComment.Text = SelItem.Comment;
                switch (SelItem.Mark)
                {
                    case 1:
                        this.Mark1.Checked = true;
                        break;
                    case 2:
                        this.Mark2.Checked = true;
                        break;
                    case 3:
                        this.Mark3.Checked = true;
                        break;
                    case 4:
                        this.Mark4.Checked = true;
                        break;
                    case 5:
                        this.Mark5.Checked = true;
                        break;
                }
            }
            else
            {
                LComment.Text = "";
                Mark1.Checked = Mark2.Checked = Mark3.Checked = Mark4.Checked = Mark5.Checked = false;
            }
        }

        private void TBComment_Leave(object sender, EventArgs e)
        {
            var selItem = Pictures.First(x => x.NamePicture == Pictures[CurrentPictures].NamePicture);
            selItem.Comment = TBComment.Text;
        }
    }
}
