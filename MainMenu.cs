namespace Wiki_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            FillInData();
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
        }

        private void ListView1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                ShowDetails(item.SubItems[3].Text);
            }
        }

        // Create a global 2D string array, use static variables for the dimensions (row = 12, column = 4),
        public string[,] data;
        public int rows = 12;
        public int columns = 4;

        private void FillInData()
        {
            data = new string[rows, columns];
            Display();
        }

        // Create an ADD button that will store the information from the 4 text boxes into the 2D array,
        private void Add_Btn_Click(object sender, EventArgs e)
        {
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
        private void GrabDataFromTextBoxes(int ent)
        {
            data[ent, 0] = textBox1.Text;
            data[ent, 1] = textBox2.Text;
            data[ent, 2] = textBox3.Text;
            data[ent, 3] = textBox4.Text;
        }

        // Create an EDIT button that will allow the user to modify any information from the 4 text boxes into the 2D array,
        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < data.GetLength(0); i++)
            {
                if (data[i, 0] != null)
                {
                    GrabDataFromTextBoxes(i);
                    break;
                }
            }
            MessageBox.Show("Data Changed!");
        }

        // Create a DELETE button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs, 
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            switch (confirmResult)
            {
                case DialogResult.Yes:
                    DeleteEntry(listView1.SelectedIndices[0]);
                    break;
                case DialogResult.No:

                    break;
                default:
                    break;
            }
            Display();
        }
        private void DeleteEntry(int index)
        {
            data[index, 0] = string.Empty;
            data[index, 1] = string.Empty;
            data[index, 2] = string.Empty;
            data[index, 3] = string.Empty;
        }

        // Create a CLEAR method to clear the four text boxes so a new definition can be added,
        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        // Write the code for a Bubble Sort method to sort the 2D array by Name ascending,
        // ensure you use a separate swap method that passes the array element to be swapped (do not use any built-in array methods),
        private void BubbleSort()
        {

        }
        private void TurnEmptyEntriesToSwaps()
        {
            for (int y = 0; y < data.GetLength(0); y++)
            {
                if(data[y, 0] == String.Empty || data[y, 0] == null)
                {
                    data[y, 0] = "~";
                    data[y, 1] = "~";
                    data[y, 2] = "~";
                    data[y, 3] = "~";
                }
            }
        }

        // Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found,
        // add suitable feedback if the search in not successful and clear the search textbox (do not use any built-in array methods),
        private void Search(string name)
        {
            int index = -1;
            for (int i = 1; i < data.GetLength(0); i++)
            {
                if (data[i, 0] == name)
                {
                    index = i;
                    Search_TextBox.Clear();
                    break;
                }
            }

            if (index >= 0)
            {
                textBox1.Text = data[index, 0];
                textBox2.Text = data[index, 1];
                textBox3.Text = data[index, 2];
                textBox4.Text = data[index, 3];
                MessageBox.Show("Entry Found!");
            }
            else
            {
                MessageBox.Show("No Entries Found!");
            }
        }

        // Create a display method that will show the following information in a ListView: Name and Category,
        private void Display()
        {
            listView1.Clear();
            listView1.View = View.Details;

            listView1.Columns.Add("Data Structure", 100);
            listView1.Columns.Add("Category", 100);
            //listView1.Columns.Add("Structure", 100);
            //listView1.Columns.Add("Definition", 100);

            for (int y = 0; y < data.GetLength(0); y++)
            {
                listView1.Items.Add(data[y, 0]);
                listView1.Items[y].SubItems.Add(data[y, 1]);
                listView1.Items[y].SubItems.Add(data[y, 2]);
                listView1.Items[y].SubItems.Add(data[y, 3]);
            }

        }

        // Create a method so the user can select a definition (Name) from the ListView and all the information is displayed in the appropriate Textboxes,
        private void ShowDetails(string details)
        {
            DescriptionBox.Text = details;
        }

        // Create a SAVE button so the information from the 2D array can be written into a binary file called definitions.dat which is sorted by Name,
        // ensure the user has the option to select an alternative file. Use a file stream and BinaryWriter to create the file.
        const string fileName = "definitions.dat";
        private void SaveFile()
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (var stream = File.Open(fileName, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, System.Text.Encoding.UTF8, false))
                {
                    for (int y = 0; y < data.GetLength(0); y++)
                    {
                        if(data[y, 0] != null)
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
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        // Create a LOAD button that will read the information from a binary file called definitions.dat into the 2D array,
        // ensure the user has the option to select an alternative file. Use a file stream and BinaryReader to complete this task.
        private void LoadFile(Stream stream, string filepath)
        {
            if(!File.Exists(filepath))
            {
                return;
            }
            using (stream)
            {
                using (var reader = new BinaryReader(stream, System.Text.Encoding.UTF8, false))
                {
                    while (stream.Position < stream.Length)
                    {
                        for (int i = 0; i < rows + 1; i++)
                        {
                            data[i, 0] = reader.ReadString();
                            data[i, 1] = reader.ReadString();
                            data[i, 2] = reader.ReadString();
                            data[i, 3] = reader.ReadString();
                        }
                    }
                }
            }
            MessageBox.Show("Data Loaded!");
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