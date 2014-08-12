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
            var property = runtime.GetViewById("property") as PropertyUI;

            var entities = project.Entities;
            entities.EntityAdded += assets.AddEntity;
            entities.EntityRemoved += assets.RemoveEntity;
            entities.EntitySelected += property.SelectEntity;

            assets.UpdateProject();
        }

        private void MnuFile_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuFile_New_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            var project = new Model.Project();
            project.Path = dlg.SelectedPath;
            BindProject(project);
        }

        private void MnuFile_Open_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            var project = new Model.Project();
            project.Load(dlg.SelectedPath);
            BindProject(project);
        }
    }
}
