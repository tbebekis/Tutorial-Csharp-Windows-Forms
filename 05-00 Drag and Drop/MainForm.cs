using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Drag and drop
 
    
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
   
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSimpleDragDrop_Click(object sender, EventArgs e)
        {
            using (SimpleDragDrop Form = new SimpleDragDrop())
            {
                Form.ShowDialog();
            }
        }
 
        private void btnCustomDragDrop_Click(object sender, EventArgs e)
        {
            using (CustomDragDrop Form = new CustomDragDrop())
            {
                Form.ShowDialog();
            }
        }

        private void btnFileDragDrop_Click(object sender, EventArgs e)
        {
            using (FileDragDrop Form = new FileDragDrop())
            {
                Form.ShowDialog();
            }
            
        }
    }
}
