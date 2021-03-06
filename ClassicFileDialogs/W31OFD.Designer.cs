
namespace ClassicFileDialogs
{
    partial class W31OFD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FileList = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.DirectoryList = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.DescLBL1 = new System.Windows.Forms.Label();
            this.FileTypeList = new System.Windows.Forms.ComboBox();
            this.DescLBL3 = new System.Windows.Forms.Label();
            this.DescLBL2 = new System.Windows.Forms.Label();
            this.DirLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DriveList = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.DescLBL4 = new System.Windows.Forms.Label();
            this.UITimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // FileList
            // 
            this.FileList.FormattingEnabled = true;
            this.FileList.Location = new System.Drawing.Point(9, 52);
            this.FileList.Name = "FileList";
            this.FileList.Pattern = "*.*";
            this.FileList.Size = new System.Drawing.Size(135, 108);
            this.FileList.TabIndex = 0;
            // 
            // DirectoryList
            // 
            this.DirectoryList.FormattingEnabled = true;
            this.DirectoryList.IntegralHeight = false;
            this.DirectoryList.Location = new System.Drawing.Point(165, 52);
            this.DirectoryList.Name = "DirectoryList";
            this.DirectoryList.Size = new System.Drawing.Size(141, 108);
            this.DirectoryList.TabIndex = 1;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(9, 26);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(135, 20);
            this.FileName.TabIndex = 2;
            // 
            // DescLBL1
            // 
            this.DescLBL1.AutoSize = true;
            this.DescLBL1.BackColor = System.Drawing.Color.Transparent;
            this.DescLBL1.Location = new System.Drawing.Point(7, 7);
            this.DescLBL1.Name = "DescLBL1";
            this.DescLBL1.Size = new System.Drawing.Size(57, 13);
            this.DescLBL1.TabIndex = 3;
            this.DescLBL1.Text = "File Name:";
            // 
            // FileTypeList
            // 
            this.FileTypeList.FormattingEnabled = true;
            this.FileTypeList.Location = new System.Drawing.Point(9, 185);
            this.FileTypeList.Name = "FileTypeList";
            this.FileTypeList.Size = new System.Drawing.Size(135, 21);
            this.FileTypeList.TabIndex = 4;
            // 
            // DescLBL3
            // 
            this.DescLBL3.AutoSize = true;
            this.DescLBL3.BackColor = System.Drawing.Color.Transparent;
            this.DescLBL3.Location = new System.Drawing.Point(7, 167);
            this.DescLBL3.Name = "DescLBL3";
            this.DescLBL3.Size = new System.Drawing.Size(89, 13);
            this.DescLBL3.TabIndex = 5;
            this.DescLBL3.Text = "List Files of Type:";
            // 
            // DescLBL2
            // 
            this.DescLBL2.AutoSize = true;
            this.DescLBL2.BackColor = System.Drawing.Color.Transparent;
            this.DescLBL2.Location = new System.Drawing.Point(163, 14);
            this.DescLBL2.Name = "DescLBL2";
            this.DescLBL2.Size = new System.Drawing.Size(60, 13);
            this.DescLBL2.TabIndex = 6;
            this.DescLBL2.Text = "Directories:";
            // 
            // DirLabel
            // 
            this.DirLabel.AutoSize = true;
            this.DirLabel.BackColor = System.Drawing.Color.Transparent;
            this.DirLabel.Location = new System.Drawing.Point(163, 33);
            this.DirLabel.Name = "DirLabel";
            this.DirLabel.Size = new System.Drawing.Size(151, 13);
            this.DirLabel.TabIndex = 7;
            this.DirLabel.Text = "MMMMMMMMMMMMMMMM";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(312, 10);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(312, 39);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DriveList
            // 
            this.DriveList.FormattingEnabled = true;
            this.DriveList.Location = new System.Drawing.Point(165, 185);
            this.DriveList.Name = "DriveList";
            this.DriveList.Size = new System.Drawing.Size(141, 21);
            this.DriveList.TabIndex = 10;
            // 
            // DescLBL4
            // 
            this.DescLBL4.AutoSize = true;
            this.DescLBL4.BackColor = System.Drawing.Color.Transparent;
            this.DescLBL4.Location = new System.Drawing.Point(163, 167);
            this.DescLBL4.Name = "DescLBL4";
            this.DescLBL4.Size = new System.Drawing.Size(40, 13);
            this.DescLBL4.TabIndex = 11;
            this.DescLBL4.Text = "Drives:";
            // 
            // UITimer
            // 
            this.UITimer.Enabled = true;
            this.UITimer.Interval = 10;
            this.UITimer.Tick += new System.EventHandler(this.UITimer_Tick);
            // 
            // W31OFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 215);
            this.Controls.Add(this.DescLBL4);
            this.Controls.Add(this.DriveList);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DirLabel);
            this.Controls.Add(this.DescLBL2);
            this.Controls.Add(this.DescLBL3);
            this.Controls.Add(this.FileTypeList);
            this.Controls.Add(this.DescLBL1);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.DirectoryList);
            this.Controls.Add(this.FileList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W31OFD";
            this.Text = "Open";
            this.Load += new System.EventHandler(this.W31OFD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox FileList;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox DirectoryList;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.ComboBox FileTypeList;
        private System.Windows.Forms.Label DescLBL3;
        private System.Windows.Forms.Label DescLBL2;
        private System.Windows.Forms.Label DirLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox DriveList;
        private System.Windows.Forms.Label DescLBL4;
        private System.Windows.Forms.Label DescLBL1;
        private System.Windows.Forms.Timer UITimer;
    }
}