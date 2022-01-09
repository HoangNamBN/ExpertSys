using diagnosisAnimal.General;
using System;
using System.Data;
using System.Windows.Forms;

namespace diagnosisAnimal
{
    public partial class CommonSymptoms : UserControl
    {
        private DataProcess dataProcess;
        private DataTable dtTrieuChung;
        public CommonSymptoms()
        {
            InitializeComponent();
            dataProcess = new DataProcess();
        }
        public int getTrieuChungThuongGapNhat()
        {
            try{
                return (int)cboTrieuChungThuongGapNhat.SelectedValue;
            }
            catch{
                return 0;
            }
        }
        public void showTrieuChung()
        {
            dtTrieuChung = dataProcess.getData("Select idEvent, EventName From Event");
            cboTrieuChungThuongGapNhat.DataSource = dtTrieuChung;
            cboTrieuChungThuongGapNhat.DisplayMember = "EventName";
            cboTrieuChungThuongGapNhat.ValueMember = "idEvent";
        }

        private void CommonSymptoms_Load(object sender, EventArgs e)
        {
            showTrieuChung();
        }
    }
}
