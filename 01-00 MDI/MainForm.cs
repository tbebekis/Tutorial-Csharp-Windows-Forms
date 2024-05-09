using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Application class, application types and Forms    
    The static Application class
    The Main Form and the ApplicationContext class (see Program.cs)
    Multiple Document Interface (MDI) applications
 
 
    to create this MDI container
    - set the IsMdiContainer to true
    - drop a MenuStrip and create menu items for New, Exit and Windows
    - assign the MenuStrip.MdiWindowListItem to the Windows menu item
    - create MDI layout menu items to the Windows menu and link them to a common event handler
    - drop a StatusStrip (status bar) and create a label to it (ToolStripStatusLabel)
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            /* assign MdiLayout values to menu item tags */
            this.mnuCascade.Tag = MdiLayout.Cascade;
            this.mnuTileHorizontal.Tag = MdiLayout.TileHorizontal;
            this.mnuTileVertical.Tag = MdiLayout.TileVertical;
            this.mnuArrangeIcons.Tag = MdiLayout.ArrangeIcons;
        }

        static int Counter = 0;

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            /* create and display a MDI child form */
            ChildForm Form = new ChildForm();
            Form.MdiParent = this;
            Form.Text = "Child " + Counter.ToString();
            Counter++;
            Form.Show();
        }

        /* the MdiChildActivate event is triggered when a MDI child form is activated or closed.   
           The ActiveMdiChild property provides access to the currently activated MDI child, if any */
        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                lblActiveChild.Text = "";
            else
                lblActiveChild.Text = ActiveMdiChild.Text;
        }

        /* a common event handler for all the menu items that handle the layout of the MDI child forms  */
        private void AnyMdiLayoutMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem MI = (ToolStripMenuItem)sender;
            MdiLayout value = (MdiLayout)MI.Tag;
            this.LayoutMdi(value);
        } 
    }
}
