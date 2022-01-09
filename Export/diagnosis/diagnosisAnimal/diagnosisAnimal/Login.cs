using diagnosisAnimal.General;
using System;
using System.Data;
using System.Windows.Forms;

namespace diagnosisAnimal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            
            if (Properties.Settings.Default.RememberMe == "true")
            {
                txtName.Text = Properties.Settings.Default.User;
                txtPassword.Text = Properties.Settings.Default.Password;
                checkSave.Checked = true;
            }
            else
            {
                txtName.Text = "";
                txtPassword.Text = "";
                checkSave.Checked = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPassword.Text == ""){
                MessageBox.Show("Tài Khoản hoặc mật khẩu không được trống !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                Connect conn = new Connect();
                DataSet ds = new DataSet();
                ds = conn.select("select * from UserAccount where UserName = '" + txtName.Text + "' and Password = '" + txtPassword.Text + "'");
                if (ds.Tables[0].Rows.Count > 0) {
                    checkSave_CheckedChanged(sender, e); 
                    /* lấy quyền mà người dùng vừa đăng nhập */
                    Home.quyen = conn.XemDL("select decentralization from UserAccount where UserName = '" + txtName.Text + "' and Password = '" + txtPassword.Text + "'").Rows[0][0].ToString().Trim();
                    ManageUser.quyen = conn.XemDL("select decentralization from UserAccount where UserName = '" + txtName.Text + "' and Password = '" + txtPassword.Text + "'").Rows[0][0].ToString().Trim();
                    MessageBox.Show("You login successfully ");
                    Home homePage = new Home();
                    homePage.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("You login unsuccessful");
                    txtName.Text = "";
                    txtPassword.Text = "";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkSave_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSave.Checked) {
                Properties.Settings.Default.User = txtName.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.RememberMe = "true";
                Properties.Settings.Default.Save();
            }
            else {
                Properties.Settings.Default.User = txtName.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = "false";
                Properties.Settings.Default.Save();
            }
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        private void editPassword_Click(object sender, EventArgs e)
        {
            ResetPassword reset = new ResetPassword();
            this.Hide();
            reset.Show();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked){
                txtPassword.UseSystemPasswordChar = false;
            }
            else{
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
