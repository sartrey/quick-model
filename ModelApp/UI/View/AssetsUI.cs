using QuickModel3D.Model;
using System;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class AssetsUI : UserControl
    {
        public TreeNode CurrentNode
        {
            get { return TrvAssets.SelectedNode; }
        }

        public TreeNode EntityNode
        {
            get
            {
                if (TrvAssets.Nodes.Count > 0)
                    return TrvAssets.Nodes[0].Nodes[0];
                return null;
            }
        }

        public TreeNode FilterNode
        {
            get
            {
                if (TrvAssets.Nodes.Count > 0)
                    return TrvAssets.Nodes[0].Nodes[1];
                return null;
            }
        }

        public AssetsUI()
        {
            InitializeComponent();
        }

        public TreeNode GetEntityNodeById(int id)
        {
            foreach (TreeNode node in EntityNode.Nodes)
                if (id == (int)node.Tag)
                    return node;
            return null;
        }

        public TreeNode GetFilterNodeById(int id)
        {
            foreach (TreeNode node in FilterNode.Nodes)
                if (id == (int)node.Tag)
                    return node;
            return null;
        }

        public void UpdateProject() 
        {
            var runtime = Runtime.Instance;
            if (runtime.Project == null)
                TrvAssets.Nodes.Clear();
            else 
            {
                var node_project = new TreeNode();
                node_project.Text = "项目";
                node_project.Tag = "project";
                TrvAssets.Nodes.Add(node_project);

                var node_entity = new TreeNode();
                node_entity.Text = "模块";
                node_entity.Tag = "entity";
                node_project.Nodes.Add(node_entity);
                
                var node_filter = new TreeNode();
                node_filter.Text = "约束";
                node_filter.Tag = "filter";
                node_project.Nodes.Add(node_filter);

                node_project.ExpandAll();
            }
        }

        public void UpdateStat() 
        {
            TbxPreStat.Text = "";
            var runtime = Runtime.Instance;
            var entities = runtime.Project.EntityHub;
            int entity_count = entities.Count;
            TbxPreStat.Text += "共有功能模块 " + entity_count + " 个。" + Environment.NewLine;
            if(entity_count == 1)
                TbxPreStat.Text += "可能的空间布局方案共有 1 个。";
            else if (entity_count < 5)
            {
                long layout_count =
                    (long)(6 * System.Math.Pow(5, entity_count - 2) * Sartrey.Math.Factorial(entity_count));
                TbxPreStat.Text += "可能的空间布局方案共有 " + layout_count + " 个。";
            }
            else
            {
                //double layout_count_log =
                //    0.778151 * (entity_count - 2) * 0.69897 +
                //    Sartrey.Math.LogFactorial(entity_count, 10);
                double layout_count_log = 0;
                long log = (long)System.Math.Floor(layout_count_log);
                TbxPreStat.Text += "可能的空间布局方案共有约 10e" + log + " 个。";
            }
        }

        public void AddEntity(Entity entity)
        {
            var node = new TreeNode();
            node.Text = 
                string.IsNullOrWhiteSpace(entity.Name) ? 
                "（模块" + entity.Id + "）" : 
                entity.Name;
            node.Tag = entity.Id;
            EntityNode.Nodes.Add(node);
            UpdateStat();
        }

        public void RemoveEntity(Entity entity)
        {
            var node = GetEntityNodeById(entity.Id);
            node.Remove();
            UpdateStat();
        }

        public void UpdateEntity(Entity entity) 
        {
            var node = GetEntityNodeById(entity.Id);
            node.Text =
                string.IsNullOrWhiteSpace(entity.Name) ?
                "（模块" + entity.Id + "）" :
                entity.Name;
        }

        public void AddFilter(Model.Filter filter)
        {
            var node = new TreeNode();
            node.Text =
                string.IsNullOrWhiteSpace(filter.Name) ?
                "（" + Model.Filter.GetTypeName(filter.Type) + " - " + filter.Id + "）" :
                filter.Name;
            node.Tag = filter.Id;
            FilterNode.Nodes.Add(node);
        }

        public void RemoveFilter(Model.Filter filter)
        {
            var node = GetFilterNodeById(filter.Id);
            node.Remove();
        }

        public void UpdateFilter(Model.Filter filter)
        {
            var node = GetFilterNodeById(filter.Id);
            node.Text =
                string.IsNullOrWhiteSpace(filter.Name) ?
                "（" + Model.Filter.GetTypeName(filter.Type) + " - " + filter.Id + "）" :
                filter.Name;
        }

        private void TrvAssets_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = TrvAssets.SelectedNode;
            if (node != null)
            {
                if (node.Level != 2)
                    return;
                var runtime = Runtime.Instance;
                var type = (string)node.Parent.Tag;
                if (type == "entity")
                {
                    var entities = runtime.Project.EntityHub;
                    var entity = entities[(int)node.Tag];
                    entities.CurrentEntity = entity;
                }
                else if (type== "filter")
                {
                    var filters = runtime.Project.FilterHub;
                    var filter = filters[(int)node.Tag];
                    filters.CurrentFilter = filter;
                }
            }
        }
    }
}
