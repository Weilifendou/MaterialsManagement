namespace MaterialsManagement
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.myTextBoxName = new MaterialsManagement.MyTextBox();
            this.myTextBoxType = new MaterialsManagement.MyTextBox();
            this.myTextBoxSpec = new MaterialsManagement.MyTextBox();
            this.myTextBoxUnit = new MaterialsManagement.MyTextBox();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonConfirm.Location = new System.Drawing.Point(17, 215);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(200, 31);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "Conform";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // myTextBoxName
            // 
            this.myTextBoxName.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.myTextBoxName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxName.HintText = "Name of material";
            this.myTextBoxName.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxName.Location = new System.Drawing.Point(17, 15);
            this.myTextBoxName.Name = "myTextBoxName";
            this.myTextBoxName.Size = new System.Drawing.Size(200, 27);
            this.myTextBoxName.TabIndex = 1;
            // 
            // myTextBoxType
            // 
            this.myTextBoxType.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.myTextBoxType.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxType.HintText = "Type of material";
            this.myTextBoxType.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxType.Location = new System.Drawing.Point(17, 65);
            this.myTextBoxType.Name = "myTextBoxType";
            this.myTextBoxType.Size = new System.Drawing.Size(200, 27);
            this.myTextBoxType.TabIndex = 2;
            // 
            // myTextBoxSpec
            // 
            this.myTextBoxSpec.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.myTextBoxSpec.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxSpec.HintText = "Spec of material";
            this.myTextBoxSpec.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxSpec.Location = new System.Drawing.Point(17, 115);
            this.myTextBoxSpec.Name = "myTextBoxSpec";
            this.myTextBoxSpec.Size = new System.Drawing.Size(200, 27);
            this.myTextBoxSpec.TabIndex = 3;
            // 
            // myTextBoxUnit
            // 
            this.myTextBoxUnit.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.myTextBoxUnit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.myTextBoxUnit.HintText = "Unit of material";
            this.myTextBoxUnit.InputType = MaterialsManagement.MyTextBox.enumInputTypes.None;
            this.myTextBoxUnit.Location = new System.Drawing.Point(17, 165);
            this.myTextBoxUnit.Name = "myTextBoxUnit";
            this.myTextBoxUnit.Size = new System.Drawing.Size(200, 27);
            this.myTextBoxUnit.TabIndex = 4;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.myTextBoxUnit);
            this.Controls.Add(this.myTextBoxSpec);
            this.Controls.Add(this.myTextBoxType);
            this.Controls.Add(this.myTextBoxName);
            this.Controls.Add(this.buttonConfirm);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information of Material";
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private MyTextBox myTextBoxName;
        private MyTextBox myTextBoxType;
        private MyTextBox myTextBoxSpec;
        private MyTextBox myTextBoxUnit;
    }
}