using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using System.Globalization;
using Lessons.Properties;


/*  
 
# Localization: making a multi-lingual application

    * Localizing a form
    * Localizing general string resources
    * Setting application culture
    * Localization tools
 
 
 
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void ChangeCulture(string Culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Culture);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Culture);

            if (this.components != null)
                this.components.Dispose();

            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void mnuGreek_Click(object sender, EventArgs e)
        {
            ChangeCulture("el-GR");
        }

        private void mnuEnglish_Click(object sender, EventArgs e)
        {
            ChangeCulture("en-US");
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            string S = Resources.Salutation;
            MessageBox.Show(S);
        }
    }
}






