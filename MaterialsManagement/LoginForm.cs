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
    public partial class LoginForm : Form
    {
        public string UserName;
        private string serverPath, localPath;
        private string databasePath, databaseContent;
        private string loginInfoPath;
        private string updaterPath;
        private string adminPswd;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserName = "";
            localPath = Directory.GetCurrentDirectory();
            serverPath = @"\\192.168.0.2\其他文档\MaterialsManagement";
            databasePath = serverPath + "\\Database";
            loginInfoPath = localPath + "\\LoginInfo";
            try
            {
                try
                {
                    if (File.Exists(loginInfoPath))
                    {
                        string loginInfoContent = File.ReadAllText(loginInfoPath, Encoding.Default);
                        loginInfoContent = Common.AESDecryptStr(loginInfoContent);
                        string name = Regex.Match(loginInfoContent, "<name=\".*\" />").ToString();
                        if (name != "") name = name.Substring(7, name.Length - 11);
                        string pswd = Regex.Match(loginInfoContent, "<pswd=\".*\" />").ToString();
                        if (pswd != "") pswd = pswd.Substring(7, pswd.Length - 11);
                        myTextBoxName.Text = name;
                        myTextBoxPswd.Text = pswd;
                        checkBoxRememberPswd.Checked = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please type your login informaiton again, becasuse old login information is invalid as update of data structure.");
                }
                updaterPath = serverPath + "\\MMSUpdater.exe";
                if (File.Exists(updaterPath))
                {
                    File.Delete(localPath + "\\MMSUpdater.exe");
                    File.Copy(updaterPath, localPath + "\\MMSUpdater.exe");
                }
                if (File.Exists(databasePath))
                {
                    databaseContent = File.ReadAllText(databasePath, Encoding.Default);
                    databaseContent = Common.AESDecryptStr(databaseContent);
                    adminPswd = Regex.Match(databaseContent, "<AdminPswd>.{3,20}</AdminPswd>").ToString();
                    if (adminPswd != "") adminPswd = adminPswd.Substring(11, adminPswd.Length - 23);
                    if (adminPswd == "")
                    {
                        databaseContent = Regex.Replace(databaseContent, "<AdminPswd></AdminPswd>", "<AdminPswd>TDYG</AdminPswd>");
                        string encryptedData = Common.AESEncryptStr(databaseContent);
                        File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                        string temp = "This is first time to run this application";
                        temp += "\r\nName：Administrator";
                        temp += "\r\nPassword：TDYG";
                        MessageBox.Show(temp);
                        Clipboard.SetText("Administrator");
                    }
                    string updateAnnouncement = Regex.Match(databaseContent, "<UpdateAnnouncement>[\\s\\S]{10,500}</UpdateAnnouncement>").ToString();
                    string version = Regex.Match(updateAnnouncement, "<version=\".*\" />").ToString();
                    if (version != "") version = version.Substring(10, version.Length - 14);
                    if (version != Application.ProductVersion)
                    {
                        string announcement = Regex.Match(updateAnnouncement, "<announce>[\\s\\S]{10,500}</announce>").ToString();
                        if (announcement != "") announcement = announcement.Substring(10, announcement.Length - 21);
                        if (MessageBox.Show("Detect new version " + version + ", please update!"
                            + "\r\n" + announcement, "Alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            string updateStatistic = Regex.Match(databaseContent, "<UpdateStatistic>[\\s\\S]*</UpdateStatistic>").ToString();
                            string temp = DateTime.Now.ToString() + " " + myTextBoxName.Text + " updated\r\n\r\n</UpdateStatistic>";
                            updateStatistic = Regex.Replace(updateStatistic, "\r\n</UpdateStatistic>", temp);
                            databaseContent = Regex.Replace(databaseContent, "<UpdateStatistic>[\\s\\S]*</UpdateStatistic>",updateStatistic);
                            string encryptedData = Common.AESEncryptStr(databaseContent);
                            File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                            File.Delete(localPath + "\\New Version");
                            File.Delete(localPath + "\\Farewell");
                            Dispose();
                            System.Diagnostics.Process.Start(localPath + "\\MMSUpdater.exe");
                            return;
                        }
                        else
                        {
                            Dispose();
                            return;
                        }
                    }
                    string serverMessage = Regex.Match(databaseContent, "<ServerMessage>.{0,100}</ServerMessage>").ToString();
                    if (serverMessage != "") serverMessage = serverMessage.Substring(15, serverMessage.Length - 31);
                    if (serverMessage != "")
                    {
                        MessageBox.Show(serverMessage);
                        Dispose();
                        return;
                    }
                }
                else
                {
                    File.WriteAllText(databasePath, Common.AESEncryptStr(""), Encoding.Default);
                    databaseContent = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No internet.");
            }
            Focus();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = myTextBoxName.Text;
            string pswd = myTextBoxPswd.Text;
            if (name != "")
            {
                if (name == "Administrator")
                {
                    if (pswd == adminPswd)
                    {
                        this.UserName = name;
                        if (checkBoxRememberPswd.Checked)
                        {
                            string loginInfo = "<name=\"" + name + "\" />\r\n<pswd=\"" + pswd + "\" />";
                            loginInfo = Common.AESEncryptStr(loginInfo);
                            File.WriteAllText(loginInfoPath, loginInfo, Encoding.Default);
                        }
                        else File.Delete(loginInfoPath);
                        Dispose();
                        new ProgressForm().ShowDialog();
                        MessageBox.Show("Welcome! you are Administrator, and you have all of permission of this application.");
                    }
                    else MessageBox.Show("Password is in correct.");
                }
                else
                {
                    databaseContent = File.ReadAllText(databasePath, Encoding.Default);
                    databaseContent = Common.AESDecryptStr(databaseContent);
                    string usersInfo = Regex.Match(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>").ToString();
                    string userInfo = Regex.Match(usersInfo, "<item>\r\n<name=\"" + name + @"[\s\S]{0,200}?</item>").ToString();
                    if (userInfo != "")
                    {
                        string storedPswd = Regex.Match(userInfo, "<pswd=\".*\" />").ToString();
                        storedPswd = storedPswd.Substring(7, storedPswd.Length - 11);
                        if (pswd == storedPswd)
                        {
                            this.UserName = name;
                            if (checkBoxRememberPswd.Checked)
                            {
                                string loginInfo = "<name=\"" + name + "\" />\r\n<pswd=\"" + pswd + "\" />";
                                loginInfo = Common.AESEncryptStr(loginInfo);
                                File.WriteAllText(loginInfoPath, loginInfo, Encoding.Default);
                            }
                            else File.Delete(loginInfoPath);
                            Dispose();
                            new ProgressForm().ShowDialog();
                            MessageBox.Show("Welcome, but you only part of permission of this application.");
                        }
                        else MessageBox.Show("Name or password is in correct.");
                    }
                    else MessageBox.Show("No this user, please register.");
                }
            }
            else MessageBox.Show("No name.");
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }

        private void linkLabelForgetPswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ResetPswdForm().ShowDialog();
        }
    }
}