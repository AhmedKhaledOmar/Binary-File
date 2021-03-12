namespace Binary_File
{
    partial class Searhform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.searchname = new System.Windows.Forms.Button();
            this.DisplayFNtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDsearch
            // 
            this.IDsearch.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDsearch.Location = new System.Drawing.Point(132, 148);
            this.IDsearch.Margin = new System.Windows.Forms.Padding(2);
            this.IDsearch.Name = "IDsearch";
            this.IDsearch.Size = new System.Drawing.Size(102, 28);
            this.IDsearch.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(181, 245);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(67, 32);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // searchname
            // 
            this.searchname.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchname.Location = new System.Drawing.Point(287, 151);
            this.searchname.Margin = new System.Windows.Forms.Padding(2);
            this.searchname.Name = "searchname";
            this.searchname.Size = new System.Drawing.Size(72, 32);
            this.searchname.TabIndex = 20;
            this.searchname.Text = "Sarech by ID";
            this.searchname.UseVisualStyleBackColor = true;
            this.searchname.Click += new System.EventHandler(this.searchname_Click);
            // 
            // DisplayFNtextBox
            // 
            this.DisplayFNtextBox.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayFNtextBox.Location = new System.Drawing.Point(121, 47);
            this.DisplayFNtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayFNtextBox.Name = "DisplayFNtextBox";
            this.DisplayFNtextBox.Size = new System.Drawing.Size(182, 28);
            this.DisplayFNtextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "File Name";
            // 
            // Searhform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayFNtextBox);
            this.Controls.Add(this.searchname);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDsearch);
            this.Name = "Searhform";
            this.Text = "Searchform";
            this.Load += new System.EventHandler(this.modifayform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button searchname;
        private System.Windows.Forms.TextBox DisplayFNtextBox;
        private System.Windows.Forms.Label label1;
    }
}