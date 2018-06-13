using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class FormGallery : Form
    {
        String FileData = "Pictures.data";
        List<PictureInfo> PicturesSave = new List<PictureInfo>();
        List<PictureInfo> Pictures = new List<PictureInfo>();
        int CurrentPictures;
        public FormGallery()
        {
            InitializeComponent();
            DeSerialize();
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
                        Pictures.Add(new PictureInfo { FullName = item.FullName, NamePicture = item.Name, Length = item.Length });
                    }
                }

                if (Pictures.Count > 0)
                {
                    Mark1.Visible = Mark2.Visible = Mark3.Visible = Mark4.Visible = Mark5.Visible = true;
                    TBComment.Visible = LComment.Visible = true;
                    PictureBox.Image = Image.FromFile(Pictures[0].FullName);
                    PicturesSave.AddRange(Pictures);
                    FilterPicture();
                }
                else
                {
                    PictureBox.Image = null;
                    Mark1.Visible = Mark2.Visible = Mark3.Visible = Mark4.Visible = Mark5.Visible = false;
                    TBComment.Visible = LComment.Visible = false;
                }
                Serialize();
            }
        }

        private void FilterPicture()
        {
            var filter = PicturesSave.Distinct().ToList();
            PicturesSave = filter;
            Serialize();
        }

        private void BNext_Click(object sender, EventArgs e)
        {
            if (CurrentPictures < Pictures.Count() - 1)
            {
                CurrentPictures++;
                PictureBox.Image = Image.FromFile(Pictures[CurrentPictures].FullName);
                SetValues();
            }
            Serialize();
        }

        private void BPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPictures > 0)
            {
                CurrentPictures--;
                PictureBox.Image = Image.FromFile(Pictures[CurrentPictures].FullName);
                SetValues();
            }
            Serialize();
        }

        private void SetValues()
        {
            if (PicturesSave.Exists(x => x.NamePicture == Pictures[CurrentPictures].NamePicture && x.Length == Pictures[CurrentPictures].Length))
            {
                var SelItem = PicturesSave.First(x => x.NamePicture == Pictures[CurrentPictures].NamePicture && x.Length == Pictures[CurrentPictures].Length);
                this.TBComment.Text = SelItem.Comment;
                switch (SelItem.Mark)
                {
                    case 0:
                        Mark1.Checked = Mark2.Checked = Mark3.Checked = Mark4.Checked = Mark5.Checked = false;
                        break;
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
                TBComment.Text = "";
                
            }
        }

        private void TBComment_Leave(object sender, EventArgs e)
        {
            var selItem = Pictures.First(x => x.NamePicture == Pictures[CurrentPictures].NamePicture);
            selItem.Comment = TBComment.Text;
            selItem = PicturesSave.First(x => x.NamePicture == Pictures[CurrentPictures].NamePicture);
            selItem.Comment = TBComment.Text;
        }

        private void Serialize()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var fs = new FileStream(FileData, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, PicturesSave);
            }
        }
        private void DeSerialize()
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(FileData))
            {
                using (var fs = new FileStream(FileData, FileMode.Open))
                {
                    PicturesSave = bf.Deserialize(fs) as List<PictureInfo>;
                }
            }
        }

        private void Mark1_CheckedChanged(object sender, EventArgs e)
        {
            if (Mark1.Checked)
            {
                Pictures[CurrentPictures].Mark = 1;
                PicturesSave.First(x => x.NamePicture == Pictures[CurrentPictures].NamePicture).Mark = 1;
            }

        }

        private void Mark2_CheckedChanged(object sender, EventArgs e)
        {
            if (Mark2.Checked)
            {
                Pictures[CurrentPictures].Mark = 2;
                PicturesSave.First(x => x.NamePicture == Pictures[CurrentPictures].NamePicture).Mark = 2;
            }

        }

        private void Mark3_CheckedChanged(object sender, EventArgs e)
        {
            if (Mark3.Checked)
            {
                Pictures[CurrentPictures].Mark = 3;
                PicturesSave.First(x => x.NamePicture == Pictures[CurrentPictures].NamePicture).Mark = 3;
            }

        }

        private void Mark4_CheckedChanged(object sender, EventArgs e)
        {
            if (Mark4.Checked)
            {
                Pictures[CurrentPictures].Mark = 4;
                PicturesSave.First(x => x.NamePicture == Pictures[CurrentPictures].NamePicture).Mark = 4;
            }

        }

        private void Mark5_CheckedChanged(object sender, EventArgs e)
        {
            if (Mark5.Checked)
            {
                Pictures[CurrentPictures].Mark = 5;
                PicturesSave.First(x => x.NamePicture == Pictures[CurrentPictures].NamePicture).Mark = 5;
            }
        }
    }
}
