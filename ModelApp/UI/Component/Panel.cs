using Sartrey.UI;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace QuickModel3D.UI
{
    public class Panel : DockContent, IWindow
    {
        private string _Id;
        private DockState _DefaultDock
            = DockState.DockLeft;

        public string Id
        {
            get { return _Id; }
        }

        public DockState DefaultDock
        {
            get { return _DefaultDock; }
            set { _DefaultDock = value; }
        }

        public Control View
        {
            get { return Controls.Count > 0 ? Controls[0] : null; }
            set
            {
                var current_view = View;
                if (value == current_view)
                    return;
                if (current_view != null)
                {
                    current_view.Dispose();
                    Controls.Clear();
                }
                value.Dock = DockStyle.Fill;
                Controls.Add(value);
            }
        }

        public Panel(string id)
        {
            AutoScaleMode = AutoScaleMode.Font;
            _Id = id;
        }

        public Panel(string id, Control view, string title, DockState dock) : this(id)
        {
            View = view;
            Text = title;
            DefaultDock = dock;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                Hide();
            }
            base.OnFormClosing(e);
        }

        public new void Show()
        {
            var runtime = Runtime.Instance;
            var window = runtime.WindowHub["main"] as MainWindow;
            Show(window.Docking, DefaultDock);
        }
    }
}
