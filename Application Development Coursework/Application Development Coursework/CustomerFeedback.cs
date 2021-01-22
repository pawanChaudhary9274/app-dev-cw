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
            addCriteriaRating();
 
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

        public void addCriteriaRating()
        {
            //3, 12
            //237, 14

            int locationX = 237;
            int locationY = 3;
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"Criteria.txt");
            while ((line = file.ReadLine()) != null)
            {
                // Remove the extra ','
                string comboName = line.Substring(0, line.Length - 1);

                ComboBox comboBox = new ComboBox();
                comboBox.Name = comboName;
                comboBox.Items.AddRange(new object[] { "Excellent", "Good", "Average", "Dissatisfied" });
                comboBox.Location = new Point(locationX, locationY);
                //this.Controls.Add(comboBox);
                this.pnlReview.Controls.Add(comboBox);

                Label label = new Label();
                label.Text = comboName;
                label.Location = new Point(0, locationY);
                //this.Controls.Add(label);
                this.pnlReview.Controls.Add(label);


                locationY += 50;
            }

            file.Close();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            RatingModel r = new RatingModel();
            r.Name = txtBoxCustomerName.Text;
            r.Email = txtBoxEmail.Text;
            r.Phone = txtBoxContactNumber.Text;
            var time = DateTime.Now;
            r.RatedTime = time;
            r.criterias = new Dictionary<string, string>();
            foreach (Control c in this.pnlReview.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox cb = c as ComboBox;
                    ComboBox cdv = (ComboBox)this.pnlReview.Controls.Find(cb.Name, true)[0];

                    r.criterias.Add(cdv.Name, cdv.Text);
                }
            }
            /*
            if (txtBoxCustomerName.Text == "Optional")
            {
                txtBoxCustomerName.Text = "";
            }
            if (txtBoxEmail.Text == "Optional")
            {
                txtBoxEmail.Text = "";
            }
            if (txtBoxContactNumber.Text == "Optional")
            {
                txtBoxContactNumber.Text = "";
            }
            */
            string flag = r.SaveReview(r);
            if (flag == "success")
            {

                MessageBox.Show("Thank you!!! For your feedbacks");
            }

        }
    }
}
