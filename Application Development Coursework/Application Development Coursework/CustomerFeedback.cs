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
    public partial class CustomerFeedback : Form
    {
        public CustomerFeedback()
        {
            InitializeComponent();
 
        }



        private void ContactNumber_Enter(object sender, EventArgs e)
        {
            if (txtBoxContactNumber.Text == "Optional")
            {
                txtBoxContactNumber.Text = "";
                txtBoxContactNumber.ForeColor = Color.Black;
            }
        }

        private void ContactNumber_Leave(object sender, EventArgs e)
        {
            if (txtBoxContactNumber.Text == "")
            {
                txtBoxContactNumber.Text = "Optional";
                txtBoxContactNumber.ForeColor = Color.Silver;
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "Optional")
            {
                txtBoxEmail.Text = "";
                txtBoxEmail.ForeColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "")
            {
                txtBoxEmail.Text = "Optional";
                txtBoxEmail.ForeColor = Color.Silver;
            }
        }

        private void CustomerName_Enter(object sender, EventArgs e)
        {
            if (txtBoxCustomerName.Text == "Optional")
            {
                txtBoxCustomerName.Text = "";
                txtBoxCustomerName.ForeColor = Color.Black;
            }
        }

        private void CustomerName_Leave(object sender, EventArgs e)
        {
            if (txtBoxCustomerName.Text == "")
            {
                txtBoxCustomerName.Text = "Optional";
                txtBoxCustomerName.ForeColor = Color.Silver;
            }
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtBoxCustomerName.Text = "Optional";
            txtBoxCustomerName.ForeColor = Color.Silver;
            txtBoxContactNumber.Text = "Optional";
            txtBoxContactNumber.ForeColor = Color.Silver;
            txtBoxEmail.Text = "Optional";
            txtBoxEmail.ForeColor = Color.Silver;
        }
    }
}
