
namespace AppQLBV
{
    partial class HSBN_ThanhTra
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewHSBN = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTimMaNV = new System.Windows.Forms.Button();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBN)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(44, 334);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Trở lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewHSBN
            // 
            this.dataGridViewHSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHSBN.Location = new System.Drawing.Point(44, 54);
            this.dataGridViewHSBN.Name = "dataGridViewHSBN";
            this.dataGridViewHSBN.Size = new System.Drawing.Size(610, 253);
            this.dataGridViewHSBN.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tìm theo mã BN:";
            // 
            // buttonTimMaNV
            // 
            this.buttonTimMaNV.Location = new System.Drawing.Point(239, 23);
            this.buttonTimMaNV.Name = "buttonTimMaNV";
            this.buttonTimMaNV.Size = new System.Drawing.Size(75, 23);
            this.buttonTimMaNV.TabIndex = 10;
            this.buttonTimMaNV.Text = "Tìm";
            this.buttonTimMaNV.UseVisualStyleBackColor = true;
            this.buttonTimMaNV.Click += new System.EventHandler(this.buttonTimMaNV_Click);
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(133, 26);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaNV.TabIndex = 9;
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(499, 334);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(75, 23);
            this.buttonIn.TabIndex = 15;
            this.buttonIn.Text = "In";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Location = new System.Drawing.Point(580, 334);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(75, 23);
            this.buttonLamMoi.TabIndex = 14;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // HSBN_ThanhTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 389);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.buttonLamMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTimMaNV);
            this.Controls.Add(this.textBoxMaNV);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewHSBN);
            this.Name = "HSBN_ThanhTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSBN_ThanhTra";
            this.Load += new System.EventHandler(this.HSBN_ThanhTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewHSBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTimMaNV;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonLamMoi;
    }
}