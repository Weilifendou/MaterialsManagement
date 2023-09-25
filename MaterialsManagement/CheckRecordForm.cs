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
    public partial class CheckRecordForm : Form
    {
        private string recordContent;
        public CheckRecordForm(string recordContent)
        {
            InitializeComponent();
            this.recordContent = recordContent;
        }

        private void CheckRecordForm_Load(object sender, EventArgs e)
        {
            recordContent = recordContent.Substring(18, recordContent.Length - 38);
            textBoxRecord.Text = recordContent;
        }


        
    }
}
