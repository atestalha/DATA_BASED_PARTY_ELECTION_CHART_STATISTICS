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
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=ATES\\SQLEXPRESS;Initial Catalog=DBLOCALELECTIONS;Integrated Security=True");
        private void btnLog_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("insert into TBLTOWN(TOWN_NAME,A_PARTY,B_PARTY,C_PARTY,D_PARTY,E_PARTY) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)",bgl);
            kmt.Parameters.AddWithValue("@p1",txtName.Text);
            kmt.Parameters.AddWithValue("@p2", txtA.Text);
            kmt.Parameters.AddWithValue("@p3", txtB.Text);
            kmt.Parameters.AddWithValue("@p4", txtC.Text);
            kmt.Parameters.AddWithValue("@p5", txtD.Text);
            kmt.Parameters.AddWithValue("@p6", txtE.Text);
            kmt.ExecuteReader();
            bgl.Close();
            MessageBox.Show("YOUR TRANSACTION WAS COMPLETED SUCCESSFULLY");
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            FrmCharts fr=new FrmCharts();
            fr.Show();
        }

        private void btnExıt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
