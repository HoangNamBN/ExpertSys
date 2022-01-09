using diagnosisAnimal.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace diagnosisAnimal
{
    public partial class Diagosis : DockContent
    {
        private DataProcess dataProcess;
        private CommonSymptoms common;
        private AdditionInfo info;
        private List<LawData> Laws;
        private Dictionary<String, String> quaTrinhSuyDien;
        public Diagosis()
        {
            InitializeComponent();
            dataProcess = new DataProcess();
            common = new CommonSymptoms();
            info = new AdditionInfo();
            Diagosis_Load();
        }
        private void Diagosis_Load()
        {
            pnlCauHoi.Controls.Clear();
            Laws = null;
            quaTrinhSuyDien = null;
            lblKetLuan.Text = "";
            lblQuaTrinhSuyDien.Text = "";
            info.RadioYes.Enabled = true;
            info.RadioNo.Enabled = true;
            btnTiep.Enabled = true;
            btnKetThuc.Enabled = true;
            pnlCauHoi.Controls.Add(common);
        }
        // thiết lập các câu hỏi tiếp theo
        public void setCauHoi(String cauHoi)
        {
            info.LbCauHoi.Text = cauHoi;
            info.RadioYes.Checked = true;
        }


        // Hàm được gọi khi kết thúc quá trình suy diễn (khi người dùng nhấn Kết thúc hoặc khi không còn câu hỏi nào
        // để hỏi nữa
        public void ketThucSuyDien()
        {
            btnTiep.Enabled = false;
            btnKetThuc.Enabled = false;
            info.RadioYes.Enabled = false;
            info.RadioNo.Enabled = false;
            try
            {
                LawData tam = Laws[0];
                bool khongtraloi = false;
                foreach (LawData item in Laws)
                {
                    if (tam.HeSoTinCay < item.HeSoTinCay)
                        tam = item;
                }
                // Chỉ đưa ra kết luận về bệnh khi các thông tin thu thập được giúp cho một luật có hệ số tin cậy >= 0.6
                if (tam.HeSoTinCay >= 0.6f && tam.HeSoTinCay < 0.7f)
                    lblKetLuan.Text = "Có thể gà đã mắc ";
                else if (tam.HeSoTinCay >= 0.7f && tam.HeSoTinCay < 0.8f)
                    lblKetLuan.Text = "Rất có thể gà đã mắc ";
                else if (tam.HeSoTinCay >= 0.8f && tam.HeSoTinCay < 0.9f)
                    lblKetLuan.Text = "Gần như chắc chắn gà đã mắc ";
                else if (tam.HeSoTinCay >= 0.9f)
                    lblKetLuan.Text = "Chắc chắn gà đã mắc ";
                else
                {
                    lblKetLuan.Text = "Rất tiếc, hệ thống không đủ thông tin để kết luận bạn đã mắc bệnh gì";
                    khongtraloi = true;
                }
                if (khongtraloi == false) lblKetLuan.Text += tam.NameLaw;
            }
            catch
            {
                lblKetLuan.Text = "Rất tiếc, hệ thống không đủ thông tin để kết luận bạn đã mắc bệnh gì";
            }
        }
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            Diagosis_Load();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            // Bước đầu tiên, người dùng cần chọn triệu chứng mà họ thấy biểu hiện rõ nhất
            if (Laws == null && quaTrinhSuyDien == null)
            {
                int tam = common.getTrieuChungThuongGapNhat();
                if (tam == 0) MessageBox.Show("Bạn chưa chọn triệu chứng thường gặp nhất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DataTable suKienThoaMan = dataProcess.getData("Select EventName, Question From Event Where idEvent = " + tam);
                    quaTrinhSuyDien = new Dictionary<String, String>();
                    quaTrinhSuyDien.Add(suKienThoaMan.Rows[0][1].ToString(), suKienThoaMan.Rows[0][0].ToString());
                    lblQuaTrinhSuyDien.Text = "";
                    String trieuChung = quaTrinhSuyDien.ElementAt(0).Value;
                    lblQuaTrinhSuyDien.Text = "Triệu chứng bạn chọn ban đầu: " + trieuChung;
                    Laws = new List<LawData>();
                    // Lấy về các bệnh có biểu hiện triệu chứng người dùng vừa chọn (là bảng Luat trong cơ sở dữ liệu
                    DataTable dtLuatSuKien = dataProcess.getData("Select Distinct idLaw From EventLaw Where idEvent = " + tam);
                    // Lặp qua từng luật rồi thêm vào List luat để làm cơ sở đặt câu hỏi cho người dùng.
                    foreach (DataRow row1 in dtLuatSuKien.Rows)
                    {
                        // Lấy về các sự kiện tạo thành luật có MaLuat là row1[0].ToString()
                        suKienThoaMan = dataProcess.getData("Select idEvent, HeSoTinCay From EventLaw Where idLaw = " + row1[0].ToString());
                        DataTable luatThoatMan = dataProcess.getData("Select idLaw, LawName From Law Where idLaw = " + row1[0].ToString());
                        Dictionary<String, float> suKien = new Dictionary<String, float>();
                        foreach (DataRow item in suKienThoaMan.Rows)
                        {
                            DataTable dtSuKienThoaMan = dataProcess.getData("Select Question From Event Where idEvent = " + item[0].ToString());
                            suKien.Add(dtSuKienThoaMan.Rows[0][0].ToString(), float.Parse(item[1].ToString()));
                        }
                        LawData l = new LawData(int.Parse(luatThoatMan.Rows[0][0].ToString()), luatThoatMan.Rows[0][1].ToString(), suKien);
                        Laws.Add(l);
                    }
                    // Lặp qua các phần tử của list luat để xem các câu hỏi đã hỏi rồi (có sự kiện xuất hiện trong dictionary quaTrinhSuyDien)
                    // thì xóa đi để tránh hỏi lại
                    foreach (LawData item1 in Laws)
                    {
                        try
                        {
                            String key = quaTrinhSuyDien.ElementAt(0).Key;
                            float heSo = item1.EnVent[key];
                            item1.EnVent.Remove(key);
                            item1.HeSoTinCay += heSo;
                        }
                        catch {}
                    }
                    Laws.Sort();
                    pnlCauHoi.Controls.Remove(common);
                    pnlCauHoi.Controls.Add(info);
                    try
                    {
                        setCauHoi(Laws[0].EnVent.ElementAt(0).Key);
                    }
                    catch{ }
                }
            }
            else
            {
                bool ketThuc = true;
                String selected = (info.RadioYes.Checked == true) ? "Có" : "Không";
                String key = info.LbCauHoi.Text;
                quaTrinhSuyDien.Add(key, selected);
                // In câu hỏi và câu trả lời vừa rồi vào phần Quá trình suy diễn
                String cauHoi = quaTrinhSuyDien.ElementAt(quaTrinhSuyDien.Count - 1).Key;
                String traLoi = quaTrinhSuyDien.ElementAt(quaTrinhSuyDien.Count - 1).Value;
                lblQuaTrinhSuyDien.Text += "\n" + "Chương trình hỏi: " + cauHoi + "   Bạn trả lời: " + traLoi;
                List<LawData> luatHetHieuLuc = new List<LawData>();
                // Lặp qua các phần tử của list luat để xem các câu hỏi đã hỏi rồi (có sự kiện xuất hiện trong dictionary quaTrinhSuyDien)
                // thì xóa đi để tránh hỏi lại
                foreach (LawData item1 in Laws)
                {
                    try
                    {
                        float heSo = item1.EnVent[key];
                        item1.EnVent.Remove(key);
                        if (selected == "Có")
                            item1.HeSoTinCay += heSo;
                        else
                            item1.HeSoKhongTinCay += heSo;
                        if (item1.HeSoTinCay >= 0.9f)
                        {
                            lblKetLuan.Text = "Chắc chắn gà đã mắc " + item1.NameLaw;
                            btnTiep.Enabled = false;
                            btnKetThuc.Enabled = false;
                            info.RadioYes.Enabled = false;
                            info.RadioNo.Enabled = false;
                            return;
                        }
                    }
                    catch {}
                    if (item1.HeSoKhongTinCay > 0.4f)
                        luatHetHieuLuc.Add(item1);
                }
                // Xóa đi những luật có hệ số không tin cậy > 0.4 vì những luật này không còn cơ hội được thỏa mãn bởi thông tin người dùng
                foreach (LawData item in luatHetHieuLuc)
                {
                    Laws.Remove(item);
                }
                Laws.Sort();
                // Lặp qua các luật có thể được thỏa mãn để chọn câu hỏi tiếp theo
                foreach (LawData item in Laws)
                {
                    for (int i = 0; i < item.EnVent.Count; i++)
                    {
                        try
                        {
                            setCauHoi(item.EnVent.ElementAt(i).Key);
                            ketThuc = false;
                            // Nếu đã tìm được câu hỏi để hỏi cho lần tiếp theo thì thoát vòng lặp để tránh mất thời gian
                            break;
                        }
                        catch { }
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
