using QuickModel3D.Model;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class PropertyUI : UserControl
    {
        public Control View 
        {
            get { return Controls.Count > 0 ? Controls[0] : null; }
            set 
            {
                var current_view = View;
                if (value == current_view)
                    return;
                if (current_view != null)
                {
                    current_view.Dispose();
                    Controls.Clear();
                }
                value.Dock = DockStyle.Fill;
                Controls.Add(value);
            }
        }

        public string Id
        {
            get { return "property"; }
        }

        public PropertyUI()
        {
            InitializeComponent();
            SelectNull();
        }

        public void SelectEntity(Entity entity) 
        {
            var ui = new EntityUI();
            ui.Model = entity;
            View = ui;
        }

        public void SelectFilter(Filter filter) 
        {
            var ui = new FilterUI();
            ui.Model = filter;
            View = ui;
        }

        public void SelectNull() 
        {
            View = new NullUI();
        }
    }
}
