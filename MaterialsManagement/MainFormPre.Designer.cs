namespace MaterialsManagement
{
    partial class MainFormPre
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormPre));
            this.contextMenuStripListSeach = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.timerWatchServerMessage = new System.Windows.Forms.Timer(this.components);
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripListSeach.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripListSeach
            // 
            this.contextMenuStripListSeach.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripListSeach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemEdit,
            this.ToolStripMenuItemDelete});
            this.contextMenuStripListSeach.Name = "contextMenuStripListSeach";
            this.contextMenuStripListSeach.Size = new System.Drawing.Size(101, 48);
            // 
            // ToolStripMenuItemEdit
            // 
            this.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
            this.ToolStripMenuItemEdit.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItemEdit.Text = "编辑";
            // 
            // ToolStripMenuItemDelete
            // 
            this.ToolStripMenuItemDelete.Name = "ToolStripMenuItemDelete";
            this.ToolStripMenuItemDelete.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItemDelete.Text = "删除";
            // 
            // timerWatchServerMessage
            // 
            this.timerWatchServerMessage.Interval = 1000;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(0, 590);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(198, 20);
            this.labelStatus.TabIndex = 17;
            this.labelStatus.Text = "检索结果：共检索到0条结果";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(426, 590);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(132, 20);
            this.labelAuthor.TabIndex = 18;
            this.labelAuthor.Text = "Developer：HQL";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(762, 590);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(210, 20);
            this.labelTime.TabIndex = 19;
            this.labelTime.Text = "Time：2020/07/17 16:20:20";
            // 
            // toolTip
            // 
            this.toolTip.ForeColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelStatus);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料管理系统";
            this.contextMenuStripListSeach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripListSeach;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelete;
        private System.Windows.Forms.Timer timerWatchServerMessage;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

