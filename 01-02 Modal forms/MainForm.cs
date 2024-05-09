using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Modal forms
    The Form.Close() case

 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        } 

        private void btnDialogForm_Click(object sender, EventArgs e)
        {
            using (DialogForm Form = new DialogForm())
            {
                DialogResult Res = Form.ShowDialog();
                MessageBox.Show(Res.ToString());
            }
        }
    }
}
