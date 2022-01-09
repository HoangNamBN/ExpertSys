using diagnosisAnimal.General;
using System;
using System.Data;
using System.Windows.Forms;

namespace diagnosisAnimal
{
    public partial class SelectEvent : Form
    {
        private DataProcess dataProcess;
        private DataTable dtEvent;
        private DataTable dtEventChoose;
        private ReliabilitCoef reliabilit;
        private float heSo;
        public event MyDelegate MyEvent;
        public SelectEvent(DataTable dtEventChoose)
        {
            InitializeComponent();
            dataProcess = new DataProcess();
            if(dtEventChoose == null)
            {
                dtEventChoose = dataProcess.getData("Select idEvent, EventName from Event where idEvent = 0");
                dtEventChoose.Columns.Add(new DataColumn("HeSoTinCay", typeof(float)));
            }
            this.dtEventChoose = dtEventChoose;
        }

        public void ShowEvent()
        {
            dgvSuKienDaChon.DataSource = dtEventChoose;
            dgvSuKienDaChon.Columns[0].Visible = false;
            dgvSuKienDaChon.Columns[1].HeaderText = "Tên sự kiện";
            dgvSuKienDaChon.Columns[2].HeaderText = "Hệ số tin cậy";
            dgvSuKienDaChon.Columns[1].Width = 200;
            dtEvent = dataProcess.getData("Select idEvent, EventName from Event");
            LapDeXoa:
            foreach (DataRow row1 in dtEvent.Rows)
            {
                foreach (DataRow row2 in dtEventChoose.Rows)
                {
                    if (row1[0].ToString() == row2[0].ToString())
                    {
                        dtEvent.Rows.Remove(row1);
                        goto LapDeXoa;
                    }
                }
            }
            dgvSuKien.DataSource = dtEvent;
            dgvSuKien.Columns[0].Visible = false;
            dgvSuKien.Columns[1].HeaderText = "Tên sự kiện";
        }

        private void SelectEvent_Load(object sender, EventArgs e)
        {
            ShowEvent();
            dgvSuKien_SelectionChanged(sender, e);
            dgvSuKienDaChon_SelectionChanged(sender, e);
            txtSearch.Text = "";
            txtSearch.Focus();

        }

        private void dgvSuKien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvSuKien.CurrentRow.Index;
                btnAdd.Enabled = true;
            }
            catch
            {
                btnAdd.Enabled = false;
            }
        }

        private void dgvSuKienDaChon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvSuKienDaChon.CurrentRow.Index;
                btnRemove.Enabled = true;
            }
            catch
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvSuKien.CurrentRow.Index;
                heSo = 0;
                reliabilit = new ReliabilitCoef();
                reliabilit.MyEvent += new MyDelegate(reliabilitCoef_MyEvent);
                reliabilit.ShowDialog();
                if (heSo <= 0) return;
                float tongHeSo = heSo;
                foreach (DataRow row1 in dtEventChoose.Rows)
                    tongHeSo += float.Parse(row1[2].ToString());
                if (tongHeSo > 1)
                {
                    MessageBox.Show("Tổng hệ số tin cậy không được lớn hơn 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataRow row = dtEventChoose.NewRow();
                for (int i = 0; i < 2; i++)
                    row[i] = dgvSuKien.Rows[dong].Cells[i].Value.ToString();
                row[2] = heSo;
                dtEventChoose.Rows.Add(row);
                SelectEvent_Load(sender, e);
            }
            catch { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvSuKienDaChon.CurrentRow.Index;
                dtEventChoose.Rows.RemoveAt(dong);
                SelectEvent_Load(sender, e);
            }
            catch { }
        }

        private void reliabilitCoef_MyEvent(object sender, MyEventArgs e)
        {
            heSo = e.HeSoTinCay;
        }

        private void SelectEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MyEvent != null)
                MyEvent(this, new MyEventArgs { DataTableMyEvent = dtEventChoose });
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtEvent.DefaultView.RowFilter = "EventName Like '%" + txtSearch.Text + "%'";
        }
    }
}
