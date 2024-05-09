using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*      
    IDE and tools
    Creating a Windows Forms application
    The Program class and the Main() method
    Messages and events
    Screen class
    SystemInformation class
    Environment class
    OSFeature class  
    PowerStatus class  
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            /* link an event handler manually to an event */
            button1.Click += new EventHandler(AnotherButtonClickEventHandler);
            
        }

        bool looping = false;

        /* An event handler that has a lot of work to do before exiting 
           can make the application unresponsive to user actions. 
           Calling Application.DoEvents() allows the application to handle any 
           window messages came in between and thus handle any UI messages too */
        private void button1_Click(object sender, EventArgs e)
        {

            if (!looping)
            {
                looping = true;

                for (int i = 0; i < int.MaxValue / 4; i++)
                    if (i % 5000 == 0)
                        Application.DoEvents();

                looping = false;

                MessageBox.Show("Done!");
            }
        }
  
        /* an event handler that is manually assigned to an event */
        void AnotherButtonClickEventHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Hello from AnotherButtonClickEventHandler!");
 
        }


        /* using the Environment class */
        private void button2_Click(object sender, EventArgs e)
        {
            string S = "";
            S += string.Format("CommandLine: {0}", Environment.CommandLine) + Environment.NewLine;
            S += string.Format("CurrentDirectory: {0}", Environment.CurrentDirectory) + Environment.NewLine;
            S += string.Format("MachineName: {0}", Environment.MachineName) + Environment.NewLine;
            S += string.Format("OSVersion: {0}", Environment.OSVersion) + Environment.NewLine;
            S += string.Format("SystemDirectory: {0}", Environment.SystemDirectory) + Environment.NewLine;
            S += string.Format("UserDomainName: {0}", Environment.UserDomainName) + Environment.NewLine;
            S += string.Format("UserName: {0}", Environment.UserName) + Environment.NewLine;
            S += string.Format(".Net Version: {0}", Environment.Version) + Environment.NewLine;

            MessageBox.Show(S);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline)
                if (SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.Low)
                    MessageBox.Show("Battery is low!");
        }


    }
}
