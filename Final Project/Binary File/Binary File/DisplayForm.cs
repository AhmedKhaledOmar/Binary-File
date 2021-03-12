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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }
     
        private void Form3_Load(object sender, EventArgs e)
        {
            displayFNtextBox.Text = Info.filename;
        }
        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.Open(Info.filename, FileMode.Open, FileAccess.Read));
            
            int num_of_records = (int)br.BaseStream.Length / Info.rec_size;

            if (num_of_records > 0) // If The file Not Empty
            {
                DisplayBtn.Text = "Next";// Change the Button Text
                NumOfRecLabel.Text = num_of_records.ToString(); 
                FileSizeLabel.Text = br.BaseStream.Length.ToString();//byhzr 3dd al records w al filesize 

                br.BaseStream.Seek(Info.count, SeekOrigin.Begin); // by3dy 3la record record 34an yzhr aly goaha

                IDtextBox.Text = br.ReadInt32().ToString(); // Read ID and display it in the ID text Box

                NametextBox.Text = br.ReadString(); // Read Name 
                TeltextBox.Text = br.ReadString(); // Read Tel
                YeartextBox.Text = br.ReadInt32().ToString(); // Read Year

                GendertextBox.Text = br.ReadString(); // Read Gender


                if ((Info.count / Info.rec_size) >= (num_of_records - 1)) // If I reach the End of file , Go to the Beginning of file
                    Info.count = 0;//lw wsl llnhaya hyro7 llbdaya tany w yzhr nfs al klam
                else
                    Info.count += Info.rec_size;//lw 3mlt insert gdeda tzhr m3 al ba2e

            }
            else MessageBox.Show("Empty File");
            br.Close();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

       
    }
}
