using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using BTL_HeChuyenGia_N02.ThuVien;

namespace BTL_HeChuyenGia_N02.ChuyenGia
{
    public partial class FrmTrieuChungBenh : DockContent
    {
        private XuLyDuLieu objXldl;
        private DataTable dtSuKien;

        public FrmTrieuChungBenh()
        {
            InitializeComponent();

            objXldl = new XuLyDuLieu();
        }

        public void HienThiTrieuChung()
        {
            dtSuKien = objXldl.LayDt("Select TenSuKien From SuKien");
            lstSuKien.DataSource = dtSuKien;
            lstSuKien.DisplayMember = "TenSuKien";
        }

        private void FrmTrieuChungBenh_Load(object sender, EventArgs e)
        {
            HienThiTrieuChung();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtSuKien.DefaultView.RowFilter = "TenSuKien Like '%" + txtTimKiem.Text + "%'";
        }

    }
}
