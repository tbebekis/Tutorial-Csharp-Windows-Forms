using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Components and Controls  
    Parentship
    Screen and client coordinates 
    The Form class
    The Form Designer as a code generation tool 
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        SecondForm secondForm;

        public MainForm()
        {
            InitializeComponent();

            secondForm = new SecondForm();
            secondForm.TopLevel = false;
            secondForm.Parent = this;
            secondForm.Visible = true;
        }
    }
}
