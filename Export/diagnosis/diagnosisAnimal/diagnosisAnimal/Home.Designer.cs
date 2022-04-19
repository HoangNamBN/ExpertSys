
namespace diagnosisAnimal
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RollbackLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.RollbackLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.RollbackRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.Page = new System.Windows.Forms.ToolStripMenuItem();
            this.triệuChứngBệnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuẩnĐoánBệnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sựKiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cácLuậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNguoiDung = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLuat = new System.Windows.Forms.Label();
            this.lbsoluongsanpham = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSuKien = new System.Windows.Forms.Label();
            this.lbsoluongkhachhang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btPrevious = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picImageSlideShow = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSlideShow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomePage,
            this.quảnLýHệThốngToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.Page,
            this.eventThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomePage
            // 
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(96, 41);
            this.HomePage.Text = "Trang Chủ";
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // quảnLýHệThốngToolStripMenuItem
            // 
            this.quảnLýHệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLyNguoiDung});
            this.quảnLýHệThốngToolStripMenuItem.Name = "quảnLýHệThốngToolStripMenuItem";
            this.quảnLýHệThốngToolStripMenuItem.Size = new System.Drawing.Size(154, 41);
            this.quảnLýHệThốngToolStripMenuItem.Text = "Quản Lý Hệ Thống";
            // 
            // QuanLyNguoiDung
            // 
            this.QuanLyNguoiDung.Name = "QuanLyNguoiDung";
            this.QuanLyNguoiDung.Size = new System.Drawing.Size(231, 26);
            this.QuanLyNguoiDung.Text = "Quản lý người dùng";
            this.QuanLyNguoiDung.Click += new System.EventHandler(this.QuanLyNguoiDung_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RollbackLogin,
            this.RollbackLogout,
            this.RollbackRegistration});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(94, 41);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // RollbackLogin
            // 
            this.RollbackLogin.Name = "RollbackLogin";
            this.RollbackLogin.Size = new System.Drawing.Size(166, 26);
            this.RollbackLogin.Text = "Đăng nhập";
            this.RollbackLogin.Click += new System.EventHandler(this.RollbackLogin_Click);
            // 
            // RollbackLogout
            // 
            this.RollbackLogout.Name = "RollbackLogout";
            this.RollbackLogout.Size = new System.Drawing.Size(166, 26);
            this.RollbackLogout.Text = "Đăng xuất";
            this.RollbackLogout.Click += new System.EventHandler(this.RollbackLogout_Click);
            // 
            // RollbackRegistration
            // 
            this.RollbackRegistration.Name = "RollbackRegistration";
            this.RollbackRegistration.Size = new System.Drawing.Size(166, 26);
            this.RollbackRegistration.Text = "Đăng ký";
            this.RollbackRegistration.Click += new System.EventHandler(this.RollbackRegistration_Click);
            // 
            // Page
            // 
            this.Page.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triệuChứngBệnhToolStripMenuItem,
            this.chuẩnĐoánBệnhToolStripMenuItem,
            this.sựKiệnToolStripMenuItem,
            this.cácLuậtToolStripMenuItem});
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(101, 41);
            this.Page.Text = "Chuyên gia";
            // 
            // triệuChứngBệnhToolStripMenuItem
            // 
            this.triệuChứngBệnhToolStripMenuItem.Name = "triệuChứngBệnhToolStripMenuItem";
            this.triệuChứngBệnhToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.triệuChứngBệnhToolStripMenuItem.Text = "Triệu chứng bệnh";
            this.triệuChứngBệnhToolStripMenuItem.Click += new System.EventHandler(this.triệuChứngBệnhToolStripMenuItem_Click);
            // 
            // chuẩnĐoánBệnhToolStripMenuItem
            // 
            this.chuẩnĐoánBệnhToolStripMenuItem.Name = "chuẩnĐoánBệnhToolStripMenuItem";
            this.chuẩnĐoánBệnhToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.chuẩnĐoánBệnhToolStripMenuItem.Text = "Chuẩn đoán bệnh";
            this.chuẩnĐoánBệnhToolStripMenuItem.Click += new System.EventHandler(this.chuẩnĐoánBệnhToolStripMenuItem_Click);
            // 
            // sựKiệnToolStripMenuItem
            // 
            this.sựKiệnToolStripMenuItem.Name = "sựKiệnToolStripMenuItem";
            this.sựKiệnToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.sựKiệnToolStripMenuItem.Text = "Sự kiện";
            this.sựKiệnToolStripMenuItem.Click += new System.EventHandler(this.sựKiệnToolStripMenuItem_Click);
            // 
            // cácLuậtToolStripMenuItem
            // 
            this.cácLuậtToolStripMenuItem.Name = "cácLuậtToolStripMenuItem";
            this.cácLuậtToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.cácLuậtToolStripMenuItem.Text = "Các luật";
            this.cácLuậtToolStripMenuItem.Click += new System.EventHandler(this.cácLuậtToolStripMenuItem_Click);
            // 
            // eventThoat
            // 
            this.eventThoat.Name = "eventThoat";
            this.eventThoat.Size = new System.Drawing.Size(63, 41);
            this.eventThoat.Text = "Thoát";
            this.eventThoat.Click += new System.EventHandler(this.eventThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.lbNguoiDung);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lượng người dùng";
            // 
            // lbNguoiDung
            // 
            this.lbNguoiDung.AutoSize = true;
            this.lbNguoiDung.Location = new System.Drawing.Point(51, 32);
            this.lbNguoiDung.Name = "lbNguoiDung";
            this.lbNguoiDung.Size = new System.Drawing.Size(0, 17);
            this.lbNguoiDung.TabIndex = 10;
            this.lbNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "more info";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.Red;
            this.lbUserName.Location = new System.Drawing.Point(12, 56);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(0, 19);
            this.lbUserName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox2.Controls.Add(this.lbLuat);
            this.groupBox2.Controls.Add(this.lbsoluongsanpham);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(276, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 93);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng luật";
            // 
            // lbLuat
            // 
            this.lbLuat.AutoSize = true;
            this.lbLuat.Location = new System.Drawing.Point(48, 32);
            this.lbLuat.Name = "lbLuat";
            this.lbLuat.Size = new System.Drawing.Size(0, 17);
            this.lbLuat.TabIndex = 11;
            this.lbLuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbsoluongsanpham
            // 
            this.lbsoluongsanpham.AutoSize = true;
            this.lbsoluongsanpham.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsoluongsanpham.ForeColor = System.Drawing.Color.White;
            this.lbsoluongsanpham.Location = new System.Drawing.Point(62, 62);
            this.lbsoluongsanpham.Name = "lbsoluongsanpham";
            this.lbsoluongsanpham.Size = new System.Drawing.Size(75, 18);
            this.lbsoluongsanpham.TabIndex = 10;
            this.lbsoluongsanpham.Text = "more info";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Orange;
            this.groupBox3.Controls.Add(this.lbSuKien);
            this.groupBox3.Controls.Add(this.lbsoluongkhachhang);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(526, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 93);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Số lượng sự kiện";
            // 
            // lbSuKien
            // 
            this.lbSuKien.AutoSize = true;
            this.lbSuKien.Location = new System.Drawing.Point(35, 32);
            this.lbSuKien.Name = "lbSuKien";
            this.lbSuKien.Size = new System.Drawing.Size(0, 17);
            this.lbSuKien.TabIndex = 12;
            this.lbSuKien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbsoluongkhachhang
            // 
            this.lbsoluongkhachhang.AutoSize = true;
            this.lbsoluongkhachhang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsoluongkhachhang.ForeColor = System.Drawing.Color.White;
            this.lbsoluongkhachhang.Location = new System.Drawing.Point(60, 62);
            this.lbsoluongkhachhang.Name = "lbsoluongkhachhang";
            this.lbsoluongkhachhang.Size = new System.Drawing.Size(75, 18);
            this.lbsoluongkhachhang.TabIndex = 11;
            this.lbsoluongkhachhang.Text = "more info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 678);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hệ Chuyên Gia - D13CNPM5";
            // 
            // btPrevious
            // 
            this.btPrevious.BackColor = System.Drawing.Color.Black;
            this.btPrevious.FlatAppearance.BorderSize = 0;
            this.btPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrevious.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrevious.ForeColor = System.Drawing.Color.White;
            this.btPrevious.Location = new System.Drawing.Point(189, 593);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(100, 33);
            this.btPrevious.TabIndex = 10;
            this.btPrevious.Text = "Prebvious";
            this.btPrevious.UseVisualStyleBackColor = false;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColor = System.Drawing.Color.Orange;
            this.btnOpenFolder.FlatAppearance.BorderSize = 0;
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolder.Location = new System.Drawing.Point(295, 593);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(125, 33);
            this.btnOpenFolder.TabIndex = 11;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(423, 593);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 33);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Red;
            this.btnstart.FlatAppearance.BorderSize = 0;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.White;
            this.btnstart.Location = new System.Drawing.Point(189, 632);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(320, 32);
            this.btnstart.TabIndex = 13;
            this.btnstart.Text = "Start Slide Show";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picImageSlideShow
            // 
            this.picImageSlideShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImageSlideShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImageSlideShow.Image = ((System.Drawing.Image)(resources.GetObject("picImageSlideShow.Image")));
            this.picImageSlideShow.Location = new System.Drawing.Point(16, 165);
            this.picImageSlideShow.Name = "picImageSlideShow";
            this.picImageSlideShow.Size = new System.Drawing.Size(696, 409);
            this.picImageSlideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageSlideShow.TabIndex = 14;
            this.picImageSlideShow.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 701);
            this.Controls.Add(this.picImageSlideShow);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laptop Sales Management System";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSlideShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomePage;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RollbackLogin;
        private System.Windows.Forms.ToolStripMenuItem RollbackLogout;
        private System.Windows.Forms.ToolStripMenuItem RollbackRegistration;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem eventThoat;
        private System.Windows.Forms.ToolStripMenuItem Page;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbsoluongsanpham;
        private System.Windows.Forms.Label lbsoluongkhachhang;
        private System.Windows.Forms.Label lbNguoiDung;
        private System.Windows.Forms.Label lbLuat;
        private System.Windows.Forms.Label lbSuKien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picImageSlideShow;
        private System.Windows.Forms.ToolStripMenuItem triệuChứngBệnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuẩnĐoánBệnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sựKiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cácLuậtToolStripMenuItem;
    }
}