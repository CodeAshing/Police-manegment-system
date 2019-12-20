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
    public partial class cU : UserControl
    {
        public string conn = "Data Source=DESKTOP-HMI8KPC\\SQL2019TEST;Initial Catalog=police station;Integrated Security=True";

        public cU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int count = 0;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            if (idd.Text.Substring(0,1) == "S")
            {

                string select = "Select * from solved where Charid=@id";
                SqlCommand cmd = new SqlCommand(select, con);
                cmd.Parameters.AddWithValue("@id", idd.Text);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count++;
                    undercb.Text = dr.GetValue(2).ToString();
                    chatb.Text = dr.GetValue(3).ToString();
                    politb.Text = dr.GetValue(4).ToString();
                    courtb.Text = dr.GetValue(6).ToString();
                    distb.Text = dr.GetValue(7).ToString();
                    nametb.Text = dr.GetValue(8).ToString();
                    agetb.Text = dr.GetValue(9).ToString();
                    addtb.Text = dr.GetValue(10).ToString();
                    photb.Text = dr.GetValue(11).ToString();
                    cnictb.Text = dr.GetValue(12).ToString();
                    firtb.Text = dr.GetValue(15).ToString();
                    casetb.Text = dr.GetValue(14).ToString();
                    againtb.Text = dr.GetValue(13).ToString();


                }
                if (count != 1)
                {

                    MessageBox.Show("your id does not match");

                }
                count--;
            }
            else
            {

                string select = "Select * from unsolved where Charid=@id";
                SqlCommand cmd = new SqlCommand(select, con);
                cmd.Parameters.AddWithValue("@id", idd.Text);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count++;
                    undercb.Text = dr.GetValue(2).ToString();
                    chatb.Text = dr.GetValue(3).ToString();
                    politb.Text = dr.GetValue(4).ToString();
                    courtb.Text = dr.GetValue(6).ToString();
                    distb.Text = dr.GetValue(7).ToString();
                    nametb.Text = dr.GetValue(8).ToString();
                    agetb.Text = dr.GetValue(9).ToString();
                    addtb.Text = dr.GetValue(10).ToString();
                    photb.Text = dr.GetValue(11).ToString();
                    cnictb.Text = dr.GetValue(12).ToString();
                    firtb.Text = dr.GetValue(15).ToString();
                    casetb.Text = dr.GetValue(14).ToString();
                    againtb.Text = dr.GetValue(13).ToString();

                }
                if (count != 1)
                {

                    MessageBox.Show("your id does not match");

                }
                count--;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            if (idd.Text.Substring(0, 1) == casetb.Text.Substring(0, 1))
            {
                if (idd.Text.Substring(0, 1) == "S")
                {

                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "update solved set [under section]='" + undercb.Text + "',challan='" + chatb.Text + "',[police station]='" + politb.Text + "',discription='" + distb.Text + "',name='" + nametb.Text + "',age='" + agetb.Text + "',address='" + addtb.Text + "',number='" + photb.Text + "',cnic='" + cnictb.Text + "',[case status]='" + casetb.Text + "',[fir no]='" + firtb.Text + "',against='" + againtb.Text + "' where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record successfully Updated");
                    }
                }
                else
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "update unsolved set [under section]='" + undercb.Text + "',challan='" + chatb.Text + "',[police station]='" + politb.Text + "',discription='" + distb.Text + "',name='" + nametb.Text + "',age='" + agetb.Text + "',address='" + addtb.Text + "',number='" + photb.Text + "',cnic='" + cnictb.Text + "',[case status]='" + casetb.Text + "',[fir no]='" + firtb.Text + "',against='" + againtb.Text + "' where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record successfully Updated");
                    }

                }

                idd.Text = "";
                undercb.Text = "";
                chatb.Text = "";
                politb.Text = "";
                courtb.Text = "";
                distb.Text = "";
                nametb.Text = "";
                agetb.Text = "";
                addtb.Text = "";
                photb.Text = "";
                cnictb.Text = "";
                firtb.Text = "";
                casetb.Text = "";
                againtb.Text = "";

            }
            else
            {
                cC cc_obj = new cC();
                if (casetb.Text == "Solved")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "insert into solved([under section],challan,[police station],court,discription,name,age,address,number,cnic,against,[case status],[fir no])values('" + undercb.Text + "','" + chatb.Text + "','" + politb.Text + "','" + courtb.Text + "','" + distb.Text + "','" + nametb.Text + "','" + agetb.Text + "','" + addtb.Text + "','" + photb.Text + "','" + cnictb.Text + "','" + againtb.Text + "','" + casetb.Text + "','" + firtb.Text + "')";
                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record registered successfully ");
                    }
                }
                else
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "insert into unsolved([under section],challan,[police station],court,discription,name,age,address,number,cnic,against,[case status],[fir no])values('" + undercb.Text + "','" + chatb.Text + "','" + politb.Text + "','" + courtb.Text + "','" + distb.Text + "','" + nametb.Text + "','" + agetb.Text + "','" + addtb.Text + "','" + photb.Text + "','" + cnictb.Text + "','" + againtb.Text + "','" + casetb.Text + "','" + firtb.Text + "')";
                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record registered successfully");
                    }
                }
                if (idd.Text.Substring(0, 1) == "U")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "delete from unsolved where CHarid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                    }
                }
                else if (idd.Text.Substring(0, 1) == "S")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "delete from solved where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();

                    }
                }


                idd.Text = "";
                undercb.Text = "";
                chatb.Text = "";
                politb.Text = "";
                courtb.Text = "";
                distb.Text = "";
                nametb.Text = "";
                agetb.Text = "";
                addtb.Text = "";
                photb.Text = "";
                cnictb.Text = "";
                firtb.Text = "";
                casetb.Text = "";
                againtb.Text = "";
            }

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
