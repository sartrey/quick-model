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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LsvArrange = new System.Windows.Forms.ListView();
            this.ColhArrangeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColhArrange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LsvLayout = new System.Windows.Forms.ListView();
            this.ColhLayoutId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColhLayout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MnuSaveStructure = new System.Windows.Forms.ToolStripButton();
            this.BtnSelect = new System.Windows.Forms.ToolStripButton();
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
            this.MnuSaveStructure,
            this.BtnSelect});
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
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
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
            this.ColhArrangeId,
            this.ColhArrange});
            this.LsvArrange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvArrange.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LsvArrange.FullRowSelect = true;
            this.LsvArrange.GridLines = true;
            this.LsvArrange.Location = new System.Drawing.Point(320, 0);
            this.LsvArrange.MultiSelect = false;
            this.LsvArrange.Name = "LsvArrange";
            this.LsvArrange.Size = new System.Drawing.Size(320, 429);
            this.LsvArrange.TabIndex = 14;
            this.LsvArrange.UseCompatibleStateImageBehavior = false;
            this.LsvArrange.View = System.Windows.Forms.View.Details;
            // 
            // ColhArrangeId
            // 
            this.ColhArrangeId.Text = "索引";
            this.ColhArrangeId.Width = 45;
            // 
            // ColhArrange
            // 
            this.ColhArrange.Text = "排列";
            this.ColhArrange.Width = 275;
            // 
            // LsvLayout
            // 
            this.LsvLayout.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColhLayoutId,
            this.ColhLayout});
            this.LsvLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.LsvLayout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LsvLayout.FullRowSelect = true;
            this.LsvLayout.GridLines = true;
            this.LsvLayout.HideSelection = false;
            this.LsvLayout.Location = new System.Drawing.Point(0, 0);
            this.LsvLayout.MultiSelect = false;
            this.LsvLayout.Name = "LsvLayout";
            this.LsvLayout.Size = new System.Drawing.Size(320, 429);
            this.LsvLayout.TabIndex = 13;
            this.LsvLayout.UseCompatibleStateImageBehavior = false;
            this.LsvLayout.View = System.Windows.Forms.View.Details;
            this.LsvLayout.SelectedIndexChanged += new System.EventHandler(this.LsvLayout_SelectedIndexChanged);
            // 
            // ColhLayoutId
            // 
            this.ColhLayoutId.Text = "索引";
            this.ColhLayoutId.Width = 45;
            // 
            // ColhLayout
            // 
            this.ColhLayout.Text = "布局";
            this.ColhLayout.Width = 275;
            // 
            // MnuSaveStructure
            // 
            this.MnuSaveStructure.Image = ((System.Drawing.Image)(resources.GetObject("MnuSaveStructure.Image")));
            this.MnuSaveStructure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MnuSaveStructure.Name = "MnuSaveStructure";
            this.MnuSaveStructure.Size = new System.Drawing.Size(76, 22);
            this.MnuSaveStructure.Text = "保存结构";
            this.MnuSaveStructure.Click += new System.EventHandler(this.BtnSaveStructure_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("BtnSelect.Image")));
            this.BtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(76, 22);
            this.BtnSelect.Text = "选定结构";
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
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
        private System.Windows.Forms.ToolStripSeparator split1;
        private System.Windows.Forms.ToolStripDropDownButton MnuOptions;
        private System.Windows.Forms.ToolStripMenuItem BtnUseFileAsMem;
        private System.Windows.Forms.ListView LsvArrange;
        private System.Windows.Forms.ColumnHeader ColhArrange;
        private System.Windows.Forms.ToolStripStatusLabel TxtStatLayout;
        private System.Windows.Forms.ToolStripProgressBar Progress;
        private System.Windows.Forms.ToolStripStatusLabel TxtStatArrange;
        private System.Windows.Forms.ColumnHeader ColhArrangeId;
        private System.Windows.Forms.ColumnHeader ColhLayoutId;
        private System.Windows.Forms.ToolStripButton MnuSaveStructure;
        private System.Windows.Forms.ToolStripButton BtnSelect;
    }
}
