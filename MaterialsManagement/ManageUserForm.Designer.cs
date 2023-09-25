namespace MaterialsManagement
{
    partial class ManageUserForm
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
        /// 
        /// method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserForm));
            this.listViewUser = new System.Windows.Forms.ListView();
            this.columnHeaderUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUserDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUserPermission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label = new System.Windows.Forms.Label();
            this.buttonAddPermission = new System.Windows.Forms.Button();
            this.comboBoxFirst = new System.Windows.Forms.ComboBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonDeletePermission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewUser
            // 
            this.listViewUser.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUserName,
            this.columnHeaderUserDepartment,
            this.columnHeaderUserPermission});
            this.listViewUser.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.listViewUser.FullRowSelect = true;
            this.listViewUser.GridLines = true;
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(12, 79);
            this.listViewUser.MultiSelect = false;
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewUser.Size = new System.Drawing.Size(560, 270);
            this.listViewUser.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewUser.TabIndex = 1;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderUserName
            // 
            this.columnHeaderUserName.Text = "User name";
            this.columnHeaderUserName.Width = 100;
            // 
            // columnHeaderUserDepartment
            // 
            this.columnHeaderUserDepartment.Text = "Department";
            this.columnHeaderUserDepartment.Width = 155;
            // 
            // columnHeaderUserPermission
            // 
            this.columnHeaderUserPermission.Text = "Permission";
            this.columnHeaderUserPermission.Width = 300;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(12, 57);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(136, 21);
            this.label.TabIndex = 0;
            this.label.Text = "Registered Users";
            // 
            // buttonAddPermission
            // 
            this.buttonAddPermission.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddPermission.Location = new System.Drawing.Point(219, 10);
            this.buttonAddPermission.Name = "buttonAddPermission";
            this.buttonAddPermission.Size = new System.Drawing.Size(150, 31);
            this.buttonAddPermission.TabIndex = 2;
            this.buttonAddPermission.Text = "Add Permission";
            this.buttonAddPermission.UseVisualStyleBackColor = true;
            this.buttonAddPermission.Click += new System.EventHandler(this.buttonAddPermission_Click);
            // 
            // comboBoxFirst
            // 
            this.comboBoxFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFirst.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBoxFirst.FormattingEnabled = true;
            this.comboBoxFirst.Location = new System.Drawing.Point(12, 12);
            this.comboBoxFirst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxFirst.Name = "comboBoxFirst";
            this.comboBoxFirst.Size = new System.Drawing.Size(200, 28);
            this.comboBoxFirst.TabIndex = 14;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(375, 47);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(150, 31);
            this.buttonDeleteUser.TabIndex = 15;
            this.buttonDeleteUser.Text = "Delete User";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonDeletePermission
            // 
            this.buttonDeletePermission.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDeletePermission.Location = new System.Drawing.Point(375, 12);
            this.buttonDeletePermission.Name = "buttonDeletePermission";
            this.buttonDeletePermission.Size = new System.Drawing.Size(150, 31);
            this.buttonDeletePermission.TabIndex = 16;
            this.buttonDeletePermission.Text = "Delete Permission";
            this.buttonDeletePermission.UseVisualStyleBackColor = true;
            this.buttonDeletePermission.Click += new System.EventHandler(this.buttonDeletePermission_Click);
            // 
            // ManageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.buttonDeletePermission);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.comboBoxFirst);
            this.Controls.Add(this.buttonAddPermission);
            this.Controls.Add(this.label);
            this.Controls.Add(this.listViewUser);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageUserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理用户";
            this.Load += new System.EventHandler(this.ManageUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ColumnHeader columnHeaderUserName;
        private System.Windows.Forms.ColumnHeader columnHeaderUserDepartment;
        private System.Windows.Forms.ColumnHeader columnHeaderUserPermission;
        private System.Windows.Forms.Button buttonAddPermission;
        private System.Windows.Forms.ComboBox comboBoxFirst;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonDeletePermission;


    }
}