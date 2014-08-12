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
            this.label1 = new System.Windows.Forms.Label();
            this.Grp2 = new System.Windows.Forms.GroupBox();
            this.PicTexture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CobxGeometry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Grp1.SuspendLayout();
            this.Grp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTexture)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp1
            // 
            this.Grp1.Controls.Add(this.TbxName);
            this.Grp1.Controls.Add(this.label2);
            this.Grp1.Controls.Add(this.label1);
            this.Grp1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grp1.Location = new System.Drawing.Point(8, 8);
            this.Grp1.Name = "Grp1";
            this.Grp1.Size = new System.Drawing.Size(285, 92);
            this.Grp1.TabIndex = 7;
            this.Grp1.TabStop = false;
            this.Grp1.Text = "基本信息";
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(55, 54);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(219, 21);
            this.TbxName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "标识：";
            // 
            // Grp2
            // 
            this.Grp2.Controls.Add(this.PicTexture);
            this.Grp2.Controls.Add(this.label4);
            this.Grp2.Controls.Add(this.CobxGeometry);
            this.Grp2.Controls.Add(this.label3);
            this.Grp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grp2.Location = new System.Drawing.Point(8, 100);
            this.Grp2.Name = "Grp2";
            this.Grp2.Size = new System.Drawing.Size(285, 285);
            this.Grp2.TabIndex = 8;
            this.Grp2.TabStop = false;
            this.Grp2.Text = "几何模型";
            // 
            // PicTexture
            // 
            this.PicTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicTexture.Location = new System.Drawing.Point(67, 62);
            this.PicTexture.Name = "PicTexture";
            this.PicTexture.Size = new System.Drawing.Size(207, 91);
            this.PicTexture.TabIndex = 10;
            this.PicTexture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "贴图";
            // 
            // CobxGeometry
            // 
            this.CobxGeometry.FormattingEnabled = true;
            this.CobxGeometry.Location = new System.Drawing.Point(67, 26);
            this.CobxGeometry.Name = "CobxGeometry";
            this.CobxGeometry.Size = new System.Drawing.Size(207, 20);
            this.CobxGeometry.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "几何体";
            // 
            // EntityUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grp2);
            this.Controls.Add(this.Grp1);
            this.Name = "EntityUI";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(301, 393);
            this.Grp1.ResumeLayout(false);
            this.Grp1.PerformLayout();
            this.Grp2.ResumeLayout(false);
            this.Grp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTexture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp1;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Grp2;
        private System.Windows.Forms.PictureBox PicTexture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CobxGeometry;
        private System.Windows.Forms.Label label3;
    }
}
