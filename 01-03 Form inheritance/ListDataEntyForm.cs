using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 

namespace Lessons
{

    /*  
        A Form class that serves as a base form for data entry forms.
        The form has two parts: the browser (list) and the data entry (item) part.
        The browser part is read only. It just displays a read-only grid.
        The data entry part is where data controls bound to individual fields are placed.
     
        The form uses just a single DataTable which serves both, the browser
        and the data entry part. That way, a "real" commit is done only when the
        DataTable is saved to a persisted medium as a whole. Hence the ListXXXX
        prefix to the form class name.
     
        The class provides 3 groups of methods. The first group has to do
        with "setup", that is form, control and data initialization. That initialization is
        triggered from inside the OnShown() method by calling the FormInitialize(). 
        The second group of methods has to do with the "list", that is the listTable DataTable
        as a whole. The third group of methods has to do with the "item", that is the current row.
     
        A derived form class provides the initial data by overriding the TablesSetup()
        and the ListRefresh() methods. The TablesSetup() is for creating and assigning
        the listTable where the ListRefresh() is for loading data to that listTable.
        The ListCommit() must save listTable to a persisted medium.
        The GridSetup() is for creating columns and customizing the DataGridView of the browser part.
        The DataControlsSetup() is for binding controls, of the data entry part, to data.
     
        The form can be used as a normal form, as an MDI child or as a modal form.
        The public property CurrentRow retuns the current DataRow of the listTable 
        and can be used when the form is modal and it is displayed to the user as a kind of a row selector.
     
     */
    public partial class ListDataEntyForm : Form
    {
        public ListDataEntyForm()
        {
            InitializeComponent();
            FormTitleSetup();
        }

        private List<TabPage> tabPages = new List<TabPage>();
        protected StdCmd closeCmd = StdCmd.None;

        protected bool initialized = false; 
        protected string formTitle = "<unknown>";
        protected DataMode dataMode = DataMode.None;
        protected bool canInsert = true;
        protected bool canEdit = true;
        protected bool canDelete = true;
        protected bool canCommit = true;
        protected DataTable listTable = null;
        protected CurrencyManager currencyManager = null;
        protected bool isListModified = false;     

        /* private methods */
        private void gridList_DoubleClick(object sender, EventArgs e)
        {
            if (btnEdit.Enabled)
                btnEdit.PerformClick();
        }
        private void anyCommand_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            if (item.Tag is StdCmd)
                ProcessStdCmd((StdCmd)item.Tag);         
        }
 
        /* overrides */
        protected override void OnLoad(EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.KeyPreview = true;

                foreach (TabPage page in Pager.TabPages)
                    tabPages.Add(page);

                ActivePageIndex = 0;

                btnList.Tag = StdCmd.List;
                btnEdit.Tag = StdCmd.Edit;
                btnInsert.Tag = StdCmd.Insert;
                btnCommit.Tag = StdCmd.Commit;
                btnDelete.Tag = StdCmd.Delete;
                btnCancel.Tag = StdCmd.Cancel;
                btnOK.Tag = StdCmd.OK;
                btnMenu.Tag = StdCmd.Menu;

                btnList.Click += new EventHandler(anyCommand_Click);
                btnEdit.Click += new EventHandler(anyCommand_Click);
                btnInsert.Click += new EventHandler(anyCommand_Click);
                btnCommit.Click += new EventHandler(anyCommand_Click);
                btnDelete.Click += new EventHandler(anyCommand_Click);
                btnCancel.Click += new EventHandler(anyCommand_Click);
                btnOK.Click += new EventHandler(anyCommand_Click);
            }

