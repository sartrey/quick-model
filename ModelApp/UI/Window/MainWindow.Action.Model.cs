using QuickModel3D.Model;
using System;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class MainWindow
    {
        private void MnuModel_Layout_Click(object sender, EventArgs e)
        {
            var runtime = Runtime.Instance;
            var window = runtime.WindowHub["layout"];
            window.Show();
        }

        private void MnuModel_Preview_Click(object sender, EventArgs e)
        {
            var runtime = Runtime.Instance;
            var window = runtime.WindowHub["preview"];
            window.Show();
            var preview = (window as Panel).View as PreviewUI;
            preview.Preview();
        }
    }
}
