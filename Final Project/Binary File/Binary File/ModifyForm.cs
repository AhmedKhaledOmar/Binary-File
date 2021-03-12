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
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(Info.filename, FileMode.Open, FileAccess.Write));
            int num_of_records = (int)bw.BaseStream.Length / Info.rec_size;
            if (num_of_records > 0) // If The file Not Empty
            {
                    bw.BaseStream.Seek(Info.count, SeekOrigin.Begin);
                        
                        bw.Write(int.Parse(IDtextBox1.Text)); 
                        NametextBox1.Text = NametextBox1.Text.PadRight(9);
                        bw.Write(NametextBox1.Text.Substring(0, 9));
                        TeltextBox1.Text = TeltextBox1.Text.PadRight(11);  
                        bw.Write(TeltextBox1.Text.Substring(0, 11));
                        bw.Write(int.Parse(YeartextBox1.Text)); 
                        bw.Write(GendertextBox1.Text.Substring(0, 1));
                        bw.Close();
                        MessageBox.Show("Done !", "Result");
            }
        }

   

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.Open(Info.filename, FileMode.Open, FileAccess.Read));
            int num_of_records = (int)br.BaseStream.Length / Info.rec_size;
            if (num_of_records > 0) // If The file Not Empty
            {
                for (int i = 0; i < br.BaseStream.Length; i += 32)
                {
                    br.BaseStream.Seek(i, SeekOrigin.Begin);
                    if (Info.ID.ToString() == br.ReadInt32().ToString())
                    {
                        br.BaseStream.Seek(i, SeekOrigin.Begin);
                        IDtextBox.Text = br.ReadInt32().ToString();
                        NametextBox.Text = br.ReadString();  
                        TeltextBox.Text = br.ReadString(); 
                        YeartextBox.Text = br.ReadInt32().ToString(); 
                        GendertextBox.Text = br.ReadString();
                        br.Close();
                        break;
                    }
                }
            }
          
           
        }
    }
}
