using diagnosisAnimal.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagnosisAnimal
{
    public partial class ManageUser : Form
    {
        public static string quyen;
        public ManageUser()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            DataSet ds = new DataSet();
            Connect conn = new Connect();
            ds = conn.select("select Username as 'Username', Password as 'Password', decentralization as 'Quyền' from UserAccount");
            dgvManageUser.DataSource = ds.Tables[0];

            ds = conn.select("select decentralization from UserAccount");
            cboQuyen.DataSource = ds.Tables[0];
            cboQuyen.ValueMember = "decentralization";
        }




        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == ""){
                MessageBox.Show("Hãy nhập tên người dùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(txtPass.Text == ""){
                MessageBox.Show("Hãy nhập mật khẩu người dùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                Connect conn = new Connect();
                bool kiemtra = conn.update("insert into UserAccount values(N'" + txtUsername.Text + "', N'" + txtPass.Text + "', N'" + cboQuyen.SelectedValue.ToString() + "') ");
                if (kiemtra == true)
                {
                    btnReset_Click(sender, e);
                    MessageBox.Show("Bạn đã thêm thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Bạn thêm thất bại");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            DataSet ds = new DataSet();
            Connect conn = new Connect();
            ds = conn.select("select decentralization from UserAccount");
            cboQuyen.DataSource = ds.Tables[0];
            cboQuyen.ValueMember = "decentralization";
        }

        private void dgvManageUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dgvManageUser.CurrentRow.Cells[0].Value.ToString();
            txtPass.Text = dgvManageUser.CurrentRow.Cells[1].Value.ToString();
            cboQuyen.Text = dgvManageUser.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            DataSet ds = new DataSet();
            Connect conn = new Connect();
            ds = conn.select("select decentralization from UserAccount");
            cboQuyen.DataSource = ds.Tables[0];
            cboQuyen.ValueMember = "decentralization";
        }

    }
}
