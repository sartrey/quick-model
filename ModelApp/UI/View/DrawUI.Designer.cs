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
            this.CobxWidth = new System.Windows.Forms.ToolStripComboBox();
            this.Lbl1 = new System.Windows.Forms.ToolStripLabel();
            this.split1 = new System.Windows.Forms.ToolStripSeparator();
            this.CvsTexture = new QuickModel3D.Canvas();
            this.BtnEraser = new System.Windows.Forms.ToolStripButton();
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
            this.CobxWidth});
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(284, 29);
            this.Toolbar.TabIndex = 2;
            // 
            // BtnPen
            // 
            this.BtnPen.Image = ((System.Drawing.Image)(resources.GetObject("BtnPen.Image")));
            this.BtnPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPen.Name = "BtnPen";
            this.BtnPen.Size = new System.Drawing.Size(52, 26);
            this.BtnPen.Text = "铅笔";
            // 
            // BtnLine
            // 
            this.BtnLine.Image = ((System.Drawing.Image)(resources.GetObject("BtnLine.Image")));
            this.BtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(52, 26);
            this.BtnLine.Text = "直线";
            // 
            // CobxWidth
            // 
            this.CobxWidth.Name = "CobxWidth";
            this.CobxWidth.Size = new System.Drawing.Size(121, 25);
            // 
            // Lbl1
            // 
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(32, 26);
            this.Lbl1.Text = "线型";
            // 
            // split1
            // 
            this.split1.Name = "split1";
            this.split1.Size = new System.Drawing.Size(6, 29);
            // 
            // CvsTexture
            // 
            this.CvsTexture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CvsTexture.Location = new System.Drawing.Point(0, 29);
            this.CvsTexture.Name = "CvsTexture";
            this.CvsTexture.Size = new System.Drawing.Size(284, 232);
            this.CvsTexture.TabIndex = 3;
            // 
            // BtnEraser
            // 
            this.BtnEraser.Image = ((System.Drawing.Image)(resources.GetObject("BtnEraser.Image")));
            this.BtnEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(52, 26);
            this.BtnEraser.Text = "橡皮";
            // 
            // DrawPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CvsTexture);
            this.Controls.Add(this.Toolbar);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "DrawPanel";
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

    }
}