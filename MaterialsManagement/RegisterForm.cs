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
using System.Text.RegularExpressions;

namespace MaterialsManagement
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string serverPath = @"\\192.168.0.2\其他文档\MaterialsManagement";
            string databasePath = serverPath + "\\Database";
            try
            {
                string databaseContent = File.ReadAllText(databasePath, Encoding.Default);
                databaseContent = Common.AESDecryptStr(databaseContent);
                string usersInfo = Regex.Match(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>").ToString();
                string name = myTextBoxName.Text;
                string pswd = myTextBoxPswd.Text;
                string rePswd = myTextBoxRePswd.Text;
                string department = comboBoxDepartment.Text;
                if (name == "") MessageBox.Show("No name.");
                else if (!Regex.IsMatch(name, "[\u4e00-\u9fa5]")) MessageBox.Show("Please user Chinese name.");
                else if (name == "Administrator") MessageBox.Show("Not allow to register Administrator.");
                else if (usersInfo.Contains(name)) MessageBox.Show("Exist this user.");
                else if (pswd == "") MessageBox.Show("No password");
                else if (pswd.Length < 3) MessageBox.Show("Password is too short.");
                else if (pswd.Length > 16) MessageBox.Show("Password is too long.");
                else if (department == "Please select department.") MessageBox.Show("No department.");
                else if (pswd != rePswd)
                {
                    MessageBox.Show("Two passwords are different.");
                    myTextBoxPswd.Text = "";
                    myTextBoxRePswd.Text = "";
                }
                else
                {
                    try
                    {
                        string temp = "<item>\r\n<name=\"" + name + "\" />\r\n<pswd=\"" + rePswd
                            + "\" />\r\n<depart=\"" + department + "\" />\r\n<state=\"OFFLINE\" />\r\n</item>\r\n\r\n</UserInformation>";
                        usersInfo = Regex.Replace(usersInfo, "</UserInformation>", temp);
                        databaseContent = Regex.Replace(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>", usersInfo);
                        string encryptedData = Common.AESEncryptStr(databaseContent);
                        File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                        Dispose();
                        new ProgressForm().ShowDialog();
                        MessageBox.Show("Registered");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No internet.");
            }
          
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
