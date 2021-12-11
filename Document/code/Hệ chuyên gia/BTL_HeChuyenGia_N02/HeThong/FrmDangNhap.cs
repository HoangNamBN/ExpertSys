using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTL_HeChuyenGia_N02.ThuVien;

namespace BTL_HeChuyenGia_N02.HeThong
{
    public partial class FrmDangNhap : Form
    {
        private XuLyDuLieu objXldl;
        private DataTable dtNguoiDung;
        public event MyDelegate MyEvent;

        public FrmDangNhap()
        {
            InitializeComponent();

            objXldl = new XuLyDuLieu();
            dtNguoiDung = null;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dtNguoiDung = objXldl.LayDt("Select ID, HoTen, Case Quyen When 0 Then N'Chuyên gia' When 1 Then " + 
                "N'Quản trị viên' End As 'Quyen' From NguoiDung Where TenDangNhap = '" + txtTaiKhoan.Text +
                "' And MatKhau = '" + txtMatKhau.Text + "'");
            if (dtNguoiDung.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                dtNguoiDung = null;
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MyEvent != null)
            {
                MyEvent(this, new MyEventArgs { Dt = dtNguoiDung});
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
