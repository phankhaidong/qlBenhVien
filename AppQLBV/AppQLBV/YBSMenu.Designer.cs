
namespace AppQLBV
{
    partial class frmGiaoDienYBS
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHSBA = new System.Windows.Forms.Button();
            this.buttonHSBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quản lý HSBA, dịch vụ HSBA và Bệnh nhân";
            // 
            // buttonHSBA
            // 
            this.buttonHSBA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHSBA.Location = new System.Drawing.Point(226, 212);
            this.buttonHSBA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHSBA.Name = "buttonHSBA";
            this.buttonHSBA.Size = new System.Drawing.Size(204, 37);
            this.buttonHSBA.TabIndex = 13;
            this.buttonHSBA.Text = "Hồ sơ bệnh án và dịch vụ";
            this.buttonHSBA.UseVisualStyleBackColor = false;
            this.buttonHSBA.Click += new System.EventHandler(this.buttonHSBA_Click);
            // 
            // buttonHSBN
            // 
            this.buttonHSBN.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHSBN.Location = new System.Drawing.Point(226, 287);
            this.buttonHSBN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHSBN.Name = "buttonHSBN";
            this.buttonHSBN.Size = new System.Drawing.Size(204, 37);
            this.buttonHSBN.TabIndex = 16;
            this.buttonHSBN.Text = "Hồ sơ bệnh nhân";
            this.buttonHSBN.UseVisualStyleBackColor = false;
            this.buttonHSBN.Click += new System.EventHandler(this.buttonHSBN_Click);
            // 
            // frmGiaoDienYBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 463);
            this.Controls.Add(this.buttonHSBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHSBA);
            this.Name = "frmGiaoDienYBS";
            this.Text = "Quản lý của Y/Bác sĩ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHSBA;
        private System.Windows.Forms.Button buttonHSBN;
    }
}