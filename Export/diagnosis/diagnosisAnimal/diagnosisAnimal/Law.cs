using diagnosisAnimal.General;
using System;
using System.Data;
using System.Windows.Forms;

namespace diagnosisAnimal
{
    public partial class Law : Form
    {
        // khai báo các thông tin cần thiết

        private DataProcess dataProcess;
        private DataTable dtLaw;
        private DataTable dtEvent;
        private int cheDo;
        private String idLaw;
        private SelectEvent selectEvent;

        public Law()
        {
            InitializeComponent();
            dataProcess = new DataProcess();
            dtEvent = dataProcess.getData("Select idEvent, EventName From Event Where idEvent = 0");
            dtEvent.Columns.Add(new DataColumn("HeSoTinCay"));
            cheDo = 0;
        }
        public void ShowLaw()
        {
            dtLaw = dataProcess.getData("Select idLaw, LawName, HeSoTinCay From Law");
            dtLaw.Columns.Add(new DataColumn("CacSuKien"));
            dgvLaw.DataSource = dtLaw;
            foreach (DataRow row in dtLaw.Rows)
            {
                DataTable dtCacSuKien = dataProcess.getData("Select s.idEvent, EventName, HeSoTinCay From Event s Inner Join EventLaw lsk On " +
                    "s.idEvent = lsk.idEvent Where idLaw = " + row[0].ToString());
                String cacSuKien = "";
                for (int i = 0; i < dtCacSuKien.Rows.Count; i++)
                {
                    cacSuKien += dtCacSuKien.Rows[i][1].ToString() + " (" + dtCacSuKien.Rows[i][2] + ")";
                    if (i < dtCacSuKien.Rows.Count - 1)
                        cacSuKien += "\r\n";
                }
                row[3] = cacSuKien;
            }
            dgvLaw.Columns[0].Width = 95;
            dgvLaw.Columns[1].Width = 300;
            dgvLaw.Columns[0].HeaderText = "Mã luật";
            dgvLaw.Columns[1].HeaderText = "Tên luật";
            dgvLaw.Columns[2].HeaderText = "Hệ số tin cậy";
            dgvLaw.Columns[3].Visible = false;
            txtLawName.DataBindings.Clear();
            txtEvent.DataBindings.Clear();
            txtLawName.DataBindings.Add("text", dtLaw, "LawName", false, DataSourceUpdateMode.Never);
            txtEvent.DataBindings.Add("text", dtLaw, "CacSuKien", false, DataSourceUpdateMode.Never);
        }


        private void Law_Load(object sender, EventArgs e)
        {
            ShowLaw();
            txtSearch_TextChanged(sender, e);
        }

        private void btnChooseEvent_Click(object sender, EventArgs e)
        {
            if (cheDo == 1)
                selectEvent = new SelectEvent(null);
            else
                selectEvent = new SelectEvent(dtEvent);
            selectEvent.MyEvent += new MyDelegate(selectEvent_MyEvent);
            selectEvent.ShowDialog();
        }
        private void selectEvent_MyEvent(object sender, MyEventArgs e)
        {
            dtEvent = e.DataTableMyEvent;
            String cacSuKien = "";
            for (int i = 0; i < dtEvent.Rows.Count; i++)
            {
                cacSuKien += dtEvent.Rows[i][1].ToString() + " (" + dtEvent.Rows[i][2] + ")";
                if (i < dtEvent.Rows.Count - 1)
                    cacSuKien += "\r\n";
            }
            txtEvent.Text = cacSuKien;
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa luật này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    dataProcess.ExecuteCommand("Delete From EventLaw Where idLaw = " + idLaw);
                    dataProcess.ExecuteCommand("Delete From Law Where idLaw = " + idLaw);
                    MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Law_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cheDo = 1;
            txtEvent.Text = "";
            txtLawName.Text = "";
            txtLawName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                dtEvent = dataProcess.getData("Select s.idEvent, EventName, HeSoTinCay From Event s Inner Join EventLaw lsk On " + "s.idEvent = lsk.idEvent Where idLaw = " + idLaw);
                cheDo = 2;
            }
            catch { }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String strSql, tb;
                if (cheDo == 1)
                {
                    strSql = "Insert Into Law(LawName) Values(N'" + txtLawName.Text + "')";
                    tb = "Thêm thành công";
                }
                else
                {
                    strSql = "Update Law Set LawName = N'" + txtLawName.Text + "' Where idLaw = " + idLaw;
                    tb = "Sửa thành công";
                }
                if (dataProcess.ExecuteCommand(strSql))
                {
                    if (cheDo == 2)
                        dataProcess.ExecuteCommand("Delete From EventLaw Where idLaw = " + idLaw);
                    else
                        idLaw = dataProcess.LenhVoHuong("Select IDENT_CURRENT('Law')").ToString();
                    foreach (DataRow row in dtEvent.Rows)
                        dataProcess.ExecuteCommand("Insert Into EventLaw(idEvent, idLaw, HeSoTinCay) Values(" + row[0].ToString() + ", " + idLaw + ", " + row[2].ToString() + ")");
                    MessageBox.Show(tb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Law_Load(sender, e);
                }
                else MessageBox.Show("Lỗi: " + dataProcess.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtLaw.DefaultView.RowFilter = "LawName Like '%" + txtSearch.Text + "%'";
        }

        private void dgvLaw_SelectionChanged(object sender, EventArgs e)
        {
            cheDo = 0;
            try
            {
                int dong = dgvLaw.CurrentRow.Index;
                idLaw = dgvLaw.Rows[dong].Cells[0].Value.ToString();
            }
            catch
            {
                btnRemove.Enabled = false;
                btnEdit.Enabled = false;
            }
        }
    }
}
