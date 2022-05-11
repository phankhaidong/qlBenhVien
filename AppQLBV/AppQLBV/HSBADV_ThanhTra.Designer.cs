
namespace AppQLBV
{
    partial class HSBADV_ThanhTra
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
            this.dataGridViewHSBA = new System.Windows.Forms.DataGridView();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTim = new System.Windows.Forms.Button();
            this.textBoxMaHSBA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(42, 339);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Trở lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewHSBA
            // 
            this.dataGridViewHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHSBA.Location = new System.Drawing.Point(42, 59);
            this.dataGridViewHSBA.Name = "dataGridViewHSBA";
            this.dataGridViewHSBA.Size = new System.Drawing.Size(610, 253);
            this.dataGridViewHSBA.TabIndex = 4;
            this.dataGridViewHSBA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHSBA_CellContentClick);
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(496, 339);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(75, 23);
            this.buttonIn.TabIndex = 17;
            this.buttonIn.Text = "In";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Location = new System.Drawing.Point(577, 339);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(75, 23);
            this.buttonLamMoi.TabIndex = 16;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tìm theo mã HSBA:";
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(577, 30);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 19;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // textBoxMaHSBA
            // 
            this.textBoxMaHSBA.Location = new System.Drawing.Point(471, 33);
            this.textBoxMaHSBA.Name = "textBoxMaHSBA";
            this.textBoxMaHSBA.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaHSBA.TabIndex = 18;
            // 
            // HSBADV_ThanhTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.textBoxMaHSBA);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.buttonLamMoi);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewHSBA);
            this.Name = "HSBADV_ThanhTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSBADV_ThanhTra";
            this.Load += new System.EventHandler(this.HSBADV_ThanhTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewHSBA;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.TextBox textBoxMaHSBA;
    }
}