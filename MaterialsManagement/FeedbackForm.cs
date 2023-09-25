using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Threading;
using System.Text.RegularExpressions;


namespace MaterialsManagement
{
    public partial class FeedbackForm : Form
    {

        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string serverPath = @"\\192.168.0.2\其他文档\MaterialsManagement";
            string databasePath = serverPath + "\\Database";
            string databaseContent = File.ReadAllText(databasePath, Encoding.Default);
            databaseContent = Common.AESDecryptStr(databaseContent);
            string feedback = Regex.Match(databaseContent, "<Feedback>[\\s\\S]*</Feedback>").ToString();
            string temp= "<item>\r\n<name=\"" + myTextBoxName.Text
                + "\" />\r\n<depart=\"" + comboBoxDepartment.Text
                + "\" />\r\n<feedback>\r\n" + myTextBoxFeedback.Text
                + "\r\n</feedback>\r\n</item>\r\n\r\n";
            feedback = Regex.Replace(feedback, "</Feedback>", temp + "</Feedback>");
            databaseContent = Regex.Replace(databaseContent, "<Feedback>[\\s\\S]*</Feedback>", feedback);
            string encryptedData = Common.AESEncryptStr(databaseContent);
            File.WriteAllText(databasePath, encryptedData, Encoding.Default);
            Dispose();
            MessageBox.Show("Appreciate your valuable suggestion.");
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxDepartment.Text == "Please input your department.")
                comboBoxDepartment.ForeColor = Color.LightGray;
            else comboBoxDepartment.ForeColor = Color.DeepSkyBlue;
        }

        private void comboBoxDepartment_Enter(object sender, EventArgs e)
        {
            comboBoxDepartment.ForeColor = Color.DeepSkyBlue;
        }

        private void comboBoxDepartment_Leave(object sender, EventArgs e)
        {
            if (comboBoxDepartment.Text == "Please input your department.")
                comboBoxDepartment.ForeColor = Color.LightGray;
            else comboBoxDepartment.ForeColor = Color.DeepSkyBlue;
        }

    }
}
