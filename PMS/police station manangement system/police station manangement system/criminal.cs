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
    public partial class criminal : UserControl
    {
        public criminal()
        {
            InitializeComponent();

            slider.Height = crcb.Height;
            slider.Top = crcb.Top;
            crC1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            slider.Height = crcb.Height;
            slider.Top = crcb.Top;
            crC1.BringToFront();
        }

        private void crub_Click(object sender, EventArgs e)
        {
            slider.Height = crub.Height;
            slider.Top = crub.Top;
            crU1.BringToFront();
        }

        private void crvb_Click(object sender, EventArgs e)
        {
        }

        private void criminal_Load(object sender, EventArgs e)
        {

        }

        private void crvb_Click_1(object sender, EventArgs e)
        {

            slider.Height = crvb.Height;
            slider.Top = crvb.Top;
            crV1.BringToFront();
        }
    }
}
