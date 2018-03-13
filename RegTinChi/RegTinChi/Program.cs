using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegTinChi
{
    static class Program
    {
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
            Application.Run(new Form2());
            Gecko.Xpcom.Shutdown();
           
        }
    }
}
