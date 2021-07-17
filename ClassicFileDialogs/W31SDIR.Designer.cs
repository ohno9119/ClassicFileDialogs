
namespace ClassicFileDialogs
{
    partial class W31SDIR
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
            this.DescLBL4 = new System.Windows.Forms.Label();
            this.DriveList = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.DirectoryList = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CreateNewDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescLBL4
            // 
            this.DescLBL4.AutoSize = true;
            this.DescLBL4.BackColor = System.Drawing.Color.Transparent;
            this.DescLBL4.Location = new System.Drawing.Point(10, 162);
            this.DescLBL4.Name = "DescLBL4";
            this.DescLBL4.Size = new System.Drawing.Size(40, 13);
            this.DescLBL4.TabIndex = 26;
            this.DescLBL4.Text = "Drives:";
            // 
            // DriveList
            // 
            this.DriveList.FormattingEnabled = true;
            this.DriveList.Location = new System.Drawing.Point(12, 180);
            this.DriveList.Name = "DriveList";
            this.DriveList.Size = new System.Drawing.Size(141, 21);
            this.DriveList.TabIndex = 25;
            this.DriveList.SelectedIndexChanged += new System.EventHandler(this.DriveList_SelectedIndexChanged);
            // 
            // DirectoryList
            // 
            this.DirectoryList.FormattingEnabled = true;
            this.DirectoryList.IntegralHeight = false;
            this.DirectoryList.Location = new System.Drawing.Point(12, 12);
            this.DirectoryList.Name = "DirectoryList";
            this.DirectoryList.Size = new System.Drawing.Size(141, 147);
            this.DirectoryList.TabIndex = 24;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(159, 41);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(159, 12);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 27;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CreateNewDir
            // 
            this.CreateNewDir.Location = new System.Drawing.Point(159, 70);
            this.CreateNewDir.Name = "CreateNewDir";
            this.CreateNewDir.Size = new System.Drawing.Size(75, 23);
            this.CreateNewDir.TabIndex = 29;
            this.CreateNewDir.Text = "New Folder";
            this.CreateNewDir.UseVisualStyleBackColor = true;
            this.CreateNewDir.Click += new System.EventHandler(this.CreateNewDir_Click);
            // 
            // W31SDIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 213);
            this.Controls.Add(this.CreateNewDir);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DescLBL4);
            this.Controls.Add(this.DriveList);
            this.Controls.Add(this.DirectoryList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W31SDIR";
            this.Text = "W31SDIR";
            this.Load += new System.EventHandler(this.W31SDIR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescLBL4;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox DriveList;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox DirectoryList;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CreateNewDir;
    }
}