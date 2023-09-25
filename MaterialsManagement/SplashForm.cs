using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Drawing.Drawing2D;
using System.IO;

namespace MaterialsManagement
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();

        }
        public void Wait()
        {
            string path = Directory.GetCurrentDirectory() + "\\New Version";
            if (!File.Exists(path))
            {
                int time = 3;
                while (time >= 0)
                {
                    labelTime.Text = time.ToString() + "s";
                    this.Refresh();
                    Thread.Sleep(1000);
                    time--;
                }
            }
           
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(1, 1, Width - 2, Height - 2);
            Region re = new Region(path);
            Region = re;
            base.OnPaint(e);
        }

        private void SplashForm_Paint(object sender, PaintEventArgs e)
        {

        }
   
    }
}
