using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development_Coursework
{
    public partial class DashboardControl : System.Windows.Forms.UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            SelectCriteria();
            BindReviewGrid();
            //BindChart();
        }

        
        private void BindReviewGrid()
        {
            RatingModel obj = new RatingModel();
            List<RatingModel> listRating = obj.List();
            DataTable dt = Utility.ConvertToDynamicDataTable(listRating);
            //dataGridView2.DataSource = dt;

            var chartData = from x in dt.AsEnumerable()
                            group x by x.Field<String>("Cleanliness") into y
                            select new
                            {
                                Food = y.Key,
                                Count = y.Count()
                            };
            var lstChart = chartData.ToList();
            var d = Utility.ConvertToDataTable(lstChart);
            BindChart(d);

        }
        private void BindChart(DataTable lst)
        {
            chrtReport.DataSource = lst;
            chrtReport.Name = "Service Rating";
            chrtReport.Series["Series1"].XValueMember = "Food";
            chrtReport.Series["Series1"].YValueMembers = "Count";
        }

        private string path = "Criteria.txt";
        public void SelectCriteria()
        {
            string[] selectList = Utility.ReadCriterias(path);
            foreach (string criteria in selectList)
            {
                cbCriteriaList.Items.Add(criteria);
            }
        }

        //public string selectedCriteria;
    }
}
