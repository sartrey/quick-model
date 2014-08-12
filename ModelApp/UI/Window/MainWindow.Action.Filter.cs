using QuickModel3D.Model;
using System;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class MainWindow
    {
        private void MnuFilter_Add_Click(object sender, EventArgs e)
        {
            var runtime = Runtime.Instance;
            var filters = runtime.Project.Filters;
            var filter = new Filter(filters.NewId);
            filters.LinkFilter(filter);
        }

        private void MnuFilter_Delete_Click(object sender, EventArgs e)
        {
            var runtime = Runtime.Instance;
            var assets = runtime.GetViewById("assets") as AssetsUI;
            TreeNode node = null;// assets.CurrentNode;
            if (node != null)
            {
                var filters = runtime.Project.Filters;
                var filter = filters[(int)node.Tag];
                filters.KickFilter(filter);
            }
        }
    }
}
