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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            txtBoxAdminPassword.PasswordChar = '*';

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                Application.Exit();
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxAdminName.Text == "admin" && txtBoxAdminPassword.Text == "admin")
            {
                new App().Show();
                this.Hide();
            }
            else if (txtBoxAdminName.Text == "" || txtBoxAdminPassword.Text == "" || txtBoxAdminName.Text == "" && txtBoxAdminPassword.Text == "")
            {
                MessageBox.Show("Please Dont Leave Fields Empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Check Credential", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCustomerReview_Click(object sender, EventArgs e)
        {
            new CustomerFeedback().Show();
        }
    }
}
