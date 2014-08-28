using QuickModel3D.Model;

namespace QuickModel3D.UI
{
    public partial class AddFilterUI : DialogUI
    {
        private FilterType[] _Types 
            = new FilterType[] {
                FilterType.Extreme, FilterType.Relative
            };

        public AddFilterUI()
        {
            InitializeComponent();
            InitFilter();
        }

        private void InitFilter() 
        {
            CobxType.Items.Clear();
            foreach(var type in _Types)
                CobxType.Items.Add(Model.Filter.GetTypeName(type));
            CobxType.SelectedIndex = 0;
        }

        private Model.Filter CreateFilter()
        {
            int index = CobxType.SelectedIndex;
            var type = _Types[index];
            if (type == FilterType.Extreme)
                return new ExtremeFilter();
            else if (type == FilterType.Relative)
                return new RelativeFilter();
            return null;
        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {
            var filter = CreateFilter();
            if (filter == null)
                return;
            var project = Runtime.Instance.Project;
            filter.Name = TbxName.Text;
            project.FilterHub.AddFilter(filter);
            FinishDialog(true);
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            FinishDialog(false);
        }
    }
}
