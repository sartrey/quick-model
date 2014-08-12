namespace QuickModel3D.UI
{
    partial class DrawUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawUI));
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            this.BtnPen = new System.Windows.Forms.ToolStripButton();
            this.BtnLine = new System.Windows.Forms.ToolStripButton();
            this.BtnEraser = new System.Windows.Forms.ToolStripButton();
            this.split1 = new System.Windows.Forms.ToolStripSeparator();
            this.Lbl1 = new System.Windows.Forms.ToolStripLabel();
            this.CobxWidth = new System.Windows.Forms.ToolStripComboBox();
            this.CvsTexture = new QuickModel3D.Canvas();
            this.split2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnBackColor = new System.Windows.Forms.ToolStripButton();
            this.BtnForeColor = new System.Windows.Forms.ToolStripButton();
            this.Toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.Toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnPen,
            this.BtnLine,
            this.BtnEraser,
            this.split1,
            this.Lbl1,
            this.CobxWidth,
            this.split2,
            this.BtnBackColor,
            this.BtnForeColor});
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(600, 25);
            this.Toolbar.TabIndex = 2;
            // 
            // BtnPen
            // 
            this.BtnPen.Image = ((System.Drawing.Image)(resources.GetObject("BtnPen.Image")));
            this.BtnPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPen.Name = "BtnPen";
            this.BtnPen.Size = new System.Drawing.Size(52, 22);
            this.BtnPen.Text = "铅笔";
            // 
            // BtnLine
            // 
            this.BtnLine.Image = ((System.Drawing.Image)(resources.GetObject("BtnLine.Image")));
            this.BtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(52, 22);
            this.BtnLine.Text = "直线";
            // 
            // BtnEraser
            // 
            this.BtnEraser.Image = ((System.Drawing.Image)(resources.GetObject("BtnEraser.Image")));
            this.BtnEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(52, 22);
            this.BtnEraser.Text = "橡皮";
            // 
            // split1
            // 
            this.split1.Name = "split1";
            this.split1.Size = new System.Drawing.Size(6, 25);
            // 
            // Lbl1
            // 
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(32, 22);
            this.Lbl1.Text = "线型";
            // 
            // CobxWidth
            // 
            this.CobxWidth.Name = "CobxWidth";
            this.CobxWidth.Size = new System.Drawing.Size(121, 25);
            // 
            // CvsTexture
            // 
            this.CvsTexture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CvsTexture.Location = new System.Drawing.Point(0, 25);
            this.CvsTexture.Name = "CvsTexture";
            this.CvsTexture.Size = new System.Drawing.Size(600, 375);
            this.CvsTexture.TabIndex = 3;
            // 
            // split2
            // 
            this.split2.Name = "split2";
            this.split2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnBackColor
            // 
            this.BtnBackColor.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackColor.Image")));
            this.BtnBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBackColor.Name = "BtnBackColor";
            this.BtnBackColor.Size = new System.Drawing.Size(64, 22);
            this.BtnBackColor.Text = "背景色";
            // 
            // BtnForeColor
            // 
            this.BtnForeColor.Image = ((System.Drawing.Image)(resources.GetObject("BtnForeColor.Image")));
            this.BtnForeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnForeColor.Name = "BtnForeColor";
            this.BtnForeColor.Size = new System.Drawing.Size(64, 22);
            this.BtnForeColor.Text = "前景色";
            // 
            // DrawUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CvsTexture);
            this.Controls.Add(this.Toolbar);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "DrawUI";
            this.Size = new System.Drawing.Size(600, 400);
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Toolbar;
        private Canvas CvsTexture;
        private System.Windows.Forms.ToolStripButton BtnPen;
        private System.Windows.Forms.ToolStripButton BtnLine;
        private System.Windows.Forms.ToolStripComboBox CobxWidth;
        private System.Windows.Forms.ToolStripLabel Lbl1;
        private System.Windows.Forms.ToolStripSeparator split1;
        private System.Windows.Forms.ToolStripButton BtnEraser;
        private System.Windows.Forms.ToolStripSeparator split2;
        private System.Windows.Forms.ToolStripButton BtnBackColor;
        private System.Windows.Forms.ToolStripButton BtnForeColor;

    }
}