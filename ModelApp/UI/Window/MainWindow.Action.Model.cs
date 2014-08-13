using QuickModel3D.Model;
using System;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class MainWindow
    {
        private void MnuModel_Layout_Click(object sender, EventArgs e)
        {

        }

        private void MnuModel_Preview_Click(object sender, EventArgs e)
        {
            var runtime = Runtime.Instance;
            var window = runtime.GetViewById("preview") as PreviewUI;
            window.Preview();
        }
    }
}
