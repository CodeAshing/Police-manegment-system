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
    public partial class crC : UserControl
    {
        public string conn = "Data Source=DESKTOP-HMI8KPC\\SQL2019TEST;Initial Catalog=police station;Integrated Security=True";

        public crC()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void crC_Load(object sender, EventArgs e)
        {

        }
        public void create()
        {
            if (cricb.Text == "Still")
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into still(evidence,[under section],[police station],date,[criminal status],discription,name,age,address,number,cnic,[fir no],[case no],[disposal reason])values('" + evitb.Text + "','" + comboBox1.Text + "','" + pstb.Text + "','" + datb.Text + "','" + cricb.Text + "','" + distb.Text + "','" + namtb.Text + "','" + agtb.Text + "','" + addtb.Text + "','" + phtb.Text + "','" + cnic.Text + "','" + firtb.Text + "','" + castb.Text + "','" + disposaltb.Text + "')";

                    SqlCommand cam = new SqlCommand(q, con);
                    cam.ExecuteNonQuery();
                    MessageBox.Show("Your Record registered successfully ");
                }
            }
            else if (cricb.Text == "Bell")
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into bell(evidence,[under section],[police station],date,[criminal status],discription,name,age,address,number,cnic,[fir no],[case no],[disposal reason])values('" + evitb.Text + "','" + comboBox1.Text + "','" + pstb.Text + "','" + datb.Text + "','" + cricb.Text + "','" + distb.Text + "','" + namtb.Text + "','" + agtb.Text + "','" + addtb.Text + "','" + phtb.Text + "','" + cnic.Text + "','" + firtb.Text + "','" + castb.Text + "','" + disposaltb.Text + "')";
                    SqlCommand cam = new SqlCommand(q, con);
                    cam.ExecuteNonQuery();
                    MessageBox.Show("Your Record registered successfully ");
                }
            }
            else if(cricb.Text=="Disposal")
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into disposal(evidence,[under section],[police station],date,[criminal status],discription,name,age,address,number,cnic,[fir no],[case no],[disposal reason])values('" + evitb.Text + "','" + comboBox1.Text + "','" + pstb.Text + "','" + datb.Text + "','" + cricb.Text + "','" + distb.Text + "','" + namtb.Text + "','" + agtb.Text + "','" + addtb.Text + "','" + phtb.Text + "','" + cnic.Text + "','" + firtb.Text + "','" + castb.Text + "','" + disposaltb.Text + "')";
                    SqlCommand cam = new SqlCommand(q, con);
                    cam.ExecuteNonQuery();
                    MessageBox.Show("Your Record registered successfully");
                }
            }

            evitb.Text = "";
            comboBox1.Text = "";
            pstb.Text = "";
            cricb.Text = "";
            distb.Text = "";
            namtb.Text = "";
            agtb.Text = "";
            addtb.Text = "";
            phtb.Text = "";
            cnic.Text = "";
            firtb.Text = "";
            castb.Text = "";
            disposaltb.Text = "";

        

    }
        private void button5_Click(object sender, EventArgs e)
        {
            create();
        }
    }
}
