using System.Drawing;
using System.Windows.Forms;

namespace QuickModel3D
{
    public partial class Canvas : Panel
    {
        bool _IsDrawing = false;

        public Canvas()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        protected void DrawPoint(Point location)
        {
            var graphics = CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var brush = new SolidBrush(Color.Black);
            graphics.FillEllipse(brush, location.X, location.Y, 8, 8);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _IsDrawing = true;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if(_IsDrawing)
                DrawPoint(e.Location);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _IsDrawing = false;
        }
    }
}
