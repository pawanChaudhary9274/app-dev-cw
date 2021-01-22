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
    public partial class AddCriteria : UserControl
    {
        public AddCriteria()
        {
            InitializeComponent();
            addCriteriaList();
        }
        
        public void addCriteriaList()
        {
            int locationY = 30;
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"Criteria.txt");
            while ((line = file.ReadLine()) != null)
            {
                string criteriaList = line.Substring(0, line.Length - 1);
                Label label = new Label();
                label.Text = criteriaList;
                label.Location = new Point(0, locationY);
                this.pnlCriteriaList.Controls.Add(label);
                locationY += 30;
            }

            file.Close();
        }
      
        private void btnAddCriteria_Click(object sender, EventArgs e) {
            CriteriaModel ctr_m = new CriteriaModel();
            string Criteria = txtBoxCriteriaName.Text;
            
            
        
            ctr_m.Save(Criteria);
            addCriteriaList();
            MessageBox.Show("Successfully Added");
        }
    }
}
