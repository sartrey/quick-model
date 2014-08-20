namespace QuickModel3D.UI
{
    partial class LayoutUI
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LblPreCount = new System.Windows.Forms.Label();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.ChbFileCache = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.LsvLayout = new System.Windows.Forms.ListView();
            this.ColhPoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColhArrayUp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.LblPreCount);
            this.Panel1.Controls.Add(this.BtnFilter);
            this.Panel1.Controls.Add(this.BtnGenerate);
            this.Panel1.Controls.Add(this.ChbFileCache);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.Panel1.Size = new System.Drawing.Size(640, 50);
            this.Panel1.TabIndex = 5;
            // 
            // LblPreCount
            // 
            this.LblPreCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPreCount.Location = new System.Drawing.Point(244, 10);
            this.LblPreCount.Name = "LblPreCount";
            this.LblPreCount.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPreCount.Size = new System.Drawing.Size(242, 30);
            this.LblPreCount.TabIndex = 15;
            this.LblPreCount.Text = "预估总数：";
            this.LblPreCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnFilter.Location = new System.Drawing.Point(130, 10);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(114, 30);
            this.BtnFilter.TabIndex = 14;
            this.BtnFilter.Text = "筛选布局";
            this.BtnFilter.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnGenerate.Location = new System.Drawing.Point(10, 10);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(120, 30);
            this.BtnGenerate.TabIndex = 12;
            this.BtnGenerate.Text = "穷举布局";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // ChbFileCache
            // 
            this.ChbFileCache.AutoSize = true;
            this.ChbFileCache.BackColor = System.Drawing.Color.Transparent;
            this.ChbFileCache.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChbFileCache.Location = new System.Drawing.Point(486, 10);
            this.ChbFileCache.Name = "ChbFileCache";
            this.ChbFileCache.Size = new System.Drawing.Size(144, 30);
            this.ChbFileCache.TabIndex = 11;
            this.ChbFileCache.Text = "使用文件缓存代替内存";
            this.ChbFileCache.UseVisualStyleBackColor = false;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.BtnSelect);
            this.Panel2.Controls.Add(this.Progress);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 430);
            this.Panel2.Name = "Panel2";
            this.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.Panel2.Size = new System.Drawing.Size(640, 50);
            this.Panel2.TabIndex = 9;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSelect.Location = new System.Drawing.Point(10, 10);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(120, 30);
            this.BtnSelect.TabIndex = 6;
            this.BtnSelect.Text = "应用所选布局";
            this.BtnSelect.UseVisualStyleBackColor = true;
            // 
            // Progress
            // 
            this.Progress.Dock = System.Windows.Forms.DockStyle.Right;
            this.Progress.Location = new System.Drawing.Point(560, 10);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(70, 30);
            this.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Progress.TabIndex = 4;
            // 
            // LsvLayout
            // 
            this.LsvLayout.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColhId,
            this.ColhPoints,
            this.ColhArrayUp});
            this.LsvLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvLayout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LsvLayout.FullRowSelect = true;
            this.LsvLayout.GridLines = true;
            this.LsvLayout.Location = new System.Drawing.Point(0, 50);
            this.LsvLayout.Name = "LsvLayout";
            this.LsvLayout.Size = new System.Drawing.Size(640, 380);
            this.LsvLayout.TabIndex = 10;
            this.LsvLayout.UseCompatibleStateImageBehavior = false;
            this.LsvLayout.View = System.Windows.Forms.View.Details;
            // 
            // ColhPoints
            // 
            this.ColhPoints.Text = "关键点位";
            this.ColhPoints.Width = 350;
            // 
            // ColhId
            // 
            this.ColhId.Text = "索引";
            // 
            // ColhArrayUp
            // 
            this.ColhArrayUp.Text = "排列上限";
            this.ColhArrayUp.Width = 120;
            // 
            // LayoutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LsvLayout);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Name = "LayoutUI";
            this.Size = new System.Drawing.Size(640, 480);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.ListView LsvLayout;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.CheckBox ChbFileCache;
        private System.Windows.Forms.ColumnHeader ColhPoints;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label LblPreCount;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.ColumnHeader ColhId;
        private System.Windows.Forms.ColumnHeader ColhArrayUp;
    }
}
