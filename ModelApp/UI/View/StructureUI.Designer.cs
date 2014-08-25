namespace QuickModel3D.UI
{
    partial class StructureUI
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StructureUI));
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.TxtStatLayout = new System.Windows.Forms.ToolStripStatusLabel();
            this.TxtStatArrange = new System.Windows.Forms.ToolStripStatusLabel();
            this.Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.BtnGenerate = new System.Windows.Forms.ToolStripButton();
            this.BtnFilter = new System.Windows.Forms.ToolStripButton();
            this.MnuOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnUseFileAsMem = new System.Windows.Forms.ToolStripMenuItem();
            this.split1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnSaveStructure = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSaveModel = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LsvArrange = new System.Windows.Forms.ListView();
            this.ColhArrange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LsvLayout = new System.Windows.Forms.ListView();
            this.ColhLayout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusbar.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusbar
            // 
            this.statusbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtStatLayout,
            this.TxtStatArrange,
            this.Progress});
            this.statusbar.Location = new System.Drawing.Point(0, 454);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(640, 26);
            this.statusbar.SizingGrip = false;
            this.statusbar.TabIndex = 26;
            // 
            // TxtStatLayout
            // 
            this.TxtStatLayout.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.TxtStatLayout.Name = "TxtStatLayout";
            this.TxtStatLayout.Size = new System.Drawing.Size(261, 21);
            this.TxtStatLayout.Spring = true;
            this.TxtStatLayout.Text = "统计布局";
            // 
            // TxtStatArrange
            // 
            this.TxtStatArrange.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.TxtStatArrange.Name = "TxtStatArrange";
            this.TxtStatArrange.Size = new System.Drawing.Size(261, 21);
            this.TxtStatArrange.Spring = true;
            this.TxtStatArrange.Text = "统计排列";
            // 
            // Progress
            // 
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(100, 20);
            this.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolbar
            // 
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGenerate,
            this.BtnFilter,
            this.MnuOptions,
            this.split1,
            this.MnuSave});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(640, 25);
            this.toolbar.TabIndex = 27;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("BtnGenerate.Image")));
            this.BtnGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(76, 22);
            this.BtnGenerate.Text = "穷举结构";
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnFilter
            // 
            this.BtnFilter.Image = ((System.Drawing.Image)(resources.GetObject("BtnFilter.Image")));
            this.BtnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(76, 22);
            this.BtnFilter.Text = "筛选结构";
            // 
            // MnuOptions
            // 
            this.MnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnUseFileAsMem});
            this.MnuOptions.Image = ((System.Drawing.Image)(resources.GetObject("MnuOptions.Image")));
            this.MnuOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MnuOptions.Name = "MnuOptions";
            this.MnuOptions.Size = new System.Drawing.Size(61, 22);
            this.MnuOptions.Text = "选项";
            // 
            // BtnUseFileAsMem
            // 
            this.BtnUseFileAsMem.Name = "BtnUseFileAsMem";
            this.BtnUseFileAsMem.Size = new System.Drawing.Size(210, 22);
            this.BtnUseFileAsMem.Text = "使用文件缓存替代内存(&F)";
            // 
            // split1
            // 
            this.split1.Name = "split1";
            this.split1.Size = new System.Drawing.Size(6, 25);
            // 
            // MnuSave
            // 
            this.MnuSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSaveStructure,
            this.BtnSaveModel});
            this.MnuSave.Image = ((System.Drawing.Image)(resources.GetObject("MnuSave.Image")));
            this.MnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MnuSave.Name = "MnuSave";
            this.MnuSave.Size = new System.Drawing.Size(61, 22);
            this.MnuSave.Text = "保存";
            // 
            // BtnSaveStructure
            // 
            this.BtnSaveStructure.Name = "BtnSaveStructure";
            this.BtnSaveStructure.Size = new System.Drawing.Size(156, 22);
            this.BtnSaveStructure.Text = "保存为结构(&S)";
            this.BtnSaveStructure.Click += new System.EventHandler(this.BtnSaveStructure_Click);
            // 
            // BtnSaveModel
            // 
            this.BtnSaveModel.Name = "BtnSaveModel";
            this.BtnSaveModel.Size = new System.Drawing.Size(156, 22);
            this.BtnSaveModel.Text = "保存为模型(&M)";
            this.BtnSaveModel.Click += new System.EventHandler(this.BtnSaveModel_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.LsvArrange);
            this.Panel1.Controls.Add(this.LsvLayout);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 25);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(640, 429);
            this.Panel1.TabIndex = 28;
            // 
            // LsvArrange
            // 
            this.LsvArrange.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColhArrange});
            this.LsvArrange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvArrange.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LsvArrange.FullRowSelect = true;
            this.LsvArrange.GridLines = true;
            this.LsvArrange.Location = new System.Drawing.Point(320, 0);
            this.LsvArrange.Name = "LsvArrange";
            this.LsvArrange.Size = new System.Drawing.Size(320, 429);
            this.LsvArrange.TabIndex = 14;
            this.LsvArrange.UseCompatibleStateImageBehavior = false;
            this.LsvArrange.View = System.Windows.Forms.View.Details;
            // 
            // ColhArrange
            // 
            this.ColhArrange.Text = "排列";
            this.ColhArrange.Width = 320;
            // 
            // LsvLayout
            // 
            this.LsvLayout.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColhLayout});
            this.LsvLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.LsvLayout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LsvLayout.FullRowSelect = true;
            this.LsvLayout.GridLines = true;
            this.LsvLayout.Location = new System.Drawing.Point(0, 0);
            this.LsvLayout.Name = "LsvLayout";
            this.LsvLayout.Size = new System.Drawing.Size(320, 429);
            this.LsvLayout.TabIndex = 13;
            this.LsvLayout.UseCompatibleStateImageBehavior = false;
            this.LsvLayout.View = System.Windows.Forms.View.Details;
            // 
            // ColhLayout
            // 
            this.ColhLayout.Text = "布局";
            this.ColhLayout.Width = 320;
            // 
            // StructureUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.statusbar);
            this.Name = "StructureUI";
            this.Size = new System.Drawing.Size(640, 480);
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.ListView LsvLayout;
        private System.Windows.Forms.ColumnHeader ColhLayout;
        private System.Windows.Forms.ToolStripButton BtnGenerate;
        private System.Windows.Forms.ToolStripButton BtnFilter;
        private System.Windows.Forms.ToolStripDropDownButton MnuSave;
        private System.Windows.Forms.ToolStripMenuItem BtnSaveStructure;
        private System.Windows.Forms.ToolStripMenuItem BtnSaveModel;
        private System.Windows.Forms.ToolStripSeparator split1;
        private System.Windows.Forms.ToolStripDropDownButton MnuOptions;
        private System.Windows.Forms.ToolStripMenuItem BtnUseFileAsMem;
        private System.Windows.Forms.ListView LsvArrange;
        private System.Windows.Forms.ColumnHeader ColhArrange;
        private System.Windows.Forms.ToolStripStatusLabel TxtStatLayout;
        private System.Windows.Forms.ToolStripProgressBar Progress;
        private System.Windows.Forms.ToolStripStatusLabel TxtStatArrange;
    }
}
