namespace BTL_HeChuyenGia_N02.HeThong
{
    partial class FrmGiaoDienChinh
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemQuanTriNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemTrieuChungBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemChuanDoanBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSuKien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlChinh = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuChuyenGia});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(767, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemQuanTriNguoiDung,
            this.mnuItemDangNhap,
            this.mnuItemDangXuat,
            this.mnuItemThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(85, 26);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuItemQuanTriNguoiDung
            // 
            this.mnuItemQuanTriNguoiDung.Name = "mnuItemQuanTriNguoiDung";
            this.mnuItemQuanTriNguoiDung.Size = new System.Drawing.Size(226, 26);
            this.mnuItemQuanTriNguoiDung.Text = "Quản trị người dùng";
            this.mnuItemQuanTriNguoiDung.Visible = false;
            this.mnuItemQuanTriNguoiDung.Click += new System.EventHandler(this.mnuItemQuanTriNguoiDung_Click);
            // 
            // mnuItemDangNhap
            // 
            this.mnuItemDangNhap.Name = "mnuItemDangNhap";
            this.mnuItemDangNhap.Size = new System.Drawing.Size(226, 26);
            this.mnuItemDangNhap.Text = "Đăng nhập";
            this.mnuItemDangNhap.Click += new System.EventHandler(this.mnuItemDangNhap_Click);
            // 
            // mnuItemDangXuat
            // 
            this.mnuItemDangXuat.Name = "mnuItemDangXuat";
            this.mnuItemDangXuat.Size = new System.Drawing.Size(226, 26);
            this.mnuItemDangXuat.Text = "Đăng xuất";
            this.mnuItemDangXuat.Visible = false;
            this.mnuItemDangXuat.Click += new System.EventHandler(this.mnuItemDangXuat_Click);
            // 
            // mnuItemThoat
            // 
            this.mnuItemThoat.Name = "mnuItemThoat";
            this.mnuItemThoat.Size = new System.Drawing.Size(226, 26);
            this.mnuItemThoat.Text = "Thoát";
            this.mnuItemThoat.Click += new System.EventHandler(this.mnuItemThoat_Click);
            // 
            // mnuChuyenGia
            // 
            this.mnuChuyenGia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemTrieuChungBenh,
            this.mnuItemChuanDoanBenh,
            this.mnuItemSuKien,
            this.mnuItemLuat});
            this.mnuChuyenGia.Name = "mnuChuyenGia";
            this.mnuChuyenGia.Size = new System.Drawing.Size(96, 26);
            this.mnuChuyenGia.Text = "Chuyên gia";
            // 
            // mnuItemTrieuChungBenh
            // 
            this.mnuItemTrieuChungBenh.Name = "mnuItemTrieuChungBenh";
            this.mnuItemTrieuChungBenh.Size = new System.Drawing.Size(224, 26);
            this.mnuItemTrieuChungBenh.Text = "Triệu chứng bệnh";
            this.mnuItemTrieuChungBenh.Click += new System.EventHandler(this.mnuItemTrieuChungBenh_Click);
            // 
            // mnuItemChuanDoanBenh
            // 
            this.mnuItemChuanDoanBenh.Name = "mnuItemChuanDoanBenh";
            this.mnuItemChuanDoanBenh.Size = new System.Drawing.Size(224, 26);
            this.mnuItemChuanDoanBenh.Text = "Chuẩn đoán bệnh";
            this.mnuItemChuanDoanBenh.Click += new System.EventHandler(this.mnuItemChuanDoanBenh_Click);
            // 
            // mnuItemSuKien
            // 
            this.mnuItemSuKien.Name = "mnuItemSuKien";
            this.mnuItemSuKien.Size = new System.Drawing.Size(224, 26);
            this.mnuItemSuKien.Text = "Sự kiện";
            this.mnuItemSuKien.Visible = false;
            this.mnuItemSuKien.Click += new System.EventHandler(this.mnuItemSuKien_Click);
            // 
            // mnuItemLuat
            // 
            this.mnuItemLuat.Name = "mnuItemLuat";
            this.mnuItemLuat.Size = new System.Drawing.Size(224, 26);
            this.mnuItemLuat.Text = "Luật";
            this.mnuItemLuat.Visible = false;
            this.mnuItemLuat.Click += new System.EventHandler(this.mnuItemLuat_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Location = new System.Drawing.Point(0, 30);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(767, 31);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai});
            this.statusStrip.Location = new System.Drawing.Point(0, 363);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(767, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(118, 20);
            this.lblTrangThai.Text = "Chưa đăng nhập";
            // 
            // pnlChinh
            // 
            this.pnlChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChinh.Location = new System.Drawing.Point(0, 61);
            this.pnlChinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(767, 302);
            this.pnlChinh.TabIndex = 3;
            // 
            // FrmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 389);
            this.Controls.Add(this.pnlChinh);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGiaoDienChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ chuyên gia chuẩn đoán bệnh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGiaoDienChinh_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel pnlChinh;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenGia;
        private System.Windows.Forms.ToolStripMenuItem mnuItemChuanDoanBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuItemTrieuChungBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSuKien;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLuat;
        private System.Windows.Forms.ToolStripMenuItem mnuItemQuanTriNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuItemThoat;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
    }
}