using QuickModel3D.Model;
using System;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class MainWindow
    {
        private void BindProject(Project project)
        {
            var runtime = Runtime.Instance;
            var assets = runtime.GetViewById("assets") as AssetsUI;
            EntityHub entities = null;
            FilterHub filters = null;
            var old_project = runtime.Project;
            if (old_project != null)
            {
                entities = old_project.EntityHub;
                entities.EntityAdded -= assets.AddEntity;
                entities.EntityRemoved -= assets.RemoveEntity;
                entities.EntityUpdated -= assets.UpdateEntity;

                filters = old_project.FilterHub;
                filters.FilterAdded -= assets.AddFilter;
                filters.FilterRemoved -= assets.RemoveFilter;
                filters.FilterUpdated -= assets.UpdateFilter;
            }

            entities = project.EntityHub;
            entities.EntityAdded += assets.AddEntity;
            entities.EntityRemoved += assets.RemoveEntity;
            entities.EntityUpdated += assets.UpdateEntity;

            filters = project.FilterHub;
            filters.FilterAdded += assets.AddFilter;
            filters.FilterRemoved += assets.RemoveFilter;
            filters.FilterUpdated += assets.UpdateFilter;

            runtime.Project = project;
            assets.UpdateProject();
        }

        private void MnuFile_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuFile_New_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.Description = "请选择一个目录用于创建项目。";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            var project = new Model.Project();
            BindProject(project);
        }

        private void MnuFile_Open_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.Description = "请选择项目所在目录。";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            var project = new Model.Project();
            project.Load(dlg.SelectedPath);
            BindProject(project);
        }
    }
}
