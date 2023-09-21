﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WikiProject
{
    public partial class WikiProgram : Form
    {
        public WikiProgram()
        {
            InitializeComponent();
            Init();
        }

        
        // 6.2 Create a global List<T> of type Information called Wiki.
        private List<Information> data;
        private const string defaultFileName = "definitions.dat";

        void Init()
        {
            data = new List<Information>();
            PopulateCategoryBox();
            // Assigns all callbacks
            Add_Btn.Click += AddEntry;
            Delete_Btn.Click += DeleteEntry;
            Edit_Btn.Click += EditEntry;
            Clear_Btn.Click += Clear;
            Search_Btn.Click += Search;
            Name_TextBox.DoubleClick += RegisterClearOnDoubleClick;
            Search_TextBox.KeyDown += Search;
            WikiData_ListView.SelectedIndexChanged += SelectEntry;
            WikiData_ListView.DoubleClick += RegisterDeleteOnDoubleClick;
            Save_Btn.Click += SaveFile;
            Load_Btn.Click += LoadFile;
            Application.ApplicationExit += AutoSave;
        }

        // Custom Methods
        private Information GetInputsData()
        {
            return new Information(Name_TextBox.Text, Category_ComboBox.Text, GetSelectedRadio(), Definition_Textbox.Text);
        }
        private void RefreshWikiDataBox()
        {
            WikiData_ListView.Clear();
            WikiData_ListView.Columns.Add("Name");
            WikiData_ListView.Columns.Add("Category");
            WikiData_ListView.Columns.Add("Structure");
            WikiData_ListView.Columns.Add("Definition");
            for (int rows = 0; rows < data.Count; rows++)
            {
                WikiData_ListView.Items.Add(data[rows].GetData(0));
                for (int columns = 1; columns < 4; columns++)
                {
                    WikiData_ListView.Items[rows].SubItems.Add(data[rows].GetData(columns));
                }
            }
        }
        public void DisplayStatusMessage(string msg, bool showMessageWindow = false)
        {
            StatusMsg_TextBox.Text = "Status: " + msg;
            if(showMessageWindow)
            {
                MessageBox.Show(msg);
            }
        }


        // 6.3 Create a button method to ADD a new item to the list.
        // Use a TextBox for the Name input, ComboBox for the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        private void AddEntry(object sender, EventArgs e)
        {
            AddEntry();
        }
        public void AddEntry()
        {
            data.Add(GetInputsData());
            RefreshWikiDataBox();
            DisplayStatusMessage("Added Data");
        }

        // 6.4 Create a custom method to populate the ComboBox when the Form Load method is called. The six categories must be read from a simple text file.
        public void PopulateCategoryBox()
        {
            try
            {
                const string categoryFileName = "category.txt";
                string line;
                using (StreamReader sr = new StreamReader(categoryFileName))
                {
                    line = sr.ReadLine();
                    Category_ComboBox.Items.Add(line);
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        Category_ComboBox.Items.Add(line);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        // 6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name and returns a Boolean after checking for duplicates.
        // Use the built in List<T> method “Exists” to answer this requirement.
        public bool ValidName(string name)
        {
            if(data.Exists(x => x.GetData(0) == name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 6.6 Create two methods to highlight and return the values from the Radio button GroupBox.
        // The first method must return a string value from the selected radio button (Linear or Non-Linear).
        // The second method must send an integer index which will highlight an appropriate radio button.
        public void HighlightRadio (int index)
        {
            for (int i = 0; i < Structure_GroupBox.Controls.Count; i++)
            {
                Structure_GroupBox.Controls[i].Focus();
            }
        }
        public string GetSelectedRadio()
        {
            return GetCheckedRadio(Structure_GroupBox).Text;
        }
        private RadioButton GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }
            return null;
        }

        // 6.7 Create a button method that will delete the currently selected record in the ListView. Ensure the user has the option to backout of this action by using a dialog box. Display an updated version of the sorted list at the end of this process.
        private void DeleteEntry(object sender, EventArgs e)
        {
            if(WikiData_ListView.SelectedItems.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                switch (confirmResult)
                {
                    case DialogResult.Yes:
                        DeleteEntry(WikiData_ListView.SelectedItems[0].Index);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("No Entry selected");
            }
        }
        public void DeleteEntry(int index)
        {
            data.RemoveAt(index);
            RefreshWikiDataBox();
            Clear();

            string msg = "Data entry deleted";
            DisplayStatusMessage(msg, true);
        }

        // 6.8 Create a button method that will save the edited record of the currently selected item in the ListView.
        // All the changes in the input controls will be written back to the list. Display an updated version of the sorted list at the end of this process.
        private void EditEntry(object sender, EventArgs e)
        {
            if (WikiData_ListView.SelectedItems.Count > 0)
            {
                EditEntry(WikiData_ListView.SelectedItems[0].Index, GetInputsData());
            }
            else
            {
                MessageBox.Show("No Entry selected");
            }
        }
        public void EditEntry(int index, Information info)
        {
            data[index] = info;
            RefreshWikiDataBox();

            string msg = "Data changed";
            DisplayStatusMessage(msg, true);
        }

        // 6.9 Create a single custom method that will sort and then display the Name and Category from the wiki information in the list.
        private void Sort(object sender, EventArgs e)
        {
            Sort();
        }
        public void Sort()
        {
            data.Sort((emp1, emp2) => emp1.GetData(0).CompareTo(emp2.GetData(0)));
            RefreshWikiDataBox();
        }

        // 6.10 Create a button method that will use the builtin binary search to find a Data Structure name.
        // If the record is found the associated details will populate the appropriate input controls and highlight the name in the ListView.
        // At the end of the search process the search input TextBox must be cleared.
        private void Search(object sender, EventArgs e)
        {
            Search(Search_TextBox.Text);
        }
        private void Search(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Search(Search_TextBox.Text);
            }
        }
        public void Search(string pName)
        {
            if(!ValidName(pName))
            {
                return;
            }

            Sort();
            int index = data.BinarySearch(new Information(pName, null, null, null));
            WikiData_ListView.Items[index].Selected = true;
            Search_TextBox.Clear();

            DisplayStatusMessage("Searched: " + pName);
        }

        // 6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names and the associated information will be displayed in the related text boxes combo box and radio button
        private void SelectEntry(object sender, EventArgs e)
        {
            if(WikiData_ListView.SelectedItems.Count > 0)
            {
                SelectEntry(WikiData_ListView.SelectedItems[0].Index);
            }
        }
        public void SelectEntry(int index)
        {
            Name_TextBox.Text = data[index].GetData(0);
            Category_ComboBox.Text = data[index].GetData(1);
            foreach (var item in Structure_GroupBox.Controls)
            {
                RadioButton btn = ((RadioButton)item);
                if (btn.Text == data[index].GetData(2))
                {
                    btn.Checked = true;
                }
            }
            Definition_Textbox.Text = data[index].GetData(3);
        }

        // 6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio button
        private void Clear(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            Name_TextBox.ResetText();
            Category_ComboBox.ResetText();
            foreach (var item in Structure_GroupBox.Controls)
            {
                ((RadioButton)item).Checked = false;
            }
            Definition_Textbox.ResetText();
        }

        // 6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox and Radio button.
        private void RegisterClearOnDoubleClick(object sender, EventArgs e)
        {
            Clear();
        }
        private void RegisterDeleteOnDoubleClick(object sender, EventArgs e)
        {
            if (WikiData_ListView.SelectedItems.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                switch (confirmResult)
                {
                    case DialogResult.Yes:
                        DeleteEntry(WikiData_ListView.SelectedItems[0].Index);
                        break;
                    default:
                        break;
                }
            }
        }

        // 6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or rename a saved file.
        // All Wiki data is stored/retrieved using a binary reader/writer file format.
        private void SaveFile(object sender, EventArgs e)
        {
            SaveFile();
        }
        public void SaveFile()
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = defaultFileName;
                saveFileDialog1.Filter = "dat file|*.dat";
                saveFileDialog1.Title = "Save an Dat File";
                if (saveFileDialog1.FileName != String.Empty && saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(saveFileDialog1.FileName, FileMode.Create))
                    {
                        using (var writer = new BinaryWriter(stream, System.Text.Encoding.UTF8, false))
                        {
                            // Check if there's data
                            if(data.Count <= 0)
                            {
                                return;
                            }
                            // Save to binary
                            foreach (var item in data)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    writer.Write(item.GetData(i));
                                }
                            }

                        }
                    }
                    DisplayStatusMessage("Data saved", true);
                }
                else
                {
                    // If upon cancel needs to be implemnented
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Data File Error!/n" + ex.Message);
            }
        }
        private void LoadFile(object sender, EventArgs e)
        {
            LoadFile();
        }
        public void LoadFile()
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "dat files (*.txt)|*.dat|All files (*.*)|*.*";
                    openFileDialog.RestoreDirectory = true;

                    int column = 4;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Read the contents of the file into a stream
                        if (!File.Exists(openFileDialog.FileName))
                        {
                            return;
                        }
                        using (openFileDialog.OpenFile())
                        {
                            using (var reader = new BinaryReader(openFileDialog.OpenFile(), System.Text.Encoding.UTF8, false))
                            {
                                data.Clear();
                                int line = 0;
                                while (reader.BaseStream.Position != reader.BaseStream.Length)
                                {
                                    Information info = new Information();
                                    if (line < column)
                                    {
                                        for (int i = 0; i < column; i++)
                                        {
                                            info.SetData(i, reader.ReadString());
                                        }
                                        line++;
                                    }
                                    data.Add(info);
                                    line = 0;
                                }
                            }
                        }
                        Clear();
                        RefreshWikiDataBox();

                        DisplayStatusMessage("Data loaded", true);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Data File Error!/n" + ex.Message);
            }
        }

        // 6.15 The Wiki application will save data when the form closes.
        private const string AutoSaveFileName = "AutoSave.dat";
        public void AutoSave(object sender, EventArgs e)
        {
            try
            {
                using (var stream = File.Open(AutoSaveFileName, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream, System.Text.Encoding.UTF8, false))
                    {
                        // Check if there's data
                        if (data.Count <= 0)
                        {
                            return;
                        }
                        // Save to binary
                        foreach (var item in data)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                writer.Write(item.GetData(i));
                            }
                        }

                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Data File Error!/n" + ex.Message);
            }
        }

        // 6.16 All code is required to be adequately commented.
        // Map the programming criteria and features to your code/methods by adding comments above the method signatures.
        // Ensure your code is compliant with the CITEMS coding standards (refer http://www.citems.com.au/).

    }


}
