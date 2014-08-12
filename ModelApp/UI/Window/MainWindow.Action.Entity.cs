using QuickModel3D.Model;
using System;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class MainWindow
    {
        private void MnuEntity_Add_Click(object sender, EventArgs e)
        {
            var runtime = Runtime.Instance;
            var entities = runtime.Project.Entities;
            var entity = new Entity(entities.NewId);
            entities.LinkEntity(entity);
        }

        private void MnuEntity_AddBatch_Click(object sender, EventArgs e)
        {
            var view = new AddBatchUI();
            var dlg = new Dialog(view, "批量添加");
            dlg.Show();
            if (!dlg.ValidDialogResult(true))
                return;
            var dlg_view = dlg.View as AddBatchUI;
            var runtime = Runtime.Instance;
            var entities = runtime.Project.Entities;
            int total = view.Total;
            for (int i = 0; i < total; i++)
            {
                var entity = new Entity(entities.NewId);
                entities.LinkEntity(entity);
            }
            dlg.Dispose();
        }

        private void MnuEntity_Delete_Click(object sender, EventArgs e)
        {
            var runtime = Runtime.Instance;
            var assets = runtime.GetViewById("assets") as AssetsUI;
            TreeNode node = null;// assets.CurrentNode;
            if (node != null)
            {
                var entities = runtime.Project.Entities;
                var entity = entities[(int)node.Tag];
                entities.KickEntity(entity);
            }
        }
    }
}
