namespace MaterialsManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.myTextBoxPswd = new MaterialsManagement.MyTextBox();
            this.myTextBoxName = new MaterialsManagement.MyTextBox();
            this.linkLabelForgetPswd = new System.Windows.Forms.LinkLabel();
            this.checkBoxRememberPswd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(73, 170);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(80, 40);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(181, 170);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(80, 40);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // myTextBoxPswd
            // 
            this.myTextBoxPswd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxPswd.HintText = "Password";
            this.myTextBoxPswd.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxPswd.Location = new System.Drawing.Point(73, 94);
            this.myTextBoxPswd.Name = "myTextBoxPswd";
            this.myTextBoxPswd.PasswordChar = '●';
            this.myTextBoxPswd.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxPswd.TabIndex = 3;
            // 
            // myTextBoxName
            // 
            this.myTextBoxName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxName.HintText = "Name";
            this.myTextBoxName.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxName.Location = new System.Drawing.Point(73, 50);
            this.myTextBoxName.Name = "myTextBoxName";
            this.myTextBoxName.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxName.TabIndex = 2;
            // 
            // linkLabelForgetPswd
            // 
            this.linkLabelForgetPswd.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelForgetPswd.AutoSize = true;
            this.linkLabelForgetPswd.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabelForgetPswd.Location = new System.Drawing.Point(188, 127);
            this.linkLabelForgetPswd.Name = "linkLabelForgetPswd";
            this.linkLabelForgetPswd.Size = new System.Drawing.Size(73, 20);
            this.linkLabelForgetPswd.TabIndex = 5;
            this.linkLabelForgetPswd.TabStop = true;
            this.linkLabelForgetPswd.Text = "Forget？";
            this.linkLabelForgetPswd.VisitedLinkColor = System.Drawing.Color.LightGreen;
            this.linkLabelForgetPswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgetPswd_LinkClicked);
            // 
            // checkBoxRememberPswd
            // 
            this.checkBoxRememberPswd.AutoSize = true;
            this.checkBoxRememberPswd.Location = new System.Drawing.Point(73, 127);
            this.checkBoxRememberPswd.Name = "checkBoxRememberPswd";
            this.checkBoxRememberPswd.Size = new System.Drawing.Size(109, 24);
            this.checkBoxRememberPswd.TabIndex = 4;
            this.checkBoxRememberPswd.Text = "Remember";
            this.checkBoxRememberPswd.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.checkBoxRememberPswd);
            this.Controls.Add(this.linkLabelForgetPswd);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.myTextBoxPswd);
            this.Controls.Add(this.myTextBoxName);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBox myTextBoxName;
        private MyTextBox myTextBoxPswd;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.LinkLabel linkLabelForgetPswd;
        private System.Windows.Forms.CheckBox checkBoxRememberPswd;

    }
}