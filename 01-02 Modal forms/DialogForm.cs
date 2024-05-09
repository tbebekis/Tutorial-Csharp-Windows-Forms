using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lessons
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();

            /* the PropertyGrid hides those two events. They have been replaced  
               by the FormClosing and FormClosed events */
            this.Closing += new CancelEventHandler(DialogForm_Closing);
            this.Closed += new EventHandler(DialogForm_Closed);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DialogForm_Closing(object sender, CancelEventArgs e)
        {
            MessageBox.Show("DialogForm_Closing");
        }

        private void DialogForm_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("DialogForm_Closed");
        }

        private void DialogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("DialogForm_FormClosing");
        }

        private void DialogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("DialogForm_FormClosed");
        }
    }
}
