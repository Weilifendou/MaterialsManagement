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
    public partial class ChangePswdForm : Form
    {
        private string name;
        public ChangePswdForm(string userName)
        {
            InitializeComponent();
            this.name = userName;
        }
        private void buttonConfirmChange_Click(object sender, EventArgs e)
        {
            string serverPath = @"\\192.168.0.2\其他文档\MaterialsManagement";
            string databasePath = serverPath + "\\Database";
            try
            {
                string databaseContent = File.ReadAllText(databasePath, Encoding.Default);
                databaseContent = Common.AESDecryptStr(databaseContent);
                string originalPswd = myTextBoxOriginalPswd.Text;
                string newPswd = myTextBoxNewPswd.Text;
                string reNewPswd = myTextBoxReNewPswd.Text;
                if (newPswd == "") MessageBox.Show("No password.");
                else if (newPswd.Length < 3) MessageBox.Show("Password is too short.");
                else if (newPswd.Length > 16) MessageBox.Show("Password is too long.");
                else if (newPswd != reNewPswd)
                {
                    MessageBox.Show("Two Passwords are different.");
                    myTextBoxNewPswd.Text = "";
                    myTextBoxReNewPswd.Text = "";
                }
                else if (name == "Administrator")
                {
                    string storedAdminPswd = Regex.Match(databaseContent, "<AdminPswd>.{3,20}</AdminPswd>").ToString();
                    if (storedAdminPswd != "") storedAdminPswd = storedAdminPswd.Substring(11, storedAdminPswd.Length - 23);
                    if (originalPswd == storedAdminPswd)
                    {
                        string temp = "<AdminPswd>"+ reNewPswd + "</AdminPswd>";
                        databaseContent = Regex.Replace(databaseContent, "<AdminPswd>.{3,20}</AdminPswd>", temp);
                        string encryptedData = Common.AESEncryptStr(databaseContent);
                        File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                        Dispose();
                        new ProgressForm().ShowDialog();
                        MessageBox.Show("Password of Administrator has been changed");
                    }
                    else
                    {
                        MessageBox.Show("Original password is incorrect.");
                        myTextBoxOriginalPswd.Text = "";
                    }
                }
                else
                {
                    string usersInfo = Regex.Match(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>").ToString();
                    string userInfo = Regex.Match(usersInfo, "<item>\r\n<name=\"" + name + @"[\s\S]{0,200}?</item>").ToString();
                    string storedPswd = Regex.Match(userInfo, "<pswd=\".*\" />").ToString();
                    storedPswd = storedPswd.Substring(7, storedPswd.Length - 11);
                    if (originalPswd == storedPswd)
                    {
                        userInfo = Regex.Replace(userInfo, "<pswd=\".*\" />", "<pswd=\"" + reNewPswd + "\" />");
                        usersInfo = Regex.Replace(usersInfo, "<item>\r\n<name=\"" + name + @"[\s\S]{0,200}?</item>", userInfo);
                        databaseContent = Regex.Replace(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>", usersInfo);
                        string encryptedData = Common.AESEncryptStr(databaseContent);
                        File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                        Dispose();
                        new ProgressForm().ShowDialog();
                        MessageBox.Show("Your password has been changed, please remember it.");
                    }
                    else
                    {
                        MessageBox.Show("Original password is incorrect.");
                        myTextBoxOriginalPswd.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No internet.");
            }
        }
    }
}
