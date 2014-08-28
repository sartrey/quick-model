using System;
using System.Diagnostics;
using System.IO;
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
            string path = Path.Combine(
                Application.StartupPath, "model", "model.exe");
            var process = Process.Start(path);
        }
    }
}
