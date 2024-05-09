using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Visual Form inheritance
 
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

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            /* create and display a MDI child form */
            CustomerForm Form = new CustomerForm();            
            Form.MdiParent = this;
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
