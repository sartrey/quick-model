using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickModel3D
{
    public enum ToolType 
    {
        Pen,
        Line,
        Eraser
    }

    public partial class Canvas : Panel
    {
        protected Rectangle _WorkRect;

        protected Brush[] _BrushCaches = null;
        protected Pen[] _PenCaches = null;
        protected Point[] _PointCaches = null;

        protected Bitmap _CurrentFrame = null;
        protected Bitmap _BackupFrame = null;
        protected bool _IsDrawing = false;
        
        protected ToolType _CurrentTool = 0;
        protected int _BrushSize = 1;
        protected Color _ForeColor = Color.Black;
        protected Color _BackColor = Color.White;

        protected event Action _ClientSizeChanged;

        public Size WorkRectSize
        {
            get { return _WorkRect.Size; }
            set
            {
                if (value == WorkRectSize)
                    return;
                Size = new Size(value.Width + 2, value.Height + 2);
                _WorkRect = new Rectangle(new Point(1, 1), value);
                if (_ClientSizeChanged != null)
                    _ClientSizeChanged();
            }
        }

        public Bitmap CurrentFrame 
        {
            get 
            {
                if (_CurrentFrame == null)
                    _CurrentFrame = new Bitmap(
                        _WorkRect.Size.Width, 
                        _WorkRect.Size.Height);
                return _CurrentFrame;
            }
        }

        public Bitmap RenderFrame 
        {
            get 
            {
                var frame = new Bitmap(
                    CurrentFrame.Width, 
                    CurrentFrame.Height);
                var g = Graphics.FromImage(frame);
                g.Clear(BackColor);
                g.DrawImage(CurrentFrame, 0, 0);
                return frame;
            }
        }

        public ToolType CurrentTool 
        {
            get { return _CurrentTool; }
            set { _CurrentTool = value; }
        }

        public int BrushSize 
        {
            get { return _BrushSize; }
            set 
            {
                if (value == _BrushSize)
                    return;
                _BrushSize = value;
                _PenCaches[1] = new Pen(_ForeColor, 2 * value);
            }
        }

        public new Color ForeColor 
        {
            get { return _ForeColor; }
            set 
            {
                if (_ForeColor == value)
                    return;
                _ForeColor = value;
                _BrushCaches[1] = new SolidBrush(value);
                _PenCaches[1] = new Pen(value, 2 * _BrushSize);
            }
        }

        public new Color BackColor 
        {
            get { return _BackColor; }
            set 
            {
                if (_BackColor == value)
                    return;
                _BackColor = value;
                _BrushCaches[2] = new SolidBrush(Color.FromArgb(128, value));
                Invalidate();
            }
        }

        public new event Action ClientSizeChanged 
        {
            add { _ClientSizeChanged += value; }
            remove { _ClientSizeChanged -= value; }
        }

        public Canvas()
        {
            InitializeComponent();
            InitControl();
            InitCache();
        }

        private void InitControl() 
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void InitCache() 
        {
            _BrushCaches = new Brush[5];
            _BrushCaches[1] = new SolidBrush(Color.Black); //fore
            _BrushCaches[2] = new SolidBrush(Color.FromArgb(128, Color.White)); //eraser

            _PenCaches = new Pen[5];
            _PenCaches[0] = new Pen(Color.Gray, 2); //outline
            _PenCaches[1] = new Pen(Color.Black, 2); //fore

            _PointCaches = new Point[5];
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var g = e.Graphics;
            g.Clear(BackColor);
            g.DrawRectangle(
                _PenCaches[0], _WorkRect);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawImage(CurrentFrame, 1, 1);
            base.OnPaint(e);
        }

        public new void Dispose() 
        {
            if (_CurrentFrame != null)
                _CurrentFrame.Dispose();
            base.Dispose();
        }

        public void Reset() 
        {
            if (_CurrentFrame != null)
            {
                _CurrentFrame.Dispose();
                _CurrentFrame = null;
            }
            if (_BackupFrame != null)
            {
                _BackupFrame.Dispose();
                _BackupFrame = null;
            }
            Refresh();
        }

        protected void DrawPoint(Point location)
        {
            var g = Graphics.FromImage(CurrentFrame);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillEllipse(_BrushCaches[1], location.X, location.Y, 2 * _BrushSize + 1, 2 * _BrushSize + 1);
        }

        protected void DrawEraser(Point location) 
        {
            var g = Graphics.FromImage(CurrentFrame);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillEllipse(_BrushCaches[2], location.X, location.Y, 3 * _BrushSize + 1, 3 * _BrushSize + 1);
        }

        protected void DrawLine(int state, Point location) 
        {
            if (state == 0)
            {
                _PointCaches[0] = location;
                _BackupFrame = new Bitmap(
                    _CurrentFrame.Width, _CurrentFrame.Height);
                var g = Graphics.FromImage(_BackupFrame);
                g.Clear(Color.Transparent);
                g.DrawImage(_CurrentFrame, 0, 0);
            }
            else if (state == 1)
            {
                var g = Graphics.FromImage(CurrentFrame);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                g.DrawImage(_BackupFrame, 0, 0);
                g.DrawLine(_PenCaches[1], _PointCaches[0], location);
            }
            else if (state == 2)
            {
                var g = Graphics.FromImage(CurrentFrame);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                if (_BackupFrame != null)
                {
                    g.DrawImage(_BackupFrame, 0, 0);
                    _BackupFrame.Dispose();
                    _BackupFrame = null;
                }
                g.DrawLine(_PenCaches[1], _PointCaches[0], location);
            }
        }

        public void DrawImage(Image image) 
        {
            var g = Graphics.FromImage(CurrentFrame);
            g.DrawImage(image, 0, 0);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _IsDrawing = true;
            if(CurrentTool == ToolType.Line)
                DrawLine(0, e.Location);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_IsDrawing)
            {
                if (CurrentTool == ToolType.Pen)
                    DrawPoint(e.Location);
                else if (CurrentTool == ToolType.Eraser)
                    DrawEraser(e.Location);
                else if (CurrentTool == ToolType.Line)
                    DrawLine(1, e.Location);
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _IsDrawing = false;
            if (CurrentTool == ToolType.Line)
            {
                DrawLine(2, e.Location);
                Invalidate();
            }
        }
    }
}
