using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClassicFileDialogs
{
    public static class Globals
    {

        public static List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }
        public static List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }
        public static Icon DialogIcon = null;
        public static string DialogTitle = string.Empty;
        public static string StartingFolder = string.Empty;
        public static string ReturnFile = string.Empty;
        public static Font FormFont = new Font("Microsoft Sans Serif", (float)8.25);

        public enum ClassicDialogFont
        {
            Tahoma,
            MSSans
        }
        public enum DialogStyle
        {
            Open31,
            Save31,
            FolderSelect31,
            Open95,
            Save95,
            FolderSelect95
        }
        public struct FileType
        {
            public string Extension;
            public string Description;
        }
        public static FileType[] FileTypeAr;
        public static string Between(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }

    }

}
