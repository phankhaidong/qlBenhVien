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
using DGVPrinterHelper;
using System.Text.RegularExpressions;

namespace AppQLBV
{
    public partial class HSBADV_ThanhTra : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public HSBADV_ThanhTra()
        {
            InitializeComponent();
            dataGridViewHSBA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            frmGiaoDienThanhTra thanhTraMenu = new frmGiaoDienThanhTra();
            this.Hide();
            thanhTraMenu.ShowDialog();
        }

        private void HSBADV_ThanhTra_Load(object sender, EventArgs e)
        {
            con.Open();
            string strSQL = "select * from qlbv_dba.HSBA_DV";
            OracleCommand oCmd = new OracleCommand(strSQL, con);
            OracleDataReader oReader = oCmd.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(oReader);
            dataGridViewHSBA.DataSource = dTable.DefaultView;
            con.Close();
        }

        private void dataGridViewHSBA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "BÁO CÁO DANH SÁCH HỒ SƠ BỆNH ÁN DỊCH VỤ";
            printer.SubTitle = string.Format("Ngày: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintDataGridView(dataGridViewHSBA);
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            con.Open();
            string strSQL = "select * from qlbv_dba.HSBA_DV";
            OracleCommand oCmd = new OracleCommand(strSQL, con);
            OracleDataReader oReader = oCmd.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(oReader);
            dataGridViewHSBA.DataSource = dTable.DefaultView;
            con.Close();
        }
        Regex rgx = new Regex("[^A-Za-z0-9]");
        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (rgx.IsMatch(textBoxMaHSBA.Text))
            {
                MessageBox.Show("không được chứa ký tự đặc biệt");
                textBoxMaHSBA.Clear();
                return;
            }
            con.Open();
            string strSQL = "select * from qlbv_dba.HSBA_DV where MAHSBA like '" + textBoxMaHSBA.Text + "%'";
            OracleCommand oCmd = new OracleCommand(strSQL, con);
            OracleDataReader oReader = oCmd.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(oReader);
            dataGridViewHSBA.DataSource = dTable.DefaultView;
            con.Close();
        }
    }
}
