using Sartrey;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace QuickModel3D.UI
{
    public partial class MainWindow : Form, IWindow
    {
        public string Id
        {
            get { return "main"; }
        }

        public DockPanel Docking
        {
            get { return PanelDock; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            var runtime = Runtime.Instance;
            runtime.WindowHub["assets"].Show();
            //runtime.WindowHub["preview"].Show();
            //runtime.WindowHub["draw"].Show();
            Width = 800;
            Height = 600;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                Application.Exit();
            }
            base.OnFormClosing(e);
        }
    }
}
