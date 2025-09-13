namespace Jankovic_4
{
    partial class RegistrationForm
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
            this.filmSchoolTitleLabel = new System.Windows.Forms.Label();
            this.registerDateLabel = new System.Windows.Forms.Label();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.registrantInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.dobMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.registerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.pricePerClassOutputLabel = new System.Windows.Forms.Label();
            this.numberOfClassOutputLabel = new System.Windows.Forms.Label();
            this.totalTitleLabel = new System.Windows.Forms.Label();
            this.pricePerClassTitleLabel = new System.Windows.Forms.Label();
            this.numberOfClassTitleLabel = new System.Windows.Forms.Label();
            this.maxRuleLabel = new System.Windows.Forms.Label();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.liveActionRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.receiptCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theaterPictureBox = new System.Windows.Forms.PictureBox();
            this.registrantInfoGroupBox.SuspendLayout();
            this.registerInfoGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theaterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // filmSchoolTitleLabel
            // 
            this.filmSchoolTitleLabel.AutoSize = true;
            this.filmSchoolTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filmSchoolTitleLabel.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmSchoolTitleLabel.Location = new System.Drawing.Point(262, 120);
            this.filmSchoolTitleLabel.Name = "filmSchoolTitleLabel";
            this.filmSchoolTitleLabel.Size = new System.Drawing.Size(277, 29);
            this.filmSchoolTitleLabel.TabIndex = 1;
            this.filmSchoolTitleLabel.Text = "Hopkins Film School";
            // 
            // registerDateLabel
            // 
            this.registerDateLabel.AutoSize = true;
            this.registerDateLabel.Location = new System.Drawing.Point(274, 176);
            this.registerDateLabel.Name = "registerDateLabel";
            this.registerDateLabel.Size = new System.Drawing.Size(92, 13);
            this.registerDateLabel.TabIndex = 2;
            this.registerDateLabel.Text = "Registration Date:";
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(372, 173);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(70, 20);
            this.dateMaskedTextBox.TabIndex = 3;
            this.dateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // registrantInfoGroupBox
            // 
            this.registrantInfoGroupBox.Controls.Add(this.statusLabel);
            this.registrantInfoGroupBox.Controls.Add(this.statusComboBox);
            this.registrantInfoGroupBox.Controls.Add(this.dobMaskedTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.dobLabel);
            this.registrantInfoGroupBox.Controls.Add(this.emailTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.emailLabel);
            this.registrantInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.registrantInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.registrantInfoGroupBox.Location = new System.Drawing.Point(87, 226);
            this.registrantInfoGroupBox.Name = "registrantInfoGroupBox";
            this.registrantInfoGroupBox.Size = new System.Drawing.Size(308, 249);
            this.registrantInfoGroupBox.TabIndex = 4;
            this.registrantInfoGroupBox.TabStop = false;
            this.registrantInfoGroupBox.Text = "Registrant Information";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 135);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(87, 132);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 9;
            // 
            // dobMaskedTextBox
            // 
            this.dobMaskedTextBox.Location = new System.Drawing.Point(87, 106);
            this.dobMaskedTextBox.Mask = "00/00/0000";
            this.dobMaskedTextBox.Name = "dobMaskedTextBox";
            this.dobMaskedTextBox.Size = new System.Drawing.Size(68, 20);
            this.dobMaskedTextBox.TabIndex = 7;
            this.dobMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dobMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(6, 109);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(69, 13);
            this.dobLabel.TabIndex = 6;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(87, 76);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(5, 79);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(76, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email Address:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(87, 49);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 52);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(87, 22);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 25);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // registerInfoGroupBox
            // 
            this.registerInfoGroupBox.Controls.Add(this.groupBox1);
            this.registerInfoGroupBox.Controls.Add(this.totalOutputLabel);
            this.registerInfoGroupBox.Controls.Add(this.pricePerClassOutputLabel);
            this.registerInfoGroupBox.Controls.Add(this.numberOfClassOutputLabel);
            this.registerInfoGroupBox.Controls.Add(this.totalTitleLabel);
            this.registerInfoGroupBox.Controls.Add(this.pricePerClassTitleLabel);
            this.registerInfoGroupBox.Controls.Add(this.numberOfClassTitleLabel);
            this.registerInfoGroupBox.Controls.Add(this.maxRuleLabel);
            this.registerInfoGroupBox.Controls.Add(this.classesListBox);
            this.registerInfoGroupBox.Controls.Add(this.animationRadioButton);
            this.registerInfoGroupBox.Controls.Add(this.liveActionRadioButton);
            this.registerInfoGroupBox.Location = new System.Drawing.Point(401, 226);
            this.registerInfoGroupBox.Name = "registerInfoGroupBox";
            this.registerInfoGroupBox.Size = new System.Drawing.Size(313, 249);
            this.registerInfoGroupBox.TabIndex = 5;
            this.registerInfoGroupBox.TabStop = false;
            this.registerInfoGroupBox.Text = "Registration Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(164, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 3);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutputLabel.Location = new System.Drawing.Point(167, 209);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(74, 23);
            this.totalOutputLabel.TabIndex = 9;
            this.totalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pricePerClassOutputLabel
            // 
            this.pricePerClassOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePerClassOutputLabel.Location = new System.Drawing.Point(167, 179);
            this.pricePerClassOutputLabel.Name = "pricePerClassOutputLabel";
            this.pricePerClassOutputLabel.Size = new System.Drawing.Size(74, 23);
            this.pricePerClassOutputLabel.TabIndex = 7;
            this.pricePerClassOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberOfClassOutputLabel
            // 
            this.numberOfClassOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfClassOutputLabel.Location = new System.Drawing.Point(167, 150);
            this.numberOfClassOutputLabel.Name = "numberOfClassOutputLabel";
            this.numberOfClassOutputLabel.Size = new System.Drawing.Size(74, 23);
            this.numberOfClassOutputLabel.TabIndex = 5;
            this.numberOfClassOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalTitleLabel
            // 
            this.totalTitleLabel.AutoSize = true;
            this.totalTitleLabel.Location = new System.Drawing.Point(92, 210);
            this.totalTitleLabel.Name = "totalTitleLabel";
            this.totalTitleLabel.Size = new System.Drawing.Size(61, 13);
            this.totalTitleLabel.TabIndex = 8;
            this.totalTitleLabel.Text = "Total Price:";
            // 
            // pricePerClassTitleLabel
            // 
            this.pricePerClassTitleLabel.AutoSize = true;
            this.pricePerClassTitleLabel.Location = new System.Drawing.Point(72, 180);
            this.pricePerClassTitleLabel.Name = "pricePerClassTitleLabel";
            this.pricePerClassTitleLabel.Size = new System.Drawing.Size(81, 13);
            this.pricePerClassTitleLabel.TabIndex = 6;
            this.pricePerClassTitleLabel.Text = "Price Per Class:";
            // 
            // numberOfClassTitleLabel
            // 
            this.numberOfClassTitleLabel.AutoSize = true;
            this.numberOfClassTitleLabel.Location = new System.Drawing.Point(10, 151);
            this.numberOfClassTitleLabel.Name = "numberOfClassTitleLabel";
            this.numberOfClassTitleLabel.Size = new System.Drawing.Size(143, 13);
            this.numberOfClassTitleLabel.TabIndex = 4;
            this.numberOfClassTitleLabel.Text = "Number of Classes Selected:";
            // 
            // maxRuleLabel
            // 
            this.maxRuleLabel.AutoSize = true;
            this.maxRuleLabel.Location = new System.Drawing.Point(147, 47);
            this.maxRuleLabel.Name = "maxRuleLabel";
            this.maxRuleLabel.Size = new System.Drawing.Size(133, 13);
            this.maxRuleLabel.TabIndex = 3;
            this.maxRuleLabel.Text = "Max. Four Classes Allowed";
            // 
            // classesListBox
            // 
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.Location = new System.Drawing.Point(21, 42);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.classesListBox.Size = new System.Drawing.Size(120, 95);
            this.classesListBox.Sorted = true;
            this.classesListBox.TabIndex = 2;
            this.classesListBox.SelectedIndexChanged += new System.EventHandler(this.classesListBox_SelectedIndexChanged);
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Location = new System.Drawing.Point(164, 19);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(71, 17);
            this.animationRadioButton.TabIndex = 1;
            this.animationRadioButton.Text = "Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            this.animationRadioButton.CheckedChanged += new System.EventHandler(this.animationRadioButton_CheckedChanged);
            // 
            // liveActionRadioButton
            // 
            this.liveActionRadioButton.AutoSize = true;
            this.liveActionRadioButton.Checked = true;
            this.liveActionRadioButton.Location = new System.Drawing.Point(21, 19);
            this.liveActionRadioButton.Name = "liveActionRadioButton";
            this.liveActionRadioButton.Size = new System.Drawing.Size(78, 17);
            this.liveActionRadioButton.TabIndex = 0;
            this.liveActionRadioButton.TabStop = true;
            this.liveActionRadioButton.Text = "Live Action";
            this.liveActionRadioButton.UseVisualStyleBackColor = true;
            this.liveActionRadioButton.CheckedChanged += new System.EventHandler(this.liveActionRadioButton_CheckedChanged);
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Checked = true;
            this.cashRadioButton.Location = new System.Drawing.Point(393, 498);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(49, 17);
            this.cashRadioButton.TabIndex = 7;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            this.cashRadioButton.CheckedChanged += new System.EventHandler(this.cashRadioButton_CheckedChanged);
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(448, 498);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(56, 17);
            this.checkRadioButton.TabIndex = 8;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            this.checkRadioButton.CheckedChanged += new System.EventHandler(this.checkRadioButton_CheckedChanged);
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Location = new System.Drawing.Point(297, 500);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(90, 13);
            this.paymentMethodLabel.TabIndex = 6;
            this.paymentMethodLabel.Text = "Payment Method:";
            // 
            // receiptCheckBox
            // 
            this.receiptCheckBox.AutoSize = true;
            this.receiptCheckBox.Location = new System.Drawing.Point(341, 521);
            this.receiptCheckBox.Name = "receiptCheckBox";
            this.receiptCheckBox.Size = new System.Drawing.Size(146, 17);
            this.receiptCheckBox.TabIndex = 9;
            this.receiptCheckBox.Text = "Email Receipt Requested";
            this.receiptCheckBox.UseVisualStyleBackColor = true;
            this.receiptCheckBox.CheckedChanged += new System.EventHandler(this.receiptCheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.ToolTipText = "Saves the registration form";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.ToolTipText = "Resets the registration form";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exits the registration form";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "Displays about information";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // theaterPictureBox
            // 
            this.theaterPictureBox.Image = global::Jankovic_4.Properties.Resources.theater;
            this.theaterPictureBox.Location = new System.Drawing.Point(12, 36);
            this.theaterPictureBox.Name = "theaterPictureBox";
            this.theaterPictureBox.Size = new System.Drawing.Size(222, 113);
            this.theaterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.theaterPictureBox.TabIndex = 0;
            this.theaterPictureBox.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.receiptCheckBox);
            this.Controls.Add(this.paymentMethodLabel);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.registerInfoGroupBox);
            this.Controls.Add(this.registrantInfoGroupBox);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(this.registerDateLabel);
            this.Controls.Add(this.filmSchoolTitleLabel);
            this.Controls.Add(this.theaterPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hopkins Film School Registration";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.registrantInfoGroupBox.ResumeLayout(false);
            this.registrantInfoGroupBox.PerformLayout();
            this.registerInfoGroupBox.ResumeLayout(false);
            this.registerInfoGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theaterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox theaterPictureBox;
        private System.Windows.Forms.Label filmSchoolTitleLabel;
        private System.Windows.Forms.Label registerDateLabel;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.GroupBox registrantInfoGroupBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.MaskedTextBox dobMaskedTextBox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox registerInfoGroupBox;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label pricePerClassOutputLabel;
        private System.Windows.Forms.Label numberOfClassOutputLabel;
        private System.Windows.Forms.Label totalTitleLabel;
        private System.Windows.Forms.Label pricePerClassTitleLabel;
        private System.Windows.Forms.Label numberOfClassTitleLabel;
        private System.Windows.Forms.Label maxRuleLabel;
        private System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.RadioButton liveActionRadioButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.CheckBox receiptCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

