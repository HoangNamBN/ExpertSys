using diagnosisAnimal.General;
using System;
using System.Data;
using System.Windows.Forms;

namespace diagnosisAnimal
{
    public partial class Symptom : Form
    {
        private DataProcess data;
        private DataTable dtSuKien;
        public Symptom()
        {
            InitializeComponent();
            data = new DataProcess();
            Load();
        }

        public void Load()
        {
            dtSuKien = data.getData("select EventName from Event");
            lstEvent.DataSource = dtSuKien;
            lstEvent.DisplayMember = "EventName";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            DataSet ds = new DataSet();
            ds = conn.select("select EventName from Event");
            dtSuKien.DefaultView.RowFilter = "EventName like '%" + txtSearch.Text + "%'";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
