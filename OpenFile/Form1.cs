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

namespace OpenFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Event handler for a click on our link
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Step 1:  Find File
            openFileDialog1.ShowDialog();
        }

        //Event Handler for a successful file selection
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //Get the filename from the open file dialog
            string s = openFileDialog1.FileName;

            //Read the file data
            string file_data = File.ReadAllText(s);

            //Display out file data
            tbFileOutput.Text = file_data;
        }
    }
}
