using Sartrey;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace QuickModel3D.UI
{
    public class Document : DockContent, IWindow
    {
        private string _Id;

        public string Id
        {
            get { return _Id; }
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

        public Document(string id)
        {
            AutoScaleMode = AutoScaleMode.Font;
            _Id = id;
        }

        public Document(string id, Control view, string title) : this(id)
        {
            View = view;
            Text = title;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(View != null)
                View.Dispose();
            base.OnFormClosing(e);
        }

        public new void Show()
        {
            var runtime = Runtime.Instance;
            var window = runtime.WindowHub["main"] as MainWindow;
            Show(window.Docking, DockState.Document);
        }
    }
}
