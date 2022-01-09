using diagnosisAnimal.General;
using System;
using System.Data;
using System.Windows.Forms;

namespace diagnosisAnimal
{
    public partial class Envent : Form
    {
        private static String idEvent;

        public void load()
        {
            Connect conn = new Connect();
            DataSet ds = new DataSet();
            ds = conn.select("select * from Event");
            cbSearch.DataSource = ds.Tables[0];
            cbSearch.ValueMember = "idEvent";
        }

        public void Result()
        {
            DataSet ds = new DataSet();
            Connect conn = new Connect();
            ds = conn.select("Select idEvent as 'Mã sự kiện', EventName as 'Tên Sự Kiện', Question as 'Câu hỏi' from Event");
            dgvEvent.DataSource = ds.Tables[0];

        }
        public Envent()
        {
            InitializeComponent();
            Result();
            load();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            DataSet ds = new DataSet();
            idEvent = "SELECT idEvent from Event where idEvent = '" + cbSearch.SelectedValue + "'";
            if (conn.CheckKey(idEvent))
            {
                MessageBox.Show("Bạn đã tìm kiếm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ds = conn.select("Select idEvent as 'Mã sự kiện', EventName as 'Tên Sự Kiện', Question as 'Câu hỏi' from Event where idEvent like N'%" + cbSearch.SelectedValue.ToString() + "%'");
                dgvEvent.DataSource = ds.Tables[0];
            }
            else
                MessageBox.Show("Mã tin tức này không tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            if (txtIdEvent.Text == "")
                MessageBox.Show("Hãy nhập mã sự kiện", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                idEvent = "SELECT idEvent from Event where idEvent = '" + txtIdEvent.Text.Trim() + "'";
                if (conn.CheckKey(idEvent))
                {
                    bool kiemtra = conn.update("delete Event where idEvent = '" + txtIdEvent.Text + "' ");
                    if (kiemtra == true)
                    {
                        btnReset_Click(sender, e);
                        MessageBox.Show("Bạn đã xoá thành công");
                        load();
                        Result();
                    }
                    else
                        MessageBox.Show("Bạn xoá thất bại");
                }
                else
                    MessageBox.Show("Mã nhà cung cấp này không tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            if(txtIdEvent.Text != "")
            {
                MessageBox.Show("Mã sự kiện được tăng tự động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdEvent.Text = "";
            }
            if(txtEventName.Text == "")
                MessageBox.Show("Hãy nhập tên sự kiện", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (txtQuestion.Text == "")
                MessageBox.Show("Hãy nhập câu hỏi cho sự kiện", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool check = conn.update("insert into Event values(N'"+txtEventName.Text+"', N'" +txtQuestion.Text+ "')");
                if(check == true)
                {
                    btnReset_Click(sender, e);
                    MessageBox.Show("Bạn đã thêm thành công");
                    load();
                    Result();
                }
                else
                    MessageBox.Show("Bạn thêm thất bại");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIdEvent.Text = "";
            txtEventName.Text = "";
            txtQuestion.Text = "";
        }

        private void dgvEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int _row = e.RowIndex;
            txtIdEvent.Text = dgvEvent.Rows[_row].Cells[0].Value.ToString();
            txtEventName.Text = dgvEvent.Rows[_row].Cells[1].Value.ToString();
            txtQuestion.Text = dgvEvent.Rows[_row].Cells[2].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            if (txtEventName.Text == "")
                MessageBox.Show("Hãy nhập tên sự kiện", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (txtQuestion.Text == "")
                MessageBox.Show("Hãy nhập câu hỏi cho sự kiện", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                idEvent = "SELECT idEvent from Event where idEvent = '" + txtIdEvent.Text.Trim() + "'";
                if (conn.CheckKey(idEvent))
                {
                    bool kiemtra = conn.update("UPDATE Event set EventName =N'" + txtEventName.Text + "',Question =N'" + txtQuestion.Text + "' where idEvent = '" + txtIdEvent.Text + "' ");
                    if (kiemtra == true)
                    {
                        btnReset_Click(sender, e);
                        MessageBox.Show("Bạn đã sửa thành công");
                        load();
                        Result();
                    }
                    else
                        MessageBox.Show("Bạn sửa thất bại");
                }
                else
                    MessageBox.Show("Mã sự kiện này không tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                    
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Connect conn = new Connect();
            ds = conn.select("Select idEvent as 'Mã sự kiện', EventName as 'Tên Sự Kiện', Question as 'Câu hỏi' from Event");
            dgvEvent.DataSource = ds.Tables[0];
        }
    }
}
