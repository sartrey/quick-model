using QuickModel3D.Model;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class LayoutUI : UserControl
    {
        private Engine _Engine 
            = new Engine();

        public LayoutUI()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, System.EventArgs e)
        {
            _Engine.Project = Runtime.Instance.Project;
            _Engine.Generate();
        }
    }
}
