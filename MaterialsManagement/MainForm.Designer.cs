namespace MaterialsManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBoxFirst = new System.Windows.Forms.ComboBox();
            this.comboBoxSecond = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRecord = new System.Windows.Forms.TabPage();
            this.textBoxRecord = new System.Windows.Forms.TextBox();
            this.tabPageSearchResult = new System.Windows.Forms.TabPage();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.columnHeaderCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripListSeach = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonExportAll = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.buttonExportSearch = new System.Windows.Forms.Button();
            this.buttonChangePswd = new System.Windows.Forms.Button();
            this.buttonManageUser = new System.Windows.Forms.Button();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonCheckRecord = new System.Windows.Forms.Button();
            this.labelAlert = new System.Windows.Forms.Label();
            this.timerWatchServerMessage = new System.Windows.Forms.Timer(this.components);
            this.linkLabelFeedback = new System.Windows.Forms.LinkLabel();
            this.linkLabelChangePersonality = new System.Windows.Forms.LinkLabel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.myTextBoxKeywords = new MaterialsManagement.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPermission = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageRecord.SuspendLayout();
            this.tabPageSearchResult.SuspendLayout();
            this.contextMenuStripListSeach.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFirst
            // 
            this.comboBoxFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFirst.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBoxFirst.FormattingEnabled = true;
            this.comboBoxFirst.Location = new System.Drawing.Point(248, 54);
            this.comboBoxFirst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxFirst.Name = "comboBoxFirst";
            this.comboBoxFirst.Size = new System.Drawing.Size(251, 28);
            this.comboBoxFirst.TabIndex = 13;
            this.comboBoxFirst.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirst_SelectedIndexChanged);
            // 
            // comboBoxSecond
            // 
            this.comboBoxSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecond.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBoxSecond.FormattingEnabled = true;
            this.comboBoxSecond.Location = new System.Drawing.Point(507, 53);
            this.comboBoxSecond.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxSecond.Name = "comboBoxSecond";
            this.comboBoxSecond.Size = new System.Drawing.Size(336, 28);
            this.comboBoxSecond.TabIndex = 14;
            this.comboBoxSecond.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecond_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageRecord);
            this.tabControl.Controls.Add(this.tabPageSearchResult);
            this.tabControl.Location = new System.Drawing.Point(248, 88);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(724, 498);
            this.tabControl.TabIndex = 16;
            // 
            // tabPageRecord
            // 
            this.tabPageRecord.Controls.Add(this.textBoxRecord);
            this.tabPageRecord.Location = new System.Drawing.Point(4, 29);
            this.tabPageRecord.Name = "tabPageRecord";
            this.tabPageRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecord.Size = new System.Drawing.Size(716, 465);
            this.tabPageRecord.TabIndex = 0;
            this.tabPageRecord.Text = "Recording";
            this.tabPageRecord.UseVisualStyleBackColor = true;
            // 
            // textBoxRecord
            // 
            this.textBoxRecord.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRecord.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBoxRecord.Location = new System.Drawing.Point(7, 6);
            this.textBoxRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRecord.Multiline = true;
            this.textBoxRecord.Name = "textBoxRecord";
            this.textBoxRecord.ReadOnly = true;
            this.textBoxRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecord.Size = new System.Drawing.Size(702, 453);
            this.textBoxRecord.TabIndex = 0;
            // 
            // tabPageSearchResult
            // 
            this.tabPageSearchResult.Controls.Add(this.listViewResult);
            this.tabPageSearchResult.Location = new System.Drawing.Point(4, 29);
            this.tabPageSearchResult.Name = "tabPageSearchResult";
            this.tabPageSearchResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchResult.Size = new System.Drawing.Size(716, 465);
            this.tabPageSearchResult.TabIndex = 1;
            this.tabPageSearchResult.Text = "Search Result";
            this.tabPageSearchResult.UseVisualStyleBackColor = true;
            // 
            // listViewResult
            // 
            this.listViewResult.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCode,
            this.columnHeaderName,
            this.columnHeaderType,
            this.columnHeaderSpec,
            this.columnHeaderUnit});
            this.listViewResult.ContextMenuStrip = this.contextMenuStripListSeach;
            this.listViewResult.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.GridLines = true;
            this.listViewResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewResult.HideSelection = false;
            this.listViewResult.HotTracking = true;
            this.listViewResult.HoverSelection = true;
            this.listViewResult.LabelEdit = true;
            this.listViewResult.Location = new System.Drawing.Point(6, 6);
            this.listViewResult.MultiSelect = false;
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.ShowItemToolTips = true;
            this.listViewResult.Size = new System.Drawing.Size(704, 453);
            this.listViewResult.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewResult.TabIndex = 0;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            this.listViewResult.DoubleClick += new System.EventHandler(this.listViewResult_DoubleClick);
            // 
            // columnHeaderCode
            // 
            this.columnHeaderCode.Text = "Code";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            // 
            // columnHeaderSpec
            // 
            this.columnHeaderSpec.Text = "Specification";
            this.columnHeaderSpec.Width = 100;
            // 
            // columnHeaderUnit
            // 
            this.columnHeaderUnit.Text = "Unit";
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
            this.ToolStripMenuItemEdit.Click += new System.EventHandler(this.ToolStripMenuItemEdit_Click);
            // 
            // ToolStripMenuItemDelete
            // 
            this.ToolStripMenuItemDelete.Name = "ToolStripMenuItemDelete";
            this.ToolStripMenuItemDelete.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItemDelete.Text = "删除";
            this.ToolStripMenuItemDelete.Click += new System.EventHandler(this.ToolStripMenuItemDelete_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Enabled = false;
            this.buttonGenerate.Location = new System.Drawing.Point(854, 50);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(118, 32);
            this.buttonGenerate.TabIndex = 15;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonExportAll
            // 
            this.buttonExportAll.Location = new System.Drawing.Point(12, 503);
            this.buttonExportAll.Name = "buttonExportAll";
            this.buttonExportAll.Size = new System.Drawing.Size(222, 40);
            this.buttonExportAll.TabIndex = 8;
            this.buttonExportAll.Text = "Export All Information";
            this.buttonExportAll.UseVisualStyleBackColor = true;
            this.buttonExportAll.Click += new System.EventHandler(this.buttonExportAll_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Enabled = false;
            this.checkBox.Location = new System.Drawing.Point(753, 13);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(215, 24);
            this.checkBox.TabIndex = 12;
            this.checkBox.Text = "Linked Selected Category";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // buttonExportSearch
            // 
            this.buttonExportSearch.Location = new System.Drawing.Point(12, 431);
            this.buttonExportSearch.Name = "buttonExportSearch";
            this.buttonExportSearch.Size = new System.Drawing.Size(222, 40);
            this.buttonExportSearch.TabIndex = 7;
            this.buttonExportSearch.Text = "Export Search Result";
            this.buttonExportSearch.UseVisualStyleBackColor = true;
            this.buttonExportSearch.Click += new System.EventHandler(this.buttonExportSearch_Click);
            // 
            // buttonChangePswd
            // 
            this.buttonChangePswd.Location = new System.Drawing.Point(12, 143);
            this.buttonChangePswd.Name = "buttonChangePswd";
            this.buttonChangePswd.Size = new System.Drawing.Size(222, 40);
            this.buttonChangePswd.TabIndex = 3;
            this.buttonChangePswd.Text = "Change Password";
            this.buttonChangePswd.UseVisualStyleBackColor = true;
            this.buttonChangePswd.Click += new System.EventHandler(this.buttonChangePswd_Click);
            // 
            // buttonManageUser
            // 
            this.buttonManageUser.Location = new System.Drawing.Point(12, 215);
            this.buttonManageUser.Name = "buttonManageUser";
            this.buttonManageUser.Size = new System.Drawing.Size(222, 40);
            this.buttonManageUser.TabIndex = 4;
            this.buttonManageUser.Text = "Manage User";
            this.buttonManageUser.UseVisualStyleBackColor = true;
            this.buttonManageUser.Click += new System.EventHandler(this.buttonManageUser_Click);
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.Location = new System.Drawing.Point(12, 287);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(222, 40);
            this.buttonEditCategory.TabIndex = 5;
            this.buttonEditCategory.Text = "Edit Category";
            this.buttonEditCategory.UseVisualStyleBackColor = true;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // buttonCheckRecord
            // 
            this.buttonCheckRecord.Location = new System.Drawing.Point(12, 359);
            this.buttonCheckRecord.Name = "buttonCheckRecord";
            this.buttonCheckRecord.Size = new System.Drawing.Size(222, 40);
            this.buttonCheckRecord.TabIndex = 6;
            this.buttonCheckRecord.Text = "Check Record";
            this.buttonCheckRecord.UseVisualStyleBackColor = true;
            this.buttonCheckRecord.Click += new System.EventHandler(this.buttonCheckRecord_Click);
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAlert.Location = new System.Drawing.Point(244, 17);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(363, 21);
            this.labelAlert.TabIndex = 10;
            this.labelAlert.Text = "Please select category from those comboBoxs.";
            // 
            // timerWatchServerMessage
            // 
            this.timerWatchServerMessage.Interval = 1000;
            this.timerWatchServerMessage.Tick += new System.EventHandler(this.timerWatchServerMessage_Tick);
            // 
            // linkLabelFeedback
            // 
            this.linkLabelFeedback.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelFeedback.AutoSize = true;
            this.linkLabelFeedback.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabelFeedback.Location = new System.Drawing.Point(77, 566);
            this.linkLabelFeedback.Name = "linkLabelFeedback";
            this.linkLabelFeedback.Size = new System.Drawing.Size(79, 20);
            this.linkLabelFeedback.TabIndex = 9;
            this.linkLabelFeedback.TabStop = true;
            this.linkLabelFeedback.Text = "Feedback";
            this.linkLabelFeedback.VisitedLinkColor = System.Drawing.Color.LightGreen;
            this.linkLabelFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFeedback_LinkClicked);
            // 
            // linkLabelChangePersonality
            // 
            this.linkLabelChangePersonality.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelChangePersonality.AutoSize = true;
            this.linkLabelChangePersonality.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabelChangePersonality.Location = new System.Drawing.Point(12, 118);
            this.linkLabelChangePersonality.Name = "linkLabelChangePersonality";
            this.linkLabelChangePersonality.Size = new System.Drawing.Size(219, 20);
            this.linkLabelChangePersonality.TabIndex = 2;
            this.linkLabelChangePersonality.TabStop = true;
            this.linkLabelChangePersonality.Text = "Change Personal Information";
            this.linkLabelChangePersonality.VisitedLinkColor = System.Drawing.Color.LightGreen;
            this.linkLabelChangePersonality.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangePersonality_LinkClicked);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(0, 590);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(271, 20);
            this.labelStatus.TabIndex = 17;
            this.labelStatus.Text = "Search Result: No result is searched.";
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
            // myTextBoxKeywords
            // 
            this.myTextBoxKeywords.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxKeywords.HintText = "Keywords";
            this.myTextBoxKeywords.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxKeywords.Location = new System.Drawing.Point(613, 11);
            this.myTextBoxKeywords.Name = "myTextBoxKeywords";
            this.myTextBoxKeywords.Size = new System.Drawing.Size(123, 27);
            this.myTextBoxKeywords.TabIndex = 11;
            this.myTextBoxKeywords.TextChanged += new System.EventHandler(this.myTextBoxKeywords_TextChanged);
            this.myTextBoxKeywords.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myTextBoxKeywords_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Permission of Operation:";
            // 
            // labelPermission
            // 
            this.labelPermission.AutoSize = true;
            this.labelPermission.Location = new System.Drawing.Point(23, 57);
            this.labelPermission.Name = "labelPermission";
            this.labelPermission.Size = new System.Drawing.Size(130, 20);
            this.labelPermission.TabIndex = 21;
            this.labelPermission.Text = "All of Permission";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.labelPermission);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.linkLabelChangePersonality);
            this.Controls.Add(this.linkLabelFeedback);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.myTextBoxKeywords);
            this.Controls.Add(this.buttonCheckRecord);
            this.Controls.Add(this.buttonEditCategory);
            this.Controls.Add(this.buttonManageUser);
            this.Controls.Add(this.buttonChangePswd);
            this.Controls.Add(this.buttonExportSearch);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.buttonExportAll);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.comboBoxSecond);
            this.Controls.Add(this.comboBoxFirst);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management of Material System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl.ResumeLayout(false);
            this.tabPageRecord.ResumeLayout(false);
            this.tabPageRecord.PerformLayout();
            this.tabPageSearchResult.ResumeLayout(false);
            this.contextMenuStripListSeach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFirst;
        private System.Windows.Forms.ComboBox comboBoxSecond;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageRecord;
        private System.Windows.Forms.TextBox textBoxRecord;
        private System.Windows.Forms.TabPage tabPageSearchResult;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonExportAll;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderSpec;
        private System.Windows.Forms.ColumnHeader columnHeaderCode;
        private MyTextBox myTextBoxKeywords;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button buttonExportSearch;
        private System.Windows.Forms.ColumnHeader columnHeaderUnit;
        private System.Windows.Forms.Button buttonChangePswd;
        private System.Windows.Forms.Button buttonManageUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListSeach;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelete;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Button buttonCheckRecord;
        private System.Windows.Forms.Label labelAlert;
        private System.Windows.Forms.Timer timerWatchServerMessage;
        private System.Windows.Forms.LinkLabel linkLabelFeedback;
        private System.Windows.Forms.LinkLabel linkLabelChangePersonality;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPermission;
    }
}

