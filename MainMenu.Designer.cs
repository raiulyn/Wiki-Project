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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.structureBox = new System.Windows.Forms.TextBox();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataView = new System.Windows.Forms.ListView();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Load_Btn = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.DataStructureLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.StructureLabel = new System.Windows.Forms.Label();
            this.DefinitionLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.Sort_Btn = new System.Windows.Forms.Button();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(208, 38);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(33, 38);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(169, 23);
            this.nameBox.TabIndex = 1;
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(33, 86);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(169, 23);
            this.categoryBox.TabIndex = 2;
            // 
            // structureBox
            // 
            this.structureBox.Location = new System.Drawing.Point(33, 135);
            this.structureBox.Name = "structureBox";
            this.structureBox.Size = new System.Drawing.Size(169, 23);
            this.structureBox.TabIndex = 3;
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Location = new System.Drawing.Point(208, 86);
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
            this.Delete_Btn.Location = new System.Drawing.Point(208, 135);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_Btn.TabIndex = 6;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(301, 29);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(345, 23);
            this.searchBox.TabIndex = 7;
            // 
            // dataView
            // 
            this.dataView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.dataView.Location = new System.Drawing.Point(301, 58);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(503, 411);
            this.dataView.TabIndex = 8;
            this.dataView.UseCompatibleStateImageBehavior = false;
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
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(21, 189);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(262, 224);
            this.descriptionBox.TabIndex = 11;
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
            this.CreditsLabel.Text = "By Raymond Lai [Student ID 30082866] Version 31 Aug 2023";
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.Location = new System.Drawing.Point(21, 417);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(262, 23);
            this.Clear_Btn.TabIndex = 20;
            this.Clear_Btn.Text = "Clear";
            this.Clear_Btn.UseVisualStyleBackColor = true;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 527);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.Sort_Btn);
            this.Controls.Add(this.Search_Btn);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.DefinitionLabel);
            this.Controls.Add(this.StructureLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.DataStructureLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.Load_Btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Edit_Btn);
            this.Controls.Add(this.structureBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.Add_Btn);
            this.Name = "MainMenu";
            this.Text = "Wiki Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Add_Btn;
        private TextBox nameBox;
        private TextBox categoryBox;
        private TextBox structureBox;
        private Button Edit_Btn;
        private Button Delete_Btn;
        private TextBox searchBox;
        private ListView dataView;
        private Button Save_Btn;
        private Button Load_Btn;
        private TextBox descriptionBox;
        private Label DataStructureLabel;
        private Label CategoryLabel;
        private Label StructureLabel;
        private Label DefinitionLabel;
        private Label SearchLabel;
        private Button Search_Btn;
        private Button Sort_Btn;
        private Label CreditsLabel;
        private Button Clear_Btn;
    }
}