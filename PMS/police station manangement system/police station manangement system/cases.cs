using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace police_station_manangement_system
{
    public partial class cases : UserControl
    {
        public cases()
        {
            InitializeComponent();

            slider.Height = ccb.Height;
            slider.Top = ccb.Top;
            cC1.BringToFront();
        }

        private void ccb_Click(object sender, EventArgs e)
        {
            slider.Height = ccb.Height;
            slider.Top = ccb.Top;
            cC1.BringToFront();

        }

        private void cub_Click(object sender, EventArgs e)
        {
            slider.Height = cub.Height;
            slider.Top = cub.Top;
            cU1.BringToFront();

        }

        private void cvb_Click(object sender, EventArgs e)
        {
            slider.Height = cvb.Height;
            slider.Top = cvb.Top;
            cV1.BringToFront();
        }
    }
}
