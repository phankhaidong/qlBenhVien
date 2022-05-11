using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DGVPrinterHelper;

namespace AppQLBV
{
    public partial class HSNV_ThanhTra : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public HSNV_ThanhTra()
        {
            InitializeComponent();
            dataGridViewHSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HSNV_ThanhTra_Load(object sender, EventArgs e)
        {
            con.Open();
            string strSQL = "select * from qlbv_dba.NHANVIEN";
            OracleCommand oCmd = new OracleCommand(strSQL, con);
            OracleDataReader oReader = oCmd.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(oReader);
            dataGridViewHSNV.DataSource = dTable.DefaultView;
            con.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            frmGiaoDienThanhTra thanhTraMenu = new frmGiaoDienThanhTra();
            this.Hide();
            thanhTraMenu.ShowDialog();
        }
        Regex rgx = new Regex("[^A-Za-z0-9]");
        private void buttonTimMANV_Click(object sender, EventArgs e)
        {
            if (rgx.IsMatch(textBoxMaNV.Text))
            {
                MessageBox.Show("không được chứa ký tự đặc biệt");
                textBoxMaNV.Clear();                
                return;
            }
            con.Open();
            string strSQL = "select * from qlbv_dba.NHANVIEN where MANV like '" + textBoxMaNV.Text + "%'";
            OracleCommand oCmd = new OracleCommand(strSQL, con);
            OracleDataReader oReader = oCmd.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(oReader);
            dataGridViewHSNV.DataSource = dTable.DefaultView;
            con.Close();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi() {
            con.Open();
            string strSQL = "select * from qlbv_dba.NHANVIEN";
            OracleCommand oCmd = new OracleCommand(strSQL, con);
            OracleDataReader oReader = oCmd.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(oReader);
            dataGridViewHSNV.DataSource = dTable.DefaultView;
            con.Close();
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "BÁO CÁO DANH SÁCH NHÂN SỰ";
            printer.SubTitle = string.Format("Ngày: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintDataGridView(dataGridViewHSNV);
        }
    }
}
