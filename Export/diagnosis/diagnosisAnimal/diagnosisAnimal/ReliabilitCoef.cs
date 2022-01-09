using diagnosisAnimal.General;
using System;
using System.Windows.Forms;

namespace diagnosisAnimal
{
    public partial class ReliabilitCoef : Form
    {
        public event MyDelegate MyEvent;
        private bool coNhap;
        public ReliabilitCoef()
        {
            InitializeComponent();
        }

        private void ReliabilitCoef_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MyEvent != null && coNhap == true)
                MyEvent(this, new MyEventArgs { HeSoTinCay = float.Parse(txtHeSoTinCay.Text) });
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            float heSo;
            if (float.TryParse(txtHeSoTinCay.Text, out heSo))
            {
                coNhap = true;
                this.Close();
            }
            else MessageBox.Show("Bạn cần nhập chính xác hệ số tin cậy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
