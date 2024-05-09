using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



/*  
    Demonstrates a custom drag and drop operation
    It passes an instance of a custom class (Person)
    from one control to another, using a drag and drop operation
 
 
    IDataObject
    DataObject
 
 */
namespace Lessons
{
    public partial class CustomDragDrop : Form
    {
        public CustomDragDrop()
        {
            InitializeComponent();

            /* The AllowDrop property must be set to true for a control to act as a drag and drop target.  */
            lboTarget.AllowDrop = true;

            lboSource.Items.Add(new Person("John Doe", 32));
            lboSource.Items.Add(new Person("Jane Doe", 30));
        }

        /* A source control initiates the drag and drop operation by calling the DoDragDrop() method.
          
           The DoDragDrop() returns the final effect of the operation, so this event handler
           removes the dragged item from the list box on success. 
         
           This event handler uses a DataObject instance to feed the operation. It passes a Person
           instance to the DataObject instance as a custom format, i.e Lessons.Person.
          
           The name of that custom format could be any string as long as it is unique among all
           other formats.
         */
        private void lboSource_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (lboSource.SelectedIndex != -1)
                {
                    DataObject DataObj = new DataObject();

                    /* The lboSource.SelectedItem is a Person object */
                    DataObj.SetData("Lessons.Person", lboSource.SelectedItem);

                    /* if DoDragDrop() succeeds then remove the item from the list */
                    if (lboSource.DoDragDrop(DataObj, DragDropEffects.Move) == DragDropEffects.Move)
                        lboSource.Items.Remove(lboSource.SelectedItem);
                }
        }

        /* The DragEnter event occurs on a target control when the mouse pointer enters the control */
        private void lboTarget_DragEnter(object sender, DragEventArgs e)
        {
            /* check to see if the custom format Lessons.Person exists in the DataObject  */
            if (e.Data.GetDataPresent("Lessons.Person"))
                if (e.AllowedEffect == DragDropEffects.Move)
                    e.Effect = DragDropEffects.Move;
        }

        /* The DragDrop event occurs on a target control when the user releases the mouse button.
           If the e.Data DataObject carries a Person object then add it to the source ListBox */
        private void lboTarget_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Lessons.Person"))
            {
                Person Person = (Person)e.Data.GetData("Lessons.Person");
                lboTarget.Items.Add(Person);
            }
        }
 
    }


    /* This class is used in the drag and drop operation */
    [Serializable]
    public class Person
    {
        public Person(): this("John Doe", 32)
        {
        }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return Name + ", " + Age.ToString();
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
