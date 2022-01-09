using diagnosisAnimal.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagnosisAnimal
{
    public partial class Home : Form
    {
        // khai báo các thành viên 
        public static string quyen;

        private string[] FolderFile = null;
        private int Selected = 0;
        private int Begin = 0;
        private int End = 0;

        public static string countAccount;
        public static string countEvent;
        public static string countLaw;
        public Home()
        {
            InitializeComponent();
            Connect conn = new Connect();
            DataSet ds = new DataSet();
            countAccount = conn.XemDL("SELECT count(*) as nguoidung from UserAccount").Rows[0][0].ToString().Trim();
            lbNguoiDung.Text = "Có " + countAccount + " người dùng";
            countEvent = conn.XemDL("SELECT count(*) as sukien from Event").Rows[0][0].ToString().Trim();
            lbSuKien.Text = "Có " + countEvent + " sự kiện";
            countLaw = conn.XemDL("SELECT count(*) as luat from Law").Rows[0][0].ToString().Trim();
            lbLuat.Text = "Có " + countLaw + " luật";
        }

        private void eventThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RollbackLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void RollbackLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void RollbackRegistration_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (quyen == "User"){
                QuanLyNguoiDung.Enabled = false;
                btnNext.Visible = false;
                btnstart.Visible = false;
                btPrevious.Visible = false;
                QuanLyNguoiDung.Enabled = false;
                sựKiệnToolStripMenuItem.Enabled = false;
                cácLuậtToolStripMenuItem.Enabled = false;
            }
            else if(quyen == "Experts"){
                QuanLyNguoiDung.Enabled = false;
                btnNext.Visible = false;
                btnstart.Visible = false;
                btPrevious.Visible = false;
                QuanLyNguoiDung.Enabled = false;
            }
        }

        private void QuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            ManageUser manage = new ManageUser();
            this.Hide();
            manage.Show();        
        }

        private void sựKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Envent eventPage = new Envent();
            this.Hide();
            eventPage.Show();
        }

        private void triệuChứngBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Symptom symptom = new Symptom();
            this.Hide();
            symptom.Show();
        }

        private void chuẩnĐoánBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diagosis diagosis = new Diagosis();
            this.Hide();
            diagosis.Show();
        }

        private void cácLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Law law = new Law();
            this.Hide();
            law.Show();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string[] path1 = null, path2 = null, path3 = null;
                path1 = Directory.GetFiles(folder.SelectedPath, "*.jpg");
                path2 = Directory.GetFiles(folder.SelectedPath, "*.jpeg");
                path3 = Directory.GetFiles(folder.SelectedPath, "*.bmp");
                FolderFile = new string[path1.Length + path2.Length + path3.Length];
                Array.Copy(path1, 0, FolderFile, 0, path1.Length);
                Array.Copy(path2, 0, FolderFile, path1.Length, path2.Length);
                Array.Copy(path3, 0, FolderFile, path1.Length + path2.Length, path3.Length);
                Selected = 0;
                Begin = 0;
                End = FolderFile.Length;
                showImage(FolderFile[Selected]);
                btPrevious.Visible = true;
                btnNext.Visible = true;
                btnstart.Visible = true;
            }
        }
        private void showImage(string path)
        {
            Image imgtemp = Image.FromFile(path);
            picImageSlideShow.Image = imgtemp;
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            if (Selected == 0)
            {
                Selected = FolderFile.Length - 1;
                showImage(FolderFile[Selected]);
            }
            else
            {
                Selected = Selected - 1;
                showImage(FolderFile[Selected]);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Selected == FolderFile.Length - 1)
            {
                Selected = 0;
                showImage(FolderFile[Selected]);
            }
            else
            {
                Selected = Selected + 1;
                showImage(FolderFile[Selected]);
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                btnstart.Text = "Start Slide Show";
            }
            else
            {
                timer1.Enabled = true;
                btnstart.Text = "Stop Slide Show";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnNext_Click(sender, e);
        }
    }
}
