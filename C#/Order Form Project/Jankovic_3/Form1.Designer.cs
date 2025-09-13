namespace Jankovic_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.balloonsPictureBox = new System.Windows.Forms.PictureBox();
            this.bonnieBalloonLabel = new System.Windows.Forms.Label();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.stateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.zipMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.deliveryInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.homeDeliveryPriceLabel = new System.Windows.Forms.Label();
            this.homeDeliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.storePickUpRadioButton = new System.Windows.Forms.RadioButton();
            this.deliveryDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.orderDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.extraPriceLabel = new System.Windows.Forms.Label();
            this.messageLimitLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messagePriceLabel = new System.Windows.Forms.Label();
            this.messageCheckBox = new System.Windows.Forms.CheckBox();
            this.dozenPriceLabel = new System.Windows.Forms.Label();
            this.extrasListBox = new System.Windows.Forms.ListBox();
            this.halfDozenPriceLabel = new System.Windows.Forms.Label();
            this.extrasLabel = new System.Windows.Forms.Label();
            this.halfDozenRadioButton = new System.Windows.Forms.RadioButton();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.singlePriceLabel = new System.Windows.Forms.Label();
            this.occasionComboBox = new System.Windows.Forms.ComboBox();
            this.occasionLabel = new System.Windows.Forms.Label();
            this.bundleSizeLabel = new System.Windows.Forms.Label();
            this.dozenRadioButton = new System.Windows.Forms.RadioButton();
            this.orderTotalsGroupBox = new System.Windows.Forms.GroupBox();
            this.salesTaxDisplayLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTitleLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.salesTaxTitleLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subtotalTitleLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.balloonsPictureBox)).BeginInit();
            this.customerInfoGroupBox.SuspendLayout();
            this.deliveryInfoGroupBox.SuspendLayout();
            this.orderDetailGroupBox.SuspendLayout();
            this.orderTotalsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // balloonsPictureBox
            // 
            this.balloonsPictureBox.Image = global::Jankovic_3.Properties.Resources.balloons;
            this.balloonsPictureBox.Location = new System.Drawing.Point(12, 12);
            this.balloonsPictureBox.Name = "balloonsPictureBox";
            this.balloonsPictureBox.Size = new System.Drawing.Size(145, 100);
            this.balloonsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloonsPictureBox.TabIndex = 0;
            this.balloonsPictureBox.TabStop = false;
            // 
            // bonnieBalloonLabel
            // 
            this.bonnieBalloonLabel.AutoSize = true;
            this.bonnieBalloonLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bonnieBalloonLabel.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonnieBalloonLabel.Location = new System.Drawing.Point(273, 45);
            this.bonnieBalloonLabel.Name = "bonnieBalloonLabel";
            this.bonnieBalloonLabel.Size = new System.Drawing.Size(255, 33);
            this.bonnieBalloonLabel.TabIndex = 1;
            this.bonnieBalloonLabel.Text = "Bonnie\'s Balloons";
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Controls.Add(this.stateMaskedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.phoneMaskedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.zipMaskedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.cityTextBox);
            this.customerInfoGroupBox.Controls.Add(this.streetTextBox);
            this.customerInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.phoneLabel);
            this.customerInfoGroupBox.Controls.Add(this.zipLabel);
            this.customerInfoGroupBox.Controls.Add(this.stateLabel);
            this.customerInfoGroupBox.Controls.Add(this.cityLabel);
            this.customerInfoGroupBox.Controls.Add(this.streetLabel);
            this.customerInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.customerInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.customerInfoGroupBox.Controls.Add(this.titleComboBox);
            this.customerInfoGroupBox.Controls.Add(this.titleLabel);
            this.customerInfoGroupBox.Location = new System.Drawing.Point(102, 118);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(255, 228);
            this.customerInfoGroupBox.TabIndex = 2;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Customer Information";
            // 
            // stateMaskedTextBox
            // 
            this.stateMaskedTextBox.Location = new System.Drawing.Point(119, 155);
            this.stateMaskedTextBox.Mask = ">LL";
            this.stateMaskedTextBox.Name = "stateMaskedTextBox";
            this.stateMaskedTextBox.Size = new System.Drawing.Size(27, 20);
            this.stateMaskedTextBox.TabIndex = 11;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(119, 205);
            this.phoneMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(81, 20);
            this.phoneMaskedTextBox.TabIndex = 15;
            this.phoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zipMaskedTextBox
            // 
            this.zipMaskedTextBox.Location = new System.Drawing.Point(119, 180);
            this.zipMaskedTextBox.Mask = "00000";
            this.zipMaskedTextBox.Name = "zipMaskedTextBox";
            this.zipMaskedTextBox.Size = new System.Drawing.Size(39, 20);
            this.zipMaskedTextBox.TabIndex = 13;
            this.zipMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.zipMaskedTextBox.ValidatingType = typeof(int);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(119, 131);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(117, 20);
            this.cityTextBox.TabIndex = 9;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(119, 106);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(117, 20);
            this.streetTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(119, 80);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(117, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(119, 55);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(117, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(18, 208);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneLabel.TabIndex = 14;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(19, 183);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(53, 13);
            this.zipLabel.TabIndex = 12;
            this.zipLabel.Text = "Zip Code:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(19, 158);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 10;
            this.stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(19, 133);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "City:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(19, 108);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(79, 13);
            this.streetLabel.TabIndex = 6;
            this.streetLabel.Text = "Street Address:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(18, 83);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(18, 58);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // titleComboBox
            // 
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Items.AddRange(new object[] {
            "Dr.",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Rev."});
            this.titleComboBox.Location = new System.Drawing.Point(119, 24);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(61, 21);
            this.titleComboBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(19, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // deliveryInfoGroupBox
            // 
            this.deliveryInfoGroupBox.Controls.Add(this.homeDeliveryPriceLabel);
            this.deliveryInfoGroupBox.Controls.Add(this.homeDeliveryRadioButton);
            this.deliveryInfoGroupBox.Controls.Add(this.storePickUpRadioButton);
            this.deliveryInfoGroupBox.Controls.Add(this.deliveryDateMaskedTextBox);
            this.deliveryInfoGroupBox.Controls.Add(this.deliveryDateLabel);
            this.deliveryInfoGroupBox.Location = new System.Drawing.Point(102, 352);
            this.deliveryInfoGroupBox.Name = "deliveryInfoGroupBox";
            this.deliveryInfoGroupBox.Size = new System.Drawing.Size(255, 96);
            this.deliveryInfoGroupBox.TabIndex = 3;
            this.deliveryInfoGroupBox.TabStop = false;
            this.deliveryInfoGroupBox.Text = "Delivery Information";
            // 
            // homeDeliveryPriceLabel
            // 
            this.homeDeliveryPriceLabel.AutoSize = true;
            this.homeDeliveryPriceLabel.Location = new System.Drawing.Point(158, 74);
            this.homeDeliveryPriceLabel.Name = "homeDeliveryPriceLabel";
            this.homeDeliveryPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.homeDeliveryPriceLabel.TabIndex = 4;
            // 
            // homeDeliveryRadioButton
            // 
            this.homeDeliveryRadioButton.AutoSize = true;
            this.homeDeliveryRadioButton.Location = new System.Drawing.Point(129, 54);
            this.homeDeliveryRadioButton.Name = "homeDeliveryRadioButton";
            this.homeDeliveryRadioButton.Size = new System.Drawing.Size(94, 17);
            this.homeDeliveryRadioButton.TabIndex = 3;
            this.homeDeliveryRadioButton.Text = "Home Delivery";
            this.homeDeliveryRadioButton.UseVisualStyleBackColor = true;
            this.homeDeliveryRadioButton.CheckedChanged += new System.EventHandler(this.homeDeliveryRadioButton_CheckedChanged);
            // 
            // storePickUpRadioButton
            // 
            this.storePickUpRadioButton.AutoSize = true;
            this.storePickUpRadioButton.Checked = true;
            this.storePickUpRadioButton.Location = new System.Drawing.Point(14, 54);
            this.storePickUpRadioButton.Name = "storePickUpRadioButton";
            this.storePickUpRadioButton.Size = new System.Drawing.Size(91, 17);
            this.storePickUpRadioButton.TabIndex = 2;
            this.storePickUpRadioButton.TabStop = true;
            this.storePickUpRadioButton.Text = "Store Pick-Up";
            this.storePickUpRadioButton.UseVisualStyleBackColor = true;
            this.storePickUpRadioButton.CheckedChanged += new System.EventHandler(this.storePickUpRadioButton_CheckedChanged);
            // 
            // deliveryDateMaskedTextBox
            // 
            this.deliveryDateMaskedTextBox.Location = new System.Drawing.Point(133, 24);
            this.deliveryDateMaskedTextBox.Mask = "00/00/0000";
            this.deliveryDateMaskedTextBox.Name = "deliveryDateMaskedTextBox";
            this.deliveryDateMaskedTextBox.Size = new System.Drawing.Size(71, 20);
            this.deliveryDateMaskedTextBox.TabIndex = 1;
            this.deliveryDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.deliveryDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(11, 27);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(74, 13);
            this.deliveryDateLabel.TabIndex = 0;
            this.deliveryDateLabel.Text = "Delivery Date:";
            // 
            // orderDetailGroupBox
            // 
            this.orderDetailGroupBox.Controls.Add(this.extraPriceLabel);
            this.orderDetailGroupBox.Controls.Add(this.messageLimitLabel);
            this.orderDetailGroupBox.Controls.Add(this.messageTextBox);
            this.orderDetailGroupBox.Controls.Add(this.messagePriceLabel);
            this.orderDetailGroupBox.Controls.Add(this.messageCheckBox);
            this.orderDetailGroupBox.Controls.Add(this.dozenPriceLabel);
            this.orderDetailGroupBox.Controls.Add(this.extrasListBox);
            this.orderDetailGroupBox.Controls.Add(this.halfDozenPriceLabel);
            this.orderDetailGroupBox.Controls.Add(this.extrasLabel);
            this.orderDetailGroupBox.Controls.Add(this.halfDozenRadioButton);
            this.orderDetailGroupBox.Controls.Add(this.singleRadioButton);
            this.orderDetailGroupBox.Controls.Add(this.singlePriceLabel);
            this.orderDetailGroupBox.Controls.Add(this.occasionComboBox);
            this.orderDetailGroupBox.Controls.Add(this.occasionLabel);
            this.orderDetailGroupBox.Controls.Add(this.bundleSizeLabel);
            this.orderDetailGroupBox.Controls.Add(this.dozenRadioButton);
            this.orderDetailGroupBox.Location = new System.Drawing.Point(363, 118);
            this.orderDetailGroupBox.Name = "orderDetailGroupBox";
            this.orderDetailGroupBox.Size = new System.Drawing.Size(379, 330);
            this.orderDetailGroupBox.TabIndex = 4;
            this.orderDetailGroupBox.TabStop = false;
            this.orderDetailGroupBox.Text = "Order Details";
            // 
            // extraPriceLabel
            // 
            this.extraPriceLabel.AutoSize = true;
            this.extraPriceLabel.Location = new System.Drawing.Point(33, 113);
            this.extraPriceLabel.Name = "extraPriceLabel";
            this.extraPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.extraPriceLabel.TabIndex = 10;
            // 
            // messageLimitLabel
            // 
            this.messageLimitLabel.AutoSize = true;
            this.messageLimitLabel.Enabled = false;
            this.messageLimitLabel.Location = new System.Drawing.Point(231, 258);
            this.messageLimitLabel.Name = "messageLimitLabel";
            this.messageLimitLabel.Size = new System.Drawing.Size(96, 13);
            this.messageLimitLabel.TabIndex = 15;
            this.messageLimitLabel.Text = "30 Characters Max";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Location = new System.Drawing.Point(9, 237);
            this.messageTextBox.MaxLength = 30;
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(216, 68);
            this.messageTextBox.TabIndex = 14;
            // 
            // messagePriceLabel
            // 
            this.messagePriceLabel.AutoSize = true;
            this.messagePriceLabel.Location = new System.Drawing.Point(141, 215);
            this.messagePriceLabel.Name = "messagePriceLabel";
            this.messagePriceLabel.Size = new System.Drawing.Size(0, 13);
            this.messagePriceLabel.TabIndex = 13;
            // 
            // messageCheckBox
            // 
            this.messageCheckBox.AutoSize = true;
            this.messageCheckBox.Location = new System.Drawing.Point(9, 214);
            this.messageCheckBox.Name = "messageCheckBox";
            this.messageCheckBox.Size = new System.Drawing.Size(132, 17);
            this.messageCheckBox.TabIndex = 12;
            this.messageCheckBox.Text = "Personalized Message";
            this.messageCheckBox.UseVisualStyleBackColor = true;
            this.messageCheckBox.CheckedChanged += new System.EventHandler(this.messageCheckBox_CheckedChanged);
            // 
            // dozenPriceLabel
            // 
            this.dozenPriceLabel.AutoSize = true;
            this.dozenPriceLabel.Location = new System.Drawing.Point(305, 44);
            this.dozenPriceLabel.Name = "dozenPriceLabel";
            this.dozenPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.dozenPriceLabel.TabIndex = 6;
            // 
            // extrasListBox
            // 
            this.extrasListBox.FormattingEnabled = true;
            this.extrasListBox.Location = new System.Drawing.Point(105, 113);
            this.extrasListBox.Name = "extrasListBox";
            this.extrasListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.extrasListBox.Size = new System.Drawing.Size(120, 95);
            this.extrasListBox.Sorted = true;
            this.extrasListBox.TabIndex = 11;
            this.extrasListBox.SelectedIndexChanged += new System.EventHandler(this.extrasListBox_SelectedIndexChanged);
            // 
            // halfDozenPriceLabel
            // 
            this.halfDozenPriceLabel.AutoSize = true;
            this.halfDozenPriceLabel.Location = new System.Drawing.Point(204, 44);
            this.halfDozenPriceLabel.Name = "halfDozenPriceLabel";
            this.halfDozenPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.halfDozenPriceLabel.TabIndex = 4;
            // 
            // extrasLabel
            // 
            this.extrasLabel.AutoSize = true;
            this.extrasLabel.Location = new System.Drawing.Point(6, 113);
            this.extrasLabel.Name = "extrasLabel";
            this.extrasLabel.Size = new System.Drawing.Size(39, 13);
            this.extrasLabel.TabIndex = 9;
            this.extrasLabel.Text = "Extras:";
            // 
            // halfDozenRadioButton
            // 
            this.halfDozenRadioButton.AutoSize = true;
            this.halfDozenRadioButton.Location = new System.Drawing.Point(126, 42);
            this.halfDozenRadioButton.Name = "halfDozenRadioButton";
            this.halfDozenRadioButton.Size = new System.Drawing.Size(78, 17);
            this.halfDozenRadioButton.TabIndex = 3;
            this.halfDozenRadioButton.Text = "Half-Dozen";
            this.halfDozenRadioButton.UseVisualStyleBackColor = true;
            this.halfDozenRadioButton.CheckedChanged += new System.EventHandler(this.halfDozenRadioButton_CheckedChanged);
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.AutoSize = true;
            this.singleRadioButton.Checked = true;
            this.singleRadioButton.Location = new System.Drawing.Point(16, 42);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(54, 17);
            this.singleRadioButton.TabIndex = 1;
            this.singleRadioButton.TabStop = true;
            this.singleRadioButton.Text = "Single";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            this.singleRadioButton.CheckedChanged += new System.EventHandler(this.singleRadioButton_CheckedChanged);
            // 
            // singlePriceLabel
            // 
            this.singlePriceLabel.AutoSize = true;
            this.singlePriceLabel.Location = new System.Drawing.Point(76, 44);
            this.singlePriceLabel.Name = "singlePriceLabel";
            this.singlePriceLabel.Size = new System.Drawing.Size(0, 13);
            this.singlePriceLabel.TabIndex = 2;
            // 
            // occasionComboBox
            // 
            this.occasionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.occasionComboBox.FormattingEnabled = true;
            this.occasionComboBox.Location = new System.Drawing.Point(105, 77);
            this.occasionComboBox.Name = "occasionComboBox";
            this.occasionComboBox.Size = new System.Drawing.Size(121, 21);
            this.occasionComboBox.Sorted = true;
            this.occasionComboBox.TabIndex = 8;
            // 
            // occasionLabel
            // 
            this.occasionLabel.AutoSize = true;
            this.occasionLabel.Location = new System.Drawing.Point(6, 80);
            this.occasionLabel.Name = "occasionLabel";
            this.occasionLabel.Size = new System.Drawing.Size(93, 13);
            this.occasionLabel.TabIndex = 7;
            this.occasionLabel.Text = "Special Occasion:";
            // 
            // bundleSizeLabel
            // 
            this.bundleSizeLabel.AutoSize = true;
            this.bundleSizeLabel.Location = new System.Drawing.Point(6, 24);
            this.bundleSizeLabel.Name = "bundleSizeLabel";
            this.bundleSizeLabel.Size = new System.Drawing.Size(66, 13);
            this.bundleSizeLabel.TabIndex = 0;
            this.bundleSizeLabel.Text = "Bundle Size:";
            // 
            // dozenRadioButton
            // 
            this.dozenRadioButton.AutoSize = true;
            this.dozenRadioButton.Location = new System.Drawing.Point(251, 42);
            this.dozenRadioButton.Name = "dozenRadioButton";
            this.dozenRadioButton.Size = new System.Drawing.Size(56, 17);
            this.dozenRadioButton.TabIndex = 5;
            this.dozenRadioButton.Text = "Dozen";
            this.dozenRadioButton.UseVisualStyleBackColor = true;
            this.dozenRadioButton.CheckedChanged += new System.EventHandler(this.dozenRadioButton_CheckedChanged);
            // 
            // orderTotalsGroupBox
            // 
            this.orderTotalsGroupBox.Controls.Add(this.salesTaxDisplayLabel);
            this.orderTotalsGroupBox.Controls.Add(this.groupBox1);
            this.orderTotalsGroupBox.Controls.Add(this.totalLabel);
            this.orderTotalsGroupBox.Controls.Add(this.totalTitleLabel);
            this.orderTotalsGroupBox.Controls.Add(this.salesTaxLabel);
            this.orderTotalsGroupBox.Controls.Add(this.salesTaxTitleLabel);
            this.orderTotalsGroupBox.Controls.Add(this.subtotalLabel);
            this.orderTotalsGroupBox.Controls.Add(this.subtotalTitleLabel);
            this.orderTotalsGroupBox.Location = new System.Drawing.Point(273, 454);
            this.orderTotalsGroupBox.Name = "orderTotalsGroupBox";
            this.orderTotalsGroupBox.Size = new System.Drawing.Size(212, 100);
            this.orderTotalsGroupBox.TabIndex = 5;
            this.orderTotalsGroupBox.TabStop = false;
            this.orderTotalsGroupBox.Text = "Order Totals";
            // 
            // salesTaxDisplayLabel
            // 
            this.salesTaxDisplayLabel.AutoSize = true;
            this.salesTaxDisplayLabel.Location = new System.Drawing.Point(168, 44);
            this.salesTaxDisplayLabel.Name = "salesTaxDisplayLabel";
            this.salesTaxDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.salesTaxDisplayLabel.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 3);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(100, 71);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(62, 18);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalTitleLabel
            // 
            this.totalTitleLabel.AutoSize = true;
            this.totalTitleLabel.Location = new System.Drawing.Point(9, 72);
            this.totalTitleLabel.Name = "totalTitleLabel";
            this.totalTitleLabel.Size = new System.Drawing.Size(63, 13);
            this.totalTitleLabel.TabIndex = 6;
            this.totalTitleLabel.Text = "Order Total:";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesTaxLabel.Location = new System.Drawing.Point(100, 43);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(62, 18);
            this.salesTaxLabel.TabIndex = 3;
            this.salesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesTaxTitleLabel
            // 
            this.salesTaxTitleLabel.AutoSize = true;
            this.salesTaxTitleLabel.Location = new System.Drawing.Point(15, 44);
            this.salesTaxTitleLabel.Name = "salesTaxTitleLabel";
            this.salesTaxTitleLabel.Size = new System.Drawing.Size(57, 13);
            this.salesTaxTitleLabel.TabIndex = 2;
            this.salesTaxTitleLabel.Text = "Sales Tax:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalLabel.Location = new System.Drawing.Point(99, 15);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(62, 18);
            this.subtotalLabel.TabIndex = 1;
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalTitleLabel
            // 
            this.subtotalTitleLabel.AutoSize = true;
            this.subtotalTitleLabel.Location = new System.Drawing.Point(23, 16);
            this.subtotalTitleLabel.Name = "subtotalTitleLabel";
            this.subtotalTitleLabel.Size = new System.Drawing.Size(49, 13);
            this.subtotalTitleLabel.TabIndex = 0;
            this.subtotalTitleLabel.Text = "Subtotal:";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(234, 573);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(107, 23);
            this.displayButton.TabIndex = 6;
            this.displayButton.Text = "&Display Summary";
            this.displayToolTip.SetToolTip(this.displayButton, "Click to display order infromation entered");
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(347, 573);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "&Clear Form";
            this.clearToolTip.SetToolTip(this.clearButton, "Click to clear order form");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(460, 573);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit Program";
            this.exitToolTip.SetToolTip(this.exitButton, "Click to exit order form");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.orderTotalsGroupBox);
            this.Controls.Add(this.orderDetailGroupBox);
            this.Controls.Add(this.deliveryInfoGroupBox);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.bonnieBalloonLabel);
            this.Controls.Add(this.balloonsPictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonnie\'s Balloons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balloonsPictureBox)).EndInit();
            this.customerInfoGroupBox.ResumeLayout(false);
            this.customerInfoGroupBox.PerformLayout();
            this.deliveryInfoGroupBox.ResumeLayout(false);
            this.deliveryInfoGroupBox.PerformLayout();
            this.orderDetailGroupBox.ResumeLayout(false);
            this.orderDetailGroupBox.PerformLayout();
            this.orderTotalsGroupBox.ResumeLayout(false);
            this.orderTotalsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox balloonsPictureBox;
        private System.Windows.Forms.Label bonnieBalloonLabel;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox zipMaskedTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.MaskedTextBox stateMaskedTextBox;
        private System.Windows.Forms.GroupBox deliveryInfoGroupBox;
        private System.Windows.Forms.RadioButton homeDeliveryRadioButton;
        private System.Windows.Forms.RadioButton storePickUpRadioButton;
        private System.Windows.Forms.MaskedTextBox deliveryDateMaskedTextBox;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.GroupBox orderDetailGroupBox;
        private System.Windows.Forms.ListBox extrasListBox;
        private System.Windows.Forms.Label extrasLabel;
        private System.Windows.Forms.ComboBox occasionComboBox;
        private System.Windows.Forms.Label occasionLabel;
        private System.Windows.Forms.RadioButton dozenRadioButton;
        private System.Windows.Forms.RadioButton halfDozenRadioButton;
        private System.Windows.Forms.RadioButton singleRadioButton;
        private System.Windows.Forms.Label bundleSizeLabel;
        private System.Windows.Forms.Label homeDeliveryPriceLabel;
        private System.Windows.Forms.Label messageLimitLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label messagePriceLabel;
        private System.Windows.Forms.CheckBox messageCheckBox;
        private System.Windows.Forms.Label dozenPriceLabel;
        private System.Windows.Forms.Label halfDozenPriceLabel;
        private System.Windows.Forms.Label singlePriceLabel;
        private System.Windows.Forms.GroupBox orderTotalsGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalTitleLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label salesTaxTitleLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label subtotalTitleLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label extraPriceLabel;
        private System.Windows.Forms.Label salesTaxDisplayLabel;
        private System.Windows.Forms.ToolTip displayToolTip;
        private System.Windows.Forms.ToolTip clearToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
    }
}

