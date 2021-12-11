using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTL_HeChuyenGia_N02.ThuVien;

namespace BTL_HeChuyenGia_N02.ChuyenGia
{
    public partial class UCtrlTrieuChungThuongGapNhat : UserControl
    {
        private XuLyDuLieu objXldl;
        private DataTable dtTrieuChung;

        public int getTrieuChungThuongGapNhat()
        {
            try
            {
                return (int)cboTrieuChungThuongGapNhat.SelectedValue;
            }
            catch
            {
                return 0;
            }
        }

        public UCtrlTrieuChungThuongGapNhat()
        {
            InitializeComponent();

            objXldl = new XuLyDuLieu();
        }

        public void HienThiTrieuChung()
        {
            dtTrieuChung = objXldl.LayDt("Select MaSuKien, TenSuKien From SuKien");
            cboTrieuChungThuongGapNhat.DataSource = dtTrieuChung;
            cboTrieuChungThuongGapNhat.DisplayMember = "TenSuKien";
            cboTrieuChungThuongGapNhat.ValueMember = "MaSuKien";
        }

        private void UCtrlTrieuChungThuongGapNhat_Load(object sender, EventArgs e)
        {
            HienThiTrieuChung();
        }
    }
}
