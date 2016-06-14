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
        public static int listCounter = 0;

        public editWindow()
        {
            InitializeComponent();
        }

        private void b_addGenre_Click(object sender, EventArgs e)
        {
            fileListWindow.fileManagementWindow.checkedListBox1.Items.Add(tb_genre.Text);
        
            listCounter++;
            reloadList();
        }

        private void b_removeGenre_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listCounter; i++)
            {
                if (fileListWindow.fileManagementWindow.checkedListBox1.Items[i].ToString().Equals(tb_genre.Text))
                {
                    fileListWindow.fileManagementWindow.checkedListBox1.Items.Remove(tb_genre.Text);
                    listCounter--;
                    reloadList();
                }
            }
        }

        private void reloadList()
        {
            list = "";
            for (int i = 0; i < listCounter; i++)
            {
                list += fileListWindow.fileManagementWindow.checkedListBox1.Items[i].ToString() + Environment.NewLine;
            }
        }
    }
}
