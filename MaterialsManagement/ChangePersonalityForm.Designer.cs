namespace MaterialsManagement
{
    partial class ChangePersonalityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePersonalityForm));
            this.buttonConfirmChange = new System.Windows.Forms.Button();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonConfirmChange
            // 
            this.buttonConfirmChange.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonConfirmChange.Location = new System.Drawing.Point(12, 60);
            this.buttonConfirmChange.Name = "buttonConfirmChange";
            this.buttonConfirmChange.Size = new System.Drawing.Size(210, 31);
            this.buttonConfirmChange.TabIndex = 0;
            this.buttonConfirmChange.Text = "Conform";
            this.buttonConfirmChange.UseVisualStyleBackColor = true;
            this.buttonConfirmChange.Click += new System.EventHandler(this.buttonConfirm_Click);
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
            this.comboBoxDepartment.Location = new System.Drawing.Point(12, 19);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(210, 25);
            this.comboBoxDepartment.Sorted = true;
            this.comboBoxDepartment.TabIndex = 5;
            this.comboBoxDepartment.Text = "Department";
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            this.comboBoxDepartment.Enter += new System.EventHandler(this.comboBoxDepartment_Enter);
            this.comboBoxDepartment.Leave += new System.EventHandler(this.comboBoxDepartment_Leave);
            // 
            // ChangePersonalityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.buttonConfirmChange);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePersonalityForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmChange;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
    }
}