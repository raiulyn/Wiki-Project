namespace Wiki_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            InitializeData();
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            listView1.MouseDoubleClick += ListView1_MouseDoubleClick;
        }

        private void ListView1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int ind = listView1.SelectedIndices[0];
                ShowDetails(data[ind, 0], data[ind, 1], data[ind, 2], data[ind, 3]);
            }
        }

        // Create a global 2D string array, use static variables for the dimensions (row = 12, column = 4),
        public string[,] data;
        public int rows = 12;
        public int columns = 4;

        private void InitializeData()
        {
            data = new string[rows, columns];
            Display();
        }

        // Create an ADD button that will store the information from the 4 text boxes into the 2D array,
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || DescriptionBox.Text == String.Empty)
                {
                    MessageBox.Show("Can't add new entry due to incomplete data!");
                    return;
                }
                for (int y = 0; y < data.GetLength(0); y++)
                {
                    if (data[y, 0] == string.Empty || data[y, 0] == null || data[y, 0] == "~")
                    {
                        GrabDataFromTextBoxes(y);
                        break;
                    }
                }
                Display();
                Clear();
                MessageBox.Show("Data Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }

            
        }
        private void GrabDataFromTextBoxes(int ent)
        {
            data[ent, 0] = textBox1.Text;
            data[ent, 1] = textBox2.Text;
            data[ent, 2] = textBox3.Text;
            data[ent, 3] = DescriptionBox.Text;
        }

        // Create an EDIT button that will allow the user to modify any information from the 4 text boxes into the 2D array,
        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedIndices.Count > 0)
                {
                    int ind = listView1.SelectedIndices[0];
                    GrabDataFromTextBoxes(ind);
                    Display();
                    MessageBox.Show("Data Changed!");
                }
                else
                {
                    MessageBox.Show("No Entry selected!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }

        }

        // Create a DELETE button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs, 
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                switch (confirmResult)
                {
                    case DialogResult.Yes:
                        DeleteEntry(listView1.SelectedIndices[0]);
                        MoveToEmptyEntries();
                        Display();
                        MessageBox.Show("Data entry deleted!");
                        break;
                    case DialogResult.No:

                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("No Entry selected!");
            }
        }
        private void DeleteEntry(int index)
        {
            data[index, 0] = string.Empty;
            data[index, 1] = string.Empty;
            data[index, 2] = string.Empty;
            data[index, 3] = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            DescriptionBox.Text = string.Empty;
        }

        private void ListView1_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            try
            {
                var senderList = (ListView)sender;
                var clickedItem = senderList?.HitTest(e.Location).Item;
                if (clickedItem != null && clickedItem.Text != String.Empty)
                {
                    var confirmResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                    switch (confirmResult)
                    {
                        case DialogResult.Yes:
                            DeleteEntry(listView1.SelectedIndices[0]);
                            MoveToEmptyEntries();
                            Display();
                            MessageBox.Show("Data entry deleted!");
                            break;
                        case DialogResult.No:

                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
            
        }

        // Create a CLEAR method to clear the four text boxes so a new definition can be added,
        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            DescriptionBox.Clear();
        }
        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Write the code for a Bubble Sort method to sort the 2D array by Name ascending,
        // ensure you use a separate swap method that passes the array element to be swapped (do not use any built-in array methods),
        private void BubbleSort()
        {
            TurnEmptyEntriesToSymbol();
            for (int y = 0; y < data.GetLength(0) - 1; y++)
            {
                if (String.Compare(data[y, 0], data[y + 1, 0], true) > 0)
                {
                    Swap(y, y + 1);
                }
            }
            MoveToEmptyEntries();
            Display();
        }
        private void Swap(int index1, int index2)
        {
            string[,] temp = new string[rows, columns];
            temp[0, 0] = data[index1, 0];
            temp[0, 1] = data[index1, 1];
            temp[0, 2] = data[index1, 2];
            temp[0, 3] = data[index1, 3];

            data[index1, 0] = data[index2, 0];
            data[index1, 1] = data[index2, 1];
            data[index1, 2] = data[index2, 2];
            data[index1, 3] = data[index2, 3];

            data[index2, 0] = temp[0, 0];
            data[index2, 1] = temp[0, 1];
            data[index2, 2] = temp[0, 2];
            data[index2, 3] = temp[0, 3];
        }
        private void MoveToEmptyEntries()
        {
            // Moves all available data to temp
            int counter = 0;
            string[,] temp = new string[rows, columns];
            for (int y = 0; y < data.GetLength(0); y++)
            {
                if (data[y, 0] != String.Empty && data[y, 0] != "~")
                {
                    temp[counter, 0] = data[y, 0];
                    temp[counter, 1] = data[y, 1];
                    temp[counter, 2] = data[y, 2];
                    temp[counter, 3] = data[y, 3];
                    counter++;
                }
            }
            // Clears and moves back available data from temp
            data = new string[rows, columns];
            for (int y = 0; y < temp.GetLength(0); y++)
            {
                data[y, 0] = temp[y, 0];
                data[y, 1] = temp[y, 1];
                data[y, 2] = temp[y, 2];
                data[y, 3] = temp[y, 3];
            }
        }
        private void TurnEmptyEntriesToSymbol()
        {
            for (int y = 0; y < data.GetLength(0); y++)
            {
                if (data[y, 0] == String.Empty || data[y, 0] == null)
                {
                    data[y, 0] = "~";
                    data[y, 1] = "~";
                    data[y, 2] = "~";
                    data[y, 3] = "~";
                }
            }
        }
        private void RemoveAllSymbols()
        {
            for (int y = 0; y < data.GetLength(0); y++)
            {
                if (data[y, 0] == "~")
                {
                    data[y, 0] = String.Empty;
                    data[y, 1] = String.Empty;
                    data[y, 2] = String.Empty;
                    data[y, 3] = String.Empty;
                }
            }
        }

        private void Sort_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                BubbleSort();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }

        // Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found,
        // add suitable feedback if the search in not successful and clear the search textbox (do not use any built-in array methods),
        private void Search(string name)
        {
            // Search Entry's 1st column by String
            int index = -1;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0].ToLower().Contains(name.ToLower()))
                {
                    index = i;
                    Search_TextBox.Clear();
                    break;
                }
            }

            // Check if there's a name match
            if (index >= 0)
            {
                textBox1.Text = data[index, 0];
                textBox2.Text = data[index, 1];
                textBox3.Text = data[index, 2];
                DescriptionBox.Text = data[index, 3];
                listView1.SelectedIndices.Clear();
                listView1.Items[index].Focused = true;
                listView1.Items[index].Selected = true;
                MessageBox.Show("Entry Found!");
            }
            else
            {
                MessageBox.Show("No Entries Found!");
            }
        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Search(Search_TextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Entries Found!");
            }
        }

        // Create a display method that will show the following information in a ListView: Name and Category,
        private void Display()
        {
            // Clear listview for refreshes
            listView1.Clear();
            listView1.View = View.Details;

            listView1.Columns.Add("Data Structure", 100);
            listView1.Columns.Add("Category", 100);
            listView1.Columns.Add("Structure", 100);
            //listView1.Columns.Add("Definition", 100); //Uncomment to show an additional column

            // Displays all data
            for (int y = 0; y < data.GetLength(0); y++)
            {
                listView1.Items.Add(data[y, 0]);
                listView1.Items[y].SubItems.Add(data[y, 1]);
                listView1.Items[y].SubItems.Add(data[y, 2]);
                listView1.Items[y].SubItems.Add(data[y, 3]);
            }

        }

        // Create a method so the user can select a definition (Name) from the ListView and all the information is displayed in the appropriate Textboxes,
        private void ShowDetails(string a, string b, string c, string d)
        {
            textBox1.Text = a;
            textBox2.Text = b;
            textBox3.Text = c;
            DescriptionBox.Text = d;
        }

        // Create a SAVE button so the information from the 2D array can be written into a binary file called definitions.dat which is sorted by Name,
        // ensure the user has the option to select an alternative file. Use a file stream and BinaryWriter to create the file.
        const string defaultFileName = "definitions.dat";
        private void SaveFile()
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "dat file|*.dat";
                saveFileDialog1.Title = "Save an Dat File";
                saveFileDialog1.ShowDialog();
                if(saveFileDialog1.FileName != String.Empty)
                {
                    using (var stream = File.Open(saveFileDialog1.FileName, FileMode.Create))
                    {
                        using (var writer = new BinaryWriter(stream, System.Text.Encoding.UTF8, false))
                        {
                            for (int y = 0; y < data.GetLength(0); y++)
                            {
                                if (data[y, 0] != null)
                                {
                                    writer.Write(data[y, 0]);
                                    writer.Write(data[y, 1]);
                                    writer.Write(data[y, 2]);
                                    writer.Write(data[y, 3]);
                                }
                            }
                        }
                    }
                    MessageBox.Show("Data Saved!");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Data File Error!/n" + ex.Message);
            }

        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        // Create a LOAD button that will read the information from a binary file called definitions.dat into the 2D array,
        // ensure the user has the option to select an alternative file. Use a file stream and BinaryReader to complete this task.
        private void LoadFile(Stream stream, string filepath)
        {
            try
            {
                int nextEmptyRow = 0;
                if (!File.Exists(filepath))
                {
                    return;
                }
                using (stream)
                {
                    using (var reader = new BinaryReader(stream, System.Text.Encoding.UTF8, false))
                    {
                        while (stream.Position < stream.Length)
                        {
                            data[nextEmptyRow, 0] = reader.ReadString();
                            data[nextEmptyRow, 1] = reader.ReadString();
                            data[nextEmptyRow, 2] = reader.ReadString();
                            data[nextEmptyRow, 3] = reader.ReadString();
                            nextEmptyRow++;
                        }
                    }
                }
                Display();
                MessageBox.Show("Data Loaded!");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Data File Error!/n" + ex.Message);
            }

        }

        private void Load_Btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "dat files (*.txt)|*.dat|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Read the contents of the file into a stream
                    LoadFile(openFileDialog.OpenFile(), openFileDialog.FileName);

                }
            }
        }

        // All code is required to be adequately commented, and each interaction must have suitable error trapping and/or feedback.
        // All methods must utilise the appropriate Dialog Boxes, Message Boxes, etc to ensure fully user functionality.
        // Map the programming criteria (9.1 - 9.11) and features to your code/methods by adding comments above the method signatures.
        // Ensure your code is compliant with the CITEMS coding standards (refer http://www.citems.com.au/).

    }
}