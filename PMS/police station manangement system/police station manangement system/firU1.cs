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
    public partial class firU1 : UserControl
    {
        public string conn = "Data Source=DESKTOP-HMI8KPC\\SQL2019TEST;Initial Catalog=police station;Integrated Security=True";

        public firU1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            if (idd.Text.Substring(0, 1) == undercb.Text.Substring(0, 1))
            {
                if (idd.Text.Substring(0, 1) == "M")
                {

                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "update murder set evidence='" + evitb.Text + "',station='" + pstb.Text + "',vitness='" + vitb.Text + "',discription='" + distb.Text + "',name='" + nametb.Text + "',age='" + agetb.Text + "',address='" + addtb.Text + "',phone='" + phtb.Text + "',cnic='" + cnictb.Text + "',accuse='" + acctb.Text + "',[accuse ph]='" + accphtb.Text + "',[under section]='" + undercb.Text + "' where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record successfully Updated");
                    }
                }
                else if (idd.Text.Substring(0, 1) == "R")
                {


                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "update robery set evidence='" + evitb.Text + "',station='" + pstb.Text + "',vitness='" + vitb.Text + "',discription='" + distb.Text + "',name='" + nametb.Text + "',age='" + agetb.Text + "',address='" + addtb.Text + "',phone='" + phtb.Text + "',cnic='" + cnictb.Text + "',accuse='" + acctb.Text + "',[accuse ph]='" + accphtb.Text + "',[under section]='" + undercb.Text + "' where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record successfully Updated");
                    }
                }
                else
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "update other set evidence='" + evitb.Text + "',station='" + pstb.Text + "',vitness='" + vitb.Text + "',discription='" + distb.Text + "',name='" + nametb.Text + "',age='" + agetb.Text + "',address='" + addtb.Text + "',phone='" + phtb.Text + "',cnic='" + cnictb.Text + "',accuse='" + acctb.Text + "',[accuse ph]='" + accphtb.Text + "',[under section]='" + undercb.Text + "' where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your Record successfully Updated");
                    }

                }
            }
            else
            {
                firCU fir_obj = new firCU();
                if (undercb.Text == "Murder")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "insert into murder(evidence,station,vitness,discription,name,age,address,phone,cnic,accuse,[accuse ph],[under section])values('" + evitb.Text + "','" + pstb.Text + "','" + vitb.Text + "','" + distb.Text + "','" + nametb.Text + "','" + agetb.Text + "','" + addtb.Text + "','" + phtb.Text + "','" + cnictb.Text + "','" + acctb.Text + "','" + accphtb.Text + "','" + undercb.Text + "')";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your FIR registered successfully ");
                    }
                }
                else if (undercb.Text == "Robery")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "insert into robery(evidence,station,vitness,discription,name,age,address,phone,cnic,accuse,[accuse ph],[under section])values('" + evitb.Text + "','" + pstb.Text + "','" + vitb.Text + "','" + distb.Text + "','" + nametb.Text + "','" + agetb.Text + "','" + addtb.Text + "','" + phtb.Text + "','" + cnictb.Text + "','" + acctb.Text + "','" + accphtb.Text + "','" + undercb.Text + "')";
                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your FIR registered successfully");
                    }
                }
                else
                {
                    
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "insert into other(evidence,station,vitness,discription,name,age,address,phone,cnic,accuse,[accuse ph],[under section])values('" + evitb.Text + "','" + pstb.Text + "','" + vitb.Text + "','" + distb.Text + "','" + nametb.Text + "','" + agetb.Text + "','" + addtb.Text + "','" + phtb.Text + "','" + cnictb.Text + "','" + acctb.Text + "','" + accphtb.Text + "','" + undercb.Text + "')";
                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                        MessageBox.Show("Your FIR registered successfully  ");
                    }
                }
                if (idd.Text.Substring(0, 1) == "M")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "delete from murder where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();
                    }
                }
                else if (idd.Text.Substring(0, 1) == "R")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "delete from robery where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();

                    }
                }
                else if (idd.Text.Substring(0, 1) == "O")
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "delete from other where Charid='" + idd.Text + "'";

                        SqlCommand cam = new SqlCommand(q, con);
                        cam.ExecuteNonQuery();

                    }


                }

            }
            idd.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {

                int count = 0;
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                if( idd.Text.Substring(0, 1) == "M")
                {


                string select = "Select * from murder where Charid=@id";
                SqlCommand cmd = new SqlCommand(select, con);
                cmd.Parameters.AddWithValue("@id", idd.Text);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    {
                        count++;
                        evitb.Text = dr.GetValue(2).ToString();
                        undercb.Text = dr.GetValue(14).ToString();
                        pstb.Text = dr.GetValue(3).ToString();
                        vitb.Text = dr.GetValue(5).ToString();
                        distb.Text = dr.GetValue(6).ToString();
                        nametb.Text = dr.GetValue(7).ToString();
                        agetb.Text = dr.GetValue(8).ToString();
                        addtb.Text = dr.GetValue(9).ToString();
                        phtb.Text = dr.GetValue(10).ToString();
                        cnictb.Text = dr.GetValue(11).ToString();
                        acctb.Text = dr.GetValue(12).ToString();
                        accphtb.Text = dr.GetValue(13).ToString();

                    }
                    if (count != 1)
                    {

                        MessageBox.Show("your id does not match");

                    }
                    count--;
                }
                else if (idd.Text.Substring(0, 1) == "R")
                {

                    string select = "Select * from robery where Charid=@id";
                    SqlCommand cmd = new SqlCommand(select, con);
                    cmd.Parameters.AddWithValue("@id", idd.Text);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        count++;
                    evitb.Text = dr.GetValue(2).ToString();
                    undercb.Text = dr.GetValue(14).ToString();
                    pstb.Text = dr.GetValue(3).ToString();
                    vitb.Text = dr.GetValue(5).ToString();
                    distb.Text = dr.GetValue(6).ToString();
                    nametb.Text = dr.GetValue(7).ToString();
                    agetb.Text = dr.GetValue(8).ToString();
                    addtb.Text = dr.GetValue(9).ToString();
                    phtb.Text = dr.GetValue(10).ToString();
                    cnictb.Text = dr.GetValue(11).ToString();
                    acctb.Text = dr.GetValue(12).ToString();
                    accphtb.Text = dr.GetValue(13).ToString();
                }


                    if (count != 1)
                    {

                        MessageBox.Show("your id does not match");

                    }
                    count--;
                }
                else
                {

                    string select = "Select * from other where Charid=@id";
                    SqlCommand cmd = new SqlCommand(select, con);
                    cmd.Parameters.AddWithValue("@id", idd.Text);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        count++;
                    evitb.Text = dr.GetValue(2).ToString();
                    undercb.Text = dr.GetValue(14).ToString();
                    pstb.Text = dr.GetValue(3).ToString();
                    vitb.Text = dr.GetValue(5).ToString();
                    distb.Text = dr.GetValue(6).ToString();
                    nametb.Text = dr.GetValue(7).ToString();
                    agetb.Text = dr.GetValue(8).ToString();
                    addtb.Text = dr.GetValue(9).ToString();
                    phtb.Text = dr.GetValue(10).ToString();
                    cnictb.Text = dr.GetValue(11).ToString();
                    acctb.Text = dr.GetValue(12).ToString();
                    accphtb.Text = dr.GetValue(13).ToString();
                }
                    if (count != 1)
                    {

                        MessageBox.Show("your id does not match");

                    }
                    count--;
                }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
