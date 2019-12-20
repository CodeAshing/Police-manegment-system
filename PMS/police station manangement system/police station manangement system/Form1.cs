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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (passb.Text == "sir")
            {

                dashboard d = new dashboard();
                d.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("check your passsword");
            }
        }
    }
}
