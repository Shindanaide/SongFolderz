using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SongFolderz
{
    public partial class fileManagementWindow : Form
    {
        editWindow editWindow;
        String currentFileName;
        String genre;
        string[] files;
        
        int index = 0;

        public fileManagementWindow()
        { 
            InitializeComponent();
        }

        private void fileManagementWindow_Load(object sender, EventArgs e)
        {
            editWindow = new editWindow();
        }
        

        public void setCurrentFiles(string[] files)
        {
            this.files = files;
            currentFileName = Path.GetFileName(files[index]);
            try
            {
                if(currentFileName.EndsWith(".mp3")||
                   currentFileName.EndsWith(".wav")||
                   currentFileName.EndsWith(".flac")||
                   files[index].StartsWith("This File"))
                {
                    tb_currentFile.Text = files[index];
                }
                else
                {
                    index++;
                }
            }
            catch
            {
                MessageBox.Show("No file found", "Fatal Error");
            }
        }

        private void b_done_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            genre = checkedListBox1.GetItemText(checkedListBox1.SelectedItem);
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)+"\\SFz_"+genre);
            File.Move(files[index], Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\SFz_"+genre+"\\"+currentFileName);
            checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, false);

            files[index] = "This File Has Been Moved";

            index++;

            currentFileName = Path.GetFileName(files[index]);

            if (currentFileName.EndsWith(".mp3") ||
                currentFileName.EndsWith(".wav") ||
                currentFileName.EndsWith(".flac")
                )
            {
                if (index == 1)
                {
                    b_previous.Enabled = true;
                }

                try
                {
                    tb_currentFile.Text = files[index];
                }
                catch
                {
                    MessageBox.Show("No file found", "Fatal Error");
                }
            }
            else
            {
                index++;
            }
        }

        private void b_preview_Click(object sender, EventArgs e)
        {
            if (!(files[index].StartsWith("This File")))
            {
                axWindowsMediaPlayer1.URL = files[index];
            }
       }

        private void fileManagementWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_next_Click(object sender, EventArgs e)
        {
            index++;
            if (index == 1)
            {
                b_previous.Enabled = true;
            }

            currentFileName = Path.GetFileName(files[index]);

            if (currentFileName.EndsWith(".mp3") ||
                currentFileName.EndsWith(".wav") ||
                currentFileName.EndsWith(".flac")||
                files[index].StartsWith("This File"))
            {
                try
                {
                    tb_currentFile.Text = files[index];
                    
                }
                catch
                {
                    MessageBox.Show("No file found", "Fatal Error");
                }
            } else
            {
                index++;
            }
        }

        private void b_previous_Click(object sender, EventArgs e)
        {
            
            index--;
            if (index == 0)
            {
                b_previous.Enabled = false;
            }

            files[index].StartsWith("This File");

            if (currentFileName.EndsWith(".mp3") ||
                currentFileName.EndsWith(".wav") ||
                currentFileName.EndsWith(".flac") ||
                files[index].StartsWith("This File"))
            {
                try
                {
                    tb_currentFile.Text = files[index];
                }
                catch
                {
                    MessageBox.Show("No file found", "Fatal Error");
                }
            }
            else
            {
                index--;
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            editWindow.Show();
        }

        private void b_saveList_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\SFz_Lists");
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\SFz_Lists\\"+ tb_listName.Text +".txt", editWindow.list);
        }

        private void b_loadList_Click(object sender, EventArgs e)
        {
            //TODO: Load List method
        }
    }
}
