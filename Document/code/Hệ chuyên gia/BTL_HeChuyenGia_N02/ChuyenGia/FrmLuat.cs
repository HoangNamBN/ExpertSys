using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTL_HeChuyenGia_N02.ThuVien;

namespace BTL_HeChuyenGia_N02.ChuyenGia
{
    public partial class FrmLuat : Form
    {
        private XuLyDuLieu objXldl;
        private DataTable dtLuat;
        private DataTable dtSuKien;
        private int cheDo;
        private String maLuat;
        private FrmChonSuKien frmChonSuKien;

        public FrmLuat()
        {
            InitializeComponent();

            objXldl = new XuLyDuLieu();
            dtSuKien = objXldl.LayDt("Select MaSuKien, TenSuKien From SuKien Where MaSuKien = 0");
            dtSuKien.Columns.Add(new DataColumn("HeSoTinCay"));
            cheDo = 0;
        }

        public void HienThiLuat()
        {
            dtLuat = objXldl.LayDt("Select MaLuat, TenLuat, HeSoTinCay From Luat");
            dtLuat.Columns.Add(new DataColumn("CacSuKien"));
            dgvLuat.DataSource = dtLuat;
            foreach (DataRow row in dtLuat.Rows)
            {
                DataTable dtCacSuKien = objXldl.LayDt("Select s.MaSuKien, TenSuKien, HeSoTinCay From SuKien s Inner Join LuatSuKien lsk On " +
                    "s.MaSuKien = lsk.MaSuKien Where MaLuat = " + row[0].ToString());
                String cacSuKien = "";
                for (int i = 0; i < dtCacSuKien.Rows.Count; i++)
                {
                    cacSuKien+=dtCacSuKien.Rows[i][1].ToString() + " (" + dtCacSuKien.Rows[i][2] + ")";
                    if (i < dtCacSuKien.Rows.Count - 1)
                    {
                        cacSuKien += "\r\n";
                    }
                }
                row[3] = cacSuKien;
            }
            dgvLuat.Columns[0].Width = 95;
            dgvLuat.Columns[1].Width = 500;
            dgvLuat.Columns[0].HeaderText = "Mã luật";
            dgvLuat.Columns[1].HeaderText = "Tên luật";
            dgvLuat.Columns[2].HeaderText = "Hệ số tin cậy";
            dgvLuat.Columns[3].Visible = false;
            txtTenLuat.DataBindings.Clear();
            txtSuKien.DataBindings.Clear();
            txtTenLuat.DataBindings.Add("text", dtLuat, "TenLuat", false, DataSourceUpdateMode.Never);
            txtSuKien.DataBindings.Add("text", dtLuat, "CacSuKien", false, DataSourceUpdateMode.Never);
        }

        private void FrmLuat_Load(object sender, EventArgs e)
        {
            HienThiLuat();
            txtTimKiem_TextChanged(sender, e);
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
                txtTenLuat.ReadOnly = true;
                btnChonSuKien.Enabled = false;
                if (dgvLuat.Rows.Count < 1)
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
                txtTenLuat.ReadOnly = false;
                btnChonSuKien.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cheDo = 1;
            ThietLapTTCacControl();
            txtTenLuat.Text = "";
            txtSuKien.Text = "";
            txtTenLuat.Focus();
        }

        private void dgvLuat_SelectionChanged(object sender, EventArgs e)
        {
            cheDo = 0;
            ThietLapTTCacControl();
            try
            {
                int dong = dgvLuat.CurrentRow.Index;
                maLuat = dgvLuat.Rows[dong].Cells[0].Value.ToString();
            }
            catch
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnChonSuKien_Click(object sender, EventArgs e)
        {
            if (cheDo == 1)
            {
                frmChonSuKien = new FrmChonSuKien(null);
            }
            else
            {
                frmChonSuKien = new FrmChonSuKien(dtSuKien);
            }
            frmChonSuKien.MyEvent += new MyDelegate(frmChonSuKien_MyEvent);
            frmChonSuKien.ShowDialog();
        }

        private void frmChonSuKien_MyEvent(object sender, MyEventArgs e)
        {
            dtSuKien = e.Dt;
            String cacSuKien = "";
            for (int i = 0; i < dtSuKien.Rows.Count; i++)
            {
                cacSuKien += dtSuKien.Rows[i][1].ToString() + " (" + dtSuKien.Rows[i][2] + ")";
                if (i < dtSuKien.Rows.Count - 1)
                {
                    cacSuKien += "\r\n";
                }
            }
            txtSuKien.Text = cacSuKien;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dtSuKien = objXldl.LayDt("Select s.MaSuKien, TenSuKien, HeSoTinCay From SuKien s Inner Join LuatSuKien lsk On " +
                    "s.MaSuKien = lsk.MaSuKien Where MaLuat = " + maLuat);
                cheDo = 2;
                ThietLapTTCacControl();
            }
            catch
            { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                String strSql, tb;
                if (cheDo == 1)
                {
                    strSql = "Insert Into Luat(TenLuat) Values(N'" + txtTenLuat.Text + "')";
                    tb = "Thêm thành công";
                }
                else
                {
                    strSql = "Update Luat Set TenLuat = N'" + txtTenLuat.Text + "' Where MaLuat = " + maLuat;
                    tb = "Sửa thành công";
                }
                if (objXldl.ThucHienCauLenh(strSql))
                {
                    if (cheDo == 2)
                    {
                        objXldl.ThucHienCauLenh("Delete From LuatSuKien Where MaLuat = " + maLuat);
                    }
                    else
                    {
                        maLuat = objXldl.LenhVoHuong("Select IDENT_CURRENT('Luat')").ToString();
                    }
                    foreach (DataRow row in dtSuKien.Rows)
                    {
                        objXldl.ThucHienCauLenh("Insert Into LuatSuKien(MaSuKien, MaLuat, HeSoTinCay) Values(" + 
                            row[0].ToString() + ", " + maLuat + ", " + row[2].ToString() + ")");
                    }
                    MessageBox.Show(tb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + objXldl.Loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtLuat.DefaultView.RowFilter = "TenLuat Like '%" + txtTimKiem.Text + "%'";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa luật này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    objXldl.ThucHienCauLenh("Delete From LuatSuKien Where MaLuat = " + maLuat);
                    objXldl.ThucHienCauLenh("Delete From Luat Where MaLuat = " + maLuat);
                    MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLuat_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
