using QuickModel3D.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace QuickModel3D.UI
{
    public partial class ShapeUI : DialogUI
    {
        private string _ExternalPath 
            = null;
        private Model.Model _Model 
            = null;
        private string[] _ShapeNames
            = new string[] { "立方体", "球体", "圆柱体" };
        private Model.ShapeType[] _ShapeTypes 
            = new Model.ShapeType[] 
            {
                ShapeType.Cube,
                ShapeType.Sphere,
                ShapeType.Cylinder
            };

        public Model.Model Model
        { 
            get { return _Model; }
            set 
            {
                if (value == _Model)
                    return;
                _Model = value;
                UpdateModel();
            }
        }

        public ShapeUI()
        {
            InitializeComponent();
            CobxGeometry.Items.Clear();
            foreach (var shape in _ShapeNames)
                CobxGeometry.Items.Add(shape);
        }

        private void UpdateModel()
        {
            CobxEntity.Items.Clear();
            foreach (var entity in Model.Entities)
            {
                var text = 
                    string.IsNullOrWhiteSpace(entity.Name) ?
                        "（模块" + entity.Id + "）" : entity.Name;
                CobxEntity.Items.Add(text);
            }
            CobxEntity.SelectedIndex = 0;
        }

        private int GetShapeIndex(ShapeType shape) 
        {
            for (int i = 0; i < _ShapeTypes.Length; i++)
                if (_ShapeTypes[i] == shape)
                    return i;
            return -1;
        }

        private void CobxEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CobxEntity.SelectedItem == null)
                return;
            int index = CobxEntity.SelectedIndex;
            var shape = Model.Shapes[index];
            CobxGeometry.SelectedIndex = GetShapeIndex(shape.Type);
            TbxTX.Text = shape.Translate.X.ToString();
            TbxTY.Text = shape.Translate.Y.ToString();
            TbxTZ.Text = shape.Translate.Z.ToString();
            TbxSX.Text = shape.Scale.X.ToString();
            TbxSY.Text = shape.Scale.Y.ToString();
            TbxSZ.Text = shape.Scale.Z.ToString();
            TbxRX.Text = shape.Rotate.X.ToString();
            TbxRY.Text = shape.Rotate.Y.ToString();
            TbxRZ.Text = shape.Rotate.Z.ToString();
        }

        private bool SaveModel(string path) 
        {
            try
            {
                var files = Directory.GetFiles(path);
                if (files.Length > 0)
                {
                    var result = MessageBox.Show(
                        "目标目录已有文件，是否清理?", "注意",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        foreach (var file in files)
                            File.Delete(file);
                    }
                }
                var xml = _Model.ToFullXML();
                xml.Save(
                    Path.Combine(path, "fullmodel.xml"));
                for (int i = 0; i < _Model.Entities.Length; i++)
                {
                    var entity = _Model.Entities[i];
                    if (entity.Texture != null)
                        entity.Texture.Save(
                            Path.Combine(Runtime.Instance.UnityDataPath, "entity" + i + ".png"));
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            if (CobxEntity.SelectedItem == null)
                return;
            int index = CobxEntity.SelectedIndex;
            var shape = Model.Shapes[index];
            shape.Type = _ShapeTypes[CobxGeometry.SelectedIndex];
            shape.Translate.X = float.Parse(TbxTX.Text);
            shape.Translate.Y = float.Parse(TbxTY.Text);
            shape.Translate.Z = float.Parse(TbxTZ.Text);
            shape.Scale.X = float.Parse(TbxSX.Text);
            shape.Scale.Y = float.Parse(TbxSY.Text);
            shape.Scale.Z = float.Parse(TbxSZ.Text);
            shape.Rotate.X = float.Parse(TbxRX.Text);
            shape.Rotate.Y = float.Parse(TbxRY.Text);
            shape.Rotate.Z = float.Parse(TbxRZ.Text);
        }

        private void BtnSaveModel_Click(object sender, EventArgs e)
        {
            var path = Runtime.Instance.UnityDataPath;
            if (SaveModel(path))
                MessageBox.Show("成功输出模型文件到预览缓存，请在预览窗口刷新场景。");
            else
                MessageBox.Show("保存失败。");
            var result = MessageBox.Show(
                "是否保存模型到非缓存区?", "提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_ExternalPath == null)
                {
                    var dlg = new FolderBrowserDialog();
                    if (dlg.ShowDialog() != DialogResult.OK)
                        return;
                    path = dlg.SelectedPath;
                    _ExternalPath = path;
                }
                else 
                    path = _ExternalPath;
                if (SaveModel(path))
                    MessageBox.Show("成功输出模型文件到：\n" + path);
                else
                    MessageBox.Show("保存失败。");
            }
        }
    }
}
