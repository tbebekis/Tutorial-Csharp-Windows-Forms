using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Control common appearance properties
    Ambient properties 
    ToolTip component and extender providers
    TabIndex and TabStop properties 
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
            button1.BackColor = Color.FromArgb(70, 90, 120);
            button1.Font = new Font(button1.Font, FontStyle.Bold | FontStyle.Italic);
        }
    }
}
