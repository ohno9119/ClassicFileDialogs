using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static ClassicFileDialogs.Globals;

namespace ClassicFileDialogs
{
    public partial class W31OFD : Form
    {
        public W31OFD()
        {
            InitializeComponent();

        }

  

        private void W31OFD_Load(object sender, EventArgs e)
        {
            FileInfo FileInfoForDrive = new FileInfo(StartingFolder);
            this.Text = DialogTitle;
            this.Icon = DialogIcon;
            DirectoryList.Path = StartingFolder;
            DriveList.Drive = FileInfoForDrive.Directory.Root.FullName;
            foreach (var Item in FileTypeAr)
            {
                FileTypeList.Items.Add(Item.Description + " (" + Item.Extension + ")");
            }
            FileTypeList.SelectedIndex = 0;
            FileList.Pattern = Between(FileTypeList.SelectedItem.ToString(), "(", ")");
            RefreshDialog();
            List<Control> allControls = GetAllControls(this);
            allControls.ForEach(k => k.Font = FormFont);
        }
        private void RefreshDialog()
        {
            FileInfo FileInfoDirlist = new FileInfo(StartingFolder);
            if (DirectoryList.Path.ToLower().Contains(FileInfoDirlist.Directory.Root.FullName.ToLower()) == false)
            {
                DirectoryList.Path = DriveList.Drive + @"\";
                FileList.Path = DirectoryList.Path;
            }
            FileList.Pattern = Between(FileTypeList.SelectedItem.ToString(), "(", ")");
            FileName.Text = FileList.FileName;
            FileList.Path = DirectoryList.Path;
            DirLabel.Text = DirectoryList.Path;
            if (DirLabel.Text.Length > 16)
            {
                DirLabel.Text = DirectoryList.Path.Substring(0, 10) +"...";
            }
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (FileList.FileName != string.Empty)
            {
                ReturnFile = FileList.Path + @"\" + FileList.FileName;
            }

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UITimer_Tick(object sender, EventArgs e)
        {
            RefreshDialog();
        }
    }
}
