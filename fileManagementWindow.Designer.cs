namespace SongFolderz
{
    partial class fileManagementWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileManagementWindow));
            this.b_done = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tb_currentFile = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.b_preview = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_previous = new System.Windows.Forms.Button();
            this.b_next = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_saveList = new System.Windows.Forms.Button();
            this.b_loadList = new System.Windows.Forms.Button();
            this.tb_listName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_done
            // 
            this.b_done.Location = new System.Drawing.Point(12, 234);
            this.b_done.Name = "b_done";
            this.b_done.Size = new System.Drawing.Size(171, 23);
            this.b_done.TabIndex = 0;
            this.b_done.Text = "Done";
            this.b_done.UseVisualStyleBackColor = true;
            this.b_done.Click += new System.EventHandler(this.b_done_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 36);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(270, 184);
            this.checkedListBox1.TabIndex = 1;
            // 
            // tb_currentFile
            // 
            this.tb_currentFile.Location = new System.Drawing.Point(12, 12);
            this.tb_currentFile.Name = "tb_currentFile";
            this.tb_currentFile.ReadOnly = true;
            this.tb_currentFile.Size = new System.Drawing.Size(270, 20);
            this.tb_currentFile.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(288, 12);
            this.axWindowsMediaPlayer1.MaximumSize = new System.Drawing.Size(300, 300);
            this.axWindowsMediaPlayer1.MinimumSize = new System.Drawing.Size(300, 300);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(300, 300);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.TabStop = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // b_preview
            // 
            this.b_preview.Location = new System.Drawing.Point(189, 234);
            this.b_preview.Name = "b_preview";
            this.b_preview.Size = new System.Drawing.Size(93, 23);
            this.b_preview.TabIndex = 4;
            this.b_preview.Text = "Preview";
            this.b_preview.UseVisualStyleBackColor = true;
            this.b_preview.Click += new System.EventHandler(this.b_preview_Click);
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(189, 289);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(93, 23);
            this.b_exit.TabIndex = 5;
            this.b_exit.Text = "Exit Program";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_previous
            // 
            this.b_previous.Location = new System.Drawing.Point(12, 289);
            this.b_previous.Name = "b_previous";
            this.b_previous.Size = new System.Drawing.Size(75, 23);
            this.b_previous.TabIndex = 6;
            this.b_previous.Text = "Previous";
            this.b_previous.UseVisualStyleBackColor = true;
            this.b_previous.Click += new System.EventHandler(this.b_previous_Click);
            // 
            // b_next
            // 
            this.b_next.Location = new System.Drawing.Point(108, 289);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(75, 23);
            this.b_next.TabIndex = 7;
            this.b_next.Text = "Next";
            this.b_next.UseVisualStyleBackColor = true;
            this.b_next.Click += new System.EventHandler(this.b_next_Click);
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(12, 318);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(270, 23);
            this.b_edit.TabIndex = 8;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_saveList
            // 
            this.b_saveList.Location = new System.Drawing.Point(288, 318);
            this.b_saveList.Name = "b_saveList";
            this.b_saveList.Size = new System.Drawing.Size(75, 23);
            this.b_saveList.TabIndex = 9;
            this.b_saveList.Text = "Save List";
            this.b_saveList.UseVisualStyleBackColor = true;
            this.b_saveList.Click += new System.EventHandler(this.b_saveList_Click);
            // 
            // b_loadList
            // 
            this.b_loadList.Location = new System.Drawing.Point(513, 318);
            this.b_loadList.Name = "b_loadList";
            this.b_loadList.Size = new System.Drawing.Size(75, 23);
            this.b_loadList.TabIndex = 10;
            this.b_loadList.Text = "Load List";
            this.b_loadList.UseVisualStyleBackColor = true;
            this.b_loadList.Click += new System.EventHandler(this.b_loadList_Click);
            // 
            // tb_listName
            // 
            this.tb_listName.Location = new System.Drawing.Point(369, 320);
            this.tb_listName.Name = "tb_listName";
            this.tb_listName.Size = new System.Drawing.Size(138, 20);
            this.tb_listName.TabIndex = 11;
            // 
            // fileManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 355);
            this.Controls.Add(this.tb_listName);
            this.Controls.Add(this.b_loadList);
            this.Controls.Add(this.b_saveList);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.b_previous);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_preview);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.tb_currentFile);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.b_done);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fileManagementWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SongFolderz - File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fileManagementWindow_FormClosing);
            this.Load += new System.EventHandler(this.fileManagementWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_done;
        private System.Windows.Forms.TextBox tb_currentFile;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button b_preview;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_previous;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.Button b_edit;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button b_saveList;
        private System.Windows.Forms.Button b_loadList;
        private System.Windows.Forms.TextBox tb_listName;
    }
}