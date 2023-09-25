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
using System.Reflection;
using System.Resources;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using MaterialsManagement.Properties;
using System.Diagnostics;
using Aspose.Cells;

namespace MaterialsManagement
{
    public partial class MainForm : Form
    {
        public MaterialInfo MI;
        public string UserName;
        private bool operateFlag;
        private string serverPath, localPath;
        private string databasePath, databaseContent;
        private string category, information;
        private string permission;
        private string operationRecord;
        private string generatedCode;
        private int serverWarnDelayer;
        private WindowZoom windowZoom;
        private string usersInfo;
        private string userInfo;
        public MainForm(string userName)
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            InitializeComponent();
            windowZoom = new WindowZoom(this);
            this.UserName = userName;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            serverWarnDelayer = 12;
            string title = " Version " + Application.ProductVersion
                + "   Login User：" + UserName;
            Text += title;
            MI = new MaterialInfo();
            localPath = Directory.GetCurrentDirectory();
            serverPath = @"\\192.168.0.2\其他文档\MaterialsManagement";
            databasePath = serverPath + "\\Database";
            databaseContent = File.ReadAllText(databasePath, Encoding.Default);
            databaseContent = Common.AESDecryptStr(databaseContent);
            if (UserName == "Administrator")
            {
                databaseContent = Regex.Replace(databaseContent,
                    "<AdminState>OFFLINE</AdminState>", "<AdminState>ONLINE</AdminState>");
                string encryptedData = Common.AESEncryptStr(databaseContent);
                File.WriteAllText(databasePath, encryptedData, Encoding.Default);
            }
            else if (UserName != "" && UserName != null)
            {
                usersInfo = Regex.Match(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>").ToString();
                userInfo = Regex.Match(usersInfo, "<item>\r\n<name=\"" + UserName + @"[\s\S]{0,200}?</item>").ToString();
                permission = Regex.Match(userInfo, "<permission=\".*\" />").ToString();
                if (permission != "")
                {
                    permission = permission.Substring(13, permission.Length - 17);
                    labelPermission.Text = permission;
                }
                else labelPermission.Text = "Only Check";
                userInfo = Regex.Replace(userInfo, "<state=\".*\" />", "<state=\"ONLINE\" />");
                usersInfo = Regex.Replace(usersInfo, "<item>\r\n<name=\"" + UserName + @"[\s\S]{0,200}?</item>", userInfo);
                databaseContent = Regex.Replace(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>", usersInfo);
                string encryptedData = Common.AESEncryptStr(databaseContent);
                File.WriteAllText(databasePath, encryptedData, Encoding.Default);
            }
            category = Regex.Match(databaseContent, "<Category>[\\s\\S]*</Category>").ToString();
            information = Regex.Match(databaseContent, "<Information>[\\s\\S]*</Information>").ToString();
            operationRecord = Regex.Match(databaseContent, "<OperationRecord>[\\s\\S]*</OperationRecord>").ToString();
            MatchCollection mc = Regex.Matches(category, "<first=\".*\">");
            foreach (Match m in mc)
            {
                string temp = m.ToString();
                temp = temp.Substring(8, temp.Length - 10);
                comboBoxFirst.Items.Add(temp);
            }
            timerWatchServerMessage.Start();
        }

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            if (UserName == "Administrator")
            {
                new EditCategoryForm().ShowDialog();
                comboBoxFirst.Items.Clear();
                comboBoxSecond.Items.Clear();
                checkBox.Checked = false;
                databaseContent = File.ReadAllText(databasePath, Encoding.Default);
                databaseContent = Common.AESDecryptStr(databaseContent);
                category = Regex.Match(databaseContent, "<Category>[\\s\\S]*</Category>").ToString();
                information = Regex.Match(databaseContent, "<Information>[\\s\\S]*</Information>").ToString();
                MatchCollection mc = Regex.Matches(category, "<first=\".*\">");
                foreach (Match m in mc)
                {
                    string temp = m.ToString();
                    temp = temp.Substring(8, temp.Length - 10);
                    comboBoxFirst.Items.Add(temp);
                }
            }
            else MessageBox.Show("No this permission for non-administrator.");
        }

        private void comboBoxFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSecond.Items.Clear();
            comboBoxSecond.Text = "";
            buttonGenerate.Enabled = false;
            checkBox.Checked = false;
            checkBox.Enabled = false;
            Match match = Regex.Match(category, "<first=\"" + comboBoxFirst.Text + "\">[\\s\\S]{0,500}?</first>");
            MatchCollection mc = Regex.Matches(match.ToString(), "<second=\".*\" />");
            foreach (Match m in mc)
            {
                string temp = m.ToString();
                temp = temp.Substring(9, temp.Length - 13);
                comboBoxSecond.Items.Add(temp);
            }
            string code = Regex.Match(comboBoxFirst.Text, "-[A-Z]{2}").ToString();
            code = code.Substring(1, 2) + "-";
            string pattern = "<item>[\\s]*<code=\"" + code + "[\\s\\S]{0,200}?</item>";
            PrimarySearch(pattern);
            tabControl.SelectedIndex = 1;
        }

        private void comboBoxSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox.Enabled = true;
            checkBox.Checked = true;
            buttonGenerate.Enabled = true;
            string code = Regex.Match(comboBoxFirst.Text, "-[A-Z]{2}").ToString();
            code = code.Substring(1, 2);
            code += Regex.Match(comboBoxSecond.Text, "-[0-9]{2}|-[A-Z]{2}").ToString() + "-";
            string pattern = "<item>[\\s]*<code=\"" + code + "[\\s\\S]{0,200}?</item>";
            PrimarySearch(pattern);
            tabControl.SelectedIndex = 1;
        }

        private void myTextBoxKeywords_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxFirst.Text != "" && comboBoxSecond.Text != "" && checkBox.Checked)
            {
                string code = Regex.Match(comboBoxFirst.Text, "-[A-Z]{2}").ToString();
                code = code.Substring(1, 2);
                code += Regex.Match(comboBoxSecond.Text, "-[0-9]{2}|-[A-Z]{2}").ToString() + "-";
                code += myTextBoxKeywords.Text;
                string pattern = "<item>[\\s]*<code=\"" + code + "[\\s\\S]{0,200}?</item>";
                PrimarySearch(pattern);
            }
            else if (myTextBoxKeywords.Text != "")
            {
                AdvanceSearch(myTextBoxKeywords.Text);
            }
            else
            {
                listViewResult.Items.Clear();
                labelStatus.Text = "Search Result: No result is searched.";
                return;
            }
            tabControl.SelectedIndex = 1;
            myTextBoxKeywords.Focus();
        }
        private void myTextBoxKeywords_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkBox.Checked)
            {
                if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
           if (UserName == "Administrator" || permission.Contains(comboBoxFirst.Text))
           {
            GenerateCode();
            string code = Regex.Match(comboBoxFirst.Text, "-[A-Z]{2}").ToString();
            code = code.Substring(1, 2);
            code += Regex.Match(comboBoxSecond.Text, "-[0-9]{2}|-[A-Z]{2}").ToString() + "-";
            string pattern = "<item>[\\s]*<code=\"" + code + "[\\s\\S]{0,200}?</item>";
            PrimarySearch(pattern);
           }
           else MessageBox.Show("You have no this permission, please ask Administrator to get it.");

        }
        private void GenerateCode()
        {
            int max = 0;
            string code = Regex.Match(comboBoxFirst.Text, "-[A-Z]{2}").ToString();
            code = code.Substring(1, 2);
            code += Regex.Match(comboBoxSecond.Text, "-[0-9]{2}|-[A-Z]{2}").ToString() + "-";
            int[] codeNumbers = new int[9999];
            MatchCollection mc = Regex.Matches(information, code + "[0-9]{4}");
            for(int i = 0; i < mc.Count; i++)
            {
                string temp = Regex.Match(mc[i].ToString(), "[0-9]{4}").ToString();
                codeNumbers[i] = int.Parse(temp);
            }
            int count = 0;
            for (int i = 0; i < codeNumbers.Length; i++)
            {
                for (int j = i + 1; j < codeNumbers.Length - 1; j++)
                {
                    if (codeNumbers[j] == codeNumbers[i] && codeNumbers[j] != 0)
                    {
                        count++;
                        string temp = code + string.Format("{0:0000}", codeNumbers[j]);
                        Clipboard.SetText(temp);
                        MessageBox.Show("Exist " + count.ToString() + " times the same code" + temp + ", the same code has been copied to clipoard, please check it.",
                            "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            if (count > 0) return;
            for (int i = 0; i < codeNumbers.Length; i++)
            {
                if (max < codeNumbers[i])
                {
                    max = codeNumbers[i];
                }
            }
            code += string.Format("{0:0000}", max + 1);
            generatedCode = code;
            operateFlag = false;
            new InformationForm(this).ShowDialog();
        }
        private void AdvanceSearch(string keyword)
        {
            int resultNumber = 0;
            listViewResult.Items.Clear();
            MatchCollection mc = Regex.Matches(information, "<item>[\\s\\S]{0,200}?</item>", RegexOptions.IgnoreCase);
            for (int i = 0; i < mc.Count; i++)
            {
                string temp = mc[i].ToString();
                string code = Regex.Match(temp, @"[A-Z]{2}-\d{2}-\d{4}|[A-Z]{2}-[A-Z]{2}-\d{4}").ToString();
                string name = Regex.Match(temp, "<name=\".*\" />").ToString();
                if (name != "") name = name.Substring(7, name.Length - 11);
                string type = Regex.Match(temp, "<type=\".*\" />").ToString();
                if (type != "") type = type.Substring(7, type.Length - 11);
                string spec = Regex.Match(temp, "<spec=\".*\" />").ToString();
                if (spec != "") spec = spec.Substring(7, spec.Length - 11);
                string unit = Regex.Match(temp, "<unit=\".*\" />").ToString();
                if (unit != "") unit = unit.Substring(7, unit.Length - 11);
                string total = code + name + type + spec + unit;
                if (total.ToUpper().Contains(keyword.ToUpper()))
                {
                    resultNumber++;
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = code;
                    lvi.SubItems.Add(name);
                    lvi.SubItems.Add(type);
                    lvi.SubItems.Add(spec);
                    lvi.SubItems.Add(unit);
                    listViewResult.Items.Add(lvi);
                    if (code == "") MessageBox.Show(mc[i].ToString());
                }
            }
            listViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            labelStatus.Text = "Search Result: The number of searched results is " + resultNumber.ToString() + ".";
        }
       private void PrimarySearch(string parttern)
       {
            listViewResult.Items.Clear();
            MatchCollection mc = Regex.Matches(information, parttern, RegexOptions.IgnoreCase);
            for (int i = 0; i < mc.Count; i++)
            {
                string temp = mc[i].ToString();
                string code = Regex.Match(temp, @"[A-Z]{2}-\d{2}-\d{4}|[A-Z]{2}-[A-Z]{2}-\d{4}").ToString();
                string name = Regex.Match(temp, "<name=\".*\" />").ToString();
                if (name != "") name = name.Substring(7, name.Length - 11);
                string type = Regex.Match(temp, "<type=\".*\" />").ToString();
                if (type != "") type = type.Substring(7, type.Length - 11);
                string spec = Regex.Match(temp, "<spec=\".*\" />").ToString();
                if (spec != "") spec = spec.Substring(7, spec.Length - 11);
                string unit = Regex.Match(temp, "<unit=\".*\" />").ToString();
                if (unit != "") unit = unit.Substring(7, unit.Length - 11);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = code;
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(type);
                lvi.SubItems.Add(spec);
                lvi.SubItems.Add(unit);
                listViewResult.Items.Add(lvi);
                if (code == "") MessageBox.Show(mc[i].ToString());
            }
            listViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            labelStatus.Text = "Search Result: The number of searched results is " + mc.Count.ToString() + ".";

       }
        private void listViewResult_DoubleClick(object sender, EventArgs e)
       {
           if (listViewResult.SelectedItems.Count > 0)
           {
               string temp = listViewResult.SelectedItems[0].SubItems[0].Text;
               Clipboard.SetText(temp);
               temp = temp.Substring(0, 2);
               if (UserName == "Administrator" || permission.Contains(temp))
               {
                   operateFlag = true;
                   MI.Name = listViewResult.SelectedItems[0].SubItems[1].Text;
                   MI.Type = listViewResult.SelectedItems[0].SubItems[2].Text;
                   MI.Spec = listViewResult.SelectedItems[0].SubItems[3].Text;
                   MI.Unit = listViewResult.SelectedItems[0].SubItems[4].Text;
                   new InformationForm(this).ShowDialog();
                   MI.Name = ""; MI.Type = "";
                   MI.Spec = ""; MI.Unit = "";
               }
               else MessageBox.Show("You have no this permission, please ask Administrator to get it.");
           
           }
         
        }

        private void ToolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            if (listViewResult.SelectedItems.Count > 0)
            {
                string temp = listViewResult.SelectedItems[0].SubItems[0].Text;
                Clipboard.SetText(temp);
                temp = temp.Substring(0, 2);
                if (UserName == "Administrator" || permission.Contains(temp))
                {
                    operateFlag = true;
                    MI.Name = listViewResult.SelectedItems[0].SubItems[1].Text;
                    MI.Type = listViewResult.SelectedItems[0].SubItems[2].Text;
                    MI.Spec = listViewResult.SelectedItems[0].SubItems[3].Text;
                    MI.Unit = listViewResult.SelectedItems[0].SubItems[4].Text;
                    new InformationForm(this).ShowDialog();
                    MI.Name = ""; MI.Type = "";
                    MI.Spec = ""; MI.Unit = "";
                }
                else MessageBox.Show("You have no this permission, please ask Administrator to get it.");
            }
            else MessageBox.Show("Please select edited item.");
          

        }
        private void ToolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (listViewResult.SelectedItems.Count > 0)
            {
                string temp = listViewResult.SelectedItems[0].SubItems[0].Text;
                Clipboard.SetText(temp);
                temp = temp.Substring(0, 2);
                if (UserName == "Administrator" || permission.Contains(temp))
                {
                    if (MessageBox.Show("Are you sure to delete this information",
                        "Alert",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string code = listViewResult.SelectedItems[0].Text;
                        string pattern = "<item>[\\s]*<code=\"" + code + "[\\s\\S]{0,200}?</item>[\\s]*";
                        information = Regex.Replace(information, pattern, "");
                        databaseContent = Regex.Replace(databaseContent, "<Information>[\\s\\S]*</Information>", information);
                        int index = listViewResult.SelectedItems[0].Index;
                        listViewResult.Items.Remove(listViewResult.Items[index]);
                        string operation = DateTime.Now.ToString() + "The information of " + code + "has been deleted.\r\n";
                        textBoxRecord.AppendText(operation);
                        operationRecord = Regex.Match(databaseContent, "<OperationRecord>[\\s\\S]*</OperationRecord>").ToString();
                        operationRecord = Regex.Replace(operationRecord, "\r\n</OperationRecord>", operation + "\r\n</OperationRecord>");
                        databaseContent = Regex.Replace(databaseContent, "<OperationRecord>[\\s\\S]*</OperationRecord>",operationRecord);
                        string encryptedData = Common.AESEncryptStr(databaseContent);
                        File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                    }
                }
                else MessageBox.Show("You have no this permission, please ask Administrator to get it.");
            }
            else MessageBox.Show("Please select deleted item.");
        }

        public void RenewListView(MaterialInfo mi)
        {
            if (operateFlag)
            {
                string code = listViewResult.SelectedItems[0].Text;
                string pattern = "<item>[\\s]*<code=\"" + code + "[\\s\\S]{0,200}?</item>";
                string temp = "<item>\r\n<code=\"" + code + "\" />\r\n<name=\"" + mi.Name + "\" />\r\n<type=\""
                    + mi.Type + "\" />\r\n<spec=\"" + mi.Spec + "\" />\r\n<unit=\"" + mi.Unit + "\" />\r\n</item>";
                information = Regex.Replace(information, pattern, temp);
                databaseContent = Regex.Replace(databaseContent, "<Information>[\\s\\S]*</Information>", information);
                string operation = DateTime.Now.ToString() + "The information of " + code + "has been modified.\r\n";
                textBoxRecord.AppendText(operation);
                operationRecord = Regex.Match(databaseContent, "<OperationRecord>[\\s\\S]*</OperationRecord>").ToString();
                operationRecord = Regex.Replace(operationRecord, "\r\n</OperationRecord>", operation + "\r\n</OperationRecord>");
                databaseContent = Regex.Replace(databaseContent, "<OperationRecord>[\\s\\S]*</OperationRecord>", operationRecord);
                string encryptedData = Common.AESEncryptStr(databaseContent);
                File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = code;
                lvi.SubItems.Add(mi.Name);
                lvi.SubItems.Add(mi.Type);
                lvi.SubItems.Add(mi.Spec);
                lvi.SubItems.Add(mi.Unit);
                int index = listViewResult.SelectedItems[0].Index;
                listViewResult.Items[index] = lvi;
                listViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                tabControl.SelectedIndex = 0;
                Clipboard.SetText(generatedCode);
                string temp = "<item>\r\n<code=\"" + generatedCode + "\" />\r\n<name=\"" + mi.Name + "\" />\r\n<type=\""
                    + mi.Type + "\" />\r\n<spec=\"" + mi.Spec + "\" />\r\n<unit=\"" + mi.Unit + "\" />\r\n</item>\r\n\r\n";
                information = Regex.Replace(information, "</Information>", temp + "</Information>");
                databaseContent = Regex.Replace(databaseContent, "<Information>[\\s\\S]*</Information>", information);
                string operation = DateTime.Now.ToString() + "The information of " + generatedCode + "has been stored.\r\n";
                textBoxRecord.AppendText(operation);
                operationRecord = Regex.Replace(operationRecord, "\r\n</OperationRecord>", operation + "\r\n</OperationRecord>");
                databaseContent = Regex.Replace(databaseContent, "<OperationRecord>[\\s\\S]*</OperationRecord>", operationRecord);
                string encryptedData = Common.AESEncryptStr(databaseContent);
                File.WriteAllText(databasePath, encryptedData, Encoding.Default);
            }
        }

        private void AsposeIdentify()
        {
            Aspose.Cells.License lic = new Aspose.Cells.License();
            string licContent = Resources.licContent;
            string licPath = localPath + "\\license.lic";
            File.Create(licPath).Close();
            File.WriteAllText(licPath, licContent, Encoding.Default);
            lic.SetLicense(licPath);
            File.Delete(licPath);
        }
        private void buttonExportSearch_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel File(*.xlsx)|*.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                AsposeIdentify();
                Workbook wb = new Workbook();
                Worksheet ws = wb.Worksheets[0];
                ws.Name = "Search Result";
                for (int i = 0; i < listViewResult.Columns.Count; i++)
                {
                    ws.Cells[0, i].PutValue(listViewResult.Columns[i].Text);
                }
                for (int i = 0; i < listViewResult.Items.Count; i++)
                {
                    for (int j = 0; j < listViewResult.Columns.Count; j++)
                    {
                        ws.Cells[i + 1, j].PutValue(listViewResult.Items[i].SubItems[j].Text);
                    }
                }
                ws.AutoFitColumns();
                wb.Save(sfd.FileName);
                MessageBox.Show("File has been exported.");
            }
        }
        private void buttonExportAll_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please select path of file";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                AsposeIdentify();
                Workbook wb = new Workbook();
                wb.Worksheets.Clear();

                MatchCollection mcsheetName = Regex.Matches(category, "<first=\".*\">");
                for (int i = 0; i < mcsheetName.Count; i++)
                {
                    string sheetName = mcsheetName[i].ToString();
                    sheetName = sheetName.Substring(8, sheetName.Length - 10);
                    wb.Worksheets.Add();
                    Worksheet ws = wb.Worksheets[i];
                    ws.Name = sheetName;
                    ws.Cells[0, 0].PutValue("code");
                    ws.Cells[0, 1].PutValue("name");
                    ws.Cells[0, 2].PutValue("type");
                    ws.Cells[0, 3].PutValue("spec");
                    ws.Cells[0, 4].PutValue("unit");
                    string sheetCode = sheetName.Substring(sheetName.Length - 2, 2);
                    string pattern = "<item>[\\s]*<code=\"" + sheetCode + @"[\s\S]{0,200}?</item>";
                    MatchCollection mcSheetCode = Regex.Matches(information, pattern);
                    for (int j = 0; j < mcSheetCode.Count; j++)
                    {
                        string temp = mcSheetCode[j].ToString();
                        string code = Regex.Match(temp, @"[A-Z]{2}-\d{2}-\d{4}|[A-Z]{2}-[A-Z]{2}-\d{4}").ToString();
                        string name = Regex.Match(temp, "<name=\".*\" />").ToString();
                        if (name != "") name = name.Substring(7, name.Length - 11);
                        string type = Regex.Match(temp, "<type=\".*\" />").ToString();
                        if (type != "") type = type.Substring(7, type.Length - 11);
                        string spec = Regex.Match(temp, "<spec=\".*\" />").ToString();
                        if (spec != "") spec = spec.Substring(7, spec.Length - 11);
                        string unit = Regex.Match(temp, "<unit=\".*\" />").ToString();
                        if (unit != "") unit = unit.Substring(7, unit.Length - 11);

                        ws.Cells[j, 0].PutValue(code);
                        ws.Cells[j, 1].PutValue(name);
                        ws.Cells[j, 2].PutValue(type);
                        ws.Cells[j, 3].PutValue(spec);
                        ws.Cells[j, 4].PutValue(unit);

                    }
                    ws.AutoFitColumns();
                }
                string path = fbd.SelectedPath;
                string time = DateTime.Now.ToString("yyyyMMddHHmmss");
                string exportPath = path + "\\All Results " + time + ".xlsx";
                wb.Save(exportPath);
                MessageBox.Show("exported，name of file is All Results。", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                System.Diagnostics.Process.Start("explorer.exe", path);
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult result = MessageBox.Show("Are you sure to exit?", "Alert",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (UserName == "Administrator")
                {
                    databaseContent = Regex.Replace(databaseContent,
                        "<AdminState>ONLINE</AdminState>", "<AdminState>OFFLINE</AdminState>");
                    string encryptedData = Common.AESEncryptStr(databaseContent);
                    File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                }
                else if (UserName != "" && UserName != null)
                {
                    usersInfo = Regex.Match(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>").ToString();
                    userInfo = Regex.Match(usersInfo, "<item>\r\n<name=\"" + UserName + @"[\s\S]{0,200}?</item>").ToString();
                    userInfo = Regex.Replace(userInfo, "<state=\".*\" />", "<state=\"OFFLINE\" />");
                    usersInfo = Regex.Replace(usersInfo, "<item>\r\n<name=\"" + UserName + @"[\s\S]{0,200}?</item>", userInfo);
                    databaseContent = Regex.Replace(databaseContent, "<UserInformation>[\\s\\S]*</UserInformation>", usersInfo);
                    string encryptedData = Common.AESEncryptStr(databaseContent);
                    File.WriteAllText(databasePath, encryptedData, Encoding.Default);
                }
                string time = DateTime.Now.ToString("yyyyMMddHHmmss");
                if (Directory.Exists(serverPath + "\\Backup"))
                {
                    foreach (FileInfo file in (new DirectoryInfo(serverPath + "\\Backup")).GetFiles())
                    {
                        file.Attributes = FileAttributes.Normal;
                        file.Delete();
                    }
                    Directory.Delete(serverPath + "\\Backup");
                }
                if (Directory.Exists(localPath + "\\Backup"))
                {
                    foreach (FileInfo file in (new DirectoryInfo(localPath + "\\Backup")).GetFiles())
                    {
                        file.Attributes = FileAttributes.Normal;
                        file.Delete();
                    }
                    Directory.Delete(localPath + "\\Backup");
                }
                File.WriteAllText(localPath + "\\DataBase.db", databaseContent, Encoding.Default);
                e.Cancel = false;
            }
        }

        private void buttonChangePswd_Click(object sender, EventArgs e)
        {
            new ChangePswdForm(UserName).ShowDialog();
        }

        private void buttonManageUser_Click(object sender, EventArgs e)
        {
            if (UserName == "Administrator") new ManageUserForm().ShowDialog();
            else MessageBox.Show("No permission for non-administrator.");
        }

        private void buttonCheckRecord_Click(object sender, EventArgs e)
        {
            new CheckRecordForm(operationRecord).ShowDialog();
        }

        private void timerWatchServerMessage_Tick(object sender, EventArgs e)
        {
            databaseContent = File.ReadAllText(databasePath, Encoding.Default);
            databaseContent = Common.AESDecryptStr(databaseContent);
            string serverMessage = Regex.Match(databaseContent, "<ServerMessage>.{0,100}</ServerMessage>").ToString();
            if (serverMessage != "") serverMessage = serverMessage.Substring(15, serverMessage.Length - 31);
            if (serverMessage != "")
            {
                if (serverWarnDelayer == 12)
                {
                    serverWarnDelayer--;
                    MessageBox.Show("The Server is repairing, and will be shut down current appliction in 10s, please save your work immedately.");
                }
                else if (serverWarnDelayer == 0)
                {
                    timerWatchServerMessage.Stop();
                    MessageBox.Show(serverMessage);
                    Dispose();
                }
                serverWarnDelayer--;
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "The current will be shoted down in" + serverWarnDelayer.ToString() + "s，please save your work immedately.";
            }
            labelTime.Text = "Time：" + DateTime.Now.ToString();
        }

        Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(",") ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");
            dllName = dllName.Replace(".", "_");
            if (dllName.EndsWith("_resources")) return null;
            ResourceManager rm = new ResourceManager(GetType().Namespace + ".Properties.Resources", Assembly.GetExecutingAssembly());
            byte[] bytes = (byte[])rm.GetObject(dllName);
            return Assembly.Load(bytes);
        }


        private void linkLabelChangePersonality_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (UserName == "Administrator") MessageBox.Show("Modify Administrator's information is not allowed.");
            else new ChangePersonalityForm(UserName).ShowDialog();
        }

        private void linkLabelFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FeedbackForm().ShowDialog();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //windowZoom.SetReSize(this);
            tabControl.Height = Height - tabControl.Top - 70;
            tabControl.Width = Width - tabControl.Left - 35;
            textBoxRecord.Height = tabControl.Height - 40;
            textBoxRecord.Width = tabControl.Width - 20;
            listViewResult.Height = tabControl.Height - 40;
            listViewResult.Width = tabControl.Width - 20;
            int bottom = Height - labelAlert.Height - 40;
            labelStatus.Top = bottom;
            labelStatus.Left = 0;
            labelAuthor.Top = bottom;
            labelAuthor.Left = Width / 2 - labelAuthor.Width / 2;
            labelTime.Top = bottom;
            labelTime.Left = Width - labelTime.Width - 30;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            string updateAnnouncement = Regex.Match(databaseContent, "<UpdateAnnouncement>[\\s\\S]{10,500}</UpdateAnnouncement>").ToString();
            string announcement = Regex.Match(updateAnnouncement, "<announce>[\\s\\S]{10,500}</announce>").ToString();
            if (announcement != "") announcement = announcement.Substring(10, announcement.Length - 21);
            string versionPath = Directory.GetCurrentDirectory() + "\\New Version";
            if (!File.Exists(versionPath))
            {
                File.Create(versionPath).Close();
                MessageBox.Show(announcement, "New function");
            }
            string farewell = Regex.Match(databaseContent, "<Farewell>[\\s\\S]{0,500}</Farewell>").ToString();
            if (farewell != "") farewell = farewell.Substring(10, farewell.Length - 21);
            string farewellPath = Directory.GetCurrentDirectory() + "\\Farewell";
            if (farewell.Length < 10)
            {
                if (File.Exists(farewellPath))
                    File.Delete(farewellPath);
            }
            else if (!File.Exists(farewellPath))
            {
                File.Create(farewellPath).Close();
                MessageBox.Show(farewell, "From Developer");
            }
        }



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Workbook wb = new Workbook();
        //    wb.Open(serverPath + "\\All Results.xlsx");
        //    for (int i = 0; i < wb.Worksheets.Count; i++)
        //    {
        //        for (int j = 0; j < wb.Worksheets[i].Cells.Rows.Count; j++)
        //        {
        //            for (int k = 0; k < wb.Worksheets[i].Cells.Columns.Count; k++)
        //            {
        //                textBoxRecord.AppendText(wb.Worksheets[i].Cells[j, k].Value + "\t");
        //            }
        //            textBoxRecord.AppendText("\r\n");
        //        }
        //        textBoxRecord.AppendText("\r\n");
        //        textBoxRecord.AppendText("\r\n");
        //    }
        //}
    }
    public class MaterialInfo
    {
        public string Code = "", Name = "", Type = "", Spec = "";
        public string Unit = "", Provider = "";
    }
}
