using QuickModel3D.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class DrawUI : UserControl
    {
        private Entity _Entity;
        private Bitmap _BackColorIcon = null;
        private Bitmap _ForeColorIcon = null;

        public Entity Entity
        {
            get { return _Entity; }
            set 
            {
                _Entity = value;
                if(value.Texture != null)
                    Canvas.DrawImage(value.Texture);
            }
        }

        public Canvas Canvas
        {
            get { return MainPanel.Controls[0] as Canvas; }
        }

        public DrawUI()
        {
            InitializeComponent();
            InitCanvas();
            InitToolbar();
        }

        private void InitCanvas() 
        {
            var canvas = new Canvas();
            canvas.WorkRectSize = new Size(500, 500);
            canvas.ClientSizeChanged += OnClientSizeChanged;
            SizeChanged += OnSizeChanged;
            MainPanel.Controls.Add(canvas);
        }

        private void InitToolbar() 
        {
            SelectTool(ToolType.Pen);
            CobxBrush.Items.Clear();
            for (int i = 0; i < 5; i++)
                CobxBrush.Items.Add(i + 1);
            CobxBrush.SelectedIndex = 0;
            _BackColorIcon = new Bitmap(16, 16);
            _ForeColorIcon = new Bitmap(16, 16);
            SetColor(Color.White, true);
            SetColor(Color.Black, false);
            BtnForeColor.Image = _ForeColorIcon;
            BtnBackColor.Image = _BackColorIcon;
        }

        private void SelectTool(ToolType tool) 
        {
            BtnPen.Checked = false;
            BtnLine.Checked = false;
            BtnEraser.Checked = false;
            if (tool == ToolType.Pen)
                BtnPen.Checked = true;
            else if (tool == ToolType.Line)
                BtnLine.Checked = true;
            else if (tool == ToolType.Eraser)
                BtnEraser.Checked = true;
            Canvas.CurrentTool = tool;
        }

        private void SetColor(Color color, bool back = true)
        {
            var g = Graphics.FromImage(
                back ? _BackColorIcon : _ForeColorIcon);
            g.Clear(color);
            g.DrawRectangle(
                new Pen(Color.Black, 1), 
                new Rectangle(0, 0, 15, 15));
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            OnClientSizeChanged();
        }

        private void OnClientSizeChanged() 
        {
            Canvas.Left = (MainPanel.Width - Canvas.Width) / 2;
            Canvas.Top = (MainPanel.Height - Canvas.Height) / 2;
        }

        private void BtnPen_Click(object sender, EventArgs e)
        {
            if (BtnPen.Checked)
                return;
            SelectTool(ToolType.Pen);
        }

        private void BtnEraser_Click(object sender, EventArgs e)
        {
            if (BtnEraser.Checked)
                return;
            SelectTool(ToolType.Eraser);
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            if (BtnLine.Checked)
                return;
            SelectTool(ToolType.Line);
        }

        private void CobxBrush_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CobxBrush.SelectedItem == null)
                return;
            var brush = CobxBrush.SelectedIndex + 1;
            Canvas.BrushSize = brush;
        }

        private void BtnBackColor_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            Canvas.BackColor = dlg.Color;
            SetColor(dlg.Color, true);
        }

        private void BtnForeColor_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            Canvas.ForeColor = dlg.Color;
            SetColor(dlg.Color, false);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Entity.Texture != null)
                Entity.Texture.Dispose();
            Entity.Texture = Canvas.RenderFrame;
            MessageBox.Show("已将当前贴图缓存在内存。");
        }
    }
}
