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
    public partial class FIR : UserControl
    {
        public FIR()
        {
            InitializeComponent();

            slider.Height = fircb.Height;
            slider.Top = fircb.Top;
            firCU1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            slider.Height = firub.Height;
            slider.Top = firub.Top;
            firU11.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            slider.Height =fircb.Height;
            slider.Top = fircb.Top;
            firCU1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            slider.Height = firvb.Height;
            slider.Top = firvb.Top;
            firV1.BringToFront();
        }

        private void firCU1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
