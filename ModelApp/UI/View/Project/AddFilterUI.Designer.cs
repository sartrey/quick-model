namespace QuickModel3D.UI
{
    partial class AddFilterUI
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
            this.CobxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.Grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp1
            // 
            this.Grp1.Controls.Add(this.CobxType);
            this.Grp1.Controls.Add(this.label1);
            this.Grp1.Controls.Add(this.TbxName);
            this.Grp1.Controls.Add(this.label2);
            this.Grp1.Location = new System.Drawing.Point(15, 15);
            this.Grp1.Name = "Grp1";
            this.Grp1.Size = new System.Drawing.Size(290, 90);
            this.Grp1.TabIndex = 8;
            this.Grp1.TabStop = false;
            this.Grp1.Text = "基本信息";
            // 
            // CobxType
            // 
            this.CobxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobxType.FormattingEnabled = true;
            this.CobxType.Location = new System.Drawing.Point(55, 56);
            this.CobxType.Name = "CobxType";
            this.CobxType.Size = new System.Drawing.Size(219, 20);
            this.CobxType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "类型";
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(55, 26);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(219, 21);
            this.TbxName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "名称";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(225, 120);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(80, 30);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(139, 120);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(80, 30);
            this.BtnOK.TabIndex = 12;
            this.BtnOK.Text = "确认";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // AddFilterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.Grp1);
            this.Name = "AddFilterUI";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(320, 160);
            this.Grp1.ResumeLayout(false);
            this.Grp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp1;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CobxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
    }
}
