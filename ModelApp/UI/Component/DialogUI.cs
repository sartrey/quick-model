using System;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class DialogUI : UserControl
    {
        private event Action<bool> _DialogFinished;

        public event Action<bool> DialogFinished
        {
            add { _DialogFinished += value; }
            remove { _DialogFinished -= value; }
        }

        public DialogUI()
        {
            AutoScaleMode = AutoScaleMode.Font;
        }

        protected void FinishDialog(bool result) 
        {
            if (_DialogFinished != null)
                _DialogFinished(result);
        }
    }
}
