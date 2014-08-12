using System.IO;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class PreviewUI : UserControl
    {
        public PreviewUI()
        {
            InitializeComponent();
        }

        public void Preview() 
        {
            ModelHost.Source = Path.Combine(
                Application.StartupPath, "model", "model.exe");
            ModelHost.Start();
        }
    }
}
