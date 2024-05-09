using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Single Document Interface (SDI) applications 
    The ShowInTaskbar property
    The Owner property
  
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static int Counter = 0;

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            Form Form = new SecondForm();
            Form.Owner = this;
            Form.Text = "SecondForm " + Counter.ToString();
            Counter++;
            Form.Show();
        }
    }
}
