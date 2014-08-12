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

        public TreeNode GetNodeById(int id)
        {
            foreach (TreeNode node in EntityNode.Nodes)
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
            var entities = runtime.Project.Entities;
            int entity_count = entities.Count;
            TbxPreStat.Text += "共有功能模块 " + entity_count + " 个。" + Environment.NewLine;
            long layout_count = 
                (long)(6 * System.Math.Pow(5, entity_count - 2) * Sartrey.Math.Factorial(entity_count));
            TbxPreStat.Text += "所有可能布局方案共有 " + layout_count + " 个。";
        }

        public void AddEntity(Entity entity)
        {
            var node = new TreeNode();
            node.Text = "功能模块" + entity.Id.ToString();
            node.Tag = entity.Id;
            EntityNode.Nodes.Add(node);
            UpdateStat();
        }

        public void RemoveEntity(Entity entity)
        {
            var node = GetNodeById(entity.Id);
            node.Remove();
            UpdateStat();
        }

        private void TrvAssets_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = TrvAssets.SelectedNode;
            if (node != null)
            {
                if (node.Level != 2 || 
                    (string)node.Parent.Tag != "entity")
                    return;
                var runtime = Runtime.Instance;
                var entities = runtime.Project.Entities;
                var entity = entities[(int)node.Tag];
                entities.CurrentEntity = entity;
            }
        }
    }
}
