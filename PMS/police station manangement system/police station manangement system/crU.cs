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
    
    public partial class crU : UserControl
    {
        public string conn = "Data Source=DESKTOP-HMI8KPC\\SQL2019TEST;Initial Catalog=police station;Integrated Security=True";

        public crU()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int count = 0;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            if (idd.Text.Substring(0, 1) == "S")
            {

                string select = "Select * from still where Charid=@id";
                SqlCommand cmd = new SqlCommand(select, con);
                cmd.Parameters.AddWithValue("@id", idd.Text);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count++;
                    evitb.Text = dr.GetValue(2).ToString();
                    comboBox1.Text = dr.GetValue(3).ToString();
                    pstb.Text = dr.GetValue(4).ToString();
                    cricb.Text = dr.GetValue(6).ToString();
                    distb.Text = dr.GetValue(7).ToString();
                    namtb.Text = dr.GetValue(8).ToString();
                    agtb.Text = dr.GetValue(9).ToString();
                    addtb.Text = dr.GetValue(10).ToString();
                    phtb.Text = dr.GetValue(11).ToString();
                    cnic.Text = dr.GetValue(12).ToString();
                    firtb.Text = dr.GetValue(13).ToString();
                    castb.Text = dr.GetValue(14).ToString();
                    disposaltb.Text = dr.GetValue(15).ToString();


                }
                if (count != 1)
                {

                    MessageBox.Show("your id does not match");

                }
                count--;
            }
            else if(idd.Text.Substring(0, 1) == "B")
            {

                string select = "Select * from bell where Charid=@id";
                SqlCommand cmd = new SqlCommand(select, con);
                cmd.Parameters.AddWithValue("@id", idd.Text);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count++;
                    evitb.Text = dr.GetValue(2).ToString();
                    comboBox1.Text = dr.GetValue(3).ToString();
                    pstb.Text = dr.GetValue(4).ToString();
                    cricb.Text = dr.GetValue(6).ToString();
                    distb.Text = dr.GetValue(7).ToString();
                    namtb.Text = dr.GetValue(8).ToString();
                    agtb.Text = dr.GetValue(9).ToString();
                    addtb.Text = dr.GetValue(10).ToString();
                    phtb.Text = dr.GetValue(11).ToString();
                    cnic.Text = dr.GetValue(12).ToString();
                    firtb.Text = dr.GetValue(13).ToString();
                    castb.Text = dr.GetValue(14).ToString();
                    disposaltb.Text = dr.GetValue(15).ToString();

                }
                if (count != 1)
                {

                    MessageBox.Show("your id does not match");

                }
                count--;
            } else 
            {

                string select = "Select * from disposal where Charid=@id";
                SqlCommand cmd = new SqlCommand(select, con);
                cmd.Parameters.AddWithValue("@id", idd.Text);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count++;
                    evitb.Text = dr.GetValue(2).ToString();
                    comboBox1.Text = dr.GetValue(3).ToString();
                    pstb.Text = dr.GetValue(4).ToString();
                    cricb.Text = dr.GetValue(6).ToString();
                    distb.Text = dr.GetValue(7).ToString();
                    namtb.Text = dr.GetValue(8).ToString();
                    agtb.Text = dr.GetValue(9).ToString();
                    addtb.Text = dr.GetValue(10).ToString();
                    phtb.Text = dr.GetValue(11).ToString();
                    cnic.Text = dr.GetValue(12).ToString();
                    firtb.Text = dr.GetValue(13).ToString();
                    castb.Text = dr.GetValue(14).ToString();
                    disposaltb.Text = dr.GetValue(15).ToString();

                }
                if (count != 1)
                {

                    MessageBox.Show("your id does not match");

                }
                count--;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            if (idd.Text.Substring(0, 1) == cricb.Text.Substring(0, 1))
            {

                if (idd.Text.Substring(0, 1) == "S")
                {

                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "update still set [under section]='" + comboBox1.Text + "',evidence='" + evitb.Text + "',[police station]='" + pstb.Text + "',discription='" + distb.Text + "',name='" + namtb.Text + "',age='" + agtb.Text + "',address='" + addtb.Text + "',number='" + phtb.Text + "',cnic='" + cnic.Text + "',[case no]='" + castb.Text + "',[fir no]='" + firtb.Text + "',[disposal reason]='" + disposaltb.Text + "' where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record successfully Updated");
                    }
                }
                else if (idd.Text.Substring(0, 1) == "D")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "update disposal set [under section]='" + comboBox1.Text + "',evidence='" + evitb.Text + "',[police station]='" + pstb.Text + "',discription='" + distb.Text + "',name='" + namtb.Text + "',age='" + agtb.Text + "',address='" + addtb.Text + "',number='" + phtb.Text + "',cnic='" + cnic.Text + "',[case no]='" + castb.Text + "',[fir no]='" + firtb.Text + "',[disposal reason]='" + disposaltb.Text + "' where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record successfully Updated");
                    }
                }
                else if (idd.Text.Substring(0, 1) == "B")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "update bell set [under section]='" + comboBox1.Text + "',evidence='" + evitb.Text + "',[police station]='" + pstb.Text + "',discription='" + distb.Text + "',name='" + namtb.Text + "',age='" + agtb.Text + "',address='" + addtb.Text + "',number='" + phtb.Text + "',cnic='" + cnic.Text + "',[case no]='" + castb.Text + "',[fir no]='" + firtb.Text + "',[disposal reason]='" + disposaltb.Text + "' where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record successfully Updated");
                    }


                }


            }
            else if (idd.Text.Substring(0, 1) != cricb.Text.Substring(0,1))
            {
                crC crc_obj = new crC();
                if (cricb.Text == "Still")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "insert into still(evidence,[under section],[police station],[criminal status],discription,name,age,address,number,cnic,[fir no],[case no],[disposal reason])values('" + evitb.Text + "','" + comboBox1.Text + "','" + pstb.Text + "','" + cricb.Text + "','" + distb.Text + "','" + namtb.Text + "','" + agtb.Text + "','" + addtb.Text + "','" + phtb.Text + "','" + cnic.Text + "','" + firtb.Text + "','" + castb.Text + "','" + disposaltb.Text + "')";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record registered successfully ");
                    }
                }
                else if (cricb.Text == "Bell")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "insert into bell(evidence,[under section],[police station],[criminal status],discription,name,age,address,number,cnic,[fir no],[case no],[disposal reason])values('" + evitb.Text + "','" + comboBox1.Text + "','" + pstb.Text + "','" + cricb.Text + "','" + distb.Text + "','" + namtb.Text + "','" + agtb.Text + "','" + addtb.Text + "','" + phtb.Text + "','" + cnic.Text + "','" + firtb.Text + "','" + castb.Text + "','" + disposaltb.Text + "')";
                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record registered successfully ");
                    }
                }
                else if (cricb.Text == "Disposal")
                {
                    
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "insert into disposal(evidence,[under section],[police station],[criminal status],discription,name,age,address,number,cnic,[fir no],[case no],[disposal reason])values('" + evitb.Text + "','" + comboBox1.Text + "','" + pstb.Text + "','" + cricb.Text + "','" + distb.Text + "','" + namtb.Text + "','" + agtb.Text + "','" + addtb.Text + "','" + phtb.Text + "','" + cnic.Text + "','" + firtb.Text + "','" + castb.Text + "','" + disposaltb.Text + "')";
                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record registered successfully ");
                    }
                }


                if (idd.Text.Substring(0, 1) == "S")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "delete from still where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                    }
                }
                else if (idd.Text.Substring(0, 1) == "D")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "delete from disposal where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();

                    }
                }
                else if (idd.Text.Substring(0, 1) == "B")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "delete from bell where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();

                    }


                }



            }
            
            remove_cr();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        public void remove_cr() 
        {

            idd.Text = "";
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
    }
}
