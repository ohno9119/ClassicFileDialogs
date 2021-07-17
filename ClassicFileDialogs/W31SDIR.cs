using Microsoft.VisualBasic;
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
    public partial class W31SDIR : Form
    {
        public W31SDIR()
        {
            InitializeComponent();
        }

        private void DriveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo FileInfoDirlist = new FileInfo(StartingFolder);
            if (DirectoryList.Path.ToLower().Contains(FileInfoDirlist.Directory.Root.FullName.ToLower()) == false)
            {
                DirectoryList.Path = DriveList.Drive + @"\";
            }
        }

        private void CreateNewDir_Click(object sender, EventArgs e)
        {
            string Dir2Cr = Interaction.InputBox("Please insert the name of the folder you want to create.", "Create folder", "");
            if (Directory.Exists(Dir2Cr) == false)
            {
                Directory.CreateDirectory(DirectoryList.Path + @"\" + Dir2Cr);
                DirectoryList.Refresh();
            }
        }

        private void W31SDIR_Load(object sender, EventArgs e)
        {
            FileInfo FileInfoForDrive = new FileInfo(StartingFolder);
            this.Text = DialogTitle;
            this.Icon = DialogIcon;
            DirectoryList.Path = StartingFolder;
            DriveList.Drive = FileInfoForDrive.Directory.Root.FullName;
            List<Control> allControls = GetAllControls(this);
            allControls.ForEach(k => k.Font = FormFont);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            ReturnFile = DirectoryList.Path + @"\";
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
