using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Binary_File
{
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
       
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Info.filename = "F:\\" + FilenametextBox.Text + ".txt"; // Get the file name from user if I insert file1 in FilenameTextBox ,filename= E:\\file1.txt
            if (!File.Exists(Info.filename)) // if the file does not exists 
            {
                File.Create(Info.filename).Close();// We Should include using System.IO;
                MessageBox.Show("File is Created Successfully","Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
                errorLabel.Visible = true; // Error Message “ File Exists “ should set Lable2 : visible = false from properties window first
                
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Info.filename = "D:\\" + FilenametextBox.Text + ".txt";
            File.Delete(Info.filename);
            MessageBox.Show("File is Deleted ");
            FilenametextBox.Clear();
            errorLabel.Visible = false;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InsertForm().Show(); // Open Form 2
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DisplayForm().Show(); // Open Form 3

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {

            Info.mod = false;
            this.Hide();
            new Searhform().Show();
        }
        private void Mod_buttom_Click(object sender, EventArgs e)
        {
            Info.mod = true;
            this.Hide();
            new Searhform().Show();
        }
    }

}