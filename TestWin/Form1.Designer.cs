namespace TestWin
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.卸载皮肤ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.挂载皮肤ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.卸载所有皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.挂载所有皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除所有皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.卸载皮肤ToolStripMenuItem1,
            this.挂载皮肤ToolStripMenuItem1,
            this.删除皮肤ToolStripMenuItem,
            this.卸载所有皮肤ToolStripMenuItem,
            this.挂载所有皮肤ToolStripMenuItem,
            this.删除所有皮肤ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 136);
            // 
            // 卸载皮肤ToolStripMenuItem1
            // 
            this.卸载皮肤ToolStripMenuItem1.Name = "卸载皮肤ToolStripMenuItem1";
            this.卸载皮肤ToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.卸载皮肤ToolStripMenuItem1.Text = "卸载当前皮肤";
            // 
            // 挂载皮肤ToolStripMenuItem1
            // 
            this.挂载皮肤ToolStripMenuItem1.Name = "挂载皮肤ToolStripMenuItem1";
            this.挂载皮肤ToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.挂载皮肤ToolStripMenuItem1.Text = "挂载当前皮肤";
            // 
            // 删除皮肤ToolStripMenuItem
            // 
            this.删除皮肤ToolStripMenuItem.Name = "删除皮肤ToolStripMenuItem";
            this.删除皮肤ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.删除皮肤ToolStripMenuItem.Text = "删除当前皮肤";
            // 
            // 卸载所有皮肤ToolStripMenuItem
            // 
            this.卸载所有皮肤ToolStripMenuItem.Name = "卸载所有皮肤ToolStripMenuItem";
            this.卸载所有皮肤ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.卸载所有皮肤ToolStripMenuItem.Text = "卸载所有皮肤";
            // 
            // 挂载所有皮肤ToolStripMenuItem
            // 
            this.挂载所有皮肤ToolStripMenuItem.Name = "挂载所有皮肤ToolStripMenuItem";
            this.挂载所有皮肤ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.挂载所有皮肤ToolStripMenuItem.Text = "挂载所有皮肤";
            // 
            // 删除所有皮肤ToolStripMenuItem
            // 
            this.删除所有皮肤ToolStripMenuItem.Name = "删除所有皮肤ToolStripMenuItem";
            this.删除所有皮肤ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.删除所有皮肤ToolStripMenuItem.Text = "删除所有皮肤";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 335);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 卸载皮肤ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 挂载皮肤ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除皮肤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 卸载所有皮肤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 挂载所有皮肤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除所有皮肤ToolStripMenuItem;
    }
}

