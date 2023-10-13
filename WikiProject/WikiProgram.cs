using System;
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
using System.Globalization;

/// =========================================
/// 
/// Wiki Software v 2.0
/// 
/// Made by Raymond Lai
/// Student Code: 30082866
/// 
/// =========================================

namespace WikiProject
{
    public partial class WikiProgram : Form
    {
        public WikiProgram()
        {
            InitializeComponent();
            AssignCallbacks();
        }

        // 6.2 Create a global List<T> of type Information called Wiki.
        private List<Information> data = new List<Information>();
        private const string defaultFileName = "definitions.dat";
        private TextInfo globalTextInfo = new CultureInfo("en-US", false).TextInfo;

        private void AssignCallbacks()
        {
            // More easily readable than fumbling around Designer
            Add_Btn.Click += AddEntry;
            Delete_Btn.Click += DeleteEntry;
            Edit_Btn.Click += EditEntry;
            Clear_Btn.Click += Clear;
            Search_Btn.Click += Search;
            Name_TextBox.DoubleClick += ClearOnDoubleClick;
            Search_TextBox.KeyDown += Search;
            WikiData_ListView.SelectedIndexChanged += SelectEntry;
            WikiData_ListView.DoubleClick += RegisterDeleteOnDoubleClick;
            Save_Btn.Click += SaveFile;
            Load_Btn.Click += LoadFile;
            this.Load += LoadCategoryBox;
            this.FormClosing += AutoSave;
        }

        // 6.3 Create a button method to ADD a new item to the list.
        // Use a TextBox for the Name input, ComboBox for the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        private void AddEntry(object sender, EventArgs e)
        {
            AddEntry();
        }
        public void AddEntry()
        {
            if (!CheckInputsData()) // Check if any empty input fields
            {
                return;
            }
            if (ValidName(TrimAndTitle(GetInputsData().GetName().ToLower()))) // Check if data already exists as an duplicate
            {
                DisplayStatusMessage("Duplicate Entry. Please add in an unique entry!", true, "Add Entry");
                return;
            }

            // Add all input texts into an entry to the data list
            data.Add(GetInputsData());
            Sort();
            Clear();
            DisplayWikiListView();

            DisplayStatusMessage("Added Data");
        }

        // 6.4 Create a custom method to populate the ComboBox when the Form Load method is called. The six categories must be read from a simple text file.
        public void LoadCategoryBox(object sender, EventArgs e)
        {
            try
            {
                const string categoryFileName = "category.txt";
                string[] lines = File.ReadAllLines(categoryFileName);
                foreach (var item in lines)
                {
                    Category_ComboBox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                DisplayStatusMessage("Exception: " + ex.Message, true, "Error");
            }
        }

        // 6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name and returns a Boolean after checking for duplicates.
        // Use the built in List<T> method “Exists” to answer this requirement.
        public bool ValidName(string _name)
        {
            if (data.Exists(x => x.GetName() == _name))
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
        public string GetSelectedRadio()
        {
            foreach (var item in Structure_GroupBox.Controls)
            {
                RadioButton radio = item as RadioButton;
                if (radio != null)
                {
                    if (radio.Checked)
                    {
                        return radio.Text;
                    }
                }
            }
            return string.Empty;
        }
        public void SetSelectedRadio(int _index)
        {
            RadioButton radio = Structure_GroupBox.Controls[_index] as RadioButton;
            if (radio != null)
            {
                radio.Checked = true;
            }
        }

        // 6.7 Create a button method that will delete the currently selected record in the ListView. Ensure the user has the option to backout of this action by using a dialog box. Display an updated version of the sorted list at the end of this process.
        private void DeleteEntry(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("No Entry selected");
            }
        }
        public void DeleteEntry(int _index)
        {
            data.RemoveAt(_index);
            DisplayWikiListView();
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
                EditEntry(WikiData_ListView.SelectedItems[0].Index, GetInputsData().GetName(), GetInputsData().GetCategory(), GetInputsData().GetStructure(), GetInputsData().GetDefinition());
            }
            else
            {
                MessageBox.Show("No Entry selected");
            }
        }
        public void EditEntry(int _index, string _name, string _category, string _structure, string _definition)
        {
            string oldEntryName = data[_index].GetName();

            Information newInfo = new Information();
            newInfo.SetName(_name);
            newInfo.SetCategory(_category);
            newInfo.SetStructure(_structure);
            newInfo.SetDefinition(_definition);

            data[_index] = newInfo;
            DisplayWikiListView();
            Clear();

            string msg = "The following data has changed: " + oldEntryName;
            DisplayStatusMessage(msg, true);
        }

        // 6.9 Create a single custom method that will sort and then display the Name and Category from the wiki information in the list.
        private void Sort(object sender, EventArgs e)
        {
            Sort();
        }
        public void Sort()
        {
            data.Sort((emp1, emp2) => emp1.GetName().CompareTo(emp2.GetName()));
            DisplayWikiListView();
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
            if (e.KeyCode == Keys.Enter)
            {
                Search(Search_TextBox.Text);
            }
        }
        public void Search(string _name)
        {
            Sort();
            string searchName = TrimAndTitle(_name.ToLower());
            if (String.IsNullOrEmpty(_name))
            {
                DisplayStatusMessage("Please input a name for the search", true, "No Name input");
                return;
            }
            if (!ValidName(searchName))
            {
                DisplayStatusMessage("Cannot find any name matching the search", true, "No Name found");
                return;
            }
            int index = -1;
            index = data.BinarySearch(new Information(searchName, null, null, null));
            WikiData_ListView.Items[index].Selected = true;
            Search_TextBox.Clear();

            DisplayStatusMessage("Searched: " + searchName);
        }

