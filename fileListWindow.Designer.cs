namespace SongFolderz
{
    partial class fileListWindow
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_startscan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_startscan
            // 
            this.b_startscan.Location = new System.Drawing.Point(12, 307);
            this.b_startscan.Name = "b_startscan";
            this.b_startscan.Size = new System.Drawing.Size(633, 23);
            this.b_startscan.TabIndex = 0;
            this.b_startscan.Text = "Start Scan";
            this.b_startscan.UseVisualStyleBackColor = true;
            this.b_startscan.Click += new System.EventHandler(this.b_startscan_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(632, 289);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "-Welcome to SongFolderz 0.2.93 by Ercanbald-\r\n\r\nUpdate: Now save lists correclty\r" +
    "\n\r\nTODO: List load to software\r\n\r\nFor bugs: leonardopaffi@hotmail.it\r\n";
            // 
            // fileListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 342);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.b_startscan);
            this.Name = "fileListWindow";
            this.ShowIcon = false;
            this.Text = "SongFolderz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_startscan;
        public System.Windows.Forms.TextBox textBox1;
    }
}

