using System.Windows.Forms;

namespace diagnosisAnimal
{
    public partial class AdditionInfo : UserControl
    {
        public AdditionInfo()
        {
            InitializeComponent();
        }

        public Label LbCauHoi { get => lbCauHoi; set => lbCauHoi = value; }
        public RadioButton RadioYes { get => radioYes; set => radioYes = value; }
        public RadioButton RadioNo { get => radioNo; set => radioNo = value; }
    }
}
