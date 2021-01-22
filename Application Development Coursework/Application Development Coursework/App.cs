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
            //addCriteriaList();
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

        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            addCriteria1.BringToFront();
            //criteriaAdd1.BringToFront();

        }
        /*
        public void addCriteriaList()
        {
            //int locationX = 34;
            int locationY = 10;
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"Criteria.txt");
            while ((line = file.ReadLine()) != null)
            {
                // Remove the extra ','
                string criteriaList = line.Substring(0, line.Length - 1);
               
                //ComboBox comboBox = new ComboBox();
                //comboBox.Name = comboName;
               // comboBox.Items.AddRange(new object[] { 1, 2, 3, 4 });
                //comboBox.Location = new Point(locationX, locationY);
                //this.Controls.Add(comboBox);
                //this.pnlCriteriaList.Controls.Add();
           

                Label label = new Label();
                label.Text = criteriaList;
                label.Location = new Point(0, locationY);
                //this.panCControls.Add(label);
                this.panCriteria.Controls.Add(label);


                locationY += 20;
            }

            file.Close();
        }
        */
    }
}

