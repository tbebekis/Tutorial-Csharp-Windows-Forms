using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    The Point, Rectangle and Size structs
    Control position and size  
    Size constraints 
    Client and non-client area
    The Z-order
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.MaximumSize = new Size(60, 32);
            button2.Size = new Size(100, 100);
        }

        private void AnyClick(object sender, EventArgs e)
        {
            (sender as Control).BringToFront();
        }

 
    }
}