        // 6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names and the associated information will be displayed in the related text boxes combo box and radio button
        private void SelectEntry(object sender, EventArgs e)
        {
            if (WikiData_ListView.SelectedItems.Count > 0)
            {
                SelectEntry(WikiData_ListView.SelectedItems[0].Index);
            }
        }
        public void SelectEntry(int _index)
        {
            Name_TextBox.Text = data[_index].GetName();
            Category_ComboBox.Text = data[_index].GetCategory();
            for (int i = 0; i < Structure_GroupBox.Controls.Count; i++)
            {
                var btn = Structure_GroupBox.Controls[i] as RadioButton;
                if (btn != null)
                {
                    if (btn.Text == data[_index].GetStructure())
                    {
                        SetSelectedRadio(i);
                    }
                }
            }
            Definition_Textbox.Text = data[_index].GetDefinition();
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
        private void ClearOnDoubleClick(object sender, EventArgs e)
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
            // Check if there's data
            if (data.Count <= 0)
            {
                DisplayStatusMessage("No Available Data to save", true, "Save Error");
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = defaultFileName;
                saveFileDialog.InitialDirectory = Application.StartupPath; // Seems redundant as having a filename without any slashes points to the Startup Path anyway
                saveFileDialog.Filter = "dat file|*.dat";
                saveFileDialog.Title = "Save an Dat File";
                if (saveFileDialog.FileName != String.Empty && saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(saveFileDialog.FileName, FileMode.Create))
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
                                writer.Write(item.GetName());
                                writer.Write(item.GetCategory());
                                writer.Write(item.GetStructure());
                                writer.Write(item.GetDefinition());
                            }

                        }
                    }

                    string msg = "Data saved at /n";
                    msg += Path.GetFullPath(saveFileDialog.FileName);
                    DisplayStatusMessage(msg.Replace("/n", Environment.NewLine), true);
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
                                        info.SetName(reader.ReadString());
                                        info.SetCategory(reader.ReadString());
                                        info.SetStructure(reader.ReadString());
                                        info.SetDefinition(reader.ReadString());
                                        line++;
                                    }
                                    data.Add(info);
                                    line = 0;
                                }
                            }
                        }
                        Clear();
                        DisplayWikiListView();

                        string msg = "Data loaded from /n";
                        msg += Path.GetFullPath(openFileDialog.FileName);
                        DisplayStatusMessage(msg.Replace("/n", Environment.NewLine), true);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Data File Error!/n" + ex.Message);
            }
        }

        // 6.15 The Wiki application will save data when the form closes.
        private const string autoSaveFileName = "AutoSave.dat";
        public void AutoSave(object sender, EventArgs e)
        {
            // Check if there's data
            if (data.Count <= 0)
            {
                return;
            }

            try
            {
                using (var stream = File.Open(autoSaveFileName, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream, System.Text.Encoding.UTF8, false))
                    {
                        // Save to binary
                        foreach (var item in data)
                        {
                            writer.Write(item.GetName());
                            writer.Write(item.GetCategory());
                            writer.Write(item.GetStructure());
                            writer.Write(item.GetDefinition());
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


        #region Custom helpers
        public string TrimAndTitle(string _name)
        {
            return globalTextInfo.ToTitleCase(_name.Trim());
        }
        /// <summary>
        /// Checks if any of the TextBoxes' values is empty or null
        /// </summary>
        /// <returns></returns>
        private bool CheckInputsData()
        {
            int invalidInputs = 0;
            string msg = string.Empty;
            if (string.IsNullOrEmpty(Name_TextBox.Text))
            {
                msg += "Please Input Name /n";
                invalidInputs++;
            }
            if (string.IsNullOrEmpty(Category_ComboBox.Text))
            {
                msg += "Please Input Category /n";
                invalidInputs++;
            }
            if (string.IsNullOrEmpty(GetSelectedRadio()))
            {
                msg += "Please Input Structure /n";
                invalidInputs++;
            }
            if (string.IsNullOrEmpty(Definition_Textbox.Text))
            {
                msg += "Please Input Definition /n";
                invalidInputs++;
            }

            if (invalidInputs > 0)
            {
                DisplayStatusMessage(msg.Replace("/n", Environment.NewLine), true, "Data Needed");
                return false;
            }

            return true;
        }
        /// <summary>
        /// Grabs all String Texts from all TextBoxes.
        /// </summary>
        /// <returns></returns>
        private Information GetInputsData()
        {
            return new Information(Name_TextBox.Text, Category_ComboBox.Text, GetSelectedRadio(), Definition_Textbox.Text);
        }
        /// <summary>
        /// Refreshes and displays current data into the ListView
        /// </summary>
        private void DisplayWikiListView()
        {
            WikiData_ListView.Clear();
            WikiData_ListView.Columns.Add("Name", 200);
            WikiData_ListView.Columns.Add("Category", 200);
            foreach (var item in data)
            {
                var entry = WikiData_ListView.Items.Add(item.GetName());
                entry.SubItems.Add(item.GetCategory());
            }
        }
        /// <summary>
        /// Displays a message into the Status Message Textbox.
        /// </summary>
        /// <param name="msg">String to output</param>
        /// <param name="showMessageWindow">Show Winforms Message Window</param>
        /// <param name="messageCaption">Name of the Winforms Message Window else defaults to Messager</param>
        public void DisplayStatusMessage(string _msg, bool _showMessageWindow = false, string _messageCaption = null)
        {
            StatusMsg_TextBox.Text = "Status: " + Environment.NewLine + _msg;

            if (_showMessageWindow)
            {
                if (string.IsNullOrEmpty(_messageCaption))
                {
                    MessageBox.Show(_msg, "Message");
                }
                else
                {
                    MessageBox.Show(_msg, _messageCaption);
                }
            }
        }
        #endregion
    }
}
