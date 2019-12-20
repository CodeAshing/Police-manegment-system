using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace police_station_manangement_system
{
    public partial class firCU : UserControl
    {
        public firCU()
        {
            InitializeComponent();
        }

        public string conn = "Data Source=DESKTOP-HMI8KPC\\SQL2019TEST;Initial Catalog=police station;Integrated Security=True";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void firCU_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }
        

        private void evitb_TextChanged(object sender, EventArgs e)
        {

        }

        private void undercb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (undercb.Text =="Murder")
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into murder(evidence,station,date,vitness,discription,name,age,address,phone,cnic,accuse,[accuse ph],[under section])values('" + evitb.Text + "','" + pstb.Text + "','" + datb.Text + "','" + vitb.Text + "','" + distb.Text + "','" + nametb.Text + "','" + agetb.Text + "','" + addtb.Text + "','" + phtb.Text + "','" + cnictb.Text + "','" + acctb.Text + "','" + accphtb.Text + "','" + undercb.Text + "')";

                    SqlCommand cam = new SqlCommand(q, con);    
                    cam.ExecuteNonQuery();
                    MessageBox.Show("Your FIR registered successfully ");
                }
            }
            else if (undercb.Text == "Robery")
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into robery(evidence,station,date,vitness,discription,name,age,address,phone,cnic,accuse,[accuse ph],[under section])values('" + evitb.Text + "','" + pstb.Text + "','" + datb.Text + "','" + vitb.Text + "','" + distb.Text + "','" + nametb.Text + "','" + agetb.Text + "','" + addtb.Text + "','" + phtb.Text + "','" + cnictb.Text + "','" + acctb.Text + "','" + accphtb.Text + "','" +undercb.Text + "')";
                    SqlCommand cam = new SqlCommand(q, con);
                    cam.ExecuteNonQuery();
                    MessageBox.Show("Your FIR registered successfully ");
                }
            }
            else
            {

                SqlConnection con = new SqlConnection(conn);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into other(evidence,station,date,vitness,discription,name,age,address,phone,cnic,accuse,[accuse ph],[under section])values('" + evitb.Text + "','" + pstb.Text + "','" + datb.Text + "','" + vitb.Text + "','" + distb.Text + "','" + nametb.Text + "','" + agetb.Text + "','" + addtb.Text + "','" + phtb.Text  + "','" + cnictb.Text + "','" + acctb.Text + "','" + accphtb.Text + "','" + undercb.Text + "')";
                    SqlCommand cam = new SqlCommand(q, con);
                    cam.ExecuteNonQuery();
                    MessageBox.Show("Your FIR registered successfully ");
                }
            }

            evitb.Text = "";
            undercb.Text = "";
            pstb.Text = "";
            vitb.Text = "";
            distb.Text = "";
            nametb.Text = "";
            agetb.Text = "";
            addtb.Text = "";
            phtb.Text = "";
            cnictb.Text = "";
            acctb.Text = "";
            accphtb.Text = "";
        }
    }
}
