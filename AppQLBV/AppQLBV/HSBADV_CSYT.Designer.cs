
namespace AppQLBV
{
    partial class HSBADV_CSYT
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
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimHSBADV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDSHSBA_DV = new System.Windows.Forms.DataGridView();
            this.colMaHSBADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtMaKTV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtMaHSBADV = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA_DV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightGray;
            this.btnTim.Location = new System.Drawing.Point(1044, 325);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 31);
            this.btnTim.TabIndex = 26;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimHSBADV
            // 
            this.txtTimHSBADV.Location = new System.Drawing.Point(825, 330);
            this.txtTimHSBADV.Name = "txtTimHSBADV";
            this.txtTimHSBADV.Size = new System.Drawing.Size(213, 22);
            this.txtTimHSBADV.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tìm mã HSBA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(321, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chi tiết dịch vụ trong hồ sơ bệnh án";
            // 
            // dgDSHSBA_DV
            // 
            this.dgDSHSBA_DV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDSHSBA_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSHSBA_DV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHSBADV,
            this.colMaDV,
            this.colNgay,
            this.colMaKTV,
            this.colKetQua});
            this.dgDSHSBA_DV.Location = new System.Drawing.Point(12, 373);
            this.dgDSHSBA_DV.Name = "dgDSHSBA_DV";
            this.dgDSHSBA_DV.RowHeadersWidth = 51;
            this.dgDSHSBA_DV.RowTemplate.Height = 24;
            this.dgDSHSBA_DV.Size = new System.Drawing.Size(1107, 297);
            this.dgDSHSBA_DV.TabIndex = 23;
            this.dgDSHSBA_DV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSHSBA_DV_CellClick);
            // 
            // colMaHSBADV
            // 
            this.colMaHSBADV.DataPropertyName = "MAHSBA";
            this.colMaHSBADV.HeaderText = "Mã HSBA";
            this.colMaHSBADV.MinimumWidth = 6;
            this.colMaHSBADV.Name = "colMaHSBADV";
            // 
            // colMaDV
            // 
            this.colMaDV.DataPropertyName = "MADV";
            this.colMaDV.HeaderText = "Mã DV";
            this.colMaDV.MinimumWidth = 6;
            this.colMaDV.Name = "colMaDV";
            // 
            // colNgay
            // 
            this.colNgay.DataPropertyName = "NGAY";
            this.colNgay.HeaderText = "Ngày";
            this.colNgay.MinimumWidth = 6;
            this.colNgay.Name = "colNgay";
            // 
            // colMaKTV
            // 
            this.colMaKTV.DataPropertyName = "MAKTV";
            this.colMaKTV.HeaderText = "Mã KTV";
            this.colMaKTV.MinimumWidth = 6;
            this.colMaKTV.Name = "colMaKTV";
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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpNgay);
            this.panel1.Controls.Add(this.txtKetQua);
            this.panel1.Controls.Add(this.txtMaKTV);
            this.panel1.Controls.Add(this.txtMaDV);
            this.panel1.Controls.Add(this.txtMaHSBADV);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 238);
            this.panel1.TabIndex = 22;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(120, 128);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(373, 22);
            this.dtpNgay.TabIndex = 18;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(670, 77);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(391, 22);
            this.txtKetQua.TabIndex = 17;
            // 
            // txtMaKTV
            // 
            this.txtMaKTV.Location = new System.Drawing.Point(670, 27);
            this.txtMaKTV.Name = "txtMaKTV";
            this.txtMaKTV.Size = new System.Drawing.Size(391, 22);
            this.txtMaKTV.TabIndex = 14;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(120, 77);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(373, 22);
            this.txtMaDV.TabIndex = 11;
            // 
            // txtMaHSBADV
            // 
            this.txtMaHSBADV.Location = new System.Drawing.Point(120, 27);
            this.txtMaHSBADV.Name = "txtMaHSBADV";
            this.txtMaHSBADV.Size = new System.Drawing.Size(373, 22);
            this.txtMaHSBADV.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Salmon;
            this.btnXoa.Location = new System.Drawing.Point(574, 181);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 33);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.Location = new System.Drawing.Point(401, 181);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 33);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(590, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Kết quả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã KTV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã DV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HSBA:";
            // 
            // HSBADV_CSYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 689);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimHSBADV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDSHSBA_DV);
            this.Controls.Add(this.panel1);
            this.Name = "HSBADV_CSYT";
            this.Text = "HSBADV_CSYT";
            this.Load += new System.EventHandler(this.HSBADV_CSYT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA_DV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimHSBADV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDSHSBA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHSBADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetQua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtMaKTV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtMaHSBADV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}