// Programmer Name: Alesandro Jankovic
// Project Name: Jankovic_3
// Due Date: 11/12/22
// Bonnie's Balloons Order Form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jankovic_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Constant Variables
        private const decimal HOME_DELIVERY = 7.50m;
        private const decimal SINGLE = 9.95m;
        private const decimal HALF_DOZEN = 35.95m;
        private const decimal DOZEN = 65.95m;
        private const decimal EXTRA = 9.50m;
        private const decimal MESSAGE = 2.50m;
        private const decimal TAX = 0.07m;

        // Varaible Declarations
        private double subtotal = 0;
        private double tax = 0;
        private double total = 0;
        private double delivery = 0;
        private double message = 0;
        private double bundle = 0;
        private double extra = 0;
        private int extraCount = 0;
        private string extraList1 = "";
        private string extraList2 = "";

        // Load Event to Display Prices, Current Date, and Combo/List Box
        private void Form1_Load(object sender, EventArgs e)
        {
            // Current Date Default
            deliveryDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Displays Price and Tax Boxes
            PopulateBoxes();

            // Birthday Default Option
            occasionComboBox.Text = "Birthday";

            // Order Totals Default Display
            if (singleRadioButton.Checked)
            {
                subtotal = (double)SINGLE;
                tax = subtotal * (double)TAX;
                total = subtotal + tax;
                subtotalLabel.Text = subtotal.ToString("c");
                salesTaxLabel.Text = tax.ToString("c");
                totalLabel.Text = total.ToString("c");
            }

        }

        // Message Check Box Functions
        private void messageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CustomMessage();
            UpdateTotals();
        }

        // Store Pickup Radio Button Functions
        private void storePickUpRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }
        
        // Home Delivery Radio Button Functions
        private void homeDeliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // Single Bundle Size Radio Button Functions
        private void singleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // Half Dozen Bundle Size Radio Button Functions
        private void halfDozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // Dozen Bundle Size Radio Button Functions
        private void dozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // Display Summary Button Functions
        private void displayButton_Click(object sender, EventArgs e)
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

            else if (!phoneMaskedTextBox.MaskFull)
            {
                MessageBox.Show("Phone Number Missing!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Store Pick Up Display Message
            else if (storePickUpRadioButton.Checked)
            {
                // Single Bundle Size Message
                if (singleRadioButton.Checked)
                {
                    MessageBox.Show("Bonnie's Balloons Order Summary" + "\n" +
                "Customer Name: " + titleComboBox.Text + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                "Customer Address: " + streetTextBox.Text + " " + cityTextBox.Text + ", " + stateMaskedTextBox.Text + " " + zipMaskedTextBox.Text + "\n" +
                "Customer Phone: " + phoneMaskedTextBox.Text + "\n" +
                "Delivery Date: " + deliveryDateMaskedTextBox.Text + "\n" +
                "Delivery Type: " + storePickUpRadioButton.Text + "\n" +
                "Bundle Size: " + singleRadioButton.Text + "\n" +
                "Special Occasion: " + occasionComboBox.Text + "\n" +
                "Extras: " + extraList2 + "\n" +
                "Message: " + messageTextBox.Text + "\n" +
                "Order Subtotal: " + subtotal.ToString("c") + "\n" +
                "Sales Tax Amount: " + tax.ToString("c") + "\n" +
                "Order Total: " + total.ToString("c"),
                "Bonnie's Balloons Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Half Dozen Bundle Size Message
                else if (halfDozenRadioButton.Checked)
                {
                    MessageBox.Show("Bonnie's Balloons Order Summary" + "\n" +
                "Customer Name: " + titleComboBox.Text + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                "Customer Address: " + streetTextBox.Text + " " + cityTextBox.Text + ", " + stateMaskedTextBox.Text + " " + zipMaskedTextBox.Text + "\n" +
                "Customer Phone: " + phoneMaskedTextBox.Text + "\n" +
                "Delivery Date: " + deliveryDateMaskedTextBox.Text + "\n" +
                "Delivery Type: " + storePickUpRadioButton.Text + "\n" +
                "Bundle Size: " + halfDozenRadioButton.Text + "\n" +
                "Special Occasion: " + occasionComboBox.Text + "\n" +
                "Extras: " + extraList2 + "\n" +
                "Message: " + messageTextBox.Text + "\n" +
                "Order Subtotal: " + subtotal.ToString("c") + "\n" +
                "Sales Tax Amount: " + tax.ToString("c") + "\n" +
                "Order Total: " + total.ToString("c"),
                "Bonnie's Balloons Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Dozen Bundle Size Message
                else if (dozenRadioButton.Checked)
                {
                    MessageBox.Show("Bonnie's Balloons Order Summary" + "\n" +
                "Customer Name: " + titleComboBox.Text + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                "Customer Address: " + streetTextBox.Text + " " + cityTextBox.Text + ", " + stateMaskedTextBox.Text + " " + zipMaskedTextBox.Text + "\n" +
                "Customer Phone: " + phoneMaskedTextBox.Text + "\n" +
                "Delivery Date: " + deliveryDateMaskedTextBox.Text + "\n" +
                "Delivery Type: " + storePickUpRadioButton.Text + "\n" +
                "Bundle Size: " + dozenRadioButton.Text + "\n" +
                "Special Occasion: " + occasionComboBox.Text + "\n" +
                "Extras: " + extraList2 + "\n" +
                "Message: " + messageTextBox.Text + "\n" +
                "Order Subtotal: " + subtotal.ToString("c") + "\n" +
                "Sales Tax Amount: " + tax.ToString("c") + "\n" +
                "Order Total: " + total.ToString("c"),
                "Bonnie's Balloons Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Home Delivery Summary Messages
            else if (homeDeliveryRadioButton.Checked)
            {
                // Single Bundle Size Message
                if (singleRadioButton.Checked)
                {
                    MessageBox.Show("Bonnie's Balloons Order Summary" + "\n" +
                "Customer Name: " + titleComboBox.Text + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                "Customer Address: " + streetTextBox.Text + " " + cityTextBox.Text + ", " + stateMaskedTextBox.Text + " " + zipMaskedTextBox.Text + "\n" +
                "Customer Phone: " + phoneMaskedTextBox.Text + "\n" +
                "Delivery Date: " + deliveryDateMaskedTextBox.Text + "\n" +
                "Delivery Type: " + homeDeliveryRadioButton.Text + "\n" +
                "Bundle Size: " + singleRadioButton.Text + "\n" +
                "Special Occasion: " + occasionComboBox.Text + "\n" +
                "Extras: " + extraList2 + "\n" +
                "Message: " + messageTextBox.Text + "\n" +
                "Order Subtotal: " + subtotal.ToString("c") + "\n" +
                "Sales Tax Amount: " + tax.ToString("c") + "\n" +
                "Order Total: " + total.ToString("c"),
                "Bonnie's Balloons Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Half Dozen Bundle Size Message
                else if (halfDozenRadioButton.Checked)
                {
                    MessageBox.Show("Bonnie's Balloons Order Summary" + "\n" +
                "Customer Name: " + titleComboBox.Text + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                "Customer Address: " + streetTextBox.Text + " " + cityTextBox.Text + ", " + stateMaskedTextBox.Text + " " + zipMaskedTextBox.Text + "\n" +
                "Customer Phone: " + phoneMaskedTextBox.Text + "\n" +
                "Delivery Date: " + deliveryDateMaskedTextBox.Text + "\n" +
                "Delivery Type: " + homeDeliveryRadioButton.Text + "\n" +
                "Bundle Size: " + halfDozenRadioButton.Text + "\n" +
                "Special Occasion: " + occasionComboBox.Text + "\n" +
                "Extras: " + extraList2 + "\n" +
                "Message: " + messageTextBox.Text + "\n" +
                "Order Subtotal: " + subtotal.ToString("c") + "\n" +
                "Sales Tax Amount: " + tax.ToString("c") + "\n" +
                "Order Total: " + total.ToString("c"),
                "Bonnie's Balloons Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Dozen Bundle Size Message
                else if (dozenRadioButton.Checked)
                {
                    MessageBox.Show("Bonnie's Balloons Order Summary" + "\n" +
                "Customer Name: " + titleComboBox.Text + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                "Customer Address: " + streetTextBox.Text + " " + cityTextBox.Text + ", " + stateMaskedTextBox.Text + " " + zipMaskedTextBox.Text + "\n" +
                "Customer Phone: " + phoneMaskedTextBox.Text + "\n" +
                "Delivery Date: " + deliveryDateMaskedTextBox.Text + "\n" +
                "Delivery Type: " + homeDeliveryRadioButton.Text + "\n" +
                "Bundle Size: " + dozenRadioButton.Text + "\n" +
                "Special Occasion: " + occasionComboBox.Text + "\n" +
                "Extras: " + extraList2 + "\n" +
                "Message: " + messageTextBox.Text + "\n" +
                "Order Subtotal: " + subtotal.ToString("c") + "\n" +
                "Sales Tax Amount: " + tax.ToString("c") + "\n" +
                "Order Total: " + total.ToString("c"),
                "Bonnie's Balloons Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
      
            // Reset Form After Summary
            ResetForm();
        }

        // Clear Button Functions
        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Exit Button Functions
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

        // Extra Selection Code
        private void extrasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // For Loop to Read Which Extras Were Selected
            for (int count = 0; count < extrasListBox.Items.Count; count++)
            {
                if (extrasListBox.GetSelected(count))
                {
                    extraCount++;
                    extraList1 += "(" + extrasListBox.Items[count] + ")";
                    UpdateTotals();
                }
            }

            // If Statement to Subtract When No Extras are Selected Again
            if (extrasListBox.SelectedIndex == -1)
            {
                extra = 0;
                extraList1 = "";
                UpdateTotals();
            }
            
            extraCount = 0;
            extraList2 = extraList1;
            extraList1 = "";
        }

        // DisplayPrice Method
        private void PopulateBoxes()
        {
            // Displays Prices and Tax
            homeDeliveryPriceLabel.Text = HOME_DELIVERY.ToString("c");
            singlePriceLabel.Text = SINGLE.ToString("c");
            halfDozenPriceLabel.Text = HALF_DOZEN.ToString("c");
            dozenPriceLabel.Text = DOZEN.ToString("c");
            extraPriceLabel.Text = EXTRA.ToString("c") + " each";
            messagePriceLabel.Text = MESSAGE.ToString("c");
            salesTaxDisplayLabel.Text = TAX.ToString("p2");

            // Special Occasion Combo Box Text
            StreamReader inputFile;
            inputFile = File.OpenText("Occasions.txt");
            while (!inputFile.EndOfStream)
            {
                occasionComboBox.Items.Add(inputFile.ReadLine());
            }
            inputFile.Close();

            // Extras List Box Text
            StreamReader inputFile2;
            inputFile2 = File.OpenText("Extras.txt");
            while (!inputFile2.EndOfStream)
            {
                extrasListBox.Items.Add(inputFile2.ReadLine());
            }
            inputFile2.Close();
        }

        // CustomMessage Method
        private void CustomMessage()
        {
            // Enables or Disables Message Box
            if (messageCheckBox.Checked)
            {
                messageTextBox.Enabled = true;
                messageLimitLabel.Enabled = true;
            }

            else
            {
                messageTextBox.Enabled = false;
                messageLimitLabel.Enabled = false;
            }

        }

        // UpdateTotals Method
        private void UpdateTotals()
        {
            // Home Delivery and Store Pick Up Calculation
            if (homeDeliveryRadioButton.Checked)
            {
                delivery = (double)HOME_DELIVERY;
            }

            else
            {
                delivery = 0;
            }

            // Bundle Size Calculation
            if (singleRadioButton.Checked)
            {
                bundle = 0;
                bundle = (double)SINGLE;
            }

            else if (halfDozenRadioButton.Checked)
            {
                bundle = 0;
                bundle = (double)HALF_DOZEN;
            }

            else if (dozenRadioButton.Checked)
            {
                bundle = 0;
                bundle = (double)DOZEN;
            }

            // Message Calculation
            if (messageCheckBox.Checked)
            {
                message = (double)MESSAGE;
            }

            else
            {
                message = 0;
            }

            // Extra Calculation
            if (extraCount > 0)
            {
                extra = 0;
                extra = extraCount * (double)EXTRA;
            }

            // Subtotal Calculation and Display
            subtotal = delivery + bundle + extra + message;
            subtotalLabel.Text = subtotal.ToString("c");

            // Tax Calculation and Display
            tax = subtotal * (double)TAX;
            salesTaxLabel.Text = tax.ToString("c");

            // Total Calculation and Display
            total = subtotal + tax;
            totalLabel.Text = total.ToString("c");
        }

        // ResetForm Method
        private void ResetForm()
        {
            // Resets Form to Default
            titleComboBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            streetTextBox.Text = "";
            cityTextBox.Text = "";
            stateMaskedTextBox.Text = "";
            zipMaskedTextBox.Text = "";
            phoneMaskedTextBox.Text = "";
            deliveryDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            storePickUpRadioButton.Checked = true;
            singleRadioButton.Checked = true;
            occasionComboBox.Text = "Birthday";
            messageCheckBox.Checked = false;
            titleComboBox.Focus();

            // Resets Totals to Default
            if (singleRadioButton.Checked)
            {
                subtotal = (double)SINGLE;
                tax = subtotal * (double)TAX;
                total = subtotal + tax;
                subtotalLabel.Text = subtotal.ToString("c");
                salesTaxLabel.Text = tax.ToString("c");
                totalLabel.Text = total.ToString("c");
            }
        }
    }
}
