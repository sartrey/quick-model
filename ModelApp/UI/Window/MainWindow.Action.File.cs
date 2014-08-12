using System;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class MainWindow
    {
        private void BindProject(Model.Project project)
        {
            var runtime = Runtime.Instance;
            runtime.Project = project;

            var assets = runtime.GetViewById("assets") as AssetsUI;

            var entities = project.Entities;
            entities.EntityAdded += assets.AddEntity;
            entities.EntityRemoved += assets.RemoveEntity;
            entities.EntityUpdated += assets.UpdateEntity;

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
            project.Path = dlg.SelectedPath;
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
