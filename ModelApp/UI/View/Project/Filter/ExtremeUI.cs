using QuickModel3D.Model;
using System;
using System.Windows.Forms;

namespace QuickModel3D.UI.Filter
{
    public partial class ExtremeUI : UserControl
    {
        private Model.Filter _Filter
            = null;
        private string[] _Extremes
            = new string[] {
                "最前（X+）", "最后（X-）", "最右（Y+）", 
                "最左（Y-）", "最上（Z+）", "最下（Z-）"
            };

        private Entity[] Entities
        {
            get
            {
                var project = Runtime.Instance.Project;
                var entities = project.EntityHub.EntityArray;
                return entities;
            }
        }

        public Model.Filter Filter
        {
            get { return _Filter; }
            set
            {
                _Filter = value;
                UpdateFilter();
            }
        }

        public Entity Entity
        {
            get
            {
                int index = CobxEntity.SelectedIndex;
                return Entities[index];
            }
        }

        public int Extreme 
        {
            get { return CobxExtreme.SelectedIndex; }
        }

        public bool IsAnchor
        {
            get { return ChbxIsAnchor.Checked; }
        }

        public bool IsOnlyOne
        {
            get { return ChbxOnlyOne.Checked; }
        }

        public ExtremeUI()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI() 
        {
            foreach (var ex in _Extremes)
                CobxExtreme.Items.Add(ex);
            foreach (var entity in Entities)
            {
                var text =
                    string.IsNullOrWhiteSpace(entity.Name) ?
                    string.Format("(标识：{0})", entity.Id) :
                    entity.Name;
                CobxEntity.Items.Add(text);
            }
            ChbxOnlyOne.Enabled = false;
        }

        public void UpdateFilter()
        {
            var filter = _Filter as Model.ExtremeFilter;
            for (int i = 0; i < Entities.Length; i++)
                if (filter.Entity == Entities[i])
                {
                    CobxEntity.SelectedIndex = i;
                    break;
                }
            CobxExtreme.SelectedIndex = filter.Extreme;
            ChbxIsAnchor.Checked = filter.IsAnchor;
            ChbxOnlyOne.Checked = filter.IsOnlyOne;
        }

        public bool ValidFilter()
        {
            var filter = _Filter as Model.ExtremeFilter;
            filter.Entity = Entity;
            filter.Extreme = Extreme;
            filter.IsAnchor = IsAnchor;
            filter.IsOnlyOne = IsOnlyOne;
            return true;
        }

        private void ChbxIsAnchor_CheckedChanged(object sender, EventArgs e)
        {
            ChbxOnlyOne.Enabled = ChbxIsAnchor.Checked;
            if (!ChbxIsAnchor.Checked)
                ChbxOnlyOne.Checked = false;
        }
    }
}
