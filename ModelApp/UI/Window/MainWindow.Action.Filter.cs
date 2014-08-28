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
            var view = new AddFilterUI();
            var dlg = new Dialog(view, "添加筛选");
            dlg.Show();
            if (!dlg.ValidDialogResult(true))
                return;
            var dlg_view = dlg.View as AddFilterUI;
            dlg.Dispose();
            //create filter
            //add filter
        }

        private void MnuFilter_Delete_Click(object sender, EventArgs e)
        {
            var runtime = Runtime.Instance;
            var assets = runtime.GetViewById("assets") as AssetsUI;
            TreeNode node = null;// assets.CurrentNode;
            if (node != null)
            {
                var filters = runtime.Project.FilterHub;
                var filter = filters[(int)node.Tag];
                filters.RemoveFilter(filter);
            }
        }
    }
}
