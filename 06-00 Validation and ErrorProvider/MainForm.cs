using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Validation and the ErrorProvider component
 
 
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

         

        private void AnyControl_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                listBox1.Items.Add(textBox.Name);
                if (textBox == textBox1)
                {
                    int Res = 0;
                    if (!int.TryParse(textBox.Text, out Res))
                    {
                        errorProvider1.SetError(textBox, "Invalid integer value");
                        e.Cancel = true;
                    }
                }
                else if (textBox == textBox2)
                {
                    /* it has no meaning to call SetError() without setting e.Cancel to true */
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        errorProvider1.SetError(textBox, "Invalid float value");
                    }
                }
                else if (textBox == textBox3)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        errorProvider1.SetError(textBox, "Invalid string value");
                        e.Cancel = true;
                    }
                }
            }
            
        }

        private void AnyControl_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, "");
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDataEntryForm_Click(object sender, EventArgs e)
        {
            using (DataEntryForm Form = new DataEntryForm())
                Form.ShowDialog();
        }


 
    }
}
