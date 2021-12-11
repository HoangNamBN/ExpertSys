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
    public partial class FrmChuanDoanBenh : DockContent
    {
        private XuLyDuLieu objXldl;
        private UCtrlTrieuChungThuongGapNhat uctrlTrieuChungThuongGapNhat;
        private UCtrlThongTinBoSung uctrlThongTinBoSung;
        private List<Luat> luat;
        private Dictionary<String, String> quaTrinhSuyDien;

        public FrmChuanDoanBenh()
        {
            InitializeComponent();

            objXldl = new XuLyDuLieu();
            uctrlTrieuChungThuongGapNhat = new UCtrlTrieuChungThuongGapNhat();
            uctrlThongTinBoSung = new UCtrlThongTinBoSung();
        }

        private void FrmChuanDoanBenh_Load(object sender, EventArgs e)
        {
            pnlCauHoi.Controls.Clear();
            luat = null;
            quaTrinhSuyDien = null;
            lblKetLuan.Text = "";
            lblQuaTrinhSuyDien.Text = "";
            uctrlThongTinBoSung.RadCo.Enabled = true;
            uctrlThongTinBoSung.RadKhong.Enabled = true;
            btnTiep.Enabled = true;
            btnKetThuc.Enabled = true;
            pnlCauHoi.Controls.Add(uctrlTrieuChungThuongGapNhat);
        }

        // Hàm thiết lập câu hỏi tiếp theo
        public void setCauHoi(String cauHoi)
        {
            uctrlThongTinBoSung.LblCauHoi.Text = cauHoi;
            uctrlThongTinBoSung.RadCo.Checked = true;
        }

        // Hàm được gọi khi kết thúc quá trình suy diễn (khi người dùng nhấn Kết thúc hoặc khi không còn câu hỏi nào
        // để hỏi nữa
        public void ketThucSuyDien()
        {
            btnTiep.Enabled = false;
            btnKetThuc.Enabled = false;
            uctrlThongTinBoSung.RadCo.Enabled = false;
            uctrlThongTinBoSung.RadKhong.Enabled = false;
            try
            {
                Luat tam = luat[0];
                bool khongtraloi = false;
                foreach (Luat item in luat)
                {
                    if (tam.HeSoTinCay < item.HeSoTinCay)
                        tam = item;
                }
                // Chỉ đưa ra kết luận về bệnh khi các thông tin thu thập được giúp cho một luật có hệ số tin cậy >= 0.6
                if (tam.HeSoTinCay >= 0.6f && tam.HeSoTinCay < 0.7f)
                {
                    lblKetLuan.Text = "Có thể bạn đã mắc ";
                }
                else if (tam.HeSoTinCay >= 0.7f && tam.HeSoTinCay < 0.8f)
                {
                    lblKetLuan.Text = "Rất có thể bạn đã mắc ";
                }
                else if (tam.HeSoTinCay >= 0.8f && tam.HeSoTinCay < 0.9f)
                {
                    lblKetLuan.Text = "Gần như chắc chắn bạn đã mắc ";
                }
                else if (tam.HeSoTinCay >= 0.9f)
                {
                    lblKetLuan.Text = "Chắc chắn bạn đã mắc ";
                }
                else
                {
                    lblKetLuan.Text = "Rất tiếc, hệ thống không đủ thông tin để kết luận bạn đã mắc bệnh gì";
                    khongtraloi = true;
                }
                if (khongtraloi == false)
                {
                    lblKetLuan.Text += tam.TenLuat;
                }
            }
            catch
            {
                lblKetLuan.Text = "Rất tiếc, hệ thống không đủ thông tin để kết luận bạn đã mắc bệnh gì";
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            // Bước đầu tiên, người dùng cần chọn triệu chứng mà họ thấy biểu hiện rõ nhất
            if (luat == null && quaTrinhSuyDien == null)
            {
                int tam = uctrlTrieuChungThuongGapNhat.getTrieuChungThuongGapNhat();
                if (tam == 0)
                {
                    MessageBox.Show("Bạn chưa chọn triệu chứng thường gặp nhất", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    DataTable suKienThoaMan = objXldl.LayDt("Select TenSuKien, CauHoi From SuKien Where MaSuKien = " + tam);
                    quaTrinhSuyDien = new Dictionary<String, String>();
                    quaTrinhSuyDien.Add(suKienThoaMan.Rows[0][1].ToString(), suKienThoaMan.Rows[0][0].ToString());
                    lblQuaTrinhSuyDien.Text = "";
                    String trieuChung = quaTrinhSuyDien.ElementAt(0).Value;
                    lblQuaTrinhSuyDien.Text = "Triệu chứng bạn chọn ban đầu: " + trieuChung;
                    luat = new List<Luat>();
                    // Lấy về các bệnh có biểu hiện triệu chứng người dùng vừa chọn (là bảng Luat trong cơ sở dữ liệu
                    DataTable dtLuatSuKien = objXldl.LayDt("Select Distinct MaLuat From LuatSuKien Where MaSuKien = " + tam);
                    // Lặp qua từng luật rồi thêm vào List luat để làm cơ sở đặt câu hỏi cho người dùng.
                    foreach (DataRow row1 in dtLuatSuKien.Rows)
                    {
                        // Lấy về các sự kiện tạo thành luật có MaLuat là row1[0].ToString()
                        suKienThoaMan = objXldl.LayDt("Select MaSuKien, HeSoTinCay From LuatSuKien Where MaLuat = " + row1[0].ToString());
                        DataTable luatThoatMan = objXldl.LayDt("Select MaLuat, TenLuat From Luat Where MaLuat = " + row1[0].ToString());
                        Dictionary<String, float> suKien = new Dictionary<String, float>();
                        foreach (DataRow item in suKienThoaMan.Rows)
                        {
                            DataTable dtSuKienThoaMan = objXldl.LayDt("Select CauHoi From SuKien Where MaSuKien = " + item[0].ToString());
                            suKien.Add(dtSuKienThoaMan.Rows[0][0].ToString(), float.Parse(item[1].ToString()));
                        }
                        Luat l = new Luat(int.Parse(luatThoatMan.Rows[0][0].ToString()), luatThoatMan.Rows[0][1].ToString(), suKien);
                        luat.Add(l);
                    }
                    // Lặp qua các phần tử của list luat để xem các câu hỏi đã hỏi rồi (có sự kiện xuất hiện trong dictionary quaTrinhSuyDien)
                    // thì xóa đi để tránh hỏi lại
                    foreach (Luat item1 in luat)
                    {
                        try
                        {
                            String key = quaTrinhSuyDien.ElementAt(0).Key;
                            float heSo = item1.SuKien[key];
                            item1.SuKien.Remove(key);
                            item1.HeSoTinCay += heSo;
                        }
                        catch
                        {
                        }
                    }
                    luat.Sort();
                    pnlCauHoi.Controls.Remove(uctrlTrieuChungThuongGapNhat);
                    pnlCauHoi.Controls.Add(uctrlThongTinBoSung);
                    try
                    {
                        setCauHoi(luat[0].SuKien.ElementAt(0).Key);
                    }
                    catch
                    {

                    }
                }
            }
            else
            {
                bool ketThuc = true;
                String selected = (uctrlThongTinBoSung.RadCo.Checked == true) ? "Có" : "Không";
                String key = uctrlThongTinBoSung.LblCauHoi.Text;
                quaTrinhSuyDien.Add(key, selected);
                // In câu hỏi và câu trả lời vừa rồi vào phần Quá trình suy diễn
                String cauHoi = quaTrinhSuyDien.ElementAt(quaTrinhSuyDien.Count - 1).Key;
                String traLoi = quaTrinhSuyDien.ElementAt(quaTrinhSuyDien.Count - 1).Value;
                lblQuaTrinhSuyDien.Text += "\n" + "Chương trình hỏi: " + cauHoi + "   Bạn trả lời: " + traLoi;
                List<Luat> luatHetHieuLuc = new List<Luat>();
                // Lặp qua các phần tử của list luat để xem các câu hỏi đã hỏi rồi (có sự kiện xuất hiện trong dictionary quaTrinhSuyDien)
                // thì xóa đi để tránh hỏi lại
                foreach (Luat item1 in luat)
                {
                    try
                    {
                        float heSo = item1.SuKien[key];
                        item1.SuKien.Remove(key);
                        if (selected == "Có")
                            item1.HeSoTinCay += heSo;
                        else
                            item1.HeSoKhongTinCay += heSo;
                        if (item1.HeSoTinCay >= 0.9f)
                        {
                            lblKetLuan.Text = "Chắc chắn bạn đã mắc " + item1.TenLuat;
                            btnTiep.Enabled = false;
                            btnKetThuc.Enabled = false;
                            uctrlThongTinBoSung.RadCo.Enabled = false;
                            uctrlThongTinBoSung.RadKhong.Enabled = false;
                            return;
                        }
                    }
                    catch
                    {
                    }
                    if (item1.HeSoKhongTinCay > 0.4f)
                        luatHetHieuLuc.Add(item1);
                }
                // Xóa đi những luật có hệ số không tin cậy > 0.4 vì những luật này không còn cơ hội được thỏa mãn bởi thông tin người dùng
                foreach (Luat item in luatHetHieuLuc)
                {
                    luat.Remove(item);
                }
                luat.Sort();
                // Lặp qua các luật có thể được thỏa mãn để chọn câu hỏi tiếp theo
                foreach (Luat item in luat)
                {
                    for (int i = 0; i < item.SuKien.Count; i++)
                    {
                        try
                        {
                            setCauHoi(item.SuKien.ElementAt(i).Key);
                            ketThuc = false;
                            // Nếu đã tìm được câu hỏi để hỏi cho lần tiếp theo thì thoát vòng lặp để tránh mất thời gian
                            break;
                        }
                        catch
                        {

                        }
                    }
                }
                // ketThuc = true tức là đã không còn câu hỏi nào để hỏi nữa, ta kiểm tra list luat để đưa ra kết luận
                if (ketThuc == true)
                {
                    ketThucSuyDien();
                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            ketThucSuyDien();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            FrmChuanDoanBenh_Load(sender, e);
        }
    }
}
