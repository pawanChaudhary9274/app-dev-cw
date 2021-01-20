using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Application_Development_Coursework
{
    public partial class SplashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            loadingScreen.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingScreen.Value += 1;
            loadingScreen.Text = loadingScreen.Value.ToString() + "%";
            if (loadingScreen.Value == 100)
            {
                timer1.Enabled = false;
                new AdminLogin().Show();
                this.Hide();

            }
        }
    }
}
