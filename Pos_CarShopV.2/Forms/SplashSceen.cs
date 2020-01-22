using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_CarShopV._2
{
    public partial class SplashSceen : Form
    {
        public SplashSceen()
        {
            InitializeComponent();
        }

        private void SplashSceenTimer_Tick(object sender, EventArgs e)
        {
            panel2.Width += 15;
            if (panel2.Width >= 700)
            {
                SplashSceenTimer.Stop();
                FormMain mainform = new FormMain();
                mainform.Show();
                this.Hide();
            }
        }
    }
}
