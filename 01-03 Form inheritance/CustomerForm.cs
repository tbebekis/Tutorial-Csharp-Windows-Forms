using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lessons
{

    /*  An ancestor of the ListDataEntyForm class which saves the listTable DataTable 
        to an .xml file. The base form provides all the functionality.
     
        Consider the amount of code needed to craft this form. 
        It is shrunk down to a minimum. */
    public partial class CustomerForm : Lessons.ListDataEntyForm
    {
        public CustomerForm()
        {
            InitializeComponent();
            formTitle = "Customers";            
        }

        string fileName = Path.GetFullPath(@"..\..\Customers.XML");                

        protected override void TablesSetup()
        {
            base.TablesSetup();

            listTable = new DataTable();
            listTable.TableName = "Customers";

            if (File.Exists(fileName))
            {
                listTable.ReadXml(fileName);
            }
            else
            {
                listTable.Columns.Add("Code", typeof(System.String));
                listTable.Columns.Add("Name", typeof(System.String));
            }       
        }
        protected override void DataControlsSetup()
        {
            base.DataControlsSetup();
            textBox1.DataBindings.Add("Text", listTable, "Code");
            textBox2.DataBindings.Add("Text", listTable, "Name");
        } 
        protected override void ListCommit()
        {
            base.ListCommit();
            listTable.WriteXml(fileName, XmlWriteMode.WriteSchema);
        }
    }
}
