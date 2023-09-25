namespace MaterialsManagement
{
    partial class CheckRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckRecordForm));
            this.textBoxRecord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxRecord
            // 
            this.textBoxRecord.Location = new System.Drawing.Point(10, 10);
            this.textBoxRecord.Multiline = true;
            this.textBoxRecord.Name = "textBoxRecord";
            this.textBoxRecord.ReadOnly = true;
            this.textBoxRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecord.Size = new System.Drawing.Size(362, 389);
            this.textBoxRecord.TabIndex = 0;
            // 
            // CheckRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.textBoxRecord);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckRecordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Record";
            this.Load += new System.EventHandler(this.CheckRecordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRecord;


    }
}