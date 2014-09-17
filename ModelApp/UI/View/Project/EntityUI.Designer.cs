namespace QuickModel3D.UI
{
    partial class EntityUI
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
            this.Grp1 = new System.Windows.Forms.GroupBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.Grp3 = new System.Windows.Forms.GroupBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.PicTexture = new System.Windows.Forms.PictureBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Grp1.SuspendLayout();
            this.Grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTexture)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp1
            // 
            this.Grp1.Controls.Add(this.TbxName);
            this.Grp1.Controls.Add(this.label2);
            this.Grp1.Controls.Add(this.LblId);
            this.Grp1.Location = new System.Drawing.Point(15, 15);
            this.Grp1.Name = "Grp1";
            this.Grp1.Size = new System.Drawing.Size(290, 90);
            this.Grp1.TabIndex = 7;
            this.Grp1.TabStop = false;
            this.Grp1.Text = "基本信息";
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(55, 52);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(219, 21);
            this.TbxName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "名称";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(20, 30);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(41, 12);
            this.LblId.TabIndex = 3;
            this.LblId.Text = "标识：";
            // 
            // Grp3
            // 
            this.Grp3.Controls.Add(this.BtnClear);
            this.Grp3.Controls.Add(this.BtnDraw);
            this.Grp3.Controls.Add(this.BtnImport);
            this.Grp3.Controls.Add(this.PicTexture);
            this.Grp3.Location = new System.Drawing.Point(15, 111);
            this.Grp3.Name = "Grp3";
            this.Grp3.Size = new System.Drawing.Size(290, 160);
            this.Grp3.TabIndex = 9;
            this.Grp3.TabStop = false;
            this.Grp3.Text = "贴图";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(174, 113);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(100, 27);
            this.BtnClear.TabIndex = 18;
            this.BtnClear.Text = "清除";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(174, 63);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(100, 27);
            this.BtnDraw.TabIndex = 17;
            this.BtnDraw.Text = "绘制";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(174, 30);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(100, 27);
            this.BtnImport.TabIndex = 16;
            this.BtnImport.Text = "导入...";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // PicTexture
            // 
            this.PicTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicTexture.Location = new System.Drawing.Point(22, 30);
            this.PicTexture.Name = "PicTexture";
            this.PicTexture.Size = new System.Drawing.Size(110, 110);
            this.PicTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTexture.TabIndex = 15;
            this.PicTexture.TabStop = false;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(139, 281);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(80, 30);
            this.BtnOK.TabIndex = 10;
            this.BtnOK.Text = "确认";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(225, 281);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(80, 30);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // EntityUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.Grp3);
            this.Controls.Add(this.Grp1);
            this.Name = "EntityUI";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(320, 325);
            this.Grp1.ResumeLayout(false);
            this.Grp1.PerformLayout();
            this.Grp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicTexture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp1;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.GroupBox Grp3;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.PictureBox PicTexture;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}
