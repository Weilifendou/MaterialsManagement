using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MaterialsManagement
{
    static class Program
    {
        /// <summary>zl
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //MainForm mainForm = new MainForm("Administrator");
            //Application.Run(mainForm);
            SplashForm splashForm = new SplashForm();
            LoginForm loginForm = new LoginForm();
            splashForm.Show();
            splashForm.Wait();
            splashForm.Dispose();
            loginForm.ShowDialog();
            if (loginForm.UserName != "")
            {
                MainForm mainForm = new MainForm(loginForm.UserName);
                Application.Run(mainForm);

            }
        }
    }
}
