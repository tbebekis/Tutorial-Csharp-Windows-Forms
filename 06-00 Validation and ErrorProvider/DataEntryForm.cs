using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;









/*  
    This form uses an ErrorProvider.
    It validates controls, all at once, when the btnSave is clicked
    by setting the DataRow.RowError property and by calling DataRow.SetColumnError().

 */
namespace Lessons
{
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable("Customer");

        private void DataEntryForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Code", typeof(System.String));
            table.Columns.Add("Name", typeof(System.String));

            table.Rows.Add(table.NewRow());


            edtCode.DataBindings.Add("Text", table, "Code");
            edtName.DataBindings.Add("Text", table, "Name");

            errorProvider1.DataSource = table;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DataRow Row = table.Rows[0];

            if ((Row["Code"] == DBNull.Value) || ("" == (string)(Row["Code"])))
            {
                Row.RowError = "Invalid Code";
                Row.SetColumnError("Code", "Invalid Code");
            }

            if ((Row["Name"] == DBNull.Value) || ("" == (string)(Row["Name"])))
            {
                Row.RowError = "Invalid Name";
                Row.SetColumnError("Name", "Invalid Name");
            }

            if (!table.HasErrors)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Please, correct any error");

        }

    }
}
