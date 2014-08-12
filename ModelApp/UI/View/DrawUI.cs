using System.Drawing;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class DrawUI : UserControl
    {
        private Image _Model;

        public Image Model
        {
            get { return _Model; }
            set 
            {
                _Model = value; 
                //update
            }
        }

        public DrawUI()
        {
            InitializeComponent();
        }
    }
}
