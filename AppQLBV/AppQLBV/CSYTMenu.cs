using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLBV
{
    public partial class frmGiaoDienCSYT : Form
    {
        public frmGiaoDienCSYT()
        {
            InitializeComponent();
        }

        private void buttonHSBA_Click(object sender, EventArgs e)
        {
            HSBA_CSYT hSBA_CSYT = new HSBA_CSYT();
            this.Hide();
            hSBA_CSYT.ShowDialog();
        }

        private void buttonHSBADV_Click(object sender, EventArgs e)
        {
            HSBADV_CSYT hSBADV_CSYT = new HSBADV_CSYT();
            this.Hide();
            hSBADV_CSYT.ShowDialog();
        }
    }
}
