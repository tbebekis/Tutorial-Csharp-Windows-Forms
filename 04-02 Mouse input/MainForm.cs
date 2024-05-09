using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Mouse events
    Mouse clicks 
    Mouse move

 */
namespace Lessons
{
    public partial class MainForm : Form
    {  
        public MainForm()
        {
            InitializeComponent();

            /* MS Visual Studio does not expose these events for the GroupBox,  
               but they can be set manually */
            groupBox1.Click += new EventHandler(GroupBox1_Click);
            groupBox1.DoubleClick += new EventHandler(GroupBox1_DoubleClick);
            groupBox1.MouseClick += new MouseEventHandler(GroupBox1_MouseClick);
            groupBox1.MouseDoubleClick += new MouseEventHandler(GroupBox1_MouseDoubleClick);

            groupBox1.MouseDown += new MouseEventHandler(GroupBox1_MouseDown);
            groupBox1.MouseUp += new MouseEventHandler(GroupBox1_MouseUp);

            groupBox1.MouseEnter += new EventHandler(GroupBox1_MouseEnter);
            groupBox1.MouseHover += new EventHandler(GroupBox1_MouseHover);
            groupBox1.MouseLeave += new EventHandler(GroupBox1_MouseLeave);

        }  

        private void MainForm_Click(object sender, EventArgs e)
        {
            string S = string.Format("x = {0}, y = {1} ( x = {2}, y = {3} )",
                                    System.Windows.Forms.Cursor.Position.X,
                                    System.Windows.Forms.Cursor.Position.Y,
                                    System.Windows.Forms.Cursor.Current.HotSpot.X,
                                    System.Windows.Forms.Cursor.Current.HotSpot.Y);

            listBox1.Items.Add(S);
        }


         
        void GroupBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Click");
        }

        void GroupBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Add("DoubleClick");
        }

        void GroupBox1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("MouseClick");
        }

        void GroupBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("MouseDoubleClick");
        }

        void GroupBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("MouseDown");
        }

        void GroupBox1_MouseUp(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("MouseUp");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        void GroupBox1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.Items.Add("MouseEnter");
        }

        void GroupBox1_MouseHover(object sender, EventArgs e)
        {
            listBox1.Items.Add("MouseHover");
        }

        void GroupBox1_MouseLeave(object sender, EventArgs e)
        {
            listBox1.Items.Add("MouseLeave");
        }
    }
}
