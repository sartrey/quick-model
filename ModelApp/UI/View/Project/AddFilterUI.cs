
namespace QuickModel3D.UI
{
    public partial class AddFilterUI : DialogUI
    {
        public AddFilterUI()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {
            FinishDialog(true);
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            FinishDialog(false);
        }
    }
}