            base.OnLoad(e);
        }
        protected override void OnShown(EventArgs e)
        {
            if (!this.DesignMode)
                if (!initialized)
                {
                    FormInitialize();
                    initialized = true;
                }
                
            base.OnShown(e);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (!this.DesignMode)
            {
                if ((closeCmd == StdCmd.OK) || ((closeCmd == StdCmd.None) && !this.Modal))
                {
                    ListCommit();
                }
            }

            base.OnClosing(e);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (btnCancel.Enabled)
                {
                    btnCancel.PerformClick();
                    return true;
                }

                if (ActivePage == tabList)
                {
                    Close();
                    return true;
                }                  
            }

            return false;
 
        }
                
        /* initialization and setup */
        protected virtual void FormInitialize()
        {
            TablesSetup();
            ListRefresh();
            GridSetup();
            DataControlsSetup();

            currencyManager = (CurrencyManager)this.BindingContext[listTable];

            DataMode = DataMode.List;
            EnableCommands();
        }
        protected virtual void TablesSetup()
        {
        }
        protected virtual void GridSetup()
        {
        }
        protected virtual void FormTitleSetup()
        {
            if (dataMode == DataMode.None)
                Text = string.Format("{0} - ()", formTitle);
            else
                Text = string.Format("{0} - ({1})", formTitle, dataMode);
        }
        protected virtual void DataControlsSetup()
        {
            gridList.DataSource = listTable;
        }        

        /* list */
        protected virtual void ListRefresh()
        {
        }
        protected virtual void ListCommit()
        {
            ListCheckCommit();
        }
        protected virtual void ListCheckCommit()
        {
        }
        
        /* item */
        protected virtual void ItemInsert()
        {
            if (canInsert && (currencyManager != null))
            {
                currencyManager.AddNew();

                ActivePage = tabItem;
                DataMode = DataMode.Insert;
                EnableCommands();
            }

        }
        protected virtual void ItemEdit()
        {
            if (canEdit && (currencyManager != null))
            {
                ActivePage = tabItem;
                DataMode = DataMode.Edit;
                EnableCommands();
            }
        }
        protected virtual void ItemDelete()
        {
            if (canDelete && (currencyManager != null))
            {
                if (MessageBox.Show("Delete item?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                currencyManager.RemoveAt(currencyManager.Position);
                if ((currencyManager.Count == 0) && (ActivePage != tabList))
                {
                    ActivePage = tabList;
                    DataMode = DataMode.List;
                }

                isListModified = true;

                EnableCommands();
            }
        }
        protected virtual void ItemCancel()
        {
            if (currencyManager != null)
            {
                /*
                if (IsItemModified)
                {
                    if (MessageBox.Show("Cancel changes?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                 * */

                currencyManager.CancelCurrentEdit();

                ActivePage = tabList;
                DataMode = DataMode.List;
                EnableCommands();
            }
        }
        protected virtual void ItemCommit()
        {            
            if (canCommit && (currencyManager != null))
            {
                ItemCheckCommit();

                currencyManager.EndCurrentEdit();

                isListModified = true;

                ActivePage = tabList;
                DataMode = DataMode.List;
                EnableCommands();                    
            }
        }
        protected virtual void ItemCheckCommit()
        {
        } 

        /* miscs */
        protected virtual void DataModeChanged()
        {
        }
        protected virtual void ProcessStdCmd(StdCmd Cmd)
        {
            switch (Cmd)
            {
                case StdCmd.List:
                    ItemCancel();
                    break;
                case StdCmd.Insert:
                    ItemInsert();
                    break;
                case StdCmd.Edit:
                    ItemEdit();
                    break;
                case StdCmd.Commit:
                    ItemCommit();
                    break;
                case StdCmd.Delete:
                    ItemDelete();
                    break;
                case StdCmd.Cancel:
                    if (ActivePage == tabList)
                        ProcessClose(StdCmd.Cancel);
                    else
                        ItemCancel();
                    break;
                case StdCmd.OK:
                    if (ActivePage == tabList)
                        ProcessClose(StdCmd.OK);
                    break;
            }
        }
        protected virtual void ProcessClose(StdCmd Cmd)
        {
            switch (Cmd)
            {
                case StdCmd.OK:
                    closeCmd = Cmd;
                    if (this.Modal)
                        this.DialogResult = DialogResult.OK;
                    else
                        this.Close();
                    break;
                case StdCmd.Cancel:
                    closeCmd = Cmd;
                    if (this.Modal)
                        this.DialogResult = DialogResult.Cancel;
                    else
                        this.Close();
                    break;
            }
        }

        /* public methods */
        public virtual void EnableCommands()
        {
            btnOK.Enabled = (ActivePage == tabList) && IsBound;
            btnList.Enabled = (ActivePage != tabList) && IsBound;
            btnInsert.Enabled = canInsert && (ActivePage == tabList) && IsBound;
            btnEdit.Enabled = canEdit && (ActivePage == tabList) && HasRows; 
            btnCommit.Enabled = canEdit && (ActivePage != tabList); // && HasRows;
            btnDelete.Enabled = canDelete && HasRows; // btnEdit.Enabled;
            btnCancel.Enabled = ((ActivePage == tabList) && (this.Modal)) || ((ActivePage != tabList) && IsBound);
            if (!Modal)
                btnOK.Text = "Exit";
            
            btnList.Visible = btnList.Enabled;
            btnEdit.Visible = !btnList.Visible;

            FormTitleSetup();
        }
        
        /* protected properties */
        protected int ActivePageIndex
        {
            get
            {
                if (Pager.TabPages.Count == 0)
                    return -1;
                return tabPages.IndexOf(Pager.TabPages[0]);
            }
            set
            {
                Pager.SuspendLayout();
                Pager.TabPages.Clear();
                Pager.TabPages.Add(tabPages[value]);
                Pager.ResumeLayout(false);
            }
        }
        protected TabPage ActivePage
        {
            get
            {
                if (Pager.TabPages.Count == 0)
                    return null;
                return Pager.TabPages[0];
            }
            set
            {   
                Pager.SuspendLayout();
                Pager.TabPages.Clear();
                if (tabPages.IndexOf(value) != -1)
                    Pager.TabPages.Add(value);
                Pager.ResumeLayout(false);
            }
        }
        protected DataMode DataMode
        {
            get { return dataMode; }
            set
            {
                if (value != dataMode)
                {
                    dataMode = value;
                    DataModeChanged();
                }
            }
        }
        protected CurrencyManager CurrencyManager
        {
            get { return currencyManager; }
        }
        protected virtual bool IsBound
        {
            get { return currencyManager != null; }
        }
        protected virtual bool HasRows
        {
            get { return (currencyManager != null) && (currencyManager.Count > 0); }
        }
        protected virtual bool IsListModified
        {
            get { return isListModified; }
        }
        protected virtual bool IsItemModified
        {
            get
            { 
                if (HasRows)
                {
                    DataRow Row = ((DataRowView)currencyManager.Current).Row;
                    return (Row.RowState == DataRowState.Added) || 
                           (Row.RowState == DataRowState.Modified) ||
                           (Row.RowState == DataRowState.Detached);
                }

                return false;
 
            }
        }
        protected virtual DataTable ListTable
        {
            get { return listTable; }
        }

        /* public properties */
        public virtual DataRow CurrentRow
        {
            get
            {
                if (HasRows)
                    return ((DataRowView)currencyManager.Current).Row;
                return null;
            }
        }
    }
}


namespace Lessons
{
    [Flags]
    public enum DataMode
    {
        None = 0,
        List = 1,
        Insert = 2,
        Edit = 4,
        View = 8,
        Commit = 16,
        Delete = 32,
        Cancel = 64,
    }

    [Flags]
    public enum StdCmd
    {
        None = 0,
        List = 1,
        Insert = 2,
        Edit = 4,
        Commit = 8,
        Delete = 16,
        Cancel = 32,
        OK = 64,
        Menu = 128,
    }

 

}