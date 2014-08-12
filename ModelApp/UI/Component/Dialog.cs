using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public class Dialog : Form
    {
        protected bool _Result = false;

        public DialogUI View
        {
            get 
            {
                var view = Controls.Count > 0 ? Controls[0] : null;
                return view as DialogUI;
            }
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
                ClientSize = value.Size;
                value.Dock = DockStyle.Fill;
                Controls.Add(value);

                var view = value as DialogUI;
                view.DialogFinished += OnViewFinished;
            }
        }

        public Dialog()
        {
            AutoScaleMode = AutoScaleMode.Font;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public Dialog(DialogUI view, string title) : this()
        {
            View = view;
            Text = title;
        }

        public new void Show()
        {
            ShowDialog();
        }

        public bool ValidDialogResult(bool result) 
        {
            return result == _Result;
        }

        protected void OnViewFinished(bool result) 
        {
            _Result = result;
            Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(View != null)
                View.DialogFinished -= OnViewFinished;
            base.OnFormClosing(e);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                View.Dispose();
                Controls.Clear();
            }
            base.Dispose(disposing);
        }
    }
}
