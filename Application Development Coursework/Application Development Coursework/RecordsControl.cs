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
    public partial class RecordsControl : System.Windows.Forms.UserControl
    {
        public RecordsControl()
        {
            InitializeComponent();
            BindReviewGrid();
        }
        private void BindReviewGrid()
        {
            RatingModel obj = new RatingModel();
            List<RatingModel> listRating = obj.List();
            DataTable dt = Utility.ConvertToDynamicDataTable(listRating);
            dataGvReports.DataSource = dt;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hell");
        }
    }
}
