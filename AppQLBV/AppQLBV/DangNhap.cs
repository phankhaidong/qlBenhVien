using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLBV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxTK.Text == null)
            {
                MessageBox.Show("ID không được để trống");
                return;
            }
            if (textBoxMK.Text == null)
            {
                MessageBox.Show("Pass không được để trống");
                return;
            }
            Regex rgx = new Regex("[^A-Za-z0-9]");
            if (rgx.IsMatch(textBoxTK.Text))
            {
                MessageBox.Show("ID không được chứa ký tự đặc biệt");
                textBoxTK.Clear();
                return;
            }
            string conString = "USER ID=" + textBoxTK.Text + ";PASSWORD=" + textBoxMK.Text + ";DATA SOURCE=localhost:1521/XE";
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["con"].ConnectionString = conString;
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
                MessageBox.Show("Connect success");
                this.Hide();
                string role="";
                string strSQL = "select GRANTED_ROLE from user_role_privs";
                OracleCommand oCmd = new OracleCommand(strSQL,con);
                OracleDataReader dr;
                dr = oCmd.ExecuteReader();
                dr.Read();
                role = dr["GRANTED_ROLE"].ToString();
                this.Hide();
                switch (role) {
                    case "THANHTRA":
                        frmGiaoDienThanhTra menu = new frmGiaoDienThanhTra();
                        menu.ShowDialog();
                        break;

                    case "NVCSYT":
                        frmGiaoDienCSYT frmGiaoDienCSYT = new frmGiaoDienCSYT();
                        frmGiaoDienCSYT.ShowDialog();
                        break;
                    case "BACSI":
                        frmGiaoDienYBS frmGiaoDienYBS = new frmGiaoDienYBS();
                        frmGiaoDienYBS.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Connection error please check your id or password");
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxMK.UseSystemPasswordChar = false;
            }
            else textBoxMK.UseSystemPasswordChar = true;
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
