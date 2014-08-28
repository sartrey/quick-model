namespace QuickModel3D.UI
{
    partial class AssetsUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbxPreStat = new System.Windows.Forms.TextBox();
            this.TrvAssets = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // TbxPreStat
            // 
            this.TbxPreStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TbxPreStat.Font = new System.Drawing.Font("宋体", 10F);
            this.TbxPreStat.Location = new System.Drawing.Point(0, 341);
            this.TbxPreStat.Multiline = true;
            this.TbxPreStat.Name = "TbxPreStat";
            this.TbxPreStat.ReadOnly = true;
            this.TbxPreStat.Size = new System.Drawing.Size(284, 100);
            this.TbxPreStat.TabIndex = 3;
            // 
            // TrvAssets
            // 
            this.TrvAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrvAssets.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.TrvAssets.Location = new System.Drawing.Point(0, 0);
            this.TrvAssets.Name = "TrvAssets";
            this.TrvAssets.Size = new System.Drawing.Size(284, 341);
            this.TrvAssets.TabIndex = 4;
            this.TrvAssets.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvAssets_AfterSelect);
            // 
            // AssetsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TrvAssets);
            this.Controls.Add(this.TbxPreStat);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "AssetsUI";
            this.Size = new System.Drawing.Size(284, 441);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxPreStat;
        private System.Windows.Forms.TreeView TrvAssets;
    }
}