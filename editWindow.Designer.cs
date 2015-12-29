namespace SongFolderz
{
    partial class editWindow
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
            this.b_addGenre = new System.Windows.Forms.Button();
            this.tb_genre = new System.Windows.Forms.TextBox();
            this.b_removeGenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_addGenre
            // 
            this.b_addGenre.Location = new System.Drawing.Point(116, 38);
            this.b_addGenre.Name = "b_addGenre";
            this.b_addGenre.Size = new System.Drawing.Size(75, 23);
            this.b_addGenre.TabIndex = 0;
            this.b_addGenre.Text = "Add Genre";
            this.b_addGenre.UseVisualStyleBackColor = true;
            this.b_addGenre.Click += new System.EventHandler(this.b_addGenre_Click);
            // 
            // tb_genre
            // 
            this.tb_genre.Location = new System.Drawing.Point(12, 12);
            this.tb_genre.Name = "tb_genre";
            this.tb_genre.Size = new System.Drawing.Size(260, 20);
            this.tb_genre.TabIndex = 1;
            // 
            // b_removeGenre
            // 
            this.b_removeGenre.Location = new System.Drawing.Point(197, 38);
            this.b_removeGenre.Name = "b_removeGenre";
            this.b_removeGenre.Size = new System.Drawing.Size(75, 23);
            this.b_removeGenre.TabIndex = 2;
            this.b_removeGenre.Text = "Remove";
            this.b_removeGenre.UseVisualStyleBackColor = true;
            this.b_removeGenre.Click += new System.EventHandler(this.b_removeGenre_Click);
            // 
            // editWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 259);
            this.Controls.Add(this.b_removeGenre);
            this.Controls.Add(this.tb_genre);
            this.Controls.Add(this.b_addGenre);
            this.Name = "editWindow";
            this.ShowIcon = false;
            this.Text = "SongFolderz - Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_addGenre;
        private System.Windows.Forms.TextBox tb_genre;
        private System.Windows.Forms.Button b_removeGenre;
    }
}