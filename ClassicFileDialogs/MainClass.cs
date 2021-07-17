using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static ClassicFileDialogs.Globals;

namespace ClassicFileDialogs
{
    public class ClassicFileDialog
    {

        public string SpawnDialog(string Title = "Dialog", FileType[] AllowedFileType = null, Icon Icon = null, string StartingDir = null, DialogStyle DialogType = DialogStyle.Open31, bool IsDialogModal = true)
        {
     
            // Insert all files file type if no filetype array is provided
            try
            {
                if (AllowedFileType == null)
                {
                    FileType DefaultFileTypeST;
                    DefaultFileTypeST.Description = "All Files";
                    DefaultFileTypeST.Extension = "*.*";
                    AllowedFileType = new FileType[] { DefaultFileTypeST };
                }
            }
            catch (Exception e)
            {
                FileType DefaultFileTypeST;
                DefaultFileTypeST.Description = "All Files";
                DefaultFileTypeST.Extension = "*.*";
                AllowedFileType = new FileType[] { DefaultFileTypeST };
            }

            // Set starting directory if its not provided
            if (StartingDir == null)
            {
                StartingDir = Environment.CurrentDirectory;
            }
            // Set Dialog icon if its not provided
            if (DialogIcon == null)
            {
                Bitmap PlaceholderDialogIconBMP = new Bitmap(Properties.Resources.Placeholder);
                Icon PlaceholderDialogIcon = Icon.FromHandle(PlaceholderDialogIconBMP.GetHicon());
                DialogIcon = PlaceholderDialogIcon;
            }
            // Variables and stuff
            string ReturnVal = string.Empty;
            FileTypeAr = AllowedFileType;
            DialogTitle = Title;
            DialogIcon = Icon;
            StartingFolder = StartingDir;
            // Open the dialog
            switch (DialogType)
            {
                case DialogStyle.Open31:
                    W31OFD Dialog = new W31OFD();
                    if (IsDialogModal)
                    {
                        Dialog.ShowDialog();
                    }
                    else
                    {
                        Dialog.Show();
                    }
                    break;
                case DialogStyle.Save31:
                    W31SFD SDialog = new W31SFD();
                    if (IsDialogModal)
                    {
                        SDialog.ShowDialog();
                    }
                    else
                    {
                        SDialog.Show();
                    }
                    break;
                case DialogStyle.FolderSelect31:
                    W31SDIR FDialog = new W31SDIR();
                    if (IsDialogModal)
                    {
                        FDialog.ShowDialog();
                    }
                    else
                    {
                        FDialog.Show();
                    }
                    break;
                default:
                    // ANAL SEX!!!!
                    break;
            }
            ReturnVal = ReturnFile;
            return ReturnVal;
        }
    }
}
