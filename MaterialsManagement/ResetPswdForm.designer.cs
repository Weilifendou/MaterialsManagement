namespace MaterialsManagement
{
    partial class ResetPswdForm
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
        /// 
        /// method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPswdForm));
            this.myTextBoxNewPswd = new MaterialsManagement.MyTextBox();
            this.myTextBoxName = new MaterialsManagement.MyTextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.myTextBoxAdminPswd = new MaterialsManagement.MyTextBox();
            this.myTextBoxReNewPswd = new MaterialsManagement.MyTextBox();
            this.SuspendLayout();
            // 
            // myTextBoxNewPswd
            // 
            this.myTextBoxNewPswd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxNewPswd.HintText = "New password";
            this.myTextBoxNewPswd.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxNewPswd.Location = new System.Drawing.Point(48, 61);
            this.myTextBoxNewPswd.Name = "myTextBoxNewPswd";
            this.myTextBoxNewPswd.PasswordChar = '●';
            this.myTextBoxNewPswd.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxNewPswd.TabIndex = 2;
            // 
            // myTextBoxName
            // 
            this.myTextBoxName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxName.HintText = "Name";
            this.myTextBoxName.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxName.Location = new System.Drawing.Point(48, 12);
            this.myTextBoxName.Name = "myTextBoxName";
            this.myTextBoxName.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxName.TabIndex = 1;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(102, 208);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 40);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // myTextBoxAdminPswd
            // 
            this.myTextBoxAdminPswd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxAdminPswd.HintText = "Administrator password";
            this.myTextBoxAdminPswd.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxAdminPswd.Location = new System.Drawing.Point(48, 159);
            this.myTextBoxAdminPswd.Name = "myTextBoxAdminPswd";
            this.myTextBoxAdminPswd.PasswordChar = '●';
            this.myTextBoxAdminPswd.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxAdminPswd.TabIndex = 4;
            // 
            // myTextBoxReNewPswd
            // 
            this.myTextBoxReNewPswd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxReNewPswd.HintText = "Conform password";
            this.myTextBoxReNewPswd.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxReNewPswd.Location = new System.Drawing.Point(48, 110);
            this.myTextBoxReNewPswd.Name = "myTextBoxReNewPswd";
            this.myTextBoxReNewPswd.PasswordChar = '●';
            this.myTextBoxReNewPswd.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxReNewPswd.TabIndex = 3;
            // 
            // ResetPswdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.myTextBoxReNewPswd);
            this.Controls.Add(this.myTextBoxAdminPswd);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.myTextBoxNewPswd);
            this.Controls.Add(this.myTextBoxName);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPswdForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重置密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBox myTextBoxName;
        private MyTextBox myTextBoxNewPswd;
        private System.Windows.Forms.Button buttonReset;
        private MyTextBox myTextBoxAdminPswd;
        private MyTextBox myTextBoxReNewPswd;

    }
}