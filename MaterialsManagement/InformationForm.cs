using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace MaterialsManagement
{
    public partial class InformationForm : Form
    {
        public MainForm mainForm;
        public InformationForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void Information_Load(object sender, EventArgs e)
        {
            myTextBoxName.Text = mainForm.MI.Name;
            myTextBoxType.Text = mainForm.MI.Type;
            myTextBoxSpec.Text = mainForm.MI.Spec;
            myTextBoxUnit.Text = mainForm.MI.Unit;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            MaterialInfo mi = new MaterialInfo();
            mi.Name = myTextBoxName.Text;
            mi.Type = myTextBoxType.Text;
            mi.Spec = myTextBoxSpec.Text;
            mi.Unit = myTextBoxUnit.Text;
            mainForm.RenewListView(mi);
            Dispose();
        }

    }
}
