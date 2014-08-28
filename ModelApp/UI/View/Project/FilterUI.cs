using QuickModel3D.Model;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class FilterUI : UserControl
    {
        private Filter _Model
            = null;

        public Filter Model
        {
            get { return _Model; }
            set
            {
                _Model = value;
                UpdateModel();
            }
        }

        public FilterUI()
        {
            InitializeComponent();
        }

        public void UpdateModel()
        {
        }
    }
}
