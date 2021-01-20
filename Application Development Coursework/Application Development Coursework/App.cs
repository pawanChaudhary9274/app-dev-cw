using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development_Coursework
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit ?", "Confirmation Dialog!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }
      

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out", "Log out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new AdminLogin().Show();
                this.Hide();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboardControl.BringToFront();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            recordsControl.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNewFeedback_Click(object sender, EventArgs e)
        {
            new CustomerFeedback().Show();
        }
    }
}

