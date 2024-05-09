using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




/*  
    Demonstrates a simple drag and drop operation
    copying text from one control to another   
  
    DataFormats class
 */
namespace Lessons
{
    public partial class SimpleDragDrop : Form
    {
        public SimpleDragDrop()
        {
            InitializeComponent();


            /* The AllowDrop property must be set to true for a control to act as a drag and drop target  */
            lboTarget.AllowDrop = true;
        }


        /* A source control initiates the drag and drop operation by calling the DoDragDrop() method */
        private void txtSource_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                txtSource.DoDragDrop(txtSource.Text, DragDropEffects.Copy);
        }

        /* The DragEnter event occurs on a target control when the mouse pointer enters the control */
        private void lboTarget_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        /* The DragDrop event occurs on a target control when the user releases the mouse button */
        private void lboTarget_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string S = (string)e.Data.GetData(DataFormats.Text);
                lboTarget.Items.Add(S);
            }
        }
    }
}
