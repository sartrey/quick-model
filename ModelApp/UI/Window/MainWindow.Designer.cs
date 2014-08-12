namespace QuickModel3D.UI
{
    partial class MainWindow
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin2 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin2 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient4 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient8 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin2 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient9 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient5 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient10 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient11 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient12 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient6 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient13 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient14 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFile_New = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFile_Split1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFile_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFile_Split2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEntity_AddEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEntity_AddBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEntity_DeleteEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFilter_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFilter_DeleteFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuModel = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuModel_Generate = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuModel_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuModel_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuView_Preview = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelDock = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.MnuEntity_Property = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEntity_Split1 = new System.Windows.Forms.ToolStripSeparator();
            this.menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menubar
            // 
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuEntity,
            this.MnuFilter,
            this.MnuModel,
            this.MnuView});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(624, 25);
            this.menubar.TabIndex = 0;
            this.menubar.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile_New,
            this.MnuFile_Open,
            this.MnuFile_Split1,
            this.MnuFile_Save,
            this.MnuFile_Split2,
            this.MnuFile_Exit});
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(58, 21);
            this.MnuFile.Text = "文件(&F)";
            // 
            // MnuFile_New
            // 
            this.MnuFile_New.Name = "MnuFile_New";
            this.MnuFile_New.Size = new System.Drawing.Size(152, 22);
            this.MnuFile_New.Text = "新建项目(&N)";
            this.MnuFile_New.Click += new System.EventHandler(this.MnuFile_New_Click);
            // 
            // MnuFile_Open
            // 
            this.MnuFile_Open.Name = "MnuFile_Open";
            this.MnuFile_Open.Size = new System.Drawing.Size(152, 22);
            this.MnuFile_Open.Text = "打开项目(&O)";
            this.MnuFile_Open.Click += new System.EventHandler(this.MnuFile_Open_Click);
            // 
            // MnuFile_Split1
            // 
            this.MnuFile_Split1.Name = "MnuFile_Split1";
            this.MnuFile_Split1.Size = new System.Drawing.Size(149, 6);
            // 
            // MnuFile_Save
            // 
            this.MnuFile_Save.Name = "MnuFile_Save";
            this.MnuFile_Save.Size = new System.Drawing.Size(152, 22);
            this.MnuFile_Save.Text = "保存项目(&S)";
            // 
            // MnuFile_Split2
            // 
            this.MnuFile_Split2.Name = "MnuFile_Split2";
            this.MnuFile_Split2.Size = new System.Drawing.Size(149, 6);
            // 
            // MnuFile_Exit
            // 
            this.MnuFile_Exit.Name = "MnuFile_Exit";
            this.MnuFile_Exit.Size = new System.Drawing.Size(152, 22);
            this.MnuFile_Exit.Text = "退出(&X)";
            this.MnuFile_Exit.Click += new System.EventHandler(this.MnuFile_Exit_Click);
            // 
            // MnuEntity
            // 
            this.MnuEntity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEntity_AddEntity,
            this.MnuEntity_AddBatch,
            this.MnuEntity_DeleteEntity,
            this.MnuEntity_Split1,
            this.MnuEntity_Property});
            this.MnuEntity.Name = "MnuEntity";
            this.MnuEntity.Size = new System.Drawing.Size(59, 21);
            this.MnuEntity.Text = "模块(&E)";
            // 
            // MnuEntity_AddEntity
            // 
            this.MnuEntity_AddEntity.Name = "MnuEntity_AddEntity";
            this.MnuEntity_AddEntity.Size = new System.Drawing.Size(152, 22);
            this.MnuEntity_AddEntity.Text = "添加模块(&A)";
            this.MnuEntity_AddEntity.Click += new System.EventHandler(this.MnuEntity_Add_Click);
            // 
            // MnuEntity_AddBatch
            // 
            this.MnuEntity_AddBatch.Name = "MnuEntity_AddBatch";
            this.MnuEntity_AddBatch.Size = new System.Drawing.Size(152, 22);
            this.MnuEntity_AddBatch.Text = "批量添加(&B)";
            this.MnuEntity_AddBatch.Click += new System.EventHandler(this.MnuEntity_AddBatch_Click);
            // 
            // MnuEntity_DeleteEntity
            // 
            this.MnuEntity_DeleteEntity.Name = "MnuEntity_DeleteEntity";
            this.MnuEntity_DeleteEntity.Size = new System.Drawing.Size(152, 22);
            this.MnuEntity_DeleteEntity.Text = "删除模块(&R)";
            this.MnuEntity_DeleteEntity.Click += new System.EventHandler(this.MnuEntity_Delete_Click);
            // 
            // MnuFilter
            // 
            this.MnuFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFilter_Add,
            this.MnuFilter_DeleteFilter});
            this.MnuFilter.Name = "MnuFilter";
            this.MnuFilter.Size = new System.Drawing.Size(58, 21);
            this.MnuFilter.Text = "约束(&F)";
            // 
            // MnuFilter_Add
            // 
            this.MnuFilter_Add.Name = "MnuFilter_Add";
            this.MnuFilter_Add.Size = new System.Drawing.Size(141, 22);
            this.MnuFilter_Add.Text = "添加约束(&A)";
            // 
            // MnuFilter_DeleteFilter
            // 
            this.MnuFilter_DeleteFilter.Name = "MnuFilter_DeleteFilter";
            this.MnuFilter_DeleteFilter.Size = new System.Drawing.Size(141, 22);
            this.MnuFilter_DeleteFilter.Text = "删除约束(&D)";
            // 
            // MnuModel
            // 
            this.MnuModel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuModel_Generate,
            this.MnuModel_Save,
            this.MnuModel_Export});
            this.MnuModel.Name = "MnuModel";
            this.MnuModel.Size = new System.Drawing.Size(64, 21);
            this.MnuModel.Text = "模型(&M)";
            // 
            // MnuModel_Generate
            // 
            this.MnuModel_Generate.Name = "MnuModel_Generate";
            this.MnuModel_Generate.Size = new System.Drawing.Size(151, 22);
            this.MnuModel_Generate.Text = "计算方案(&C)...";
            // 
            // MnuModel_Save
            // 
            this.MnuModel_Save.Name = "MnuModel_Save";
            this.MnuModel_Save.Size = new System.Drawing.Size(151, 22);
            this.MnuModel_Save.Text = "保存模型(&S)";
            // 
            // MnuModel_Export
            // 
            this.MnuModel_Export.Name = "MnuModel_Export";
            this.MnuModel_Export.Size = new System.Drawing.Size(151, 22);
            this.MnuModel_Export.Text = "导出效果图(&E)";
            // 
            // MnuView
            // 
            this.MnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuView_Preview});
            this.MnuView.Name = "MnuView";
            this.MnuView.Size = new System.Drawing.Size(60, 21);
            this.MnuView.Text = "视图(&V)";
            // 
            // MnuView_Preview
            // 
            this.MnuView_Preview.Name = "MnuView_Preview";
            this.MnuView_Preview.Size = new System.Drawing.Size(115, 22);
            this.MnuView_Preview.Text = "预览(&P)";
            this.MnuView_Preview.Click += new System.EventHandler(this.MnuView_Preview_Click);
            // 
            // PanelDock
            // 
            this.PanelDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDock.Location = new System.Drawing.Point(0, 25);
            this.PanelDock.Name = "PanelDock";
            this.PanelDock.Size = new System.Drawing.Size(624, 436);
            dockPanelGradient4.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient4.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin2.DockStripGradient = dockPanelGradient4;
            tabGradient8.EndColor = System.Drawing.SystemColors.Control;
            tabGradient8.StartColor = System.Drawing.SystemColors.Control;
            tabGradient8.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin2.TabGradient = tabGradient8;
            autoHideStripSkin2.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            dockPanelSkin2.AutoHideStripSkin = autoHideStripSkin2;
            tabGradient9.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient9.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient9.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient2.ActiveTabGradient = tabGradient9;
            dockPanelGradient5.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient5.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient2.DockStripGradient = dockPanelGradient5;
            tabGradient10.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient10.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient10.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient2.InactiveTabGradient = tabGradient10;
            dockPaneStripSkin2.DocumentGradient = dockPaneStripGradient2;
            dockPaneStripSkin2.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            tabGradient11.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient11.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient11.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient11.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient2.ActiveCaptionGradient = tabGradient11;
            tabGradient12.EndColor = System.Drawing.SystemColors.Control;
            tabGradient12.StartColor = System.Drawing.SystemColors.Control;
            tabGradient12.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient2.ActiveTabGradient = tabGradient12;
            dockPanelGradient6.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient6.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient2.DockStripGradient = dockPanelGradient6;
            tabGradient13.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient13.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient13.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient13.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient2.InactiveCaptionGradient = tabGradient13;
            tabGradient14.EndColor = System.Drawing.Color.Transparent;
            tabGradient14.StartColor = System.Drawing.Color.Transparent;
            tabGradient14.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient2.InactiveTabGradient = tabGradient14;
            dockPaneStripSkin2.ToolWindowGradient = dockPaneStripToolWindowGradient2;
            dockPanelSkin2.DockPaneStripSkin = dockPaneStripSkin2;
            this.PanelDock.Skin = dockPanelSkin2;
            this.PanelDock.TabIndex = 1;
            // 
            // MnuEntity_Property
            // 
            this.MnuEntity_Property.Name = "MnuEntity_Property";
            this.MnuEntity_Property.Size = new System.Drawing.Size(152, 22);
            this.MnuEntity_Property.Text = "模块属性(&P)";
            this.MnuEntity_Property.Click += new System.EventHandler(this.MnuEntity_Property_Click);
            // 
            // MnuEntity_Split1
            // 
            this.MnuEntity_Split1.Name = "MnuEntity_Split1";
            this.MnuEntity_Split1.Size = new System.Drawing.Size(149, 6);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.PanelDock);
            this.Controls.Add(this.menubar);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menubar;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Model 3D";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem MnuView;
        private System.Windows.Forms.ToolStripMenuItem MnuView_Preview;
        private System.Windows.Forms.ToolStripMenuItem MnuEntity;
        private System.Windows.Forms.ToolStripMenuItem MnuEntity_AddEntity;
        private System.Windows.Forms.ToolStripMenuItem MnuEntity_DeleteEntity;
        private System.Windows.Forms.ToolStripMenuItem MnuEntity_AddBatch;
        private System.Windows.Forms.ToolStripMenuItem MnuModel;
        private System.Windows.Forms.ToolStripMenuItem MnuModel_Save;
        private System.Windows.Forms.ToolStripMenuItem MnuModel_Export;
        private WeifenLuo.WinFormsUI.Docking.DockPanel PanelDock;
        private System.Windows.Forms.ToolStripMenuItem MnuModel_Generate;
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem MnuFile_New;
        private System.Windows.Forms.ToolStripMenuItem MnuFile_Open;
        private System.Windows.Forms.ToolStripSeparator MnuFile_Split1;
        private System.Windows.Forms.ToolStripMenuItem MnuFile_Save;
        private System.Windows.Forms.ToolStripSeparator MnuFile_Split2;
        private System.Windows.Forms.ToolStripMenuItem MnuFile_Exit;
        private System.Windows.Forms.ToolStripMenuItem MnuFilter;
        private System.Windows.Forms.ToolStripMenuItem MnuFilter_Add;
        private System.Windows.Forms.ToolStripMenuItem MnuFilter_DeleteFilter;
        private System.Windows.Forms.ToolStripSeparator MnuEntity_Split1;
        private System.Windows.Forms.ToolStripMenuItem MnuEntity_Property;
    }
}

