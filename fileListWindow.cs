using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SongFolderz
{
    public partial class fileListWindow : Form
    {
        public static fileManagementWindow fileManagementWindow;
        String targetDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        public String currentFile;
        public fileListWindow()
        {
            InitializeComponent();
            textBox1.AppendText(Environment.NewLine);
        }


        private void b_startscan_Click(object sender, EventArgs e)
        {
            fileManagementWindow = new fileManagementWindow();
            string[] fileEntries = Directory.GetFiles(targetDirectory,"*.mp3");
            for (int i = 0; i < fileEntries.Length; i++)
            {
                if ((fileEntries[i].Contains(".wav")) ||
                    (fileEntries[i].Contains(".mp3")) ||
                    (fileEntries[i].Contains(".flac")))
                    {
                    textBox1.AppendText(fileEntries[i]);
                    textBox1.AppendText(Environment.NewLine);
                }
            }
            fileManagementWindow.setCurrentFiles(fileEntries);
            fileManagementWindow.Show();
        }
        }
    }

