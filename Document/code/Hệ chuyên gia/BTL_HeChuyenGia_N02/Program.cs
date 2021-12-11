using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BTL_HeChuyenGia_N02.HeThong;
using BTL_HeChuyenGia_N02.ChuyenGia;

namespace BTL_HeChuyenGia_N02
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmGiaoDienChinh());
        }
    }
}
