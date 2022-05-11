
namespace AppQLBV
{
    partial class HSBA_HSBADV_YBS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimMaHSBA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaHSBA_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgDSHSBA = new System.Windows.Forms.DataGridView();
            this.colMaHSBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHSBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChanDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCSYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightGray;
            this.btnTim.Location = new System.Drawing.Point(1043, 79);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 31);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // txtTimMaHSBA
            // 
            this.txtTimMaHSBA.Location = new System.Drawing.Point(824, 84);
            this.txtTimMaHSBA.Name = "txtTimMaHSBA";
            this.txtTimMaHSBA.Size = new System.Drawing.Size(213, 22);
            this.txtTimMaHSBA.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tìm HSBA:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(743, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 485);
            this.panel2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHSBA_DV,
            this.colKetQua});
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 460);
            this.dataGridView1.TabIndex = 5;
            // 
            // colMaHSBA_DV
            // 
            this.colMaHSBA_DV.DataPropertyName = "MAHSBA";
            this.colMaHSBA_DV.HeaderText = "Mã HSBA";
            this.colMaHSBA_DV.MinimumWidth = 6;
            this.colMaHSBA_DV.Name = "colMaHSBA_DV";
            // 
            // colKetQua
            // 
            this.colKetQua.DataPropertyName = "KETQUA";
            this.colKetQua.HeaderText = "Kết quả";
            this.colKetQua.MinimumWidth = 6;
            this.colKetQua.Name = "colKetQua";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgDSHSBA);
            this.panel1.Location = new System.Drawing.Point(10, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 540);
            this.panel1.TabIndex = 16;
            // 
            // dgDSHSBA
            // 
            this.dgDSHSBA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDSHSBA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDSHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSHSBA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHSBA,
            this.colMaBN,
            this.colNgayHSBA,
            this.colChanDoan,
            this.colMaBS,
            this.colMaKhoa,
            this.colMaCSYT,
            this.colKetLuan});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDSHSBA.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgDSHSBA.Location = new System.Drawing.Point(8, 12);
            this.dgDSHSBA.Name = "dgDSHSBA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDSHSBA.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDSHSBA.RowHeadersWidth = 51;
            this.dgDSHSBA.RowTemplate.Height = 24;
            this.dgDSHSBA.Size = new System.Drawing.Size(710, 515);
            this.dgDSHSBA.TabIndex = 4;
            // 
            // colMaHSBA
            // 
            this.colMaHSBA.DataPropertyName = "MAHSBA";
            this.colMaHSBA.HeaderText = "Mã HSBA";
            this.colMaHSBA.MinimumWidth = 6;
            this.colMaHSBA.Name = "colMaHSBA";
            // 
            // colMaBN
            // 
            this.colMaBN.DataPropertyName = "MABN";
            this.colMaBN.HeaderText = "Mã BN";
            this.colMaBN.MinimumWidth = 6;
            this.colMaBN.Name = "colMaBN";
            // 
            // colNgayHSBA
            // 
            this.colNgayHSBA.DataPropertyName = "NGAY";
            this.colNgayHSBA.HeaderText = "Ngày";
            this.colNgayHSBA.MinimumWidth = 6;
            this.colNgayHSBA.Name = "colNgayHSBA";
            // 
            // colChanDoan
            // 
            this.colChanDoan.DataPropertyName = "CHUANDOAN";
            this.colChanDoan.HeaderText = "Chẩn đoán";
            this.colChanDoan.MinimumWidth = 6;
            this.colChanDoan.Name = "colChanDoan";
            // 
            // colMaBS
            // 
            this.colMaBS.DataPropertyName = "MABS";
            this.colMaBS.HeaderText = "Mã BS";
            this.colMaBS.MinimumWidth = 6;
            this.colMaBS.Name = "colMaBS";
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.DataPropertyName = "MAKHOA";
            this.colMaKhoa.HeaderText = "Mã khoa";
            this.colMaKhoa.MinimumWidth = 6;
            this.colMaKhoa.Name = "colMaKhoa";
            // 
            // colMaCSYT
            // 
            this.colMaCSYT.DataPropertyName = "MACSYT";
            this.colMaCSYT.HeaderText = "Mã CSYT";
            this.colMaCSYT.MinimumWidth = 6;
            this.colMaCSYT.Name = "colMaCSYT";
            // 
            // colKetLuan
            // 
            this.colKetLuan.DataPropertyName = "KETLUAN";
            this.colKetLuan.HeaderText = "Kết luận";
            this.colKetLuan.MinimumWidth = 6;
            this.colKetLuan.Name = "colKetLuan";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(224, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(688, 32);
            this.label18.TabIndex = 15;
            this.label18.Text = "Thông tin hồ sơ bệnh án và dịch vụ hồ sơ bệnh án";
            // 
            // HSBA_HSBADV_YBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 636);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimMaHSBA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label18);
            this.Name = "HSBA_HSBADV_YBS";
            this.Text = "HSBA_HSBADV_YBS";
            this.Load += new System.EventHandler(this.HSBA_HSBADV_YBS_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimMaHSBA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHSBA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetQua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgDSHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChanDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCSYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetLuan;
        private System.Windows.Forms.Label label18;
    }
}