using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTL_HeChuyenGia_N02.ThuVien
{
    class Luat : IComparable<Luat>
    {
        private int maLuat;
        public int MaLuat
        {
            get { return maLuat; }
            set { maLuat = value; }
        }

        private String tenLuat;
        public String TenLuat
        {
            get { return tenLuat; }
            set { tenLuat = value; }
        }

        private float heSoTinCay;
        public float HeSoTinCay
        {
            get { return heSoTinCay; }
            set { heSoTinCay = value; }
        }

        private float heSoKhongTinCay;
        public float HeSoKhongTinCay
        {
            get { return heSoKhongTinCay; }
            set { heSoKhongTinCay = value; }
        }

        private Dictionary<String, float> suKien;
        public Dictionary<String, float> SuKien
        {
            get { return suKien; }
            set { suKien = value; }
        }

        public Luat(int maLuat, String tenLuat, Dictionary<String, float> suKien)
        {
            this.maLuat = maLuat;
            this.tenLuat = tenLuat;
            this.suKien = suKien;
            this.HeSoTinCay = 0;
            this.HeSoKhongTinCay = 0;
        }

        public int CompareTo(Luat other)
        {
            return -this.HeSoTinCay.CompareTo(other.HeSoTinCay);
        }

    }
}
