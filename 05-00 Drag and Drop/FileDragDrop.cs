using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



/*  
    Drag and dropping files from File Explorer
    
    DataFormats.FileDrop 
 
 */
namespace Lessons
{
    public partial class FileDragDrop : Form
    {
        public FileDragDrop()
        {
            InitializeComponent();

            lboTarget.AllowDrop = true;
        }

        private void lboTarget_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
        }

        private void lboTarget_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] Files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string File in Files)
                    lboTarget.Items.Add(File);
            }
        }
    }
}
