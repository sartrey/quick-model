using QuickModel3D.Model;
using System.Windows.Forms;

namespace QuickModel3D.UI.Filter
{
    public partial class RelativeUI : UserControl
    {
        private Model.Filter _Filter
            = null;

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

        public Entity EntityA 
        {
            get 
            {
                int index = CobxEntityA.SelectedIndex;
                return Entities[index];
            }
        }

        public Entity EntityB
        {
            get
            {
                int index = CobxEntityB.SelectedIndex;
                return Entities[index];
            }
        }

        public bool IsLink 
        {
            get { return ChbxIsLink.Checked; }
        }

        public RelativeUI()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI() 
        {
            foreach (var entity in Entities)
            {
                var text =
                    string.IsNullOrWhiteSpace(entity.Name) ?
                    string.Format("(标识：{0})", entity.Id) :
                    entity.Name;
                CobxEntityA.Items.Add(text);
                CobxEntityB.Items.Add(text);
            }
        }

        public void UpdateFilter() 
        {
            var filter = _Filter as RelativeFilter;
            var entity_a = filter.EntityA;
            var entity_b = filter.EntityB;
            for (int i = 0; i < Entities.Length; i++) 
            {
                var entity = Entities[i];
                if (entity_a == entity)
                    CobxEntityA.SelectedIndex = i;
                if (entity_b == entity)
                    CobxEntityB.SelectedIndex = i;
            }
            ChbxIsLink.Checked = filter.IsLink;
        }

        public bool ValidFilter()
        {
            var filter = _Filter as Model.RelativeFilter;
            if (EntityA == EntityB)
            {
                MessageBox.Show("模块A和模块B不能指向同一个模块。");
                return false;
            }
            filter.EntityA = EntityA;
            filter.EntityB = EntityB;
            filter.IsLink = IsLink;
            return true;
        }
    }
}
