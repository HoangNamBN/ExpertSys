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
    public partial class FrmQuanTriNguoiDung : Form
    {
        private XuLyDuLieu objXldl;
        private DataTable dtNguoiDung;
        private int cheDo;
        private String id;

        public FrmQuanTriNguoiDung()
        {
            InitializeComponent();

            objXldl = new XuLyDuLieu();
            cboQuyen.SelectedIndex = 0;
            cheDo = 0;
        }

        public void HienThiNguoiDung()
        {
            dtNguoiDung = objXldl.LayDt("Select ID, TenDangNhap, MatKhau, HoTen, Case Quyen When 0 Then N'Chuyên gia' When 1 Then " + 
                "N'Quản trị viên' End As 'Quyen' From NguoiDung");
            dgvNguoiDung.DataSource = dtNguoiDung;
            dgvNguoiDung.Columns[0].HeaderText = "ID";
            dgvNguoiDung.Columns[0].Width = 50;
            dgvNguoiDung.Columns[1].HeaderText = "Tên đăng nhập";
            dgvNguoiDung.Columns[2].HeaderText = "Mật khẩu";
            dgvNguoiDung.Columns[3].HeaderText = "Họ tên";
            dgvNguoiDung.Columns[4].HeaderText = "Quyền";
            dgvNguoiDung.Columns[4].Width = 120;

            txtTenDangNhap.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            cboQuyen.DataBindings.Clear();

            txtTenDangNhap.DataBindings.Add("text", dtNguoiDung, "TenDangNhap", false, DataSourceUpdateMode.Never);
            txtMatKhau.DataBindings.Add("text", dtNguoiDung, "MatKhau", false, DataSourceUpdateMode.Never);
            txtHoTen.DataBindings.Add("text", dtNguoiDung, "HoTen", false, DataSourceUpdateMode.Never);
            cboQuyen.DataBindings.Add("text", dtNguoiDung, "Quyen", false, DataSourceUpdateMode.Never);
        }

        private void FrmQuanTriNguoiDung_Load(object sender, EventArgs e)
        {
            HienThiNguoiDung();
            ThietLapTTCacControl();
        }

        public void ThietLapTTCacControl()
        {
            if (cheDo == 0)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                txtTenDangNhap.ReadOnly = true;
                txtMatKhau.ReadOnly = true;
                txtHoTen.ReadOnly = true;
                cboQuyen.Enabled = false;
                if (dgvNguoiDung.Rows.Count < 1)
                {
                    btnSua.Enabled = false;
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                txtTenDangNhap.ReadOnly = false;
                txtMatKhau.ReadOnly = false;
                txtHoTen.ReadOnly = false;
                cboQuyen.Enabled = true;
            }
        }

        public bool KiemTraTenDangNhap()
        {
            bool kq = true;
            if (txtTenDangNhap.Text.Trim().Length < 10 || txtTenDangNhap.Text.Trim().Length > 50)
            {
                kq = false;
                err.SetError(txtTenDangNhap, "Tên đăng nhập chưa đúng");
            }
            else
            {
                err.SetError(txtTenDangNhap, "");
            }
            return kq;
        }

        public bool KiemTraMatKhau()
        {
            bool kq = true;
            if (txtMatKhau.Text.Trim().Length < 6 || txtMatKhau.Text.Trim().Length > 30)
            {
                kq = false;
                err.SetError(txtMatKhau, "Mật khẩu chưa đúng");
            }
            else
            {
                err.SetError(txtMatKhau, "");
            }
            return kq;
        }

        public bool KiemTraHoTen()
        {
            bool kq = true;
            if (txtHoTen.Text.Trim().Length < 1)
            {
                kq = false;
                err.SetError(txtHoTen, "Họ tên không được để trống");
            }
            else
            {
                err.SetError(txtHoTen, "");
            }
            return kq;
        }

        public bool KiemTraToanBo()
        {
            bool kq = true;
            if (cheDo != 0)
            {
                kq = KiemTraTenDangNhap() & KiemTraMatKhau() & KiemTraHoTen();
                btnLuu.Enabled = kq;
            }
            return kq;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cheDo = 1;
            ThietLapTTCacControl();
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtHoTen.Text = "";
            cboQuyen.SelectedIndex = 0;
            KiemTraToanBo();
            txtTenDangNhap.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                String strSql, tb;
                if (cheDo == 1)
                {
                    strSql = "Insert Into NguoiDung Values('" + txtTenDangNhap.Text.Trim() + "', '" + txtMatKhau.Text.Trim() + "', N'" +
                        txtHoTen.Text.Trim() + "', " + cboQuyen.SelectedIndex + ")";
                    tb = "Thêm thành công";
                }
                else
                {
                    strSql = "Update NguoiDung Set TenDangNhap = '" + txtTenDangNhap.Text.Trim() + "', MatKhau = '" + txtMatKhau.Text.Trim() +
                        "', HoTen = N'" + txtHoTen.Text.Trim() + "', Quyen = " + cboQuyen.SelectedIndex + " Where ID = " + id;
                    tb = "Sửa thành công";
                }
                if (objXldl.ThucHienCauLenh(strSql))
                {
                    MessageBox.Show(tb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cheDo = 0;
                    FrmQuanTriNguoiDung_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + objXldl.Loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            KiemTraToanBo();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            KiemTraToanBo();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            KiemTraToanBo();
        }

        private void dgvNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            cheDo = 0;
            ThietLapTTCacControl();
            try
            {
                int dong = dgvNguoiDung.CurrentRow.Index;
                id = dgvNguoiDung.Rows[dong].Cells[0].Value.ToString();
            }
            catch
            {
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cheDo = 2;
            ThietLapTTCacControl();
            txtTenDangNhap.Focus();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtNguoiDung.DefaultView.RowFilter = "HoTen Like '%" + txtTimKiem.Text + "%'";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    if (objXldl.ThucHienCauLenh("Delete From NguoiDung Where ID = " + id))
                    {
                        MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmQuanTriNguoiDung_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + objXldl.Loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
