using ClassicFileDialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static ClassicFileDialogs.Globals;

namespace ClassicFDTester
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicFileDialog alg = new ClassicFileDialog();
            FileType DefaultFileTypeST;
            DefaultFileTypeST.Description = "PNG Files";
            DefaultFileTypeST.Extension = "*.png";
            FileType DefaultFileTypeST2;
            DefaultFileTypeST2.Description = "DLL Files";
            DefaultFileTypeST2.Extension = "*.dll";
            FileType[] AllowedFileType = new FileType[] { DefaultFileTypeST , DefaultFileTypeST2 };
            Console.WriteLine(alg.SpawnDialog("Select directory", AllowedFileType, Icon.ExtractAssociatedIcon(@"C:\Placeholder.ico"),null,DialogStyle.FolderSelect31));
            Console.ReadLine();
        }
    }
}
