using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTL_HeChuyenGia_N02.ChuyenGia
{
    public partial class UCtrlThongTinBoSung : UserControl
    {
        public Label LblCauHoi
        {
            get { return lblCauHoi; }
            set { lblCauHoi = value; }
        }

        public RadioButton RadCo
        {
            get { return radCo; }
            set { radCo = value; }
        }

        public RadioButton RadKhong
        {
            get { return radKhong; }
            set { radKhong = value; }
        }

        public UCtrlThongTinBoSung()
        {
            InitializeComponent();
        }
    }
}
