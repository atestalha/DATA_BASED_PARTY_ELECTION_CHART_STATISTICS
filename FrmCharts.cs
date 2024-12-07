using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DATA_BASED_PARTY_ELECTION_CHART_STATISTICS
{
    public partial class FrmCharts : Form
    {
        public FrmCharts()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection("Data Source=ATES\\SQLEXPRESS;Initial Catalog=DBLOCALELECTIONS;Integrated Security=True");
        private void FrmCharts_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("SELECT TOWN_NAME FROM TBLTOWN", bgl);
            SqlDataReader dr= kmt.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            bgl.Close();


            bgl.Open();
            SqlCommand kmt2 = new SqlCommand("select SUM(A_PARTY),SUM(B_PARTY),SUM(C_PARTY),SUM(D_PARTY),SUM(E_PARTY) FROM TBLTOWN ", bgl);
            SqlDataReader dr2= kmt2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["PARTY"].Points.AddXY("A_PARTY", dr2[0]);
                chart1.Series["PARTY"].Points.AddXY("B_PARTY", dr2[1]);
                chart1.Series["PARTY"].Points.AddXY("C_PARTY", dr2[2]);
                chart1.Series["PARTY"].Points.AddXY("D_PARTY", dr2[3]);
                chart1.Series["PARTY"].Points.AddXY("E_PARTY", dr2[4]);
            }
            bgl.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("select *from TBLTOWN WHERE TOWN_NAME=@p1", bgl);
            kmt.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr= kmt.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                lblA.Text = dr[2].ToString();
                lblB.Text = dr[3].ToString();
                lblC.Text = dr[4].ToString();
                lblD.Text = dr[5].ToString();
                lblE.Text = dr[6].ToString();

            }
            bgl.Close(); 
        }
    }
}
