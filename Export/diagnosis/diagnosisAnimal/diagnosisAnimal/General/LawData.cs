using System;
using System.Collections.Generic;

namespace diagnosisAnimal.General
{
    class LawData : IComparable<LawData>
    {

        #region Thuộc tính
        private int idLaw;
        private String nameLaw;
        private Dictionary<String, float> enVent;
        private float heSoTinCay;
        private float heSoKhongTinCay;
        #endregion

        #region Contructor, Get, Set
        public int IdLaw { get => idLaw; set => idLaw = value; }
        public string NameLaw { get => nameLaw; set => nameLaw = value; }
        public float HeSoTinCay { get => heSoTinCay; set => heSoTinCay = value; }
        public float HeSoKhongTinCay { get => heSoKhongTinCay; set => heSoKhongTinCay = value; }
        public Dictionary<string, float> EnVent { get => enVent; set => enVent = value; }

        public LawData(int idLaw, string nameLaw, Dictionary<string, float> enVent)
        {
            this.idLaw = idLaw;
            this.nameLaw = nameLaw;
            this.enVent = enVent;
            this.heSoKhongTinCay = 0;
            this.heSoTinCay = 0;
        }

        #endregion

        public int CompareTo(LawData other)
        {
            return -this.heSoTinCay.CompareTo(other.heSoTinCay);
        }
    }
}
