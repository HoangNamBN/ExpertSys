using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using BTL_HeChuyenGia_N02.ChuyenGia;
using BTL_HeChuyenGia_N02.ThuVien;

namespace BTL_HeChuyenGia_N02.HeThong
{
    public partial class FrmGiaoDienChinh : Form
    {
        // Khai báo các biến thành viên
        private DockPanel dockPanel;
        private FrmTrieuChungBenh frmTrieuChungBenh;
        private FrmChuanDoanBenh frmChuanDoanBenh;
        private FrmDangNhap frmDangNhap;

        // Cấu tử
        public FrmGiaoDienChinh()
        {
            InitializeComponent();

            // Khởi tạo các biến thành viên chưa được khởi tạo trong phương thức InitializeComponent()
            this.Size = new Size(780, 500);
            dockPanel = new DockPanel();
            frmTrieuChungBenh = new FrmTrieuChungBenh();
        }

        // Sự kiện lúc form được load
        private void FrmGiaoDienChinh_Load(object sender, EventArgs e)
        {
            // Hiển thị panel chứa các triệu chứng bệnh ở phía bên trái
            dockPanel.DocumentStyle = DocumentStyle.DockingWindow;
            dockPanel.Dock = DockStyle.Fill;
            dockPanel.DockLeftPortion = 200;
            dockPanel.DockBottomPortion = 200;
            pnlChinh.Controls.Add(dockPanel);

            frmTrieuChungBenh.FormClosed += new FormClosedEventHandler(frmTrieuChungBenh_FormClosed);
            frmTrieuChungBenh.Show(dockPanel, DockState.DockLeft);
        }

        private void mnuItemChuanDoanBenh_Click(object sender, EventArgs e)
        {
            if (frmChuanDoanBenh == null)
            {
                frmChuanDoanBenh = new FrmChuanDoanBenh();
                frmChuanDoanBenh.FormClosed+=new FormClosedEventHandler(frmChuanDoanBenh_FormClosed);
                frmChuanDoanBenh.Show(dockPanel, DockState.Document);
            }
            else
                frmChuanDoanBenh.Activate();
        }

        private void frmChuanDoanBenh_FormClosed(object sender, EventArgs e)
        {
            frmChuanDoanBenh = null;
        }

        private void mnuItemTrieuChungBenh_Click(object sender, EventArgs e)
        {
            if (frmTrieuChungBenh == null)
            {
                frmTrieuChungBenh = new FrmTrieuChungBenh();
                frmTrieuChungBenh.FormClosed += new FormClosedEventHandler(frmTrieuChungBenh_FormClosed);
                frmTrieuChungBenh.Show(dockPanel, DockState.DockLeft);
            }
            else
                frmTrieuChungBenh.Activate();
        }

        private void frmTrieuChungBenh_FormClosed(object sender, EventArgs e)
        {
            frmTrieuChungBenh = null;
        }

        private void mnuItemSuKien_Click(object sender, EventArgs e)
        {
            FrmSuKien frmSuKien = new FrmSuKien();
            frmSuKien.ShowDialog();
        }

        private void mnuItemLuat_Click(object sender, EventArgs e)
        {
            FrmLuat frmLuat = new FrmLuat();
            frmLuat.ShowDialog();
        }

        private void mnuItemQuanTriNguoiDung_Click(object sender, EventArgs e)
        {
            FrmQuanTriNguoiDung frmQuanTriNguoiDung = new FrmQuanTriNguoiDung();
            frmQuanTriNguoiDung.ShowDialog();
        }

        private void mnuItemDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap = new FrmDangNhap();
            frmDangNhap.MyEvent += new MyDelegate(frmDangNhap_MyEvent);
            frmDangNhap.ShowDialog();
        }

        private void frmDangNhap_MyEvent(object sender, BTL_HeChuyenGia_N02.ThuVien.MyEventArgs e)
        {
            if (e.Dt != null)
            {
                String quyen = e.Dt.Rows[0][2].ToString();
                lblTrangThai.Text = "Người đăng nhập: " + e.Dt.Rows[0][1].ToString() + "    Quyền: " + quyen;
                mnuItemDangNhap.Visible = false;
                mnuItemDangXuat.Visible = true;
                mnuItemSuKien.Visible = true;
                mnuItemLuat.Visible = true;
                if (quyen == "Quản trị viên")
                {
                    mnuItemQuanTriNguoiDung.Visible = true;
                }
            }
        }

        private void mnuItemDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                mnuItemDangNhap.Visible = true;
                mnuItemDangXuat.Visible = false;
                mnuItemSuKien.Visible = false;
                mnuItemLuat.Visible = false;
                mnuItemQuanTriNguoiDung.Visible = false;
                lblTrangThai.Text = "Chưa đăng nhập";
            }
        }

        private void mnuItemThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
