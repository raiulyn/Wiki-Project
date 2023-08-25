﻿namespace Wiki_Project
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
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Load_Btn = new System.Windows.Forms.Button();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.DataStructureLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.StructureLabel = new System.Windows.Forms.Label();
            this.DefinitionLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.Sort_Btn = new System.Windows.Forms.Button();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(173, 38);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(33, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 3;
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Location = new System.Drawing.Point(173, 86);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(75, 23);
            this.Edit_Btn.TabIndex = 5;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Delete_Btn.Location = new System.Drawing.Point(173, 135);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_Btn.TabIndex = 6;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(301, 29);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(345, 23);
            this.Search_TextBox.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(301, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 411);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(173, 446);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(75, 23);
            this.Save_Btn.TabIndex = 9;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Load_Btn
            // 
            this.Load_Btn.Location = new System.Drawing.Point(58, 446);
            this.Load_Btn.Name = "Load_Btn";
            this.Load_Btn.Size = new System.Drawing.Size(75, 23);
            this.Load_Btn.TabIndex = 10;
            this.Load_Btn.Text = "Open";
            this.Load_Btn.UseVisualStyleBackColor = true;
            this.Load_Btn.Click += new System.EventHandler(this.Load_Btn_Click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(21, 189);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(262, 241);
            this.DescriptionBox.TabIndex = 11;
            // 
            // DataStructureLabel
            // 
            this.DataStructureLabel.AutoSize = true;
            this.DataStructureLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataStructureLabel.Location = new System.Drawing.Point(33, 20);
            this.DataStructureLabel.Name = "DataStructureLabel";
            this.DataStructureLabel.Size = new System.Drawing.Size(90, 15);
            this.DataStructureLabel.TabIndex = 12;
            this.DataStructureLabel.Text = "Data Structure";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.Location = new System.Drawing.Point(33, 68);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(57, 15);
            this.CategoryLabel.TabIndex = 13;
            this.CategoryLabel.Text = "Category";
            // 
            // StructureLabel
            // 
            this.StructureLabel.AutoSize = true;
            this.StructureLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StructureLabel.Location = new System.Drawing.Point(33, 117);
            this.StructureLabel.Name = "StructureLabel";
            this.StructureLabel.Size = new System.Drawing.Size(61, 15);
            this.StructureLabel.TabIndex = 14;
            this.StructureLabel.Text = "Structure";
            // 
            // DefinitionLabel
            // 
            this.DefinitionLabel.AutoSize = true;
            this.DefinitionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DefinitionLabel.Location = new System.Drawing.Point(33, 171);
            this.DefinitionLabel.Name = "DefinitionLabel";
            this.DefinitionLabel.Size = new System.Drawing.Size(63, 15);
            this.DefinitionLabel.TabIndex = 15;
            this.DefinitionLabel.Text = "Definition";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.Location = new System.Drawing.Point(301, 11);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(45, 15);
            this.SearchLabel.TabIndex = 16;
            this.SearchLabel.Text = "Search";
            // 
            // Search_Btn
            // 
            this.Search_Btn.Location = new System.Drawing.Point(652, 29);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(75, 23);
            this.Search_Btn.TabIndex = 17;
            this.Search_Btn.Text = "Search";
            this.Search_Btn.UseVisualStyleBackColor = true;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // Sort_Btn
            // 
            this.Sort_Btn.Location = new System.Drawing.Point(729, 29);
            this.Sort_Btn.Name = "Sort_Btn";
            this.Sort_Btn.Size = new System.Drawing.Size(75, 23);
            this.Sort_Btn.TabIndex = 18;
            this.Sort_Btn.Text = "Sort";
            this.Sort_Btn.UseVisualStyleBackColor = true;
            this.Sort_Btn.Click += new System.EventHandler(this.Sort_Btn_Click);
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.AutoSize = true;
            this.CreditsLabel.Location = new System.Drawing.Point(12, 503);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(317, 15);
            this.CreditsLabel.TabIndex = 19;
            this.CreditsLabel.Text = "By Raymond Lai [Student ID 30082866] Version 25 Aug 2023";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 527);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.Sort_Btn);
            this.Controls.Add(this.Search_Btn);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.DefinitionLabel);
            this.Controls.Add(this.StructureLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.DataStructureLabel);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.Load_Btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Search_TextBox);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Edit_Btn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Add_Btn);
            this.Name = "MainMenu";
            this.Text = "Wiki Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Add_Btn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Edit_Btn;
        private Button Delete_Btn;
        private TextBox Search_TextBox;
        private ListView listView1;
        private Button Save_Btn;
        private Button Load_Btn;
        private TextBox DescriptionBox;
        private Label DataStructureLabel;
        private Label CategoryLabel;
        private Label StructureLabel;
        private Label DefinitionLabel;
        private Label SearchLabel;
        private Button Search_Btn;
        private Button Sort_Btn;
        private Label CreditsLabel;
    }
}