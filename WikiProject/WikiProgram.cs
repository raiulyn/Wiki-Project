using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        List<Information> data;
        void Init()
        {
            data = new List<Information>();
        }

        // 6.3 Create a button method to ADD a new item to the list.
        // Use a TextBox for the Name input, ComboBox for the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        public void AddItem()
        {
            data.Add(new Information(Name_TextBox.Text, Category_TextBox.Text, Structure_ComboBox.Text, Definition_Textbox.Text));
        }

        // 6.4 Create a custom method to populate the ComboBox when the Form Load method is called. The six categories must be read from a simple text file.
        public void PopulateBox()
        {

        }
                        //TODO: Implement a callback when Load happens

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
        public void HightlightRadio(int index)
        {

        }
        public string SelectRadio(int index)
        {
            return ""; //TODO: Fix this later
        }

        // 6.7 Create a button method that will delete the currently selected record in the ListView. Ensure the user has the option to backout of this action by using a dialog box. Display an updated version of the sorted list at the end of this process.
        public void DeleteEntry(int index)
        {
            MessageBox.Show("Are you sure you want to delete?", "Confirmation");
            //TODO: Refresh listview
        }

        // 6.8 Create a button method that will save the edited record of the currently selected item in the ListView.
        // All the changes in the input controls will be written back to the list. Display an updated version of the sorted list at the end of this process.
        public void EditEntry()
        {
            //TODO: Refresh listview
        }

        // 6.9 Create a single custom method that will sort and then display the Name and Category from the wiki information in the list.
        public void Sort()
        {
            //data.Sort(x => x.)
        }

        // 6.10 Create a button method that will use the builtin binary search to find a Data Structure name. If the record is found the associated details will populate the appropriate input controls and highlight the name in the ListView. At the end of the search process the search input TextBox must be cleared.
        // 6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names and the associated information will be displayed in the related text boxes combo box and radio button
        // 6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio button
        // 6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox and Radio button.
        // 6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or rename a saved file. All Wiki data is stored/retrieved using a binary reader/writer file format.
        // 6.15 The Wiki application will save data when the form closes.
        // 6.16 All code is required to be adequately commented. Map the programming criteria and features to your code/methods by adding comments above the method signatures. Ensure your code is compliant with the CITEMS coding standards (refer http://www.citems.com.au/).

    }


}
