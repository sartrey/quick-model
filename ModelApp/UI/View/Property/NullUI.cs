using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class NullUI : UserControl
    {
        public NullUI()
        {
            InitializeComponent();
            LblText.Text = "没有选中任何资源，\n\n或资源没有对应的属性页。";
        }
    }
}
