using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongFolderz
{
    public partial class editWindow : Form
    {
        public static string list = "";
        public editWindow()
        {
            InitializeComponent();
        }

        private void b_addGenre_Click(object sender, EventArgs e)
        {
            fileListWindow.fileManagementWindow.checkedListBox1.Items.Add(tb_genre.Text);
            list += tb_genre.Text + Environment.NewLine;
        }

        private void b_removeGenre_Click(object sender, EventArgs e)
        {
            fileListWindow.fileManagementWindow.checkedListBox1.Items.Remove(tb_genre.Text);
        }
    }
}
