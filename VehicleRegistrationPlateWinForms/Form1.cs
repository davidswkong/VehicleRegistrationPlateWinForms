/*
 * Project: VehicleRegistrationPlateWinForms
 * Author: David Kong
 * Description:
 *     This program is a Windows Forms App that provides a GUI for the user to add, edit, delete, and search registration plates in a list as a proof of concept
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace VehicleRegistrationPlateWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Ready";
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
                toolStripStatusLabel1.Text = "Please enter a registration plate";
            }
            // Ensure rego plate is unique, disallow duplicates to be added (show error message)
            else if (registrationPlates.Contains(textBox1.Text))
            {
                toolStripStatusLabel1.Text = "Registration plate already exists";
            }
            else
            {
                // Add the registration plate to the list
                registrationPlates.Add(textBox1.Text);

                // Refresh listbox
                refreshListBox1();
            }

        }
        //Refresh list box function - clears listbox1, sorts registrationPlates list, for each item in list add items to listbox
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
            if (listBox1.SelectedIndex != -1)
            {
                // Display the selected item in the textbox
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
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

            // Set the properties on saveFileDialog1 so the user is 
            // prompted to create the file if it doesn't exist 
            // or overwrite the file if it does exist.
            // saveFileDialog1.CreatePrompt = true;
            // saveFileDialog1.OverwritePrompt = true;

            // Set the filter to look for text files
            saveFileDialog1.Filter = "Text Files|*.txt";

            // Show the dialog box
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Write the data to the file
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, registrationPlates);
            }

        }

        // Create a FORM closing method using the save method so all data from the List<> will be written back to a single text file called “demo_##.txt” file which is auto incremented (ie demo_01.txt, demo_02.txt, etc).
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Set the initial filename to demo_00.txt
            for (int count = 0; count <= 999; count++)
            {

                string fileName = "demo_" + count.ToString("000") + ".txt";


                // If the file exists, increment the number in the filename
                if (File.Exists(fileName))
                {
                    count++;
                    continue;
                }

                // Write the data to the file
                System.IO.File.WriteAllLines(fileName, registrationPlates);
                break;
                
            }
                
        }


        // Delete an existing registration plate from the listbox
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Remove the registration plate from the list and listbox
            if (listBox1.SelectedIndex == -1)
            {
                toolStripStatusLabel1.Text = "Please select a registration plate to delete";
                return;
            }
            registrationPlates.Remove(textBox1.Text);

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
                toolStripStatusLabel1.Text = "Please select a registration plate to edit";
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
        }

        // Reset button clears all registration plates from the registrationPlates List, listBox1, and text box
        private void buttonReset_Click(object sender, EventArgs e)
        {
            registrationPlates.Clear();
            listBox1.Items.Clear();
            textBox1.Clear();
            refreshListBox1();
        }

        private void buttonBinarySearch_Click(object sender, EventArgs e)
        {
            // Binary search for registration plate in list
            int index = registrationPlates.BinarySearch(textBox1.Text);
            if (index < 0)
            {
                toolStripStatusLabel1.Text = $"Registration plate {textBox1.Text} is not found";
            }
            else
            {
                // Display the registration plate in the listbox
                listBox1.SelectedIndex = index;
                // Display tool strip status
                toolStripStatusLabel1.Text = $"Registration plate {textBox1.Text} is number {index + 1} in the list";
            }
        }

        private void buttonLinearSearch_Click(object sender, EventArgs e)
        {
            // Linear search for registration plate in list
            for (int i = 0; i < registrationPlates.Count; i++)
            {
                
                if (registrationPlates[i] == textBox1.Text)
                {
                    listBox1.SelectedIndex = i;
                    toolStripStatusLabel1.Text = $"Registration plate {textBox1.Text} is number {i + 1} in the list";
                    return;
                }
            }
            // Display tool strip status
            toolStripStatusLabel1.Text = $"Registration plate {textBox1.Text} is not found";
            // Clear and refocus textbox
            textBox1.Clear();
            textBox1.Focus();
        }


        private void buttonTag_Click(object sender, EventArgs e)
        {
            // Tag condition (to tag registration plate with "z" prefix)
            if (registrationPlates[listBox1.SelectedIndex][0] != 'z')
            {
                // Add "z" as a prefix to the registration plate
                registrationPlates[listBox1.SelectedIndex] = "z" + registrationPlates[listBox1.SelectedIndex];               
                // Update content in textbox to selected index of the listbox
                textBox1.Text = registrationPlates[listBox1.SelectedIndex];
                // Update listbox
                refreshListBox1();
                // Refocus cursor back on the textbox
                textBox1.Focus();
            }
            
            // Untag condition (to remove "z" from tagged registration plate)
            else
            {
                // Remove z from registration plate
                registrationPlates[listBox1.SelectedIndex] = registrationPlates[listBox1.SelectedIndex].Substring(1);
                textBox1.Text = registrationPlates[listBox1.SelectedIndex];
                // Update listbox
                refreshListBox1();
                // Refocus cursor back on the textbox
                textBox1.Focus();
             }
            
        }
    }
}

