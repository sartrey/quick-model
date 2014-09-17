using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class StructureUI : UserControl
    {
        public int CurrentLayout
        {
            get 
            {
                if (LsvLayout.SelectedItems.Count != 1)
                    return -1;
                var index = LsvLayout.SelectedIndices[0];
                return index;
            }
        }

        public int CurrentArrange
        {
            get 
            { 
                if (LsvArrange.SelectedItems.Count != 1)
                    return -1;
                var index = LsvArrange.SelectedIndices[0];
                return index;
            }
        }

        public StructureUI()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            LsvLayout.Width = Width / 2;
            ColhLayout.Width = LsvLayout.Width;
            ColhArrange.Width = LsvLayout.Width;
        }

        private void ResetUI() 
        {
            LsvLayout.Items.Clear();
            LsvArrange.Items.Clear();
        }

        private void LoadLayout() 
        {
            var project = Runtime.Instance.Project;
            var layouts = project.Layouts;
            for (int i = 0; i < layouts.Count; i++)
            {
                string txt_points = null;
                var layout = layouts[i];
                for (int j = 0; j < layout.Points.Length; j++)
                {
                    var point = layout.Points[j];
                    txt_points += string.Format("({0},{1},{2}) ",
                        point.X, point.Y, point.Z);
                }
                var lvi = new ListViewItem(
                    new string[] { (i + 1).ToString(), txt_points });
                LsvLayout.Items.Add(lvi);
            }
            TxtStatLayout.Text = "布局共有 " + layouts.Count;
        }

        private void LoadArrange() 
        {
            var project = Runtime.Instance.Project;
            var arranges = project.Arranges;
            for (int i = 0; i < arranges.Count; i++)
            {
                var arrange = arranges[i];
                string txt_arrange = string.Join(",", arrange.Ids);
                var lvi = new ListViewItem(
                    new string[] { (i + 1).ToString(), txt_arrange });
                LsvArrange.Items.Add(lvi);
            }
            TxtStatArrange.Text = "排列共有 " + arranges.Count;
        }

        private void BtnGenerate_Click(object sender, System.EventArgs e)
        {
            ResetUI();
            var runtime = Runtime.Instance;
            var project = runtime.Project;
            var engine = runtime.Engine;

            engine.GenerateLayout();
            LoadLayout();

            engine.GenerateArrange();
            LoadArrange();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            ResetUI();
            var runtime = Runtime.Instance;
            var project = runtime.Project;
            var engine = runtime.Engine;

            engine.DoWithFilter();
            LoadLayout();
            LoadArrange();
        }

        private void LsvLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            var project = Runtime.Instance.Project;
            var layout_index = CurrentLayout;
            if (layout_index < 0)
                return;
            var layout = project.Layouts[layout_index];
            var items = LsvArrange.Items;
            int valid_count = 0;
            foreach (ListViewItem lvi in items)
            {
                var arrange_index = lvi.Index;
                if (layout.InvalidArranges.Contains(arrange_index))
                    lvi.ForeColor = Color.LightGray;
                else
                {
                    lvi.ForeColor = Color.Black;
                    valid_count++;
                }
            }
            TxtStatArrange.Text = "有效排列共有 " + valid_count;
        }

        private void BtnSaveStructure_Click(object sender, EventArgs e)
        {
            var project = Runtime.Instance.Project;
            var model = new Model.Model();
            model.Project = project;
            int total = 0;
            for (int i = 0; i < project.Layouts.Count; i++)
            {
                model.LayoutIndex = i;
                var layout = model.Layout;
                for (int j = 0; j < project.Arranges.Count; j++)
                {
                    var arrange = project.Arranges[j];
                    if (layout.InvalidArranges.Contains(j))
                        continue;
                    model.ArrangeIndex = j;
                    var xml = model.ToStructureXML();
                    xml.Save(
                        Path.Combine(
                        Runtime.Instance.UnityDataPath,
                        "model" + (total + 1) + ".xml"));
                    total++;
                }
            }
            MessageBox.Show(string.Format("共生成{0}个结构预览，请在预览窗口刷新场景。", total));
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            var project = Runtime.Instance.Project;
            var model = new Model.Model();
            model.Project = project;
            model.LayoutIndex = CurrentLayout;
            model.ArrangeIndex = CurrentArrange;
            var total = model.Entities.Length;
            if (model.Shapes.Count != total)
            {
                model.Shapes.Clear();
                for (int i = 0; i < total; i++)
                    model.Shapes.Add(new Model.Shape());
            }

            var shape_ui = new ShapeUI();
            shape_ui.Model = model;

            var dlg = new Dialog(shape_ui, "模型定型");
            dlg.Show();
        }
    }
}