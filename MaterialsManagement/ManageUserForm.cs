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
    public partial class ManageUserForm : Form
    {
        private string serverPath, databasePath;
        private string databaseContent, usersInfo;
        private string category;
        public ManageUserForm()
        {
            InitializeComponent();
        }

        private void ManageUserForm_Load(object sender, EventArgs e)
        {
            serverPath = @"\\192.168.0.2\其他文档\MaterialsManagement";
            databasePath = serverPath + "\\Database";
            databaseContent = File.ReadAllText(databasePath, Encoding.Default);
            databaseContent = Common.AESDecryptStr(databaseContent);
            usersInfo = Regex.Match(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>").ToString();
            MatchCollection mc = Regex.Matches(usersInfo, "<item>[\\s\\S]{0,200}?</item>");
            for (int i = 0; i < mc.Count; i++)
            {
                string temp = mc[i].ToString();
                string name = Regex.Match(temp, "<name=\".*\" />").ToString();
                if (name != "") name = name.Substring(7, name.Length - 11);
                string depart = Regex.Match(temp, "<depart=\".*\" />").ToString();
                if (depart != "") depart = depart.Substring(9, depart.Length - 13);
                string permission = Regex.Match(temp, "<permission=\".*\" />").ToString();
                if (permission != "") permission = permission.Substring(13, permission.Length - 17);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = name;
                lvi.SubItems.Add(depart);
                lvi.SubItems.Add(permission);
                listViewUser.Items.Add(lvi);
            }

            category = Regex.Match(databaseContent, "<Category>[\\s\\S]*</Category>").ToString();
            foreach (Match m in Regex.Matches(category, "<first=\".*\">"))
            {
                string temp = m.ToString();
                temp = temp.Substring(8, temp.Length - 10);
                comboBoxFirst.Items.Add(temp);
            }

        }


        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {

            if (listViewUser.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usersInfo = Regex.Replace(usersInfo, "<item>\r\n<name=\"" + listViewUser.SelectedItems[0].Text + @"[\s\S]{0,200}?</item>[\s]*", "");
                    databaseContent = Regex.Replace(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>", usersInfo);
                    string encryptedData = Common.AESEncryptStr(databaseContent);
                    File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                    listViewUser.Items.Remove(listViewUser.Items[listViewUser.SelectedItems[0].Index]);
                }
            }
            else MessageBox.Show("Please select deleted item.");
        }

        private void buttonAddPermission_Click(object sender, EventArgs e)
        {

            if (listViewUser.SelectedItems.Count > 0)
            {
                if (comboBoxFirst.Text != "")
                {
                    string user = Regex.Match(usersInfo, "<item>\r\n<name=\"" + listViewUser.SelectedItems[0].Text + @"[\s\S]{0,200}?</item>").ToString();
                    if (!user.Contains(comboBoxFirst.Text))
                    {
                        if (MessageBox.Show("Are you sure add this permission for select user?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string permission = "";
                            if (user.Contains("permission"))
                            {
                                permission = Regex.Match(user, "<permission=\".*\" />").ToString();
                                if (permission != "") permission = permission.Substring(13, permission.Length - 17);
                                permission += "、" + comboBoxFirst.Text;
                                user = Regex.Replace(user, "<permission=\".*\" />", "<permission=\"" + permission + "\" />").ToString();
                                usersInfo = Regex.Replace(usersInfo, "<item>\r\n<name=\"" + listViewUser.SelectedItems[0].Text + @"[\s\S]{0,200}?</item>", user).ToString();
                            }
                            else
                            {
                                permission = comboBoxFirst.Text;
                                user = Regex.Replace(user, "</item>", "<permission=\"" + permission + "\" />\r\n</item>");
                                usersInfo = Regex.Replace(usersInfo, "<item>\r\n<name=\"" + listViewUser.SelectedItems[0].Text + @"[\s\S]{0,200}?</item>", user).ToString();
                            }
                            databaseContent = Regex.Replace(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>", usersInfo);
                            string encryptedData = Common.AESEncryptStr(databaseContent);
                            File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = listViewUser.SelectedItems[0].Text;
                            lvi.SubItems.Add(listViewUser.SelectedItems[0].SubItems[1]);
                            lvi.SubItems.Add(permission);
                            int index = listViewUser.SelectedItems[0].Index;
                            listViewUser.Items[index] = lvi;
                        }

                    }
                    else MessageBox.Show("Exist this permission.");
                }
                else MessageBox.Show("Please select permission.");
            }
            else MessageBox.Show("Please select user.");

        }

        private void buttonDeletePermission_Click(object sender, EventArgs e)
        {

            if (listViewUser.SelectedItems.Count > 0)
            {
                string user = Regex.Match(usersInfo, "<item>\r\n<name=\"" + listViewUser.SelectedItems[0].Text + @"[\s\S]{0,200}?</item>").ToString();
                if (MessageBox.Show("Are you sure delete this permission for select user?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    user = Regex.Replace(user, "<permission=\".*\" />\r\n", "").ToString();
                    usersInfo = Regex.Replace(usersInfo, "<item>\r\n<name=\"" + listViewUser.SelectedItems[0].Text + @"[\s\S]{0,200}?</item>", user).ToString();
                    databaseContent = Regex.Replace(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>", usersInfo);
                    string encryptedData = Common.AESEncryptStr(databaseContent);
                    File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = listViewUser.SelectedItems[0].Text;
                    lvi.SubItems.Add(listViewUser.SelectedItems[0].SubItems[1]);
                    lvi.SubItems.Add("");
                    int index = listViewUser.SelectedItems[0].Index;
                    listViewUser.Items[index] = lvi;
                }
            }
            else MessageBox.Show("Please select user.");
        }


        
    }
}
