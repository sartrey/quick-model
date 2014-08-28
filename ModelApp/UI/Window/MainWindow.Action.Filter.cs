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
            var filters = runtime.Project.FilterHub;
            var filter = filters.CurrentFilter;
            if (filter != null)
                filters.RemoveFilter(filter);
        }

        private void MnuFilter_Property_Click(object sender, System.EventArgs e)
        {
            var runtime = Runtime.Instance;
            if (runtime.Project == null)
                return;
            var filters = runtime.Project.FilterHub;
            var filter = filters.CurrentFilter;
            if (filter == null)
                return;
            var property = new FilterUI();
            property.Filter = filter;

            var dlg = new Dialog(property, "约束属性");
            dlg.Show();

            if (dlg.ValidDialogResult(false))
                return;
            filters.UpdateFilter(filter);
        }
    }
}
