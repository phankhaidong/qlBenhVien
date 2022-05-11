
namespace AppQLBV
{
    partial class HSBN_YBS
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgDSBN = new System.Windows.Forms.DataGridView();
            this.colMaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCSYte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuanHuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienSuBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienSuBenhGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiUngThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.btnTim1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTim2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSBN)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgDSBN);
            this.panel4.Location = new System.Drawing.Point(12, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1107, 452);
            this.panel4.TabIndex = 22;
            // 
            // dgDSBN
            // 
            this.dgDSBN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSBN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBenhNhan,
            this.colMaCSYte,
            this.colTenBN,
            this.colCMND,
            this.colNgaySinh,
            this.colSoNha,
            this.colTenDuong,
            this.colQuanHuyen,
            this.colTinhTP,
            this.colTienSuBenh,
            this.colTienSuBenhGD,
            this.colDiUngThuoc});
            this.dgDSBN.Location = new System.Drawing.Point(3, 3);
            this.dgDSBN.Name = "dgDSBN";
            this.dgDSBN.RowHeadersWidth = 51;
            this.dgDSBN.RowTemplate.Height = 24;
            this.dgDSBN.Size = new System.Drawing.Size(1101, 446);
            this.dgDSBN.TabIndex = 0;
            // 
            // colMaBenhNhan
            // 
            this.colMaBenhNhan.DataPropertyName = "MABN";
            this.colMaBenhNhan.HeaderText = "Mã BN";
            this.colMaBenhNhan.MinimumWidth = 6;
            this.colMaBenhNhan.Name = "colMaBenhNhan";
            // 
            // colMaCSYte
            // 
            this.colMaCSYte.DataPropertyName = "MACSYT";
            this.colMaCSYte.HeaderText = "Mã CSYT";
            this.colMaCSYte.MinimumWidth = 6;
            this.colMaCSYte.Name = "colMaCSYte";
            // 
            // colTenBN
            // 
            this.colTenBN.DataPropertyName = "TENBN";
            this.colTenBN.HeaderText = "Tên BN";
            this.colTenBN.MinimumWidth = 6;
            this.colTenBN.Name = "colTenBN";
            // 
            // colCMND
            // 
            this.colCMND.DataPropertyName = "CMND";
            this.colCMND.HeaderText = "CMND";
            this.colCMND.MinimumWidth = 6;
            this.colCMND.Name = "colCMND";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NGAYSINH";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colSoNha
            // 
            this.colSoNha.DataPropertyName = "SONHA";
            this.colSoNha.HeaderText = "Số nhà";
            this.colSoNha.MinimumWidth = 6;
            this.colSoNha.Name = "colSoNha";
            // 
            // colTenDuong
            // 
            this.colTenDuong.DataPropertyName = "TENDUONG";
            this.colTenDuong.HeaderText = "Tên đường";
            this.colTenDuong.MinimumWidth = 6;
            this.colTenDuong.Name = "colTenDuong";
            // 
            // colQuanHuyen
            // 
            this.colQuanHuyen.DataPropertyName = "QUANHUYEN";
            this.colQuanHuyen.HeaderText = "Quận/Huyện";
            this.colQuanHuyen.MinimumWidth = 6;
            this.colQuanHuyen.Name = "colQuanHuyen";
            // 
            // colTinhTP
            // 
            this.colTinhTP.DataPropertyName = "TINHTP";
            this.colTinhTP.HeaderText = "Tỉnh/TP";
            this.colTinhTP.MinimumWidth = 6;
            this.colTinhTP.Name = "colTinhTP";
            // 
            // colTienSuBenh
            // 
            this.colTienSuBenh.DataPropertyName = "TIENSUBENH";
            this.colTienSuBenh.HeaderText = "Tiền sử bệnh";
            this.colTienSuBenh.MinimumWidth = 6;
            this.colTienSuBenh.Name = "colTienSuBenh";
            // 
            // colTienSuBenhGD
            // 
            this.colTienSuBenhGD.DataPropertyName = "TIENSUBENHGD";
            this.colTienSuBenhGD.HeaderText = "Tiền sử bệnh GĐ";
            this.colTienSuBenhGD.MinimumWidth = 6;
            this.colTienSuBenhGD.Name = "colTienSuBenhGD";
            // 
            // colDiUngThuoc
            // 
            this.colDiUngThuoc.DataPropertyName = "DIUNGTHUOC";
            this.colDiUngThuoc.HeaderText = "Dị ứng thuốc";
            this.colDiUngThuoc.MinimumWidth = 6;
            this.colDiUngThuoc.Name = "colDiUngThuoc";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtMaBN);
            this.panel3.Controls.Add(this.btnTim1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCMND);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnTim2);
            this.panel3.Location = new System.Drawing.Point(12, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1107, 53);
            this.panel3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "hoặc";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(161, 14);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(213, 22);
            this.txtMaBN.TabIndex = 13;
            // 
            // btnTim1
            // 
            this.btnTim1.BackColor = System.Drawing.Color.LightGray;
            this.btnTim1.Location = new System.Drawing.Point(380, 9);
            this.btnTim1.Name = "btnTim1";
            this.btnTim1.Size = new System.Drawing.Size(75, 31);
            this.btnTim1.TabIndex = 14;
            this.btnTim1.Text = "Tìm";
            this.btnTim1.UseVisualStyleBackColor = false;
            this.btnTim1.Click += new System.EventHandler(this.btnTim1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(708, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tìm CMND:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(788, 15);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(213, 22);
            this.txtCMND.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tìm mã bệnh nhân:";
            // 
            // btnTim2
            // 
            this.btnTim2.BackColor = System.Drawing.Color.LightGray;
            this.btnTim2.Location = new System.Drawing.Point(1007, 10);
            this.btnTim2.Name = "btnTim2";
            this.btnTim2.Size = new System.Drawing.Size(75, 31);
            this.btnTim2.TabIndex = 11;
            this.btnTim2.Text = "Tìm";
            this.btnTim2.UseVisualStyleBackColor = false;
            this.btnTim2.Click += new System.EventHandler(this.btnTim2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(413, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thông tin bệnh nhân";
            // 
            // HSBN_YBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 636);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Name = "HSBN_YBS";
            this.Text = "HSBN_YBS";
            this.Load += new System.EventHandler(this.HSBN_YBS_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSBN)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgDSBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCSYte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuanHuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienSuBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienSuBenhGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiUngThuoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Button btnTim1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTim2;
        private System.Windows.Forms.Label label2;
    }
}