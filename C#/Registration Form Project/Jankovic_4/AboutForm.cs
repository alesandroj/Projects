// Programmer Name: Alesandro Jankovic
// Project Name: Jankovic_4
// Due Date: 12/02/22
// Hopkins Film School AboutForm

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jankovic_4
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        // Close Button Function
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
