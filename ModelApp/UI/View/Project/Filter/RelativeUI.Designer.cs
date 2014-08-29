namespace QuickModel3D.UI.Filter
{
    partial class RelativeUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.CobxEntityA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CobxEntityB = new System.Windows.Forms.ComboBox();
            this.ChbxIsLink = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "模块A";
            // 
            // CobxEntityA
            // 
            this.CobxEntityA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobxEntityA.FormattingEnabled = true;
            this.CobxEntityA.Location = new System.Drawing.Point(55, 15);
            this.CobxEntityA.Name = "CobxEntityA";
            this.CobxEntityA.Size = new System.Drawing.Size(220, 20);
            this.CobxEntityA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "模块B";
            // 
            // CobxEntityB
            // 
            this.CobxEntityB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobxEntityB.FormattingEnabled = true;
            this.CobxEntityB.Location = new System.Drawing.Point(55, 41);
            this.CobxEntityB.Name = "CobxEntityB";
            this.CobxEntityB.Size = new System.Drawing.Size(220, 20);
            this.CobxEntityB.TabIndex = 3;
            // 
            // ChbxIsLink
            // 
            this.ChbxIsLink.AutoSize = true;
            this.ChbxIsLink.Location = new System.Drawing.Point(55, 67);
            this.ChbxIsLink.Name = "ChbxIsLink";
            this.ChbxIsLink.Size = new System.Drawing.Size(192, 16);
            this.ChbxIsLink.TabIndex = 4;
            this.ChbxIsLink.Text = "模块A与模块B相邻，否则不相邻";
            this.ChbxIsLink.UseVisualStyleBackColor = true;
            // 
            // RelativeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChbxIsLink);
            this.Controls.Add(this.CobxEntityB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CobxEntityA);
            this.Controls.Add(this.label1);
            this.Name = "RelativeUI";
            this.Size = new System.Drawing.Size(290, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CobxEntityA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CobxEntityB;
        private System.Windows.Forms.CheckBox ChbxIsLink;
    }
}
