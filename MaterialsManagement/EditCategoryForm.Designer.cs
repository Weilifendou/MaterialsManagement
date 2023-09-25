namespace MaterialsManagement
{
    partial class EditCategoryForm
    {
        /// <summary>
        /// Required designer stringiable.
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
        /// the contents of 
        /// 
        /// method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategoryForm));
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.treeViewCategory = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSecondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(92, 359);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(100, 40);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "Conform";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // treeViewCategory
            // 
            this.treeViewCategory.ContextMenuStrip = this.contextMenuStrip;
            this.treeViewCategory.LabelEdit = true;
            this.treeViewCategory.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.treeViewCategory.Location = new System.Drawing.Point(12, 12);
            this.treeViewCategory.Name = "treeViewCategory";
            this.treeViewCategory.Size = new System.Drawing.Size(260, 341);
            this.treeViewCategory.TabIndex = 1;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFirstToolStripMenuItem,
            this.addSecondToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 92);
            // 
            // addFirstToolStripMenuItem
            // 
            this.addFirstToolStripMenuItem.Name = "addFirstToolStripMenuItem";
            this.addFirstToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addFirstToolStripMenuItem.Text = "添加一级目录";
            this.addFirstToolStripMenuItem.Click += new System.EventHandler(this.addFirstToolStripMenuItem_Click);
            // 
            // addSecondToolStripMenuItem
            // 
            this.addSecondToolStripMenuItem.Name = "addSecondToolStripMenuItem";
            this.addSecondToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addSecondToolStripMenuItem.Text = "添加二级目录";
            this.addSecondToolStripMenuItem.Click += new System.EventHandler(this.addSecondToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editToolStripMenuItem.Text = "编辑";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteToolStripMenuItem.Text = "删除";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // EditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.treeViewCategory);
            this.Controls.Add(this.buttonConfirm);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCategoryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Category";
            this.Load += new System.EventHandler(this.EditCategoryForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TreeView treeViewCategory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addSecondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFirstToolStripMenuItem;


    }
}