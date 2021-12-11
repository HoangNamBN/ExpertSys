namespace BTL_HeChuyenGia_N02.ChuyenGia
{
    partial class UCtrlThongTinBoSung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.radCo = new System.Windows.Forms.RadioButton();
            this.radKhong = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Location = new System.Drawing.Point(10, 39);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(46, 13);
            this.lblCauHoi.TabIndex = 2;
            this.lblCauHoi.Text = "Câu hỏi:";
            // 
            // radCo
            // 
            this.radCo.AutoSize = true;
            this.radCo.Checked = true;
            this.radCo.Location = new System.Drawing.Point(18, 66);
            this.radCo.Name = "radCo";
            this.radCo.Size = new System.Drawing.Size(38, 17);
            this.radCo.TabIndex = 3;
            this.radCo.TabStop = true;
            this.radCo.Text = "Có";
            this.radCo.UseVisualStyleBackColor = true;
            // 
            // radKhong
            // 
            this.radKhong.AutoSize = true;
            this.radKhong.Location = new System.Drawing.Point(75, 66);
            this.radKhong.Name = "radKhong";
            this.radKhong.Size = new System.Drawing.Size(56, 17);
            this.radKhong.TabIndex = 4;
            this.radKhong.Text = "Không";
            this.radKhong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Các triệu chứng khác:";
            // 
            // UCtrlThongTinBoSung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radKhong);
            this.Controls.Add(this.radCo);
            this.Controls.Add(this.lblCauHoi);
            this.Name = "UCtrlThongTinBoSung";
            this.Size = new System.Drawing.Size(654, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.RadioButton radCo;
        private System.Windows.Forms.RadioButton radKhong;
        private System.Windows.Forms.Label label1;
    }
}
