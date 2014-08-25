using System;
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
                var lvi = LsvLayout.SelectedItems[0];
                var index = (int)lvi.Tag;
                return index;
            }
        }

        public int CurrentArrange
        {
            get 
            { 
                if (LsvArrange.SelectedItems.Count != 1)
                    return -1;
                var lvi = LsvArrange.SelectedItems[0];
                var index = (int)lvi.Tag;
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
            var layouts = project.LayoutHub;
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
                var lvi = new ListViewItem(new string[] { txt_points });
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
                string txt_arrange = string.Join(",", arrange);
                var lvi = new ListViewItem(new string[] { txt_arrange });
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

        private void BtnSaveStructure_Click(object sender, EventArgs e)
        {
            var layout = CurrentLayout;
            var arrange = CurrentArrange;
            if (layout == -1 || arrange == -1)
            {
                MessageBox.Show("请选择一个结构方案，包括一个布局和一个排列。");
                return;
            }
            var model = new Model.Model();
            model.Project = Runtime.Instance.Project;
            model.LayoutIndex = layout;
            //
            var xml = model.ToStructureXML();
            xml.Save(Path.Combine(Runtime.Instance.UnityDataPath, "model.xml"));
            MessageBox.Show("结构文件已经生成，请在预览窗口刷新场景。");
        }

        private void BtnSaveModel_Click(object sender, EventArgs e)
        {

        }
    }
}