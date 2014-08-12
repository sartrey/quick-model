namespace QuickModel3D.UI
{
    partial class NullUI
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
            this.LblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblText
            // 
            this.LblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblText.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.LblText.Location = new System.Drawing.Point(0, 0);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(300, 300);
            this.LblText.TabIndex = 0;
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NullUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.LblText);
            this.Name = "NullUI";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblText;
    }
}
