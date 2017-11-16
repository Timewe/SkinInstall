namespace SkinInstall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.卸载当前皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.挂载当前皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除当前皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.卸载所有皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.挂载所有皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除所有皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SkinInstall";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip2;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(2, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(445, 283);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_DragEnter);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "皮肤名称";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 320;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "挂载状态";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 71;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.卸载当前皮肤ToolStripMenuItem,
            this.挂载当前皮肤ToolStripMenuItem,
            this.删除当前皮肤ToolStripMenuItem,
            this.卸载所有皮肤ToolStripMenuItem,
            this.挂载所有皮肤ToolStripMenuItem,
            this.删除所有皮肤ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(147, 136);
            this.contextMenuStrip2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // 卸载当前皮肤ToolStripMenuItem
            // 
            this.卸载当前皮肤ToolStripMenuItem.Name = "卸载当前皮肤ToolStripMenuItem";
            this.卸载当前皮肤ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.卸载当前皮肤ToolStripMenuItem.Text = "卸载当前皮肤";
            this.卸载当前皮肤ToolStripMenuItem.Click += new System.EventHandler(this.卸载当前皮肤ToolStripMenuItem_Click);
            // 
            // 挂载当前皮肤ToolStripMenuItem
            // 
            this.挂载当前皮肤ToolStripMenuItem.Name = "挂载当前皮肤ToolStripMenuItem";
            this.挂载当前皮肤ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.挂载当前皮肤ToolStripMenuItem.Text = "挂载当前皮肤";
            this.挂载当前皮肤ToolStripMenuItem.Click += new System.EventHandler(this.挂载当前皮肤ToolStripMenuItem_Click);
            // 
            // 删除当前皮肤ToolStripMenuItem
            // 
            this.删除当前皮肤ToolStripMenuItem.Name = "删除当前皮肤ToolStripMenuItem";
            this.删除当前皮肤ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.删除当前皮肤ToolStripMenuItem.Text = "删除当前皮肤";
            this.删除当前皮肤ToolStripMenuItem.Click += new System.EventHandler(this.删除当前皮肤ToolStripMenuItem_Click);
            // 
            // 卸载所有皮肤ToolStripMenuItem
            // 
            this.卸载所有皮肤ToolStripMenuItem.Name = "卸载所有皮肤ToolStripMenuItem";
            this.卸载所有皮肤ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.卸载所有皮肤ToolStripMenuItem.Text = "卸载所有皮肤";
            this.卸载所有皮肤ToolStripMenuItem.Click += new System.EventHandler(this.卸载所有皮肤ToolStripMenuItem_Click_1);
            // 
            // 挂载所有皮肤ToolStripMenuItem
            // 
            this.挂载所有皮肤ToolStripMenuItem.Name = "挂载所有皮肤ToolStripMenuItem";
            this.挂载所有皮肤ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.挂载所有皮肤ToolStripMenuItem.Text = "挂载所有皮肤";
            this.挂载所有皮肤ToolStripMenuItem.Click += new System.EventHandler(this.挂载所有皮肤ToolStripMenuItem_Click_1);
            // 
            // 删除所有皮肤ToolStripMenuItem
            // 
            this.删除所有皮肤ToolStripMenuItem.Name = "删除所有皮肤ToolStripMenuItem";
            this.删除所有皮肤ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.删除所有皮肤ToolStripMenuItem.Text = "删除所有皮肤";
            this.删除所有皮肤ToolStripMenuItem.Click += new System.EventHandler(this.删除所有皮肤ToolStripMenuItem_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SkinInstall.Properties.Resources.mini;
            this.pictureBox2.Location = new System.Drawing.Point(360, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkinInstall.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(405, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "诗蓝LOL皮肤挂载器";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SkinInstall.Properties.Resources.ico;
            this.pictureBox3.Location = new System.Drawing.Point(2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(447, 334);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkinInstall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 卸载当前皮肤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 挂载当前皮肤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除当前皮肤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 卸载所有皮肤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 挂载所有皮肤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除所有皮肤ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

