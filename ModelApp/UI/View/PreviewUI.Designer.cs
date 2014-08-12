namespace QuickModel3D.UI
{
    partial class PreviewUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ModelHost = new QuickModel3D.WindowHost();
            this.SuspendLayout();
            // 
            // ModelHost
            // 
            this.ModelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelHost.Location = new System.Drawing.Point(0, 0);
            this.ModelHost.Name = "ModelHost";
            this.ModelHost.Size = new System.Drawing.Size(284, 261);
            this.ModelHost.Source = null;
            this.ModelHost.TabIndex = 0;
            // 
            // PreviewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ModelHost);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "PreviewPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowHost ModelHost;

    }
}