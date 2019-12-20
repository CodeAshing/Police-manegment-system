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
    public partial class cC : UserControl
    {

        public string conn = "Data Source=DESKTOP-HMI8KPC\\SQL2019TEST;Initial Catalog=police station;Integrated Security=True";

        public cC()
        {
            InitializeComponent();
        }

        private void cC_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (casetb.Text =="Solved")
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into solved([under section],challan,[police station],date,court,discription,name,age,address,number,cnic,against,[case status],[fir no])values('" + undercb.Text + "','" + chatb.Text + "','" + politb.Text + "','" + datb.Text + "','" + coutb.Text + "','" + distb.Text + "','" + namtb.Text + "','" + agetb.Text + "','" + addtb.Text + "','" + photb.Text + "','" + cnictb.Text + "','" + againtb.Text + "','" + casetb.Text + "','" + firtb.Text + "')";
                    SqlCommand cam = new SqlCommand(q, con);
                    cam.ExecuteNonQuery();
                    MessageBox.Show("Your Record registered successfully ");
                }
            }else
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into unsolved([under section],challan,[police station],date,court,discription,name,age,address,number,cnic,against,[case status],[fir no])values('" + undercb.Text + "','" + chatb.Text + "','" + politb.Text + "','" + datb.Text + "','" + coutb.Text + "','" + distb.Text + "','" + namtb.Text + "','" + agetb.Text + "','" + addtb.Text + "','" + photb.Text + "','" + cnictb.Text + "','" + againtb.Text + "','" + casetb.Text + "','" + firtb.Text + "')";
                    SqlCommand cam = new SqlCommand(q, con);
                    cam.ExecuteNonQuery();
                    MessageBox.Show("Your Record registered successfully ");
                }
            }

            undercb.Text = "";
            chatb.Text = "";
            politb.Text = "";
            coutb.Text = "";
            distb.Text = "";
            namtb.Text = "";
            agetb.Text = "";
            addtb.Text = "";
            photb.Text = "";
            cnictb.Text = "";
            firtb.Text = "";
            casetb.Text = "";
            againtb.Text = "";

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
