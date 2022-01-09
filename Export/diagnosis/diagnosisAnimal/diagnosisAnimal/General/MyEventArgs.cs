using System;
using System.Data;

namespace diagnosisAnimal.General
{
    public delegate void MyDelegate(object sender, MyEventArgs e);
    public class MyEventArgs : EventArgs
    {
        private float heSoTinCay;
        private DataTable dataTable;

        public float HeSoTinCay { get => heSoTinCay; set => heSoTinCay = value; }
        public DataTable DataTableMyEvent { get => dataTable; set => dataTable = value; }
    }
}
