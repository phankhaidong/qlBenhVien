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
    public partial class HSBA_HSBADV_YBS : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public HSBA_HSBADV_YBS()
        {
            InitializeComponent();
        }
        private void ClearSearch()
        {
            txtTimMaHSBA.Text = "";
        }

        private void HSBA_HSBADV_YBS_Load(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DNHLAN.UV_YBSXEMTHONGTINHSBA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM DNHLAN.UV_YBSXEMTHONGTINHSBA WHERE MAHSBA LIKE '" + txtTimMaHSBA.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA.DataSource = dt;

            cmd.CommandText = "SELECT * FROM DNHLAN.UV_YBSXEMKQHSBA_DV WHERE MAHSBA LIKE '" + txtTimMaHSBA.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr1 = cmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);
            dataGridView1.DataSource = dt1;
            ClearSearch();
        }
    }
}
