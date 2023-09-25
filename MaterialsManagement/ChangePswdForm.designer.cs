namespace MaterialsManagement
{
    partial class ChangePswdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePswdForm));
            this.myTextBoxOriginalPswd = new MaterialsManagement.MyTextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.myTextBoxReNewPswd = new MaterialsManagement.MyTextBox();
            this.myTextBoxNewPswd = new MaterialsManagement.MyTextBox();
            this.SuspendLayout();
            // 
            // myTextBoxOriginalPswd
            // 
            this.myTextBoxOriginalPswd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxOriginalPswd.HintText = "Input original password";
            this.myTextBoxOriginalPswd.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxOriginalPswd.Location = new System.Drawing.Point(48, 37);
            this.myTextBoxOriginalPswd.Name = "myTextBoxOriginalPswd";
            this.myTextBoxOriginalPswd.PasswordChar = '●';
            this.myTextBoxOriginalPswd.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxOriginalPswd.TabIndex = 1;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(92, 184);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(100, 40);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Conform";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonConfirmChange_Click);
            // 
            // myTextBoxReNewPswd
            // 
            this.myTextBoxReNewPswd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxReNewPswd.HintText = "Conform new password";
            this.myTextBoxReNewPswd.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxReNewPswd.Location = new System.Drawing.Point(48, 135);
            this.myTextBoxReNewPswd.Name = "myTextBoxReNewPswd";
            this.myTextBoxReNewPswd.PasswordChar = '●';
            this.myTextBoxReNewPswd.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxReNewPswd.TabIndex = 3;
            // 
            // myTextBoxNewPswd
            // 
            this.myTextBoxNewPswd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxNewPswd.HintText = "Input new password";
            this.myTextBoxNewPswd.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxNewPswd.Location = new System.Drawing.Point(48, 86);
            this.myTextBoxNewPswd.Name = "myTextBoxNewPswd";
            this.myTextBoxNewPswd.PasswordChar = '●';
            this.myTextBoxNewPswd.Size = new System.Drawing.Size(188, 27);
            this.myTextBoxNewPswd.TabIndex = 2;
            // 
            // ChangePswdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.myTextBoxNewPswd);
            this.Controls.Add(this.myTextBoxReNewPswd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.myTextBoxOriginalPswd);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePswdForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBox myTextBoxOriginalPswd;
        private System.Windows.Forms.Button buttonChange;
        private MyTextBox myTextBoxReNewPswd;
        private MyTextBox myTextBoxNewPswd;

    }
}