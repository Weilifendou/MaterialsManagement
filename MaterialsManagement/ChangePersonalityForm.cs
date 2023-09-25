using System;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

using System.IO;
using System.Threading;
using System.Text.RegularExpressions;


namespace MaterialsManagement
{
    public partial class ChangePersonalityForm : Form
    {
        private string name;
        private string serverPath, databasePath;
        private string databaseContent, usersInfo, userInfo;
        public ChangePersonalityForm(string userName)
        {
            InitializeComponent();
            this.name = userName;
        }

        private void Information_Load(object sender, EventArgs e)
        {
            serverPath = @"\\192.168.0.2\其他文档\MaterialsManagement";
            databasePath = serverPath + "\\Database";
            databaseContent = File.ReadAllText(databasePath, Encoding.Default);
            databaseContent = Common.AESDecryptStr(databaseContent);
            usersInfo = Regex.Match(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>").ToString();
            userInfo = Regex.Match(usersInfo, "<item>\r\n<name=\"" + name + @"[\s\S]{0,200}?</item>").ToString();
            string depart = Regex.Match(userInfo, "<depart=\".*\" />").ToString();
            if (depart != "") depart = depart.Substring(9, depart.Length - 13);
            comboBoxDepartment.Text = depart;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            userInfo = Regex.Replace(userInfo, "<depart=\".*\" />", "<depart=\"" + comboBoxDepartment.Text + "\" />");
            usersInfo = Regex.Replace(usersInfo, "<item>\r\n<name=\"" + name + @"[\s\S]{0,200}?</item>", userInfo);
            databaseContent = Regex.Replace(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>", usersInfo);
            string encryptedData = Common.AESEncryptStr(databaseContent);
            File.WriteAllText(databasePath, encryptedData, Encoding.Default);
            Dispose();
            new ProgressForm().ShowDialog();
            MessageBox.Show("Changed department.");
        }
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxDepartment.Text == "Department")
                comboBoxDepartment.ForeColor = Color.LightGray;
            else comboBoxDepartment.ForeColor = Color.DeepSkyBlue;
        }

        private void comboBoxDepartment_Enter(object sender, EventArgs e)
        {
            comboBoxDepartment.ForeColor = Color.DeepSkyBlue;
        }

        private void comboBoxDepartment_Leave(object sender, EventArgs e)
        {
            if (comboBoxDepartment.Text == "Department")
                comboBoxDepartment.ForeColor = Color.LightGray;
            else comboBoxDepartment.ForeColor = Color.DeepSkyBlue;
        }



    }
}
