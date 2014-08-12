using QuickModel3D.Model;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class EntityUI : UserControl
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
        }
    }
}
