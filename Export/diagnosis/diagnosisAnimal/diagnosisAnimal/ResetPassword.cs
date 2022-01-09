using diagnosisAnimal.General;
using System;
using System.Data;
using System.Windows.Forms;

namespace diagnosisAnimal
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
            Connect conn = new Connect();
            DataSet ds = new DataSet();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            if (txtNewPassword.Text == "" || txtnhaplaiPass.Text == "")
                MessageBox.Show("Tên tài khoản hoặc mật khẩu chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            else{
                if (txtNewPassword.Text != txtnhaplaiPass.Text)
                    MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else{
                    bool check = conn.update("UPDATE UserAccount SET Password = '" + txtnhaplaiPass.Text + "' where UserName = '" + txtUserName.Text + "'");
                    if (check == true){
                        MessageBox.Show("Reset successfully !");
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                    else MessageBox.Show("Mật khẩu không trùng khớp !");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
