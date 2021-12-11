namespace BTL_HeChuyenGia_N02.ChuyenGia
{
    partial class FrmNhapHeSoTinCay
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
            this.txtHeSoTinCay = new System.Windows.Forms.TextBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHeSoTinCay
            // 
            this.txtHeSoTinCay.Location = new System.Drawing.Point(12, 12);
            this.txtHeSoTinCay.Name = "txtHeSoTinCay";
            this.txtHeSoTinCay.Size = new System.Drawing.Size(258, 20);
            this.txtHeSoTinCay.TabIndex = 0;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Image = global::BTL_HeChuyenGia_N02.Properties.Resources.HuyBo;
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(195, 42);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBo.TabIndex = 1;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Image = global::BTL_HeChuyenGia_N02.Properties.Resources.DongY;
            this.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongY.Location = new System.Drawing.Point(114, 42);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 1;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // FrmNhapHeSoTinCay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 73);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.txtHeSoTinCay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNhapHeSoTinCay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hệ số tin cậy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNhapHeSoTinCay_FormClosing);
            this.Load += new System.EventHandler(this.FrmNhapHeSoTinCay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeSoTinCay;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnDongY;

    }
}