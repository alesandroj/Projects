// Programmer Name: Alesandro Jankovic
// Project Name: Jankovic_4
// Due Date: 12/02/22
// Hopkins Film School RegistrationForm


using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jankovic_4
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        // Constant Variable Declaration
        private const decimal LIVE_ACTION = 79.95m;
        private const decimal ANIMATION = 99.95m;
        private const int LIMIT = 4;

        // Variable Declaration
        private int numOfClasses = 0;
        private decimal total = 0m;
        private string selectedClasses = "";
        private string receipt = "No";
        private string payment = "Cash";
        private string classType = "Live Action";
        private decimal pricePerClass = LIVE_ACTION;

        // Save Tool Strip Functions
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display Summary Error Messages
            if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("First Name Missing!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("Last Name Missing!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email Address Missing!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!dobMaskedTextBox.MaskFull)
            {
                MessageBox.Show("Date of Birth Missing!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (numOfClasses == 0)
            {
                MessageBox.Show("No classes selected! Please select up to four classes.", "No Classes Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (numOfClasses > LIMIT)
            {
                MessageBox.Show("More than four classes selected! Maximum number of classes allowed is four.", "Class Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Registration Summary Message Box
            else
            {
                MessageBox.Show("Registration Summary\n" +
                    "\nRegistration Date: " + dateMaskedTextBox.Text + "\n" +
                    "Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                    "Email Address: " + emailTextBox.Text + "\n" +
                    "Date of Birth: " + dobMaskedTextBox.Text + "\n" +
                    "Status: " + statusComboBox.SelectedItem + "\n" +
                    "\nClass(es) Selected: " + selectedClasses + "\n" +
                    "Number of Classes Selected: " + numOfClasses.ToString() + "\n" +
                    "Price Per Class: " + pricePerClass.ToString("c") + "\n" +
                    "Total Registration Price: " + total.ToString("c") + "\n" +
                    "Payment Type: " + payment + "\n" +
                    "Email Receipt Requested: " + receipt + "\n", "Registration Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Save to RegistrationData File
            StreamWriter outputFile;
            outputFile = File.AppendText("RegistrationData.txt");
            outputFile.WriteLine("Registration Summary\n" +
                    "\nRegistration Date: " + dateMaskedTextBox.Text + "\n" +
                    "Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                    "Email Address: " + emailTextBox.Text + "\n" +
                    "Date of Birth: " + dobMaskedTextBox.Text + "\n" +
                    "Status: " + statusComboBox.SelectedItem + "\n" +
                    "\nClass(es) Selected: " + selectedClasses + "\n" +
                    "Number of Classes Selected: " + numOfClasses.ToString() + "\n" +
                    "Price Per Class: " + pricePerClass.ToString("c") + "\n" +
                    "Total Registration Price: " + total.ToString("c") + "\n" +
                    "Payment Type: " + payment + "\n" +
                    "Email Receipt Requested: " + receipt + "\n");
            outputFile.Close();

            // Reset Form to Default
            ResetForm();
            UpdateTotals();

        }

        // Clear Tool Strip Functions
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Exit Tool Strip Functions
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Message Box for Exiting Form
            string message = "Are you sure you wish to exit?";
            string title = "Exiting Registration Form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes) // If User Clicks Yes
            {
                this.Close();
            }

            else // If User Clicks No
            {

            }
        }

        // About Tool Strip Functions
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Calling AboutForm
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        // Live Action Radio Button Functions
        private void liveActionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Sets Class Type to Live Action
            classType = "Live Action";
            pricePerClass = LIVE_ACTION;

            // Loads Live Action Classes
            PopulateList();

            // Resets Outputs to Default
            numOfClasses = 0;
            total = 0;
            selectedClasses = "";

            // Update Totals
            UpdateTotals();
        }

        // Animation Radio Button Functions
        private void animationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set Class Type to Animation
            classType = "Animation";
            pricePerClass = ANIMATION;

            // Loads Animation Classes
            PopulateList();

            // Resets Outputs to Default
            numOfClasses = 0;
            total = 0;
            selectedClasses = "";

            // Update Totals
            UpdateTotals();
        }

        // Classes ListBox Selections
        private void classesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Resets Outputs to Default
            numOfClasses = 0;
            total = 0;
            selectedClasses = "";

            // Update Totals
            UpdateTotals();
        }

        
        // Cash Radio Button Funtion
        private void cashRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Sets Payment to Cash for MessageBox
            if (cashRadioButton.Checked)
            {
                payment = "Cash";
            }
        }

        // Check Radio Button Function
        private void checkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Sets Payment to Check for MessageBox
            if (checkRadioButton.Checked)
            {
                payment = "Check";
            }
        }

        // Receipt Check Box
        private void receiptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Sets Receipt to Yes for MessageBox
            if (receiptCheckBox.Checked)
            {
                receipt = "Yes";
            }

            // Sets Receipt to No for MessageBox
            else
            {
                receipt = "No";
            }
        }

        // PopulateList Method
        private void PopulateList()
        {
            // Clears Classes List Box to Prevent Duplicates
            classesListBox.Items.Clear();

            // For Loop to Read in Live Action Classes
            if (liveActionRadioButton.Checked)
            {
                StreamReader inputFile;
                inputFile = File.OpenText("LiveActionClasses.txt");
                while (!inputFile.EndOfStream)
                {
                    classesListBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }

            // For Loop to Read in Animation Classes
            else if (animationRadioButton.Checked)
            {
                StreamReader inputFile2;
                inputFile2 = File.OpenText("AnimationClasses.txt");
                while (!inputFile2.EndOfStream)
                {
                    classesListBox.Items.Add(inputFile2.ReadLine());
                }
                inputFile2.Close();
            }
        }

        // UpdateTotals Method
        private void UpdateTotals()
        {
            // Live Action Classes Calculations
            if (liveActionRadioButton.Checked)
            {
                // For Loop to Read Selected Classes
                for (int count = 0; count < classesListBox.Items.Count; count++)
                {
                    if (classesListBox.GetSelected(count))
                    {
                        numOfClasses++;
                        selectedClasses += classesListBox.Items[count] + "\n";
                    }
                }

                // Output Labels Display
                numberOfClassOutputLabel.Text = numOfClasses.ToString();

                pricePerClassOutputLabel.Text = LIVE_ACTION.ToString("c");

                total = numOfClasses * LIVE_ACTION;
                totalOutputLabel.Text = total.ToString("c");
            }

            // Animation Classes Calculations
            else if (animationRadioButton.Checked)
            {
                // For Loop to Read Selected Classes
                for (int count = 0; count < classesListBox.Items.Count; count++)
                {
                    if (classesListBox.GetSelected(count))
                    {
                        numOfClasses++;
                        selectedClasses += classesListBox.Items[count] + "\n";
                    }
                }

                // Output Labels Display
                numberOfClassOutputLabel.Text = numOfClasses.ToString();

                pricePerClassOutputLabel.Text = ANIMATION.ToString("c");

                total = numOfClasses * ANIMATION;
                totalOutputLabel.Text = total.ToString("c");
            }

        }

        // ResetForm Method
        private void ResetForm()
        {
            // Sets Form to Default Values
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            dobMaskedTextBox.Text = "";
            statusComboBox.Text = "";
            liveActionRadioButton.Checked = true;
            PopulateList();
            numOfClasses = 0;
            total = 0;
            selectedClasses = "";
            UpdateTotals();
            cashRadioButton.Checked = true;
            receiptCheckBox.Checked = false;
            firstNameTextBox.Focus();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // Current Date
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Status Array
            const int SIZE = 8;
            string[] statusArray = new string[SIZE] { "Actor", "Producer", "Director", "Animator", "Cinematographer", "Drama Teacher", "Light Technician", "Sound Technician" };

            // Status ComboBox Display
            for (int count = 0; count < statusArray.Length; count++)
            {
                statusComboBox.Items.Add(statusArray[count]);
            }

            // Load List and Outputs with Default Options upon Load
            PopulateList();
            UpdateTotals();
        }
    }
}
