using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace FbTools
{
    static class Program
    {
        public static string ACCESS_TOKEN = "";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Gecko.Xpcom.Initialize(Application.StartupPath + @"\firefox");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin2());
            Gecko.Xpcom.Shutdown();
        }
    }
}
