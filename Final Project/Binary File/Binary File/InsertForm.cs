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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            displayFNtextBox.Text = Info.filename;//kda byktb asm al file aly nta 3mltlo create 

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(Info.filename, FileMode.Open, FileAccess.Write)); // btcreate file zy streamwriter w btsgl feh al binat aly bd5lha
            int length = (int)bw.BaseStream.Length;//by2ys 7agm al file(BaseStream.Length)

            if (length != 0) //If the file is not empty hymshy 32 byte (record size) w b3d keda yktb
            {
                bw.BaseStream.Seek(length, SeekOrigin.Begin); //by7dd hyktb mnin
                            
            }
    
            bw.Write(int.Parse(IDtextBox.Text)); // ID
            NametextBox.Text = NametextBox.Text.PadRight(9);
            bw.Write(NametextBox.Text.Substring(0, 9));
            TeltextBox.Text = TeltextBox.Text.PadRight(11); //Tel 
            bw.Write(TeltextBox.Text.Substring(0, 11));

            bw.Write(int.Parse(YeartextBox.Text)); //Year 

            bw.Write(GendertextBox.Text.Substring(0, 1)); // Gender

            
           length += Info.rec_size;//kol my3lm bynat gdeeda bydyf 32 bite 34an y7sb al msa7a w yktbha fl formsize 
           IDtextBox.Text = NametextBox.Text = TeltextBox.Text = YeartextBox.Text = GendertextBox.Text = "";
           NumOfRecLabel.Text = (length / Info.rec_size).ToString(); // lma y2sm al 7gm 3la al record size aly hoa 32 hydena fe kam data gwa msln 64/32=2 ybaa kda fe 2 
           FileSizeLabel.Text = length.ToString();//update file length label
           MessageBox.Show(" Data is Saved Successfully ");
           bw.Close();
            

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new MainForm().Show();
        }

      

    }
}
