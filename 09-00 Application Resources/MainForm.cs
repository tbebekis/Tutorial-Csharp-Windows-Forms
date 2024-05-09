using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Lessons.Properties;





/*  
    Application resources
 
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            PrepareDll();
            pictureBox1.Image = Resources.cslogo;
        }

        private void btnResourceString_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.string_resource);
        }

        /* The TestLib resource item is an unmanaged dll. This method saves the resource
           item to the disk */
        static internal void PrepareDll()
        {
            string FileName = Application.StartupPath + Path.DirectorySeparatorChar + "TestLib.dll";
            if (!File.Exists(FileName))
                File.WriteAllBytes(FileName, Resources.TestLib);
        }

        /* import a dll function */
        [DllImport("TestLib.dll")]
        public static extern int Add(int X, int Y);


        /* call a dll function */
        private void btnCallDllFunc_Click(object sender, EventArgs e)
        {
            int Res = Add(1, 2);
            MessageBox.Show(Res.ToString());
        }


    }
}
