namespace Wiki_Project
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("4");
            this.Add_Btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Load_Btn = new System.Windows.Forms.Button();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(173, 22);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(33, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(33, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 4;
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Location = new System.Drawing.Point(173, 70);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(75, 23);
            this.Edit_Btn.TabIndex = 5;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(173, 110);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_Btn.TabIndex = 6;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(173, 151);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(100, 23);
            this.Search_TextBox.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(301, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 472);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(173, 472);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(75, 23);
            this.Save_Btn.TabIndex = 9;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Load_Btn
            // 
            this.Load_Btn.Location = new System.Drawing.Point(82, 472);
            this.Load_Btn.Name = "Load_Btn";
            this.Load_Btn.Size = new System.Drawing.Size(75, 23);
            this.Load_Btn.TabIndex = 10;
            this.Load_Btn.Text = "Open";
            this.Load_Btn.UseVisualStyleBackColor = true;
            this.Load_Btn.Click += new System.EventHandler(this.Load_Btn_Click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(33, 254);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(240, 165);
            this.DescriptionBox.TabIndex = 11;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 527);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.Load_Btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Search_TextBox);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Edit_Btn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Add_Btn);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Add_Btn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button Edit_Btn;
        private Button Delete_Btn;
        private TextBox Search_TextBox;
        private ListView listView1;
        private Button Save_Btn;
        private Button Load_Btn;
        private TextBox DescriptionBox;
    }
}