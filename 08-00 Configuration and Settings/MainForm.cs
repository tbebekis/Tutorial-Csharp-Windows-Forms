using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using Lessons.Properties;


/*  
    Configuration: application and user settings 

 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnGetAppValue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Settings.Default.AppValue);            
        }

        private void btnGetUserValue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Settings.Default.UserValue.ToString());
        }

        private void btnSetUserValue_Click(object sender, EventArgs e)
        {
            Settings.Default.UserValue = Convert.ToInt32(edtUserValue.Value);

            /* save the change */
            Settings.Default.Save();
        }

        private void btnUserConfigLocation_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);

            if (File.Exists(config.FilePath))
                MessageBox.Show(config.FilePath);
            else
                MessageBox.Show("user.config not found");
        }

    }
}
