namespace Wiki_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            FillInData();
        }

        // Create a global 2D string array, use static variables for the dimensions (row = 12, column = 4),
        public string[,] data;
        public int rows = 12;
        public int columns = 4;

        private void FillInData()
        {
            data = new string[rows, columns];
            data[0, 0] = "Data Structure";
            data[0, 1] = "Category";
            data[0, 2] = "Structure";
            data[0, 3] = "Definition";
            Display();
        }

        // Create an ADD button that will store the information from the 4 text boxes into the 2D array,
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < data.GetLength(0); i++)
            {
                if (data[i, 0] == null)
                {
                    GrabDataFromTextBoxes(i);
                    break;
                }
            }
            MessageBox.Show("Data Added!");
            Display();
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
                    DeleteEntry(1);
                    break;
                case DialogResult.No:

                    break;
                default:
                    break;
            }
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
            listView1 = new ListView();
            listView1.View = View.Details;
            listView1.Items.Add("HELLO");
        }


    }
}