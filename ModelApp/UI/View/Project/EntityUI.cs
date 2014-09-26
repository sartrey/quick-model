using QuickModel3D.Model;
using System.Drawing;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class EntityUI : DialogUI
    {
        private Entity _Entity
            = null;

        public Entity Entity
        {
            get { return _Entity; }
            set 
            {
                _Entity = value;
                UpdateEntity();
            }
        }

        public EntityUI()
        {
            InitializeComponent();
        }

        public void UpdateEntity() 
        {
            if (_Entity == null)
                return;
            LblId.Text = "索引：" + _Entity.Id.ToString();
            TbxName.Text = _Entity.Name;
            PicTexture.Image = _Entity.Texture;
        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {
            _Entity.Name = TbxName.Text;
            //do NOT update texture
            FinishDialog(true);
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            FinishDialog(false);
        }

        private void BtnDraw_Click(object sender, System.EventArgs e)
        {
            var draw = new DrawUI();
            draw.Entity = _Entity;

            var doc = new UI.Document("texture", draw, "绘制贴图");
            doc.Show();
            BtnOK_Click(null, null);
        }

        private void BtnImport_Click(object sender, System.EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "图片文件|*.png;*.jpg;*.bmp";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            var image = Image.FromFile(dlg.FileName);
            if (image.Width != 500 || image.Height != 500)
                image = GetResizeImage(image);
            if (_Entity.Texture != null)
                _Entity.Texture.Dispose();
            _Entity.Texture = image;
            PicTexture.Image = image;
        }

        private void BtnClear_Click(object sender, System.EventArgs e)
        {
            if (_Entity.Texture != null)
            {
                _Entity.Texture.Dispose();
                _Entity.Texture = null;
            }
        }

        private Image GetResizeImage(Image source) 
        {
            var bitmap = new Bitmap(500, 500);
            var graphics = Graphics.FromImage(bitmap);
            graphics.CompositingQuality = 
                System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            graphics.DrawImage(source, 0, 0, 500, 500);
            source.Dispose();
            return bitmap;
        }
    }
}
