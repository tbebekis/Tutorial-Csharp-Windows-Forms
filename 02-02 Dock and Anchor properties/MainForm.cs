using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Dock and Anchor properties
 
    pnlGray         Parent = Form, Dock = Fill
        pnlRed      Parent = pnlGray, Dock = Left
        pnlGreen    Parent = pnlGray, Dock = Left
        pnlBlue     Parent = pnlGray, Dock = Top
        pnlYellow   Parent = pnlGray, Dock = Right
    pnlLime         Parent = Form, Dock = Bottom
 
 
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
