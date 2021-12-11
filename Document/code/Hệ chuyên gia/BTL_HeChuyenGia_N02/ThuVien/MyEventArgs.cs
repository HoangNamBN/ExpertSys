using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BTL_HeChuyenGia_N02.ThuVien
{
    public delegate void MyDelegate(object sender, MyEventArgs e);

    public class MyEventArgs : EventArgs
    {
        private float heSoTinCay;
        public float HeSoTinCay
        {
            get { return heSoTinCay; }
            set { heSoTinCay = value; }
        }

        private DataTable dt;
        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }

    }
}
