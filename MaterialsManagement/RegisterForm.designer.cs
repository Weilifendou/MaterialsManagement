namespace MaterialsManagement
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.myTextBoxPswd = new MaterialsManagement.MyTextBox();
            this.myTextBoxName = new MaterialsManagement.MyTextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.myTextBoxRePswd = new MaterialsManagement.MyTextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // myTextBoxPswd
            // 
            this.myTextBoxPswd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxPswd.HintText = "Password";
            this.myTextBoxPswd.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxPswd.Location = new System.Drawing.Point(48, 68);
            this.myTextBoxPswd.Name = "myTextBoxPswd";
            this.myTextBoxPswd.PasswordChar = '●';
            this.myTextBoxPswd.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxPswd.TabIndex = 2;
            // 
            // myTextBoxName
            // 
            this.myTextBoxName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxName.HintText = "Name";
            this.myTextBoxName.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxName.Location = new System.Drawing.Point(48, 26);
            this.myTextBoxName.Name = "myTextBoxName";
            this.myTextBoxName.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxName.TabIndex = 1;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(102, 195);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(80, 40);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // myTextBoxRePswd
            // 
            this.myTextBoxRePswd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxRePswd.HintText = "Conform Password";
            this.myTextBoxRePswd.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxRePswd.Location = new System.Drawing.Point(48, 110);
            this.myTextBoxRePswd.Name = "myTextBoxRePswd";
            this.myTextBoxRePswd.PasswordChar = '●';
            this.myTextBoxRePswd.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxRePswd.TabIndex = 3;
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
            this.comboBoxDepartment.Location = new System.Drawing.Point(48, 152);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(188, 28);
            this.comboBoxDepartment.Sorted = true;
            this.comboBoxDepartment.TabIndex = 4;
            this.comboBoxDepartment.Text = "Department";
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            this.comboBoxDepartment.Enter += new System.EventHandler(this.comboBoxDepartment_Enter);
            this.comboBoxDepartment.Leave += new System.EventHandler(this.comboBoxDepartment_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.myTextBoxRePswd);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.myTextBoxPswd);
            this.Controls.Add(this.myTextBoxName);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBox myTextBoxName;
        private MyTextBox myTextBoxPswd;
        private System.Windows.Forms.Button buttonRegister;
        private MyTextBox myTextBoxRePswd;
        private System.Windows.Forms.ComboBox comboBoxDepartment;

    }
}