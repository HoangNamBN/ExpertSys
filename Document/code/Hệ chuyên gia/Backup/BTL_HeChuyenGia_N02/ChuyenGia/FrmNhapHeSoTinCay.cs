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
    public partial class FrmNhapHeSoTinCay : Form
    {
        public event MyDelegate MyEvent;
        private bool coNhap;

        public FrmNhapHeSoTinCay()
        {
            InitializeComponent();
        }

        private void FrmNhapHeSoTinCay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MyEvent != null && coNhap == true)
            {
                MyEvent(this, new MyEventArgs { HeSoTinCay = float.Parse(txtHeSoTinCay.Text) });
            }
                
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            float heSo;
            if (float.TryParse(txtHeSoTinCay.Text, out heSo))
            {
                coNhap = true;
                this.Close();
            }
            else
                MessageBox.Show("Bạn cần nhập chính xác hệ số tin cậy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
