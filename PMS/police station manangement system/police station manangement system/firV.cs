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
    public partial class firV : UserControl
    {
        public string conn = "Data Source=DESKTOP-HMI8KPC\\SQL2019TEST;Initial Catalog=police station;Integrated Security=True";

        public firV()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            if (table.Text == "All")
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "(select * from murder union all select * from other) union all select * from robery order by Charid";
                    SqlDataAdapter adp = new SqlDataAdapter(q, con);
                    DataTable tab = new DataTable();
                   adp.Fill(tab);
                    dataGridView1.DataSource = tab;
                }
            }
            else
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "select * from " + table.Text;
                    SqlDataAdapter adp = new SqlDataAdapter(q, con);
                    DataTable tab = new DataTable();
                    adp.Fill(tab);
                    dataGridView1.DataSource = tab;
                }
            }
        }
    }
}
