using QuickModel3D.Model;
using System;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class MainWindow
    {
        private void AddEntity(int count)
        {
            var runtime = Runtime.Instance;
            var entities = runtime.Project.EntityHub;
            for (int i = 0; i < count; i++)
            {
                var entity = new Entity();
                entities.AddEntity(entity);
            }
        }

        private void MnuEntity_Add_Click(object sender, EventArgs e)
        {
            AddEntity(1);
        }

        private void MnuEntity_AddBatch_Click(object sender, EventArgs e)
        {
            var view = new AddBatchUI();
            var dlg = new Dialog(view, "批量添加");
            dlg.Show();
            if (!dlg.ValidDialogResult(true))
                return;
            var dlg_view = dlg.View as AddBatchUI;
            int total = view.Total;
            dlg.Dispose();
            AddEntity(total);
        }

        private void MnuEntity_Delete_Click(object sender, EventArgs e)
        {
            var runtime = Runtime.Instance;
            var entities = runtime.Project.EntityHub;
            var entity = entities.CurrentEntity;
            if (entity != null)
                entities.RemoveEntity(entity);
        }

        private void MnuEntity_Property_Click(object sender, EventArgs e)
        {
            var runtime = Runtime.Instance;
            if (runtime.Project == null)
                return;
            var entities = runtime.Project.EntityHub;
            var entity = entities.CurrentEntity;
            if (entity == null)
                return;

            var property = new EntityUI();
            property.Entity = entity;

            var dlg = new Dialog(property, "模块属性");
            dlg.Show();

            if (dlg.ValidDialogResult(false))
                return;
            entities.UpdateEntity(entity);
        }
    }
}
