// Programmer: Alesandro Jankovic
// Project: Jankovic_2
// Due Date: 10/11/2022
// Description: Individual Assignment #2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jankovic_2
{
    public partial class Form1 : Form
    {
        // In State and Out of State Constants
        private const int IN_STATE = 49;
        private const int OUT_STATE = 99;

        // Declare numOfClass and totalPrice Variables
        private int numOfClass = 0;
        private int totalPrice = 0;


        public Form1()
        {
            InitializeComponent();
        }


        // French CheckBox Statements
        private void frenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // In State and Out of State If Statements When CheckBox is True
            if (frenchCheckBox.Checked)
            {
                if (inStateRadioButton.Checked)
                {
                    numOfClass += 1;
                    totalPrice += IN_STATE;
                }

                if (outOfStateRadioButton.Checked)
                {
                    numOfClass += 1;
                    totalPrice += OUT_STATE;
                }
            }


            // In State and Out of State If Statements When CheckBox is False
            if (frenchCheckBox.Checked == false)
            {
                if (inStateRadioButton.Checked)
                {
                    numOfClass -= 1;
                    totalPrice -= IN_STATE;
                }

                if (outOfStateRadioButton.Checked)
                {
                    numOfClass -= 1;
                    totalPrice -= OUT_STATE;

                }
            }


            numOfCourseOutputLabel.Text = numOfClass.ToString();
            totalPriceOutputLabel.Text = totalPrice.ToString("c");

        }

        // German CheckBox Statements
        private void germanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // In State and Out of State If Statements When CheckBox is True
            if (germanCheckBox.Checked)
            {
                if (inStateRadioButton.Checked)
                {
                    numOfClass += 1;
                    totalPrice += IN_STATE;
                }

                if (outOfStateRadioButton.Checked)
                {
                    numOfClass += 1;
                    totalPrice += OUT_STATE;
                }

            }

            // In State and Out of State If Statements When CheckBox is False
            if (germanCheckBox.Checked == false)
            {
                if (inStateRadioButton.Checked)
                {
                    numOfClass -= 1;
                    totalPrice -= IN_STATE;
                }

                if (outOfStateRadioButton.Checked)
                {
                    numOfClass -= 1;
                    totalPrice -= OUT_STATE;

                }
            }

            numOfCourseOutputLabel.Text = numOfClass.ToString();
            totalPriceOutputLabel.Text = totalPrice.ToString("c");
        }

        // Italian CheckBox Statements
        private void italianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // In State and Out of State If Statements When CheckBox is True
            if (italianCheckBox.Checked)
            {
                if (inStateRadioButton.Checked)
                {
                    numOfClass += 1;
                    totalPrice += IN_STATE;
                }

                if (outOfStateRadioButton.Checked)
                {
                    numOfClass += 1;
                    totalPrice += OUT_STATE;
                }

            }

            // In State and Out of State If Statements When CheckBox is False
            if (italianCheckBox.Checked == false)
            {
                if (inStateRadioButton.Checked)
                {
                    numOfClass -= 1;
                    totalPrice -= IN_STATE;
                }

                if (outOfStateRadioButton.Checked)
                {
                    numOfClass -= 1;
                    totalPrice -= OUT_STATE;

                }
            }

            numOfCourseOutputLabel.Text = numOfClass.ToString();
            totalPriceOutputLabel.Text = totalPrice.ToString("c");
        }

        // Russian CheckBox Statements
        private void russianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // In State and Out of State If Statements When CheckBox is True
            if (russianCheckBox.Checked)
            {
                if (inStateRadioButton.Checked)
                {
                    numOfClass += 1;
                    totalPrice += IN_STATE;
                }

                if (outOfStateRadioButton.Checked)
                {
                    numOfClass += 1;
                    totalPrice += OUT_STATE;
                }

            }

            // In State and Out of State If Statements When CheckBox is False
            if (russianCheckBox.Checked == false)
            {
                if (inStateRadioButton.Checked)
                {
                    numOfClass -= 1;
                    totalPrice -= IN_STATE;
                }

                if (outOfStateRadioButton.Checked)
                {
                    numOfClass -= 1;
                    totalPrice -= OUT_STATE;

                }
            }

            numOfCourseOutputLabel.Text = numOfClass.ToString();
            totalPriceOutputLabel.Text = totalPrice.ToString("c");
        }

        // Spanish CheckBox Statements
        private void spanishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // In State and Out of State If Statements When CheckBox is True
            if (spanishCheckBox.Checked)
            {
                if (inStateRadioButton.Checked)
                {
                    numOfClass += 1;
                    totalPrice += IN_STATE;
                }

                if (outOfStateRadioButton.Checked)
                {
                    numOfClass += 1;
                    totalPrice += OUT_STATE;
                }

            }

            // In State and Out of State If Statements When CheckBox is False
            if (spanishCheckBox.Checked == false)
            {
                if (inStateRadioButton.Checked)
                {
                    numOfClass -= 1;
                    totalPrice -= IN_STATE;
                }

                if (outOfStateRadioButton.Checked)
                {
                    numOfClass -= 1;
                    totalPrice -= OUT_STATE;

                }
            }

            numOfCourseOutputLabel.Text = numOfClass.ToString();
            totalPriceOutputLabel.Text = totalPrice.ToString("c");
        }

        // Save Button Functions
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Message Box for orders for with no courses selected or more than 3 courses were selected
            if (numOfClass == 0 || numOfClass > 3)
            {
                MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                MessageBox.Show("Error! Please select the appropriate number of courses.", "Error Insufficient Number Of Courses", MessageBoxButtons.OK , icon);
            }

            // Message Box for Fall Term, In State, and MasterCard
            if (fallRadioButton.Checked && inStateRadioButton.Checked && mastercardRadioButton.Checked && numOfClass > 0 && numOfClass <= 3)
            {
                MessageBox.Show("Registration Term:" + " " + fallRadioButton.Text + " " + yearComboBox.Text + "\n"
                    + "Student ID:" + " " + studentIDMaskedTextBox.Text + "\n"
                    + "Student Name:" + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n"
                    + "Email Address:" + " " + emailTextBox.Text + "\n"
                    + "Residence Status:" + " " + inStateRadioButton.Text + "\n"
                    + "Total Courses Purchased:" + " " + numOfCourseOutputLabel.Text + "\n"
                    + "Price per Course:" + " " + IN_STATE.ToString("c") + "\n"
                    + "Total Order Price:" + " " + totalPriceOutputLabel.Text + "\n"
                    + "Credit Card Type:" + " " + mastercardRadioButton.Text + "\n"
                    + "Card Number:" + " " + cardNumberMaskedTextBox.Text + "\n"
                    + "Card Expiration Date:" + " " + expirationMaskedTextBox.Text
                    ,"Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            // Message Box for Fall Term, Out of State, and MasterCard
            if (fallRadioButton.Checked && outOfStateRadioButton.Checked && mastercardRadioButton.Checked && numOfClass > 0 && numOfClass <= 3)
            {
                MessageBox.Show("Registration Term:" + " " + fallRadioButton.Text + " " + yearComboBox.Text + "\n"
                    + "Student ID:" + " " + studentIDMaskedTextBox.Text + "\n"
                    + "Student Name:" + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n"
                    + "Email Address:" + " " + emailTextBox.Text + "\n"
                    + "Residence Status:" + " " + outOfStateRadioButton.Text + "\n"
                    + "Total Courses Purchased:" + " " + numOfCourseOutputLabel.Text + "\n"
                    + "Price per Course:" + " " + OUT_STATE.ToString("c") + "\n"
                    + "Total Order Price:" + " " + totalPriceOutputLabel.Text + "\n"
                    + "Credit Card Type:" + " " + mastercardRadioButton.Text + "\n"
                    + "Card Number:" + " " + cardNumberMaskedTextBox.Text + "\n"
                    + "Card Expiration Date:" + " " + expirationMaskedTextBox.Text
                    , "Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            // Message Box for Fall Term, In State, and Visa
            if (fallRadioButton.Checked && inStateRadioButton.Checked && visaRadioButton.Checked && numOfClass > 0 && numOfClass <= 3)
            {
                MessageBox.Show("Registration Term:" + " " + fallRadioButton.Text + " " + yearComboBox.Text + "\n"
                    + "Student ID:" + " " + studentIDMaskedTextBox.Text + "\n"
                    + "Student Name:" + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n"
                    + "Email Address:" + " " + emailTextBox.Text + "\n"
                    + "Residence Status:" + " " + inStateRadioButton.Text + "\n"
                    + "Total Courses Purchased:" + " " + numOfCourseOutputLabel.Text + "\n"
                    + "Price per Course:" + " " + IN_STATE.ToString("c") + "\n"
                    + "Total Order Price:" + " " + totalPriceOutputLabel.Text + "\n"
                    + "Credit Card Type:" + " " + visaRadioButton.Text + "\n"
                    + "Card Number:" + " " + cardNumberMaskedTextBox.Text + "\n"
                    + "Card Expiration Date:" + " " + expirationMaskedTextBox.Text
                    , "Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            // Message Box for Fall Term, Out of State, and Visa
            if (fallRadioButton.Checked && outOfStateRadioButton.Checked && visaRadioButton.Checked && numOfClass > 0 && numOfClass <= 3)
            {
                MessageBox.Show("Registration Term:" + " " + fallRadioButton.Text + " " + yearComboBox.Text + "\n"
                    + "Student ID:" + " " + studentIDMaskedTextBox.Text + "\n"
                    + "Student Name:" + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n"
                    + "Email Address:" + " " + emailTextBox.Text + "\n"
                    + "Residence Status:" + " " + outOfStateRadioButton.Text + "\n"
                    + "Total Courses Purchased:" + " " + numOfCourseOutputLabel.Text + "\n"
                    + "Price per Course:" + " " + OUT_STATE.ToString("c") + "\n"
                    + "Total Order Price:" + " " + totalPriceOutputLabel.Text + "\n"
                    + "Credit Card Type:" + " " + visaRadioButton.Text + "\n"
                    + "Card Number:" + " " + cardNumberMaskedTextBox.Text + "\n"
                    + "Card Expiration Date:" + " " + expirationMaskedTextBox.Text
                    , "Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            // Message Box for Spring Term, In State, and MasterCard
            if (springRadioButton.Checked && inStateRadioButton.Checked && mastercardRadioButton.Checked && numOfClass > 0 && numOfClass <= 3)
            {
                MessageBox.Show("Registration Term:" + " " + springRadioButton.Text + " " + yearComboBox.Text + "\n"
                    + "Student ID:" + " " + studentIDMaskedTextBox.Text + "\n"
                    + "Student Name:" + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n"
                    + "Email Address:" + " " + emailTextBox.Text + "\n"
                    + "Residence Status:" + " " + inStateRadioButton.Text + "\n"
                    + "Total Courses Purchased:" + " " + numOfCourseOutputLabel.Text + "\n"
                    + "Price per Course:" + " " + IN_STATE.ToString("c") + "\n"
                    + "Total Order Price:" + " " + totalPriceOutputLabel.Text + "\n"
                    + "Credit Card Type:" + " " + mastercardRadioButton.Text + "\n"
                    + "Card Number:" + " " + cardNumberMaskedTextBox.Text + "\n"
                    + "Card Expiration Date:" + " " + expirationMaskedTextBox.Text
                    , "Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            // Message Box for Spring Term, Out of State, and MasterCard
            if (springRadioButton.Checked && outOfStateRadioButton.Checked && mastercardRadioButton.Checked && numOfClass > 0 && numOfClass <= 3)
            {
                MessageBox.Show("Registration Term:" + " " + springRadioButton.Text + " " + yearComboBox.Text + "\n"
                    + "Student ID:" + " " + studentIDMaskedTextBox.Text + "\n"
                    + "Student Name:" + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n"
                    + "Email Address:" + " " + emailTextBox.Text + "\n"
                    + "Residence Status:" + " " + outOfStateRadioButton.Text + "\n"
                    + "Total Courses Purchased:" + " " + numOfCourseOutputLabel.Text + "\n"
                    + "Price per Course:" + " " + OUT_STATE.ToString("c") + "\n"
                    + "Total Order Price:" + " " + totalPriceOutputLabel.Text + "\n"
                    + "Credit Card Type:" + " " + mastercardRadioButton.Text + "\n"
                    + "Card Number:" + " " + cardNumberMaskedTextBox.Text + "\n"
                    + "Card Expiration Date:" + " " + expirationMaskedTextBox.Text
                    , "Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            // Message Box for Spring Term, In State, and Visa
            if (springRadioButton.Checked && inStateRadioButton.Checked && visaRadioButton.Checked && numOfClass > 0 && numOfClass <= 3)
            {
                MessageBox.Show("Registration Term:" + " " + springRadioButton.Text + " " + yearComboBox.Text + "\n"
                    + "Student ID:" + " " + studentIDMaskedTextBox.Text + "\n"
                    + "Student Name:" + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n"
                    + "Email Address:" + " " + emailTextBox.Text + "\n"
                    + "Residence Status:" + " " + inStateRadioButton.Text + "\n"
                    + "Total Courses Purchased:" + " " + numOfCourseOutputLabel.Text + "\n"
                    + "Price per Course:" + " " + IN_STATE.ToString("c") + "\n"
                    + "Total Order Price:" + " " + totalPriceOutputLabel.Text + "\n"
                    + "Credit Card Type:" + " " + visaRadioButton.Text + "\n"
                    + "Card Number:" + " " + cardNumberMaskedTextBox.Text + "\n"
                    + "Card Expiration Date:" + " " + expirationMaskedTextBox.Text
                    , "Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            // Message Box for Spring Term, Out of State, and Visa
            if (springRadioButton.Checked && outOfStateRadioButton.Checked && visaRadioButton.Checked && numOfClass > 0 && numOfClass <= 3)
            {
                MessageBox.Show("Registration Term:" + " " + springRadioButton.Text + " " + yearComboBox.Text + "\n"
                    + "Student ID:" + " " + studentIDMaskedTextBox.Text + "\n"
                    + "Student Name:" + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n"
                    + "Email Address:" + " " + emailTextBox.Text + "\n"
                    + "Residence Status:" + " " + outOfStateRadioButton.Text + "\n"
                    + "Total Courses Purchased:" + " " + numOfCourseOutputLabel.Text + "\n"
                    + "Price per Course:" + " " + OUT_STATE.ToString("c") + "\n"
                    + "Total Order Price:" + " " + totalPriceOutputLabel.Text + "\n"
                    + "Credit Card Type:" + " " + visaRadioButton.Text + "\n"
                    + "Card Number:" + " " + cardNumberMaskedTextBox.Text + "\n"
                    + "Card Expiration Date:" + " " + expirationMaskedTextBox.Text
                    , "Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        // Load Event for Intial Values of Number of Courses and Total Price
        private void Form1_Load(object sender, EventArgs e)
        {
            numOfCourseOutputLabel.Text = numOfClass.ToString();
            totalPriceOutputLabel.Text = totalPrice.ToString("c");

        }

        // Event to Update Total Price if Residence Status Changed to Out of State
        private void outOfStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (numOfClass == 5 && outOfStateRadioButton.Checked)
            {
                totalPrice = 5 * OUT_STATE;
                totalPriceOutputLabel.Text = totalPrice.ToString("c");
            }

            if (numOfClass == 4 && outOfStateRadioButton.Checked)
            {
                totalPrice = 4 * OUT_STATE;
                totalPriceOutputLabel.Text = totalPrice.ToString("c");
            }

            if (numOfClass == 3 && outOfStateRadioButton.Checked)
            {
                totalPrice = 3 * OUT_STATE;
                totalPriceOutputLabel.Text = totalPrice.ToString("c");
            }

            if (numOfClass == 2 && outOfStateRadioButton.Checked)
            {
                totalPrice = 2 * OUT_STATE;
                totalPriceOutputLabel.Text = totalPrice.ToString("c");
            }

            if (numOfClass == 1 && outOfStateRadioButton.Checked)
            {
                totalPrice = OUT_STATE;
                totalPriceOutputLabel.Text = totalPrice.ToString("c");
            }
        }

        // Event to Update Total Price if Residence Status Changed to In State
        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (numOfClass == 5 && inStateRadioButton.Checked)
            {
                totalPrice = 5 * IN_STATE;
                totalPriceOutputLabel.Text = totalPrice.ToString("c");
            }

            if (numOfClass == 4 && inStateRadioButton.Checked)
            {
                totalPrice = 4 * IN_STATE;
                totalPriceOutputLabel.Text = totalPrice.ToString("c");
            }

            if (numOfClass == 3 && inStateRadioButton.Checked)
            {
                totalPrice = 3 * IN_STATE;
                totalPriceOutputLabel.Text = totalPrice.ToString("c");
            }

            if (numOfClass == 2 && inStateRadioButton.Checked)
            {
                totalPrice = 2 * IN_STATE;
                totalPriceOutputLabel.Text = totalPrice.ToString("c");
            }

            if (numOfClass == 1 && inStateRadioButton.Checked)
            {
                totalPrice = IN_STATE;
                totalPriceOutputLabel.Text = totalPrice.ToString("c");
            }
        }

        // Clear Button Function
        private void clearButton_Click(object sender, EventArgs e)
        {
            fallRadioButton.Checked = true;
            yearComboBox.SelectedIndex = -1;
            studentIDMaskedTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            inStateRadioButton.Checked = true;
            frenchCheckBox.Checked = false;
            germanCheckBox.Checked = false;
            italianCheckBox.Checked = false;
            russianCheckBox.Checked = false;
            spanishCheckBox.Checked = false;
            mastercardRadioButton.Checked = true;
            cardNumberMaskedTextBox.Text = "";
            expirationMaskedTextBox.Text = "";

        }

        // Exit Button Function
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Message Box for Exiting Form
            string message = "Do you want to exit?";
            string title = "Exiting Order Form";
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
    }
}
