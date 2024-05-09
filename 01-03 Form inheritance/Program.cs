using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lessons
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (ApplicationContext AppContext = new ApplicationContext())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                AppContext.MainForm = new MainForm();
                Application.Run(AppContext);
            }
        }
    }
}
