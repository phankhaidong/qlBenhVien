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
    public partial class HSBA_CSYT : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public HSBA_CSYT()
        {
            InitializeComponent();
        }
        private void ClearSearch()
        {
            txtTimHSBA.Text = "";
        }
        private void ClearThongTin()
        {
            txtMaHSBA.Text = "";
            txtMaBN.Text = "";
            txtChanDoan.Text = "";
            txtMaBS.Text = "";
            txtMaKhoa.Text = "";
            txtMaCSYT.Text = "";
            txtKetLuan.Text = "";
        }
        private void HSBA_CSYT_Load(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DNHLAN.UV_THONGTINHSBA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void btnThemHSBA_Click(object sender, EventArgs e)
        {
            try
            {
                //con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO DNHLAN.UV_THONGTINHSBA(MAHSBA, MABN, NGAY, CHUANDOAN, MABS, MAKHOA, MACSYT, KETLUAN) VALUES('" + txtMaHSBA.Text + "', '" + txtMaBN.Text + "', TO_DATE(SUBSTR('" + dtpNgayHSBA.Value.Date + "',1,15) ,'MM/DD/YYYY HH:MI:SS'), '" + txtChanDoan.Text + "', '" + txtMaBS.Text + "', '" + txtMaKhoa.Text + "', '" + txtMaCSYT.Text + "', '" + txtKetLuan.Text + "')";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm hồ sơ bệnh án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearThongTin();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Thêm hồ sơ bệnh án không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ClearThongTin();
            }
        }

        private void dgDSHSBA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgDSHSBA.Rows[dgDSHSBA.CurrentCell.RowIndex];
            txtMaHSBA.Text = row.Cells[0].Value.ToString();
            txtMaBN.Text = row.Cells[1].Value.ToString();
            dtpNgayHSBA.Text = row.Cells[2].Value.ToString();
            txtChanDoan.Text = row.Cells[3].Value.ToString();
            txtMaBS.Text = row.Cells[4].Value.ToString();
            txtMaKhoa.Text = row.Cells[5].Value.ToString();
            txtMaCSYT.Text = row.Cells[6].Value.ToString();
            txtKetLuan.Text = row.Cells[7].Value.ToString();
        }

        private void btnXoaHSBA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dgDSHSBA.CurrentCell.RowIndex;
                dgDSHSBA.Rows.RemoveAt(index);
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM DNHLAN.UV_THONGTINHSBA WHERE MAHSBA = '" + txtMaHSBA.Text + "'";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa hồ sơ bệnh án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearThongTin();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM DNHLAN.UV_THONGTINHSBA WHERE MAHSBA LIKE '" + txtTimHSBA.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA.DataSource = dt;
            ClearSearch();
        }
    }
}
