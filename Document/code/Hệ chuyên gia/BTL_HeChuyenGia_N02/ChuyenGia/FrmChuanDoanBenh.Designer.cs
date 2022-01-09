using WeifenLuo.WinFormsUI.Docking;

namespace BTL_HeChuyenGia_N02.ChuyenGia
{
    partial class FrmChuanDoanBenh : DockContent
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pnlThuThapThongTin = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCauHoi = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKetLuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuaTrinhSuyDien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlThuThapThongTin.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.lblQuaTrinhSuyDien);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(797, 415);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pnlThuThapThongTin);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(797, 265);
            this.splitContainer2.SplitterDistance = 525;
            this.splitContainer2.TabIndex = 1;
            // 
            // pnlThuThapThongTin
            // 
            this.pnlThuThapThongTin.Controls.Add(this.label1);
            this.pnlThuThapThongTin.Controls.Add(this.pnlCauHoi);
            this.pnlThuThapThongTin.Controls.Add(this.flowLayoutPanel1);
            this.pnlThuThapThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThuThapThongTin.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlThuThapThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnlThuThapThongTin.Name = "pnlThuThapThongTin";
            this.pnlThuThapThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.pnlThuThapThongTin.Size = new System.Drawing.Size(523, 263);
            this.pnlThuThapThongTin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thu thập thông tin";
            // 
            // pnlCauHoi
            // 
            this.pnlCauHoi.AutoSize = true;
            this.pnlCauHoi.Location = new System.Drawing.Point(13, 33);
            this.pnlCauHoi.Name = "pnlCauHoi";
            this.pnlCauHoi.Size = new System.Drawing.Size(0, 0);
            this.pnlCauHoi.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnTiep);
            this.flowLayoutPanel1.Controls.Add(this.btnKetThuc);
            this.flowLayoutPanel1.Controls.Add(this.btnLamLai);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(276, 64);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnTiep
            // 
            this.btnTiep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiep.Location = new System.Drawing.Point(18, 3);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(75, 23);
            this.btnTiep.TabIndex = 0;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKetThuc.Location = new System.Drawing.Point(99, 3);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetThuc.TabIndex = 1;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamLai.Location = new System.Drawing.Point(180, 3);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 2;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.lblKetLuan);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(266, 263);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết luận";
            // 
            // lblKetLuan
            // 
            this.lblKetLuan.AutoSize = true;
            this.lblKetLuan.Location = new System.Drawing.Point(13, 40);
            this.lblKetLuan.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblKetLuan.Name = "lblKetLuan";
            this.lblKetLuan.Size = new System.Drawing.Size(0, 13);
            this.lblKetLuan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quá trình suy diễn";
            // 
            // lblQuaTrinhSuyDien
            // 
            this.lblQuaTrinhSuyDien.AutoSize = true;
            this.lblQuaTrinhSuyDien.Location = new System.Drawing.Point(16, 38);
            this.lblQuaTrinhSuyDien.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQuaTrinhSuyDien.Name = "lblQuaTrinhSuyDien";
            this.lblQuaTrinhSuyDien.Size = new System.Drawing.Size(0, 13);
            this.lblQuaTrinhSuyDien.TabIndex = 3;
            // 
            // FrmChuanDoanBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 415);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmChuanDoanBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuẩn đoán bệnh";
            this.Load += new System.EventHandler(this.FrmChuanDoanBenh_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlThuThapThongTin.ResumeLayout(false);
            this.pnlThuThapThongTin.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel pnlThuThapThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlCauHoi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKetLuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuaTrinhSuyDien;
        private System.Windows.Forms.Button btnLamLai;

    }
}