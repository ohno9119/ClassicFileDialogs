# WARNING: This project is under development.
# ClassicFileDialogs
A .NET Framework library that lets you use the classic file dialogs in your applications
# Features
1. Windows 3.1 style dialogs for open, save and folder selection,
# Usage example
```
ClassicFileDialog CDLG = new ClassicFileDialog();
FileType PNGFT;
PNGFT.Description = "PNG Files";
PNGFT.Extension = "*.png";
FileType JPEGFT;
JPEGFT.Description = "JPEG Files";
JPEGFT.Extension = "*.jpg";
FileType[] AllowedFileType = new FileType[] { PNGFT , JPEGFT };
Console.WriteLine(CDLG.SpawnDialog("Select file", AllowedFileType, Icon.ExtractAssociatedIcon(@"C:\Placeholder.ico"),null,DialogStyle.Open31));
```
# To do
1. .NET Core/.NET 5 port
2. Windows 95 style dialogs
