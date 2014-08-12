using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace QuickModel3D
{
    public partial class WindowHost : Panel
    {
        private IntPtr _Target
            = IntPtr.Zero;
        private string _Source
            = null;
        private Process _Process
            = null;

        public WindowHost()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IntPtr Target
        {
            get { return _Target; }
        }

        public string Source 
        {
            get { return _Source; }
            set { _Source = value; }
        }



        public void Start()
        {
            if (string.IsNullOrWhiteSpace(_Source))
                throw new ArgumentException();
            if (!File.Exists(_Source))
                throw new FileNotFoundException();
            if (_Process != null)
                throw new InvalidOperationException();
            _Process = Process.Start(_Source);
            _Process.WaitForInputIdle();
            _Target = _Process.MainWindowHandle;
            Win32.SetParent(_Target, Handle);
            Win32.SetWindowLong(_Target, Win32.GWL_STYLE, Win32.WS_VISIBLE);
            Win32.MoveWindow(_Target, 0, 0, Width, Height, true);
        }

        public void Stop(int wait) 
        {
            if (_Target != IntPtr.Zero)
                Win32.PostMessage(_Target, Win32.WM_CLOSE, 0, 0);
            if (_Process != null)
            {
                _Process.WaitForExit(wait);
                _Process.Kill();
            }
            _Process = null;
            _Target = IntPtr.Zero;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_Target != IntPtr.Zero)
                Win32.MoveWindow(_Target, 0, 0, Width, Height, true);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            Stop(0);
            base.OnHandleDestroyed(e);
        }
    }
}
