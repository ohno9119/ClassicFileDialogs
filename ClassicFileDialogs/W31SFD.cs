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
    public partial class W31SFD : Form
    {
        public W31SFD()
        {
            InitializeComponent();
        }
        private void W31SFD_Load(object sender, EventArgs e)
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
                DirLabel.Text = DirectoryList.Path.Substring(0, 10) + "...";
            }
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            string FName = string.Empty;
            if (FileName.Text != string.Empty)
            {
                FName = FileList.Path + @"\" + FileList.FileName;

            }
            if (File.Exists(FName))
            {
                DialogResult DLGResult = MessageBox.Show("This file already exists in the location you have selected.\nWould you like to overwrite it?", "Confirm file overwrite", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (DLGResult == DialogResult.No)
                {
                    return;
                }
            }
            ReturnFile = FName;
            this.Close();
        }

        private void UITimer_Tick(object sender, EventArgs e)
        {
            RefreshDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
