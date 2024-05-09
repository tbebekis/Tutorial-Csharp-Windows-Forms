using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Keyboard input
 
    KeyDownEvent and KeyEventArgs class
 
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = string.Format("KeyCode: {0}", e.KeyCode);
            label2.Text = string.Format("KeyData: {0}", e.KeyData);
            label3.Text = string.Format("Modifiers: {0}", e.Modifiers);
            label4.Text = string.Format("KeyValue: {0}", e.KeyValue);
        }

          
    }
}
