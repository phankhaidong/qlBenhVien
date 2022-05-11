
namespace AppQLBV
{
    partial class frmGiaoDienThanhTra
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
            this.buttonHSBA = new System.Windows.Forms.Button();
            this.buttonHSBADV = new System.Windows.Forms.Button();
            this.buttonHSBN = new System.Windows.Forms.Button();
            this.buttonCSYT = new System.Windows.Forms.Button();
            this.buttonHSNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHSBA
            // 
            this.buttonHSBA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHSBA.Location = new System.Drawing.Point(159, 137);
            this.buttonHSBA.Name = "buttonHSBA";
            this.buttonHSBA.Size = new System.Drawing.Size(153, 30);
            this.buttonHSBA.TabIndex = 1;
            this.buttonHSBA.Text = "Hồ sơ bệnh án";
            this.buttonHSBA.UseVisualStyleBackColor = false;
            this.buttonHSBA.Click += new System.EventHandler(this.buttonHSBA_Click);
            // 
            // buttonHSBADV
            // 
            this.buttonHSBADV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHSBADV.Location = new System.Drawing.Point(159, 192);
            this.buttonHSBADV.Name = "buttonHSBADV";
            this.buttonHSBADV.Size = new System.Drawing.Size(153, 30);
            this.buttonHSBADV.TabIndex = 2;
            this.buttonHSBADV.Text = "Hồ sơ bệnh án Dịch vụ";
            this.buttonHSBADV.UseVisualStyleBackColor = false;
            this.buttonHSBADV.Click += new System.EventHandler(this.buttonHSBADV_Click);
            // 
            // buttonHSBN
            // 
            this.buttonHSBN.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHSBN.Location = new System.Drawing.Point(159, 247);
            this.buttonHSBN.Name = "buttonHSBN";
            this.buttonHSBN.Size = new System.Drawing.Size(153, 30);
            this.buttonHSBN.TabIndex = 3;
            this.buttonHSBN.Text = "Hồ sơ bệnh nhân";
            this.buttonHSBN.UseVisualStyleBackColor = false;
            this.buttonHSBN.Click += new System.EventHandler(this.buttonHSBN_Click);
            // 
            // buttonCSYT
            // 
            this.buttonCSYT.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCSYT.Location = new System.Drawing.Point(159, 298);
            this.buttonCSYT.Name = "buttonCSYT";
            this.buttonCSYT.Size = new System.Drawing.Size(153, 30);
            this.buttonCSYT.TabIndex = 4;
            this.buttonCSYT.Text = "Cơ sở y tế";
            this.buttonCSYT.UseVisualStyleBackColor = false;
            this.buttonCSYT.Click += new System.EventHandler(this.buttonCSYT_Click);
            // 
            // buttonHSNV
            // 
            this.buttonHSNV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHSNV.Location = new System.Drawing.Point(159, 353);
            this.buttonHSNV.Name = "buttonHSNV";
            this.buttonHSNV.Size = new System.Drawing.Size(153, 30);
            this.buttonHSNV.TabIndex = 5;
            this.buttonHSNV.Text = "Hồ sơ nhân viên";
            this.buttonHSNV.UseVisualStyleBackColor = false;
            this.buttonHSNV.Click += new System.EventHandler(this.buttonHSNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản lý thông tin";
            // 
            // frmGiaoDienThanhTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHSNV);
            this.Controls.Add(this.buttonCSYT);
            this.Controls.Add(this.buttonHSBN);
            this.Controls.Add(this.buttonHSBADV);
            this.Controls.Add(this.buttonHSBA);
            this.Name = "frmGiaoDienThanhTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý của Thanh Tra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHSBA;
        private System.Windows.Forms.Button buttonHSBADV;
        private System.Windows.Forms.Button buttonHSBN;
        private System.Windows.Forms.Button buttonCSYT;
        private System.Windows.Forms.Button buttonHSNV;
        private System.Windows.Forms.Label label1;
    }
}