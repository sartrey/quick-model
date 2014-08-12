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
            entities.AddEntity(entity);
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
                entities.AddEntity(entity);
            }
            dlg.Dispose();
        }

        private void MnuEntity_Delete_Click(object sender, EventArgs e)
        {
            var runtime = Runtime.Instance;
            var entities = runtime.Project.Entities;
            var entity = entities.CurrentEntity;
            if (entity != null)
                entities.RemoveEntity(entity);
        }
        private void MnuEntity_Property_Click(object sender, EventArgs e)
        {
            var property = new EntityUI();
            var runtime = Runtime.Instance;
            var entities = runtime.Project.Entities;
            var entity = entities.CurrentEntity;
            property.Model = entity;

            var dlg = new Dialog(property, "模块属性");
            dlg.Show();

            if (dlg.ValidDialogResult(false))
                return;
            entities.UpdateEntity(entity);
        }
    }
}
