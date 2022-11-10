using System;
using System.IO;
using System.Windows.Forms;
using DAL;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TestForm());
            Model.User defaultUser = new Model.User(-1, "default", "default", 123, 1, 1, "default");
            Application.Run(new MainViewForm(defaultUser));


        }
    }
}
