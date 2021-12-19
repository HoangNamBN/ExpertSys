using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTL_HeChuyenGia_N02.ThuVien;
using System.Data.SqlClient;

namespace BTL_HeChuyenGia_N02.ChuyenGia
{
    public partial class FrmSuKien : Form
    {
        private XuLyDuLieu objXldl;
        private SqlDataAdapter daSuKien;
        private DataTable dtSuKien;
        private SqlCommandBuilder cb;
        int maSuKien, dong;

        public FrmSuKien()
        {
            InitializeComponent();

            objXldl = new XuLyDuLieu();
        }

        public void HienThiSuKien()
        {
            dtSuKien = new DataTable();
            daSuKien = objXldl.LayDa("Select MaSuKien, TenSuKien, CauHoi From SuKien");
            cb = new SqlCommandBuilder(daSuKien);
            daSuKien.Fill(dtSuKien);
            dgvSuKien.DataSource = dtSuKien;
            dgvSuKien.Columns[0].Width = 95;
            dgvSuKien.Columns[1].Width = 250;
            dgvSuKien.Columns[0].HeaderText = "Mã sự kiện";
            dgvSuKien.Columns[1].HeaderText = "Tên sự kiện";
            dgvSuKien.Columns[2].HeaderText = "Câu hỏi";
            dgvSuKien.Columns[0].ReadOnly = true;
        }

        private void FrmSuKien_Load(object sender, EventArgs e)
        {
            HienThiSuKien();
            txtTimKiem_TextChanged(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daSuKien.Update(dtSuKien);
                MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmSuKien_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lưu thất bại" + "\nLỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(dgvSuKien.Rows[dong].Cells[0].Value.ToString(), out maSuKien))
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sự kiện này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            dgvSuKien.Rows.RemoveAt(dong);
                            daSuKien.Update(dtSuKien);
                            MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmSuKien_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xóa thất bại" + "\nLỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    dgvSuKien.Rows.RemoveAt(dong); // Chỉ là dòng vừa mới thêm vào dgvSuKien chứ chưa thêm vào csdl nên chỉ xóa trên dgvSuKien thôi
            }
            catch
            { }
        }

        private void dgvSuKien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dong = dgvSuKien.CurrentRow.Index;
                if (dong > -1 && dong < dtSuKien.Rows.Count)
                    btnXoa.Enabled = true; // Nếu như có dòng được chọn thì cho phép xóa
                else
                    btnXoa.Enabled = false;
            }
            catch
            { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtSuKien.DefaultView.RowFilter = "TenSuKien Like '%" + txtTimKiem.Text + "%'";
        }

    }
}
