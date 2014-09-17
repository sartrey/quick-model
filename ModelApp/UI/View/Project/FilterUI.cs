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
            Control ctrl = null;
            if (_Filter.Type == FilterType.Extreme)
            {
                var ui = new Filter.ExtremeUI();
                ui.Filter = _Filter;
                ctrl = ui;
            }
            else if(_Filter.Type == FilterType.Relative)
            {
                var ui = new Filter.RelativeUI();
                ui.Filter = _Filter;
                ctrl = ui;
            }
            Grp2.Height = ctrl.Height + 20;
            Height = Grp2.Bottom + 50;
            BtnOK.Top = Grp2.Bottom + 10;
            BtnCancel.Top = Grp2.Bottom + 10;
            Grp2.Controls.Add(ctrl);
            ctrl.Dock = DockStyle.Fill;

            TxtId.Text = "标识：" + _Filter.Id.ToString();
            TxtType.Text = "类型：" + Model.Filter.GetTypeName(_Filter.Type);
            TbxName.Text = _Filter.Name;
        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {
            var ctrl = Grp2.Controls[0];
            if (_Filter.Type == FilterType.Extreme)
            {
                var ui = ctrl as Filter.ExtremeUI;
                if (!ui.ValidFilter())
                    return;
            }
            else if (_Filter.Type == FilterType.Relative)
            {
                var ui = ctrl as Filter.RelativeUI;
                if (!ui.ValidFilter())
                    return;
            }
            _Filter.Name = TbxName.Text;
            FinishDialog(true);
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            FinishDialog(false);
        }
    }
}
