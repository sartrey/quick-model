using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class LayoutUI : UserControl
    {
        public LayoutUI()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, System.EventArgs e)
        {
            Runtime.Instance.ModelHub.RemoveAllModels();
            LsvLayout.Items.Clear();
            var engine = Runtime.Instance.Engine;
            engine.ModelCreated += OnModelCreated;
            engine.Generate();
        }

        private void OnModelCreated(Model.Model model)
        {
            var models = Runtime.Instance.ModelHub;
            model.Id = models.Count;
            models.AddModel(model);
            var lvi = new ListViewItem(
                new string[]
                {
                    model.Id.ToString(),
                    model.KeyPoints.ToString(),
                    "0"
                });
            LsvLayout.Items.Add(lvi);
        }
    }
}
