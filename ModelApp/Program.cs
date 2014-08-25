using System;
using System.Windows.Forms;
using QuickModel3D.UI;
using WeifenLuo.WinFormsUI.Docking;

namespace QuickModel3D
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var runtime = Runtime.Instance;
            runtime.WindowHub.LinkWindow(new MainWindow());
            runtime.WindowHub.LinkWindow(new UI.Panel("assets", new AssetsUI(), "资源", DockState.DockLeft));
            runtime.WindowHub.LinkWindow(new UI.Panel("preview", new PreviewUI(), "预览", DockState.Document));
            runtime.WindowHub.LinkWindow(new UI.Panel("layout", new StructureUI(), "布局", DockState.Document));
            runtime.WindowHub["main"].Show();
            
            Application.Run();
        }
    }
}
