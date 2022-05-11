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
    public partial class HSBADV_CSYT : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public HSBADV_CSYT()
        {
            InitializeComponent();
        }
        private void ClearSearch()
        {
            txtTimHSBADV.Text = "";
        }
        private void ClearThongTin()
        {
            txtMaHSBADV.Text = "";
            txtMaDV.Text = "";
            txtMaKTV.Text = "";
            txtKetQua.Text = "";
        }
        private void HSBADV_CSYT_Load(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DNHLAN.UV_THONGTINHSBA_DV";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA_DV.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO DNHLAN.UV_THONGTINHSBA_DV(MAHSBA, MADV, NGAY, MAKTV, KETQUA) VALUES('" + txtMaHSBADV.Text + "', '" + txtMaDV.Text + "', TO_DATE(SUBSTR('" + dtpNgay.Value.Date + "',1,15) ,'MM/DD/YYYY HH:MI:SS'), '" + txtMaKTV.Text + "', '" + txtKetQua.Text + "')";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dịch vụ của hồ sơ bệnh án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearThongTin();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Thêm dịch vụ của hồ sơ bệnh án không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ClearThongTin();
            }
        }

        private void dgDSHSBA_DV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgDSHSBA_DV.Rows[dgDSHSBA_DV.CurrentCell.RowIndex];
            txtMaHSBADV.Text = row.Cells[0].Value.ToString();
            txtMaDV.Text = row.Cells[1].Value.ToString();
            dtpNgay.Text = row.Cells[2].Value.ToString();
            txtMaKTV.Text = row.Cells[3].Value.ToString();
            txtKetQua.Text = row.Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dòng dịch vụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dgDSHSBA_DV.CurrentCell.RowIndex;
                dgDSHSBA_DV.Rows.RemoveAt(index);
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM DNHLAN.UV_THONGTINHSBA_DV WHERE MADV = '" + txtMaDV.Text + "'";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dịch vụ của hồ sơ bệnh án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearThongTin();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM DNHLAN.UV_THONGTINHSBA_DV WHERE MAHSBA LIKE '" + txtTimHSBADV.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA_DV.DataSource = dt;
            ClearSearch();
        }
    }
}
