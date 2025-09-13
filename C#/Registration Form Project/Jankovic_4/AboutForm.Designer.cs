namespace Jankovic_4
{
    partial class AboutForm
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
            this.filmPictureBox = new System.Windows.Forms.PictureBox();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.closeToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.filmPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // filmPictureBox
            // 
            this.filmPictureBox.Image = global::Jankovic_4.Properties.Resources.film;
            this.filmPictureBox.Location = new System.Drawing.Point(12, 12);
            this.filmPictureBox.Name = "filmPictureBox";
            this.filmPictureBox.Size = new System.Drawing.Size(329, 183);
            this.filmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filmPictureBox.TabIndex = 0;
            this.filmPictureBox.TabStop = false;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.Location = new System.Drawing.Point(365, 27);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(288, 80);
            this.copyrightLabel.TabIndex = 1;
            this.copyrightLabel.Text = "Hopkins Film School Registration Copyright 2020 by A. Jankovic";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(520, 172);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "&Close";
            this.closeToolTip.SetToolTip(this.closeButton, "Closes the about window");
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 223);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.filmPictureBox);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.filmPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox filmPictureBox;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolTip closeToolTip;
    }
}