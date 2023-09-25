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
using System.Runtime.InteropServices;


namespace MaterialsManagement
{
    public partial class EditCategoryForm : Form
    {
        private string serverPath, databasePath;
        private string databaseContent;
        public EditCategoryForm()
        {
            InitializeComponent();
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {
            serverPath = @"\\192.168.0.2\其他文档\MaterialsManagement";
            databasePath = serverPath + "\\Database";
            databaseContent = File.ReadAllText(databasePath, Encoding.Default);
            databaseContent = Common.AESDecryptStr(databaseContent);
            string category = Regex.Match(databaseContent, "<Category>[\\s\\S]*</Category>").ToString();
            MatchCollection mc = Regex.Matches(category, "<first=\".*\">");
            for (int i = 0; i < mc.Count; i++)
            {
                string temp = mc[i].ToString();
                temp = temp.Substring(8, temp.Length - 10);
                treeViewCategory.Nodes.Add(temp);
                TreeNode node = treeViewCategory.Nodes[i];
                Match match = Regex.Match(category, "<first=\"" + node.Text + "\">[\\s\\S]{0,500}?</first>");
                MatchCollection mc1 = Regex.Matches(match.ToString(), "<second=\".*\" />");
                foreach (Match m in mc1)
                {
                    string temp1 = m.ToString();
                    temp1 = temp1.Substring(9, temp1.Length - 13);
                    node.Nodes.Add(temp1);
                }
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            bool errorFlag = false;
            StringBuilder category = new StringBuilder("<Category>\r\n\r\n");
            foreach(TreeNode tn in treeViewCategory.Nodes)
            {
                if (!Regex.IsMatch(tn.Text, ".{1,20}-[A-Z]{2}"))
                {
                    MessageBox.Show("Please edit category obey the code rule.");
                    return;
                }
                category.Append("<first=\"" + tn.Text + "\">\r\n");
                foreach (TreeNode tn1 in tn.Nodes)
                {
                    if (!Regex.IsMatch(tn.Text, ".{1,20}(-[A-Z]{2})|(-[0-9]{2})"))
                    {
                        errorFlag = true;
                        MessageBox.Show("Please edit category obey the code rule.");
                        return;
                    }
                    category.Append("<second=\"" + tn1.Text + "\" />\r\n");
                }
                if (errorFlag) return;
                category.Append("</first>\r\n");
            }
            category.Append("\r\n</Category>");
            databaseContent = Regex.Replace(databaseContent, "<Category>[\\s\\S]*</Category>", category.ToString());
            string encryptedData = Common.AESEncryptStr(databaseContent);
            File.WriteAllText(databasePath, encryptedData, Encoding.Default);
            Dispose();
            MessageBox.Show("Finish Editing.");

        }

        private void addFirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewCategory.Nodes.Add("XXXX-XX");
        }


        private void addSecondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewCategory.SelectedNode != null)
            {
                treeViewCategory.SelectedNode.Nodes.Add("XXXX-XX");
                treeViewCategory.SelectedNode.Expand();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewCategory.SelectedNode != null)
                treeViewCategory.SelectedNode.BeginEdit();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewCategory.SelectedNode.Remove();
        }
    }
}
