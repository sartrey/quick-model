namespace QuickModel3D.UI.Filter
{
    partial class ExtremeUI
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
            this.ChbxIsAnchor = new System.Windows.Forms.CheckBox();
            this.CobxExtreme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CobxEntity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChbxOnlyOne = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChbxIsAnchor
            // 
            this.ChbxIsAnchor.AutoSize = true;
            this.ChbxIsAnchor.Location = new System.Drawing.Point(51, 87);
            this.ChbxIsAnchor.Name = "ChbxIsAnchor";
            this.ChbxIsAnchor.Size = new System.Drawing.Size(156, 16);
            this.ChbxIsAnchor.TabIndex = 9;
            this.ChbxIsAnchor.Text = "锚定极限位置，否则排除";
            this.ChbxIsAnchor.UseVisualStyleBackColor = true;
            this.ChbxIsAnchor.CheckedChanged += new System.EventHandler(this.ChbxIsAnchor_CheckedChanged);
            // 
            // CobxExtreme
            // 
            this.CobxExtreme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobxExtreme.FormattingEnabled = true;
            this.CobxExtreme.Location = new System.Drawing.Point(51, 41);
            this.CobxExtreme.Name = "CobxExtreme";
            this.CobxExtreme.Size = new System.Drawing.Size(224, 20);
            this.CobxExtreme.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "极限";
            // 
            // CobxEntity
            // 
            this.CobxEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobxEntity.FormattingEnabled = true;
            this.CobxEntity.Location = new System.Drawing.Point(51, 15);
            this.CobxEntity.Name = "CobxEntity";
            this.CobxEntity.Size = new System.Drawing.Size(224, 20);
            this.CobxEntity.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "模块";
            // 
            // ChbxOnlyOne
            // 
            this.ChbxOnlyOne.AutoSize = true;
            this.ChbxOnlyOne.Location = new System.Drawing.Point(51, 109);
            this.ChbxOnlyOne.Name = "ChbxOnlyOne";
            this.ChbxOnlyOne.Size = new System.Drawing.Size(96, 16);
            this.ChbxOnlyOne.TabIndex = 10;
            this.ChbxOnlyOne.Text = "极限位置排他";
            this.ChbxOnlyOne.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "*极限位置服从笛卡尔右手直角坐标系。";
            // 
            // ExtremeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChbxOnlyOne);
            this.Controls.Add(this.ChbxIsAnchor);
            this.Controls.Add(this.CobxExtreme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CobxEntity);
            this.Controls.Add(this.label1);
            this.Name = "ExtremeUI";
            this.Size = new System.Drawing.Size(290, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChbxIsAnchor;
        private System.Windows.Forms.ComboBox CobxExtreme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CobxEntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChbxOnlyOne;
        private System.Windows.Forms.Label label3;
    }
}
