using QuickModel3D.Model;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class FilterUI : DialogUI
    {
        private Model.Filter _Filter
            = null;

        public Model.Filter Filter
        {
            get { return _Filter; }
            set
            {
                _Filter = value;
                UpdateFilter();
            }
        }

        public FilterUI()
        {
            InitializeComponent();
        }

        public void UpdateFilter()
        {

        }
    }
}
