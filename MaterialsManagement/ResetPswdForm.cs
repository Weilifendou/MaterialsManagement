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
    public partial class ResetPswdForm : Form
    {
        public ResetPswdForm()
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
                string storedAdminPswd = Regex.Match(databaseContent, "<AdminPswd>.{3,20}</AdminPswd>").ToString();
                if (storedAdminPswd != "") storedAdminPswd = storedAdminPswd.Substring(11, storedAdminPswd.Length - 23);
                string name = myTextBoxName.Text;
                string pswd = myTextBoxNewPswd.Text;
                string rePswd = myTextBoxReNewPswd.Text;
                string adminPswd = myTextBoxAdminPswd.Text;
                if (name == "") MessageBox.Show("No name.");
                else if (pswd == "") MessageBox.Show("No password");
                else if (pswd.Length < 3) MessageBox.Show("Password is too short.");
                else if (pswd.Length > 16) MessageBox.Show("Password is too long.");
                else if (pswd != rePswd)
                {
                    MessageBox.Show("Two passwords are different.");
                    myTextBoxNewPswd.Text = "";
                    myTextBoxReNewPswd.Text = "";
                }
                else if (adminPswd != storedAdminPswd)
                {
                    MessageBox.Show("Password of Administrator is incorrect.");
                    myTextBoxName.Text = "";
                    myTextBoxNewPswd.Text = "";
                    myTextBoxReNewPswd.Text = "";
                    myTextBoxAdminPswd.Text = "";

                }
                else
                {
                    string usersInfo = Regex.Match(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>").ToString();
                    string userInfo = Regex.Match(usersInfo, "<item>\r\n<name=\"" + name + @"[\s\S]{0,200}?</item>").ToString();
                    if (userInfo != "")
                    {
                        userInfo = Regex.Replace(userInfo, "<pswd=\".*\" />", "<pswd=\"" + pswd + "\" />");
                        usersInfo = Regex.Replace(usersInfo, "<item>\r\n<name=\"" + name + @"[\s\S]{0,200}?</item>", userInfo);
                        databaseContent = Regex.Replace(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>", usersInfo);
                        string encryptedData = Common.AESEncryptStr(databaseContent);
                        File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                        Dispose();
                        new ProgressForm().ShowDialog();
                        MessageBox.Show("Reseted");
                    }
                    else MessageBox.Show("No this user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No internet.");
            }
          
        }


    
    }
}
