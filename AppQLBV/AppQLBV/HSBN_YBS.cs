using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace AppQLBV
{
    public partial class HSBN_YBS : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public HSBN_YBS()
        {
            InitializeComponent();
        }
        private void ClearSearchMABN()
        {
            txtMaBN.Text = "";
        }
        private void ClearSearchCMND()
        {
            txtCMND.Text = "";
        }

        private void HSBN_YBS_Load(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DNHLAN.UV_YBSXEMTHONGTINBN";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSBN.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void btnTim1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM DNHLAN.UV_YBSXEMTHONGTINBN WHERE MABN LIKE '" + txtMaBN.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSBN.DataSource = dt;
            ClearSearchMABN();
        }

        private void btnTim2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM DNHLAN.UV_YBSXEMTHONGTINBN WHERE CMND LIKE '" + txtCMND.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSBN.DataSource = dt;
            ClearSearchCMND();
        }
    }
}
