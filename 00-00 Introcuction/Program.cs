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
        static void Main(string[] Args)
        {
            string S = "";
            foreach (string arg in Args)
                S += arg + Environment.NewLine;

            MessageBox.Show(S);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
 
        }
    }
}
