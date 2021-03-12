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
    public partial class Searhform : Form
    {
        public Searhform()
        {
            InitializeComponent();
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void modifayform_Load(object sender, EventArgs e)
        {
            DisplayFNtextBox.Text = Info.filename;
        }


  
    private void searchname_Click(object sender, EventArgs e)
        {

            BinaryReader br = new BinaryReader(File.Open(Info.filename, FileMode.Open, FileAccess.Read));
            bool flag = false;
           int num_of_records = (int)br.BaseStream.Length / Info.rec_size;
            Info.ID = int.Parse(IDsearch.Text);
            if (num_of_records > 0) // If The file Not Empty
            {

                for (Info.count = 0; Info.count < br.BaseStream.Length; Info.count += 32)
                {
                    br.BaseStream.Seek(Info.count, SeekOrigin.Begin);
                    if (IDsearch.Text.ToString() == br.ReadInt32().ToString())
                    {
                        if (!Info.mod)
                        {
                              MessageBox.Show("Item Found", "Search Result");
                              flag = true;
                              br.Close();
                              break;
                        }
                        else
                        {
                       
                            flag = true;
                            this.Hide();
                            br.Close();
                            new ModifyForm().Show();
                            break;
                           
                         
                        }
                    }

                }
                if (!flag)
                {
               
                    MessageBox.Show("Not Found","Search Result");
                    br.Close();
                }
            }
        }
    }
}
      
      
 
 
         
  

