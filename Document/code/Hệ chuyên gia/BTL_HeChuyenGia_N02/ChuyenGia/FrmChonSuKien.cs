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
    public partial class FrmChonSuKien : Form
    {
        private XuLyDuLieu objXldl;
        private DataTable dtSuKien;
        private DataTable dtSuKienDaChon;
        private FrmNhapHeSoTinCay frmNhapHeSoTinCay;
        private float heSo;
        public event MyDelegate MyEvent;

        public FrmChonSuKien(DataTable dtSuKienDaChon)
        {
            InitializeComponent();

            objXldl = new XuLyDuLieu();
            if (dtSuKienDaChon == null)
            {
                dtSuKienDaChon = objXldl.LayDt("Select MaSuKien, TenSuKien From SuKien Where MaSuKien = 0");
                dtSuKienDaChon.Columns.Add(new DataColumn("HeSoTinCay", typeof(float)));
            }
                
            this.dtSuKienDaChon = dtSuKienDaChon;
        }

        public void HienThiSuKien()
        {
            dgvSuKienDaChon.DataSource = dtSuKienDaChon;
            dgvSuKienDaChon.Columns[0].Visible = false;
            dgvSuKienDaChon.Columns[1].HeaderText = "Tên sự kiện";
            dgvSuKienDaChon.Columns[2].HeaderText = "Hệ số tin cậy";
            dgvSuKienDaChon.Columns[1].Width = 200;
            dtSuKien = objXldl.LayDt("Select MaSuKien, TenSuKien From SuKien");
            LapDeXoa:
            foreach (DataRow row1 in dtSuKien.Rows)
            {
                foreach (DataRow row2 in dtSuKienDaChon.Rows)
                {
                    if(row1[0].ToString()==row2[0].ToString())
                    {
                        dtSuKien.Rows.Remove(row1);
                        goto LapDeXoa;
                    }
                }
            }
            dgvSuKien.DataSource = dtSuKien;
            dgvSuKien.Columns[0].Visible = false;
            dgvSuKien.Columns[1].HeaderText = "Tên sự kiện";
        }

        private void FrmChonSuKien_Load(object sender, EventArgs e)
        {
            HienThiSuKien();
            dgvSuKien_SelectionChanged(sender, e);
            dgvSuKienDaChon_SelectionChanged(sender, e);
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void dgvSuKien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvSuKien.CurrentRow.Index;
                btnThem.Enabled = true;
            }
            catch
            {
                btnThem.Enabled = false;
            }
        }

        private void dgvSuKienDaChon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvSuKienDaChon.CurrentRow.Index;
                btnXoa.Enabled = true;
            }
            catch
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvSuKien.CurrentRow.Index;
                heSo = 0;
                frmNhapHeSoTinCay = new FrmNhapHeSoTinCay();
                frmNhapHeSoTinCay.MyEvent += new MyDelegate(frmNhapHeSoTinCay_MyEvent);
                frmNhapHeSoTinCay.ShowDialog();
                if (heSo <= 0)
                    return;
                float tongHeSo = heSo;
                foreach (DataRow row1 in dtSuKienDaChon.Rows)
                {
                    tongHeSo += float.Parse(row1[2].ToString());
                }
                if (tongHeSo > 1)
                {
                    MessageBox.Show("Tổng hệ số tin cậy không được lớn hơn 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataRow row = dtSuKienDaChon.NewRow();
                for (int i = 0; i < 2; i++)
                {
                    row[i] = dgvSuKien.Rows[dong].Cells[i].Value.ToString();
                }
                row[2] = heSo;
                dtSuKienDaChon.Rows.Add(row);
                FrmChonSuKien_Load(sender, e);
            }
            catch
            { }
        }

        private void frmNhapHeSoTinCay_MyEvent(object sender, MyEventArgs e)
        {
            heSo = e.HeSoTinCay;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvSuKienDaChon.CurrentRow.Index;
                dtSuKienDaChon.Rows.RemoveAt(dong);
                FrmChonSuKien_Load(sender, e);
            }
            catch
            { }
        }

        private void FrmChonSuKien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MyEvent != null)
            {
                MyEvent(this, new MyEventArgs { Dt = dtSuKienDaChon});
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtSuKien.DefaultView.RowFilter = "TenSuKien Like '%" + txtTimKiem.Text + "%'";
        }

    }
}
