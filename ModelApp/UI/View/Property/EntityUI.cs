using QuickModel3D.Model;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class EntityUI : DialogUI
    {
        private Entity _Entity
            = null;
        private string[] _Shapes
            = new string[] { "立方体", "球体" };

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
            CobxGeometry.Items.Clear();
            foreach (var shape in _Shapes)
                CobxGeometry.Items.Add(shape);
        }

        private int GetShapeIndex(ShapeType shape) 
        {
            if (shape == ShapeType.Cube)
                return 0;
            if (shape == ShapeType.Sphere)
                return 1;
            return -1;
        }

        public void UpdateEntity() 
        {
            if (_Entity == null)
                return;
            LblId.Text = "索引：" + _Entity.Id.ToString();
            TbxName.Text = _Entity.Name;
            int shape_index = GetShapeIndex(_Entity.Shape.Type);
            CobxGeometry.SelectedIndex = shape_index;
            PicTexture.Image = _Entity.Texture;
        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {
            _Entity.Name = TbxName.Text;
            //shape
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

        }

        private void BtnClear_Click(object sender, System.EventArgs e)
        {
        }
    }
}
