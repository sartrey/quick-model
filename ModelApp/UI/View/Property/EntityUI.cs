using QuickModel3D.Model;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class EntityUI : DialogUI
    {
        private Entity _Model
            = null;

        public Entity Model 
        {
            get { return _Model; }
            set 
            {
                _Model = value;
                UpdateModel();
            }
        }

        public EntityUI()
        {
            InitializeComponent();
        }

        public void UpdateModel() 
        {
            LblId.Text = "标识：" + _Model.Id.ToString();
            TbxName.Text = _Model.Name;

        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {
            _Model.Name = TbxName.Text;
            FinishDialog(true);
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            FinishDialog(false);
        }

        private void BtnDraw_Click(object sender, System.EventArgs e)
        {
            var draw = new DrawUI();
            draw.Model = _Model.Texture;

            var doc = new UI.Document("texture", draw, "绘制贴图");
            doc.Show();
            BtnOK_Click(null, null);
        }
    }
}
