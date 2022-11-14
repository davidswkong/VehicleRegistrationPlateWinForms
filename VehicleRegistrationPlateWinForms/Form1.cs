/*
 * Project: VehicleRegistrationPlateWinForms
 * Author: David Kong
 * Student ID: 30063446
 * Description:
 *     This program is a Windows Forms App that provides a GUI for the user to add, edit, delete, and search registration plates in a list as a proof of concept
 *     
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRegistrationPlateWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The global data structure is a List<> of type string
        List<string> registrationPlates = new List<string>();

        // Open text file and load data
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog object
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the current project solution directory to default directory
            openFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

            // Set the filter to look for text files
            openFileDialog1.Filter = "Text Files|*.txt";

            // Load the data. Show the dialog box
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Read and display all lines of the file into a list registrationPlates
                registrationPlates = System.IO.File.ReadAllLines(openFileDialog1.FileName).ToList();

                // Refresh listbox
                refreshListBox1();
            }
        }
        // Add button adds a new registration plate from textbox1 to the listbox

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Error trapping if Null or Empty
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a registration plate");
            }
            // Ensure rego plate is unique, disallow duplicates to be added (show error message)
            else if (registrationPlates.Contains(textBox1.Text))
            {
                MessageBox.Show("Registration plate already exists");
            }
            else
            {
                // Add the registration plate to the list
                registrationPlates.Add(textBox1.Text);

                // Refresh listbox
                refreshListBox1();
            }

        }
        //Refresh list box function
        private void refreshListBox1()
        {
            listBox1.Items.Clear();
            registrationPlates.Sort();
            foreach (string car in registrationPlates)
            {
                listBox1.Items.Add(car);
            }
        }


        // Select an item in the list box and refocus cursor to the textbox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the selected item in the textbox
            textBox1.Text = listBox1.SelectedItem.ToString();

        }


        // When registration plate is entered in textbox,after Enter key is pressed, add content of textbox to listbox like Add button
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd_Click(sender, e);
            }
        }

        // Save button saves the data to a text file
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog object
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Set the current project solution directory to default directory
            saveFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

            // Set the filter to look for text files
            saveFileDialog1.Filter = "Text Files|*.txt";

            // Save the data. Show the dialog box
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Creates new file, writes strings from registrationPlates to new file, closes file
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, registrationPlates);
                // Display the updated list in the listbox
                // listBox1.DataSource = registrationPlates;
            }
        }

        // Delete an existing registration plate from the listbox
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Remove the registration plate from the list and listbox
            registrationPlates.Remove(textBox1.Text);
            registrationPlates.Remove(listBox1.SelectedItem.ToString());

            // Display the updated list in the listbox
            // listBox1.DataSource = null;
            // listBox1.DataSource = registrationPlates;

            // Refresh listBox1
            refreshListBox1();

            // Refocus cursor back on the textbox
            textBox1.Focus();

        }

        // Double clicking on a registration plate in the listbox deletes the registration plate
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            // Warning box to warn before deleting a registration plate in listbox
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this registration plate?", "Delete Registration Plate", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                buttonDelete_Click(sender, e);
            }
            else
            {
                // Refocus cursor back on the textbox
                textBox1.Focus();
            }
        }

        // Edit button edits an existing registration plate in the listbox
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a registration plate to edit");
            }
            else
            {
                // Update content in textbox to selected index of the listbox
                registrationPlates[listBox1.SelectedIndex] = textBox1.Text;
                // Update listbox
                refreshListBox1();

                // Refocus cursor back on the textbox
                textBox1.Focus();
            }

            /*
            // Update the registration plate in the list with the altered registration plate in the textbox
            registrationPlates[listBox1.SelectedIndex] = textBox1.Text;
            // Clear the textbox
            textBox1.Clear();
            // Refocus cursor back on the textbox
            textBox1.Focus();
            */
        }


        /* Chris' example on Dinosaurs
         *private void btnAdd_Click(object sender, Eventargs e)
{
dinosaurList.Add(txtDinosaur.text);
txtDinosaur.Clear();
refreshDinosaurListBox();
//txtDinosaur.Text = "";
}

private void btnDelete_Click(object sender, Eventargs e)
{
//dinosaurList.Remove(txtDinosaur.Text);
dinosaurList.Remove(listBoxDinosaurs.SelectedItem.toString)

}

refreshDinosaurListBox()
{

listBoxDinosaurs.Items.Clear();
for (int = 0; i < dinosaurList.Count;  i++)
{
	listBoxDinosaurs.Items.Add(dinosaurList[i]);
}

}
         * 
         * 
         * 
         * 
         * 
         * Frank's example
         * 
         * if item[0] == 'z':
         *   item = item.substring(1)
         * else:
         *  item = "z" + item
         *  update listbox
         * 
         * 
         * 
         * string filename =""
           for(int i =1, i < 1000; i++)
           {
           filename = "demo" + i.ToString("000")+".txt";
           if(!File.Exists(filename)) break;
           }
           using(StreamWriter sw = new StreamWriter(filename))
           {
           sw.WriteLine("Test");
           }
         */
    }
}