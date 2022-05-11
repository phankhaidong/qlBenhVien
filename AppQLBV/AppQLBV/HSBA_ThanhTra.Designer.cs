
namespace AppQLBV
{
    partial class HSBA_ThanhTra
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
            this.dataGridViewHSBA = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTim = new System.Windows.Forms.Button();
            this.textBoxMaHSBA = new System.Windows.Forms.TextBox();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHSBA
            // 
            this.dataGridViewHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHSBA.Location = new System.Drawing.Point(31, 66);
            this.dataGridViewHSBA.Name = "dataGridViewHSBA";
            this.dataGridViewHSBA.RowHeadersWidth = 51;
            this.dataGridViewHSBA.Size = new System.Drawing.Size(610, 253);
            this.dataGridViewHSBA.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(31, 346);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Trở lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tìm theo mã HSBA:";
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(566, 37);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 22;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // textBoxMaHSBA
            // 
            this.textBoxMaHSBA.Location = new System.Drawing.Point(460, 40);
            this.textBoxMaHSBA.Name = "textBoxMaHSBA";
            this.textBoxMaHSBA.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaHSBA.TabIndex = 21;
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(485, 346);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(75, 23);
            this.buttonIn.TabIndex = 25;
            this.buttonIn.Text = "In";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Location = new System.Drawing.Point(566, 346);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(75, 23);
            this.buttonLamMoi.TabIndex = 24;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // HSBA_ThanhTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 421);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.buttonLamMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.textBoxMaHSBA);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewHSBA);
            this.Name = "HSBA_ThanhTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSBA_ThanhTra";
            this.Load += new System.EventHandler(this.HSBA_ThanhTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHSBA;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.TextBox textBoxMaHSBA;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonLamMoi;
    }
}