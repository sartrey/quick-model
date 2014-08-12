using System;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class AddBatchUI : DialogUI
    {
        private int _Total;

        public int Total 
        {
            get { return _Total; }
        }

        public AddBatchUI()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxTotal.Text))
                return;
            _Total = int.Parse(TbxTotal.Text);
            FinishDialog(true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FinishDialog(false);
        }
    }
}
