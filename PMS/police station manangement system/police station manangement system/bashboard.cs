using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace police_station_manangement_system
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            slider.Width = BF.Width;
            slider.Location = BF.Location;
            fir1.BringToFront();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slider.Width = BF.Width;
            slider.Location = BF.Location;
            fir1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            slider.Width = CB.Width;
            slider.Location = CB.Location;
            criminal1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            slider.Width = CaB.Width;
            slider.Location= CaB.Location;
            cases1.BringToFront();
        }

        private void slider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cases1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void staff1_Load(object sender, EventArgs e)
        {

        }
    }
}
