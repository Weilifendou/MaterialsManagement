namespace MaterialsManagement
{
    partial class FeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackForm));
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.myTextBoxName = new MaterialsManagement.MyTextBox();
            this.myTextBoxFeedback = new MaterialsManagement.MyTextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(146, 358);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(80, 40);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // myTextBoxName
            // 
            this.myTextBoxName.HintText = "Please input your name";
            this.myTextBoxName.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxName.Location = new System.Drawing.Point(12, 13);
            this.myTextBoxName.Name = "myTextBoxName";
            this.myTextBoxName.Size = new System.Drawing.Size(360, 27);
            this.myTextBoxName.TabIndex = 1;
            // 
            // myTextBoxFeedback
            // 
            this.myTextBoxFeedback.HintText = "Please offer your valuable suggestion.";
            this.myTextBoxFeedback.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxFeedback.Location = new System.Drawing.Point(12, 108);
            this.myTextBoxFeedback.Multiline = true;
            this.myTextBoxFeedback.Name = "myTextBoxFeedback";
            this.myTextBoxFeedback.Size = new System.Drawing.Size(360, 230);
            this.myTextBoxFeedback.TabIndex = 3;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "技术部-天线",
            "技术部-总体",
            "生产部",
            "市场部",
            "运营部",
            "综合部"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(12, 60);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(360, 28);
            this.comboBoxDepartment.Sorted = true;
            this.comboBoxDepartment.TabIndex = 2;
            this.comboBoxDepartment.Text = "Please input your department.";
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            this.comboBoxDepartment.Enter += new System.EventHandler(this.comboBoxDepartment_Enter);
            this.comboBoxDepartment.Leave += new System.EventHandler(this.comboBoxDepartment_Leave);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.myTextBoxFeedback);
            this.Controls.Add(this.myTextBoxName);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FeedbackForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback and Suggestion";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private MyTextBox myTextBoxName;
        private MyTextBox myTextBoxFeedback;
        private System.Windows.Forms.ComboBox comboBoxDepartment;



    }
}