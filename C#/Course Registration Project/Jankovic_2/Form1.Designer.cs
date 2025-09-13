namespace Jankovic_2
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
            this.languagePictureBox = new System.Windows.Forms.PictureBox();
            this.termInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.yearSelectLabel = new System.Windows.Forms.Label();
            this.springRadioButton = new System.Windows.Forms.RadioButton();
            this.fallRadioButton = new System.Windows.Forms.RadioButton();
            this.termSelectLabel = new System.Windows.Forms.Label();
            this.studentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.outOfStateRadioButton = new System.Windows.Forms.RadioButton();
            this.inStateRadioButton = new System.Windows.Forms.RadioButton();
            this.residenceLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.studentIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.courseInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.spanishCheckBox = new System.Windows.Forms.CheckBox();
            this.russianCheckBox = new System.Windows.Forms.CheckBox();
            this.italianCheckBox = new System.Windows.Forms.CheckBox();
            this.germanCheckBox = new System.Windows.Forms.CheckBox();
            this.frenchCheckBox = new System.Windows.Forms.CheckBox();
            this.chooseCourseLabel = new System.Windows.Forms.Label();
            this.paymentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.expirationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.expirationLabel = new System.Windows.Forms.Label();
            this.cardNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.mastercardRadioButton = new System.Windows.Forms.RadioButton();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.numOfCourseOutputLabel = new System.Windows.Forms.Label();
            this.totalPriceOutputLabel = new System.Windows.Forms.Label();
            this.numOfCourseTitleLabel = new System.Windows.Forms.Label();
            this.totalPriceTitleLabel = new System.Windows.Forms.Label();
            this.saveButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).BeginInit();
            this.termInfoGroupBox.SuspendLayout();
            this.studentInfoGroupBox.SuspendLayout();
            this.courseInfoGroupBox.SuspendLayout();
            this.paymentInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // languagePictureBox
            // 
            this.languagePictureBox.Image = global::Jankovic_2.Properties.Resources.languages_around_the_world;
            this.languagePictureBox.Location = new System.Drawing.Point(12, 22);
            this.languagePictureBox.Name = "languagePictureBox";
            this.languagePictureBox.Size = new System.Drawing.Size(174, 111);
            this.languagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.languagePictureBox.TabIndex = 0;
            this.languagePictureBox.TabStop = false;
            // 
            // termInfoGroupBox
            // 
            this.termInfoGroupBox.Controls.Add(this.yearComboBox);
            this.termInfoGroupBox.Controls.Add(this.yearSelectLabel);
            this.termInfoGroupBox.Controls.Add(this.springRadioButton);
            this.termInfoGroupBox.Controls.Add(this.fallRadioButton);
            this.termInfoGroupBox.Controls.Add(this.termSelectLabel);
            this.termInfoGroupBox.Location = new System.Drawing.Point(198, 12);
            this.termInfoGroupBox.Name = "termInfoGroupBox";
            this.termInfoGroupBox.Size = new System.Drawing.Size(328, 145);
            this.termInfoGroupBox.TabIndex = 0;
            this.termInfoGroupBox.TabStop = false;
            this.termInfoGroupBox.Text = "Term Information:";
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.yearComboBox.Location = new System.Drawing.Point(77, 85);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 4;
            // 
            // yearSelectLabel
            // 
            this.yearSelectLabel.AutoSize = true;
            this.yearSelectLabel.Location = new System.Drawing.Point(6, 88);
            this.yearSelectLabel.Name = "yearSelectLabel";
            this.yearSelectLabel.Size = new System.Drawing.Size(65, 13);
            this.yearSelectLabel.TabIndex = 3;
            this.yearSelectLabel.Text = "Select Year:";
            // 
            // springRadioButton
            // 
            this.springRadioButton.AutoSize = true;
            this.springRadioButton.Location = new System.Drawing.Point(77, 52);
            this.springRadioButton.Name = "springRadioButton";
            this.springRadioButton.Size = new System.Drawing.Size(55, 17);
            this.springRadioButton.TabIndex = 2;
            this.springRadioButton.Text = "Spring";
            this.springRadioButton.UseVisualStyleBackColor = true;
            // 
            // fallRadioButton
            // 
            this.fallRadioButton.AutoSize = true;
            this.fallRadioButton.Checked = true;
            this.fallRadioButton.Location = new System.Drawing.Point(77, 29);
            this.fallRadioButton.Name = "fallRadioButton";
            this.fallRadioButton.Size = new System.Drawing.Size(41, 17);
            this.fallRadioButton.TabIndex = 1;
            this.fallRadioButton.TabStop = true;
            this.fallRadioButton.Text = "Fall";
            this.fallRadioButton.UseVisualStyleBackColor = true;
            // 
            // termSelectLabel
            // 
            this.termSelectLabel.AutoSize = true;
            this.termSelectLabel.Location = new System.Drawing.Point(6, 31);
            this.termSelectLabel.Name = "termSelectLabel";
            this.termSelectLabel.Size = new System.Drawing.Size(67, 13);
            this.termSelectLabel.TabIndex = 0;
            this.termSelectLabel.Text = "Select Term:";
            // 
            // studentInfoGroupBox
            // 
            this.studentInfoGroupBox.Controls.Add(this.outOfStateRadioButton);
            this.studentInfoGroupBox.Controls.Add(this.inStateRadioButton);
            this.studentInfoGroupBox.Controls.Add(this.residenceLabel);
            this.studentInfoGroupBox.Controls.Add(this.emailTextBox);
            this.studentInfoGroupBox.Controls.Add(this.emailLabel);
            this.studentInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.studentInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.studentInfoGroupBox.Controls.Add(this.studentIDMaskedTextBox);
            this.studentInfoGroupBox.Controls.Add(this.studentIDLabel);
            this.studentInfoGroupBox.Location = new System.Drawing.Point(12, 163);
            this.studentInfoGroupBox.Name = "studentInfoGroupBox";
            this.studentInfoGroupBox.Size = new System.Drawing.Size(328, 216);
            this.studentInfoGroupBox.TabIndex = 1;
            this.studentInfoGroupBox.TabStop = false;
            this.studentInfoGroupBox.Text = "Student Information:";
            // 
            // outOfStateRadioButton
            // 
            this.outOfStateRadioButton.AutoSize = true;
            this.outOfStateRadioButton.Location = new System.Drawing.Point(173, 157);
            this.outOfStateRadioButton.Name = "outOfStateRadioButton";
            this.outOfStateRadioButton.Size = new System.Drawing.Size(84, 17);
            this.outOfStateRadioButton.TabIndex = 10;
            this.outOfStateRadioButton.Text = "Out-Of-State";
            this.outOfStateRadioButton.UseVisualStyleBackColor = true;
            this.outOfStateRadioButton.CheckedChanged += new System.EventHandler(this.outOfStateRadioButton_CheckedChanged);
            // 
            // inStateRadioButton
            // 
            this.inStateRadioButton.AutoSize = true;
            this.inStateRadioButton.Checked = true;
            this.inStateRadioButton.Location = new System.Drawing.Point(105, 157);
            this.inStateRadioButton.Name = "inStateRadioButton";
            this.inStateRadioButton.Size = new System.Drawing.Size(62, 17);
            this.inStateRadioButton.TabIndex = 9;
            this.inStateRadioButton.TabStop = true;
            this.inStateRadioButton.Text = "In-State";
            this.inStateRadioButton.UseVisualStyleBackColor = true;
            this.inStateRadioButton.CheckedChanged += new System.EventHandler(this.inStateRadioButton_CheckedChanged);
            // 
            // residenceLabel
            // 
            this.residenceLabel.AutoSize = true;
            this.residenceLabel.Location = new System.Drawing.Point(5, 159);
            this.residenceLabel.Name = "residenceLabel";
            this.residenceLabel.Size = new System.Drawing.Size(94, 13);
            this.residenceLabel.TabIndex = 8;
            this.residenceLabel.Text = "Residence Status:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(105, 121);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 124);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(76, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email Address:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(105, 92);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(5, 95);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(105, 63);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(5, 66);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // studentIDMaskedTextBox
            // 
            this.studentIDMaskedTextBox.Location = new System.Drawing.Point(105, 31);
            this.studentIDMaskedTextBox.Mask = "000-00-0000";
            this.studentIDMaskedTextBox.Name = "studentIDMaskedTextBox";
            this.studentIDMaskedTextBox.Size = new System.Drawing.Size(73, 20);
            this.studentIDMaskedTextBox.TabIndex = 1;
            this.studentIDMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(6, 34);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(61, 13);
            this.studentIDLabel.TabIndex = 0;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // courseInfoGroupBox
            // 
            this.courseInfoGroupBox.Controls.Add(this.spanishCheckBox);
            this.courseInfoGroupBox.Controls.Add(this.russianCheckBox);
            this.courseInfoGroupBox.Controls.Add(this.italianCheckBox);
            this.courseInfoGroupBox.Controls.Add(this.germanCheckBox);
            this.courseInfoGroupBox.Controls.Add(this.frenchCheckBox);
            this.courseInfoGroupBox.Controls.Add(this.chooseCourseLabel);
            this.courseInfoGroupBox.Location = new System.Drawing.Point(346, 163);
            this.courseInfoGroupBox.Name = "courseInfoGroupBox";
            this.courseInfoGroupBox.Size = new System.Drawing.Size(327, 101);
            this.courseInfoGroupBox.TabIndex = 2;
            this.courseInfoGroupBox.TabStop = false;
            this.courseInfoGroupBox.Text = "Course Order Information:";
            // 
            // spanishCheckBox
            // 
            this.spanishCheckBox.AutoSize = true;
            this.spanishCheckBox.Location = new System.Drawing.Point(204, 72);
            this.spanishCheckBox.Name = "spanishCheckBox";
            this.spanishCheckBox.Size = new System.Drawing.Size(114, 17);
            this.spanishCheckBox.TabIndex = 5;
            this.spanishCheckBox.Text = "Beginning Spanish";
            this.spanishCheckBox.UseVisualStyleBackColor = true;
            this.spanishCheckBox.CheckedChanged += new System.EventHandler(this.spanishCheckBox_CheckedChanged);
            // 
            // russianCheckBox
            // 
            this.russianCheckBox.AutoSize = true;
            this.russianCheckBox.Location = new System.Drawing.Point(84, 72);
            this.russianCheckBox.Name = "russianCheckBox";
            this.russianCheckBox.Size = new System.Drawing.Size(114, 17);
            this.russianCheckBox.TabIndex = 4;
            this.russianCheckBox.Text = "Beginning Russian";
            this.russianCheckBox.UseVisualStyleBackColor = true;
            this.russianCheckBox.CheckedChanged += new System.EventHandler(this.russianCheckBox_CheckedChanged);
            // 
            // italianCheckBox
            // 
            this.italianCheckBox.AutoSize = true;
            this.italianCheckBox.Location = new System.Drawing.Point(204, 49);
            this.italianCheckBox.Name = "italianCheckBox";
            this.italianCheckBox.Size = new System.Drawing.Size(104, 17);
            this.italianCheckBox.TabIndex = 3;
            this.italianCheckBox.Text = "Beginning Italian";
            this.italianCheckBox.UseVisualStyleBackColor = true;
            this.italianCheckBox.CheckedChanged += new System.EventHandler(this.italianCheckBox_CheckedChanged);
            // 
            // germanCheckBox
            // 
            this.germanCheckBox.AutoSize = true;
            this.germanCheckBox.Location = new System.Drawing.Point(84, 49);
            this.germanCheckBox.Name = "germanCheckBox";
            this.germanCheckBox.Size = new System.Drawing.Size(113, 17);
            this.germanCheckBox.TabIndex = 2;
            this.germanCheckBox.Text = "Beginning German";
            this.germanCheckBox.UseVisualStyleBackColor = true;
            this.germanCheckBox.CheckedChanged += new System.EventHandler(this.germanCheckBox_CheckedChanged);
            // 
            // frenchCheckBox
            // 
            this.frenchCheckBox.AutoSize = true;
            this.frenchCheckBox.Location = new System.Drawing.Point(204, 26);
            this.frenchCheckBox.Name = "frenchCheckBox";
            this.frenchCheckBox.Size = new System.Drawing.Size(109, 17);
            this.frenchCheckBox.TabIndex = 1;
            this.frenchCheckBox.Text = "Beginning French";
            this.frenchCheckBox.UseVisualStyleBackColor = true;
            this.frenchCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // chooseCourseLabel
            // 
            this.chooseCourseLabel.AutoSize = true;
            this.chooseCourseLabel.Location = new System.Drawing.Point(6, 26);
            this.chooseCourseLabel.Name = "chooseCourseLabel";
            this.chooseCourseLabel.Size = new System.Drawing.Size(129, 13);
            this.chooseCourseLabel.TabIndex = 0;
            this.chooseCourseLabel.Text = "Choose Courses (up to 3):";
            // 
            // paymentInfoGroupBox
            // 
            this.paymentInfoGroupBox.Controls.Add(this.expirationMaskedTextBox);
            this.paymentInfoGroupBox.Controls.Add(this.expirationLabel);
            this.paymentInfoGroupBox.Controls.Add(this.cardNumberMaskedTextBox);
            this.paymentInfoGroupBox.Controls.Add(this.cardNumberLabel);
            this.paymentInfoGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentInfoGroupBox.Controls.Add(this.mastercardRadioButton);
            this.paymentInfoGroupBox.Controls.Add(this.creditCardLabel);
            this.paymentInfoGroupBox.Location = new System.Drawing.Point(346, 270);
            this.paymentInfoGroupBox.Name = "paymentInfoGroupBox";
            this.paymentInfoGroupBox.Size = new System.Drawing.Size(328, 109);
            this.paymentInfoGroupBox.TabIndex = 3;
            this.paymentInfoGroupBox.TabStop = false;
            this.paymentInfoGroupBox.Text = "Payment Information:";
            // 
            // expirationMaskedTextBox
            // 
            this.expirationMaskedTextBox.Location = new System.Drawing.Point(92, 81);
            this.expirationMaskedTextBox.Mask = "00/00/0000";
            this.expirationMaskedTextBox.Name = "expirationMaskedTextBox";
            this.expirationMaskedTextBox.Size = new System.Drawing.Size(66, 20);
            this.expirationMaskedTextBox.TabIndex = 19;
            this.expirationMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expirationMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // expirationLabel
            // 
            this.expirationLabel.AutoSize = true;
            this.expirationLabel.Location = new System.Drawing.Point(4, 84);
            this.expirationLabel.Name = "expirationLabel";
            this.expirationLabel.Size = new System.Drawing.Size(82, 13);
            this.expirationLabel.TabIndex = 18;
            this.expirationLabel.Text = "Expiration Date:";
            // 
            // cardNumberMaskedTextBox
            // 
            this.cardNumberMaskedTextBox.Location = new System.Drawing.Point(92, 52);
            this.cardNumberMaskedTextBox.Mask = "0000000000000000";
            this.cardNumberMaskedTextBox.Name = "cardNumberMaskedTextBox";
            this.cardNumberMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardNumberMaskedTextBox.TabIndex = 17;
            this.cardNumberMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(4, 55);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(72, 13);
            this.cardNumberLabel.TabIndex = 16;
            this.cardNumberLabel.Text = "Card Number:";
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Location = new System.Drawing.Point(159, 24);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(45, 17);
            this.visaRadioButton.TabIndex = 15;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // mastercardRadioButton
            // 
            this.mastercardRadioButton.AutoSize = true;
            this.mastercardRadioButton.Checked = true;
            this.mastercardRadioButton.Location = new System.Drawing.Point(74, 24);
            this.mastercardRadioButton.Name = "mastercardRadioButton";
            this.mastercardRadioButton.Size = new System.Drawing.Size(79, 17);
            this.mastercardRadioButton.TabIndex = 14;
            this.mastercardRadioButton.TabStop = true;
            this.mastercardRadioButton.Text = "MasterCard";
            this.mastercardRadioButton.UseVisualStyleBackColor = true;
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.AutoSize = true;
            this.creditCardLabel.Location = new System.Drawing.Point(6, 26);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(62, 13);
            this.creditCardLabel.TabIndex = 13;
            this.creditCardLabel.Text = "Credit Card:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(225, 438);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "&Save";
            this.saveButtonToolTip.SetToolTip(this.saveButton, "Click to save order information");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(306, 438);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "&Clear";
            this.clearButtonToolTip.SetToolTip(this.clearButton, "Click to clear order form");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(387, 438);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "&Exit";
            this.exitButtonToolTip.SetToolTip(this.exitButton, "Click to exit program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // numOfCourseOutputLabel
            // 
            this.numOfCourseOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOfCourseOutputLabel.Location = new System.Drawing.Point(271, 393);
            this.numOfCourseOutputLabel.Name = "numOfCourseOutputLabel";
            this.numOfCourseOutputLabel.Size = new System.Drawing.Size(67, 23);
            this.numOfCourseOutputLabel.TabIndex = 5;
            this.numOfCourseOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalPriceOutputLabel
            // 
            this.totalPriceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutputLabel.Location = new System.Drawing.Point(454, 394);
            this.totalPriceOutputLabel.Name = "totalPriceOutputLabel";
            this.totalPriceOutputLabel.Size = new System.Drawing.Size(67, 23);
            this.totalPriceOutputLabel.TabIndex = 7;
            this.totalPriceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numOfCourseTitleLabel
            // 
            this.numOfCourseTitleLabel.AutoSize = true;
            this.numOfCourseTitleLabel.Location = new System.Drawing.Point(165, 393);
            this.numOfCourseTitleLabel.Name = "numOfCourseTitleLabel";
            this.numOfCourseTitleLabel.Size = new System.Drawing.Size(100, 13);
            this.numOfCourseTitleLabel.TabIndex = 4;
            this.numOfCourseTitleLabel.Text = "Number of Courses:";
            // 
            // totalPriceTitleLabel
            // 
            this.totalPriceTitleLabel.AutoSize = true;
            this.totalPriceTitleLabel.Location = new System.Drawing.Point(354, 395);
            this.totalPriceTitleLabel.Name = "totalPriceTitleLabel";
            this.totalPriceTitleLabel.Size = new System.Drawing.Size(90, 13);
            this.totalPriceTitleLabel.TabIndex = 6;
            this.totalPriceTitleLabel.Text = "Total Order Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 490);
            this.Controls.Add(this.totalPriceTitleLabel);
            this.Controls.Add(this.numOfCourseTitleLabel);
            this.Controls.Add(this.totalPriceOutputLabel);
            this.Controls.Add(this.numOfCourseOutputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.paymentInfoGroupBox);
            this.Controls.Add(this.courseInfoGroupBox);
            this.Controls.Add(this.studentInfoGroupBox);
            this.Controls.Add(this.termInfoGroupBox);
            this.Controls.Add(this.languagePictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAI Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).EndInit();
            this.termInfoGroupBox.ResumeLayout(false);
            this.termInfoGroupBox.PerformLayout();
            this.studentInfoGroupBox.ResumeLayout(false);
            this.studentInfoGroupBox.PerformLayout();
            this.courseInfoGroupBox.ResumeLayout(false);
            this.courseInfoGroupBox.PerformLayout();
            this.paymentInfoGroupBox.ResumeLayout(false);
            this.paymentInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox languagePictureBox;
        private System.Windows.Forms.GroupBox termInfoGroupBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label yearSelectLabel;
        private System.Windows.Forms.RadioButton springRadioButton;
        private System.Windows.Forms.RadioButton fallRadioButton;
        private System.Windows.Forms.Label termSelectLabel;
        private System.Windows.Forms.GroupBox studentInfoGroupBox;
        private System.Windows.Forms.RadioButton outOfStateRadioButton;
        private System.Windows.Forms.RadioButton inStateRadioButton;
        private System.Windows.Forms.Label residenceLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.MaskedTextBox studentIDMaskedTextBox;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.GroupBox courseInfoGroupBox;
        private System.Windows.Forms.CheckBox spanishCheckBox;
        private System.Windows.Forms.CheckBox russianCheckBox;
        private System.Windows.Forms.CheckBox italianCheckBox;
        private System.Windows.Forms.CheckBox germanCheckBox;
        private System.Windows.Forms.CheckBox frenchCheckBox;
        private System.Windows.Forms.Label chooseCourseLabel;
        private System.Windows.Forms.GroupBox paymentInfoGroupBox;
        private System.Windows.Forms.MaskedTextBox expirationMaskedTextBox;
        private System.Windows.Forms.Label expirationLabel;
        private System.Windows.Forms.MaskedTextBox cardNumberMaskedTextBox;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.RadioButton mastercardRadioButton;
        private System.Windows.Forms.Label creditCardLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label numOfCourseOutputLabel;
        private System.Windows.Forms.Label totalPriceOutputLabel;
        private System.Windows.Forms.Label numOfCourseTitleLabel;
        private System.Windows.Forms.Label totalPriceTitleLabel;
        private System.Windows.Forms.ToolTip saveButtonToolTip;
        private System.Windows.Forms.ToolTip clearButtonToolTip;
        private System.Windows.Forms.ToolTip exitButtonToolTip;
    }
}

