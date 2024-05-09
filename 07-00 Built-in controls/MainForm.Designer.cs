namespace Lessons
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "a",
            "a1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "b",
            "b1"}, -1);
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode5});
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Pager = new System.Windows.Forms.TabControl();
            this.tabMostCommon = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabOther = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.edtMask = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabRichTextBox = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Editor = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFontColor = new System.Windows.Forms.ComboBox();
            this.edtFontSize = new System.Windows.Forms.NumericUpDown();
            this.chUnderline = new System.Windows.Forms.CheckBox();
            this.chItalic = new System.Windows.Forms.CheckBox();
            this.chBold = new System.Windows.Forms.CheckBox();
            this.tabListAndTreeView = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LV = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.TV = new System.Windows.Forms.TreeView();
            this.tabDialogs = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.edtFileName = new System.Windows.Forms.TextBox();
            this.btnColorDlg = new System.Windows.Forms.Button();
            this.btnFontDlg = new System.Windows.Forms.Button();
            this.btnFolderBrowseDlg = new System.Windows.Forms.Button();
            this.btnSaveFileDlg = new System.Windows.Forms.Button();
            this.btnOpenFileDlg = new System.Windows.Forms.Button();
            this.tabDataGridView = new System.Windows.Forms.TabPage();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.tabWebBrowser = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.edtUrl = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.Pager.SuspendLayout();
            this.tabMostCommon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabRichTextBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtFontSize)).BeginInit();
            this.tabListAndTreeView.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabDialogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.tabDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.tabWebBrowser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mnuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblDateTime});
            this.StatusBar.Location = new System.Drawing.Point(0, 500);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(607, 22);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 17);
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = false;
            this.lblDateTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(109, 17);
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(607, 25);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 2500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(607, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(92, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Pager
            // 
            this.Pager.Controls.Add(this.tabMostCommon);
            this.Pager.Controls.Add(this.tabOther);
            this.Pager.Controls.Add(this.tabRichTextBox);
            this.Pager.Controls.Add(this.tabListAndTreeView);
            this.Pager.Controls.Add(this.tabDialogs);
            this.Pager.Controls.Add(this.tabDataGridView);
            this.Pager.Controls.Add(this.tabWebBrowser);
            this.Pager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pager.Location = new System.Drawing.Point(0, 49);
            this.Pager.Name = "Pager";
            this.Pager.SelectedIndex = 0;
            this.Pager.Size = new System.Drawing.Size(607, 451);
            this.Pager.TabIndex = 3;
            this.Pager.Selected += new System.Windows.Forms.TabControlEventHandler(this.Pager_Selected);
            // 
            // tabMostCommon
            // 
            this.tabMostCommon.Controls.Add(this.listBox1);
            this.tabMostCommon.Controls.Add(this.checkBox2);
            this.tabMostCommon.Controls.Add(this.label10);
            this.tabMostCommon.Controls.Add(this.groupBox1);
            this.tabMostCommon.Controls.Add(this.radioButton3);
            this.tabMostCommon.Controls.Add(this.radioButton2);
            this.tabMostCommon.Controls.Add(this.radioButton1);
            this.tabMostCommon.Controls.Add(this.checkBox1);
            this.tabMostCommon.Controls.Add(this.label3);
            this.tabMostCommon.Controls.Add(this.comboBox1);
            this.tabMostCommon.Controls.Add(this.label2);
            this.tabMostCommon.Controls.Add(this.label1);
            this.tabMostCommon.Controls.Add(this.textBox2);
            this.tabMostCommon.Controls.Add(this.textBox1);
            this.tabMostCommon.Controls.Add(this.button1);
            this.tabMostCommon.Location = new System.Drawing.Point(4, 22);
            this.tabMostCommon.Name = "tabMostCommon";
            this.tabMostCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabMostCommon.Size = new System.Drawing.Size(599, 425);
            this.tabMostCommon.TabIndex = 0;
            this.tabMostCommon.Text = "Most common";
            this.tabMostCommon.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "one",
            "two",
            "three"});
            this.listBox1.Location = new System.Drawing.Point(381, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 18;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(149, 208);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 23);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "combo box";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(231, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 67);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(13, 40);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(13, 17);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(48, 281);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(48, 258);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(48, 235);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(48, 208);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "list box";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "one",
            "two",
            "three"});
            this.comboBox1.Location = new System.Drawing.Point(380, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Multi-line text box";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Single-line text box";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 96);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(145, 61);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(23, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "application.png");
            this.imageList1.Images.SetKeyName(1, "application_form_add.png");
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(this.label9);
            this.tabOther.Controls.Add(this.label8);
            this.tabOther.Controls.Add(this.label7);
            this.tabOther.Controls.Add(this.label6);
            this.tabOther.Controls.Add(this.button2);
            this.tabOther.Controls.Add(this.progressBar1);
            this.tabOther.Controls.Add(this.numericUpDown1);
            this.tabOther.Controls.Add(this.edtMask);
            this.tabOther.Controls.Add(this.monthCalendar1);
            this.tabOther.Controls.Add(this.linkLabel1);
            this.tabOther.Controls.Add(this.dateTimePicker1);
            this.tabOther.Controls.Add(this.checkedListBox1);
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(599, 425);
            this.tabOther.TabIndex = 1;
            this.tabOther.Text = "Other";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "CheckedListBox";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "NumericUpDown";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "MaskedTextBox";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ProgressBar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(351, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(252, 69);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(288, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(395, 231);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // edtMask
            // 
            this.edtMask.Location = new System.Drawing.Point(395, 205);
            this.edtMask.Mask = "(999) 000-0000";
            this.edtMask.Name = "edtMask";
            this.edtMask.Size = new System.Drawing.Size(100, 20);
            this.edtMask.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(17, 233);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(313, 335);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://msdn.microsoft.com";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "one",
            "two",
            "three"});
            this.checkedListBox1.Location = new System.Drawing.Point(17, 47);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tabRichTextBox
            // 
            this.tabRichTextBox.Controls.Add(this.panel3);
            this.tabRichTextBox.Controls.Add(this.panel2);
            this.tabRichTextBox.Location = new System.Drawing.Point(4, 22);
            this.tabRichTextBox.Name = "tabRichTextBox";
            this.tabRichTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.tabRichTextBox.Size = new System.Drawing.Size(599, 425);
            this.tabRichTextBox.TabIndex = 4;
            this.tabRichTextBox.Text = "RichTextBox";
            this.tabRichTextBox.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Editor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 372);
            this.panel3.TabIndex = 15;
            // 
            // Editor
            // 
            this.Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editor.Location = new System.Drawing.Point(0, 0);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(593, 372);
            this.Editor.TabIndex = 14;
            this.Editor.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cboFontColor);
            this.panel2.Controls.Add(this.edtFontSize);
            this.panel2.Controls.Add(this.chUnderline);
            this.panel2.Controls.Add(this.chItalic);
            this.panel2.Controls.Add(this.chBold);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 47);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select text and then apply formatting";
            // 
            // cboFontColor
            // 
            this.cboFontColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFontColor.FormattingEnabled = true;
            this.cboFontColor.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Green",
            "Blue"});
            this.cboFontColor.Location = new System.Drawing.Point(201, 20);
            this.cboFontColor.Name = "cboFontColor";
            this.cboFontColor.Size = new System.Drawing.Size(98, 21);
            this.cboFontColor.TabIndex = 7;
            // 
            // edtFontSize
            // 
            this.edtFontSize.Location = new System.Drawing.Point(131, 20);
            this.edtFontSize.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.edtFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.edtFontSize.Name = "edtFontSize";
            this.edtFontSize.Size = new System.Drawing.Size(55, 20);
            this.edtFontSize.TabIndex = 6;
            this.edtFontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // chUnderline
            // 
            this.chUnderline.Appearance = System.Windows.Forms.Appearance.Button;
            this.chUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chUnderline.Location = new System.Drawing.Point(101, 17);
            this.chUnderline.Name = "chUnderline";
            this.chUnderline.Size = new System.Drawing.Size(24, 24);
            this.chUnderline.TabIndex = 2;
            this.chUnderline.Text = "U";
            this.chUnderline.UseVisualStyleBackColor = true;
            // 
            // chItalic
            // 
            this.chItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.chItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chItalic.Location = new System.Drawing.Point(73, 17);
            this.chItalic.Name = "chItalic";
            this.chItalic.Size = new System.Drawing.Size(22, 24);
            this.chItalic.TabIndex = 1;
            this.chItalic.Text = "I";
            this.chItalic.UseVisualStyleBackColor = true;
            // 
            // chBold
            // 
            this.chBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.chBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chBold.Location = new System.Drawing.Point(42, 17);
            this.chBold.Name = "chBold";
            this.chBold.Size = new System.Drawing.Size(25, 24);
            this.chBold.TabIndex = 0;
            this.chBold.Text = "B";
            this.chBold.UseVisualStyleBackColor = true;
            // 
            // tabListAndTreeView
            // 
            this.tabListAndTreeView.Controls.Add(this.splitContainer1);
            this.tabListAndTreeView.Location = new System.Drawing.Point(4, 22);
            this.tabListAndTreeView.Name = "tabListAndTreeView";
            this.tabListAndTreeView.Padding = new System.Windows.Forms.Padding(3);
            this.tabListAndTreeView.Size = new System.Drawing.Size(599, 425);
            this.tabListAndTreeView.TabIndex = 2;
            this.tabListAndTreeView.Text = "ListView and TreeView";
            this.tabListAndTreeView.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TV);
            this.splitContainer1.Size = new System.Drawing.Size(593, 419);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 0;
            // 
            // LV
            // 
            this.LV.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV.GridLines = true;
            this.LV.HotTracking = true;
            this.LV.HoverSelection = true;
            this.LV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.LV.Location = new System.Drawing.Point(0, 0);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(593, 209);
            this.LV.TabIndex = 0;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 117;
            // 
            // TV
            // 
            this.TV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TV.Location = new System.Drawing.Point(0, 0);
            this.TV.Name = "TV";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Node4";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Node5";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Node2";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Node3";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Node0";
            this.TV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.TV.Size = new System.Drawing.Size(593, 206);
            this.TV.TabIndex = 0;
            // 
            // tabDialogs
            // 
            this.tabDialogs.Controls.Add(this.label11);
            this.tabDialogs.Controls.Add(this.label5);
            this.tabDialogs.Controls.Add(this.picBox);
            this.tabDialogs.Controls.Add(this.pnlColor);
            this.tabDialogs.Controls.Add(this.edtFileName);
            this.tabDialogs.Controls.Add(this.btnColorDlg);
            this.tabDialogs.Controls.Add(this.btnFontDlg);
            this.tabDialogs.Controls.Add(this.btnFolderBrowseDlg);
            this.tabDialogs.Controls.Add(this.btnSaveFileDlg);
            this.tabDialogs.Controls.Add(this.btnOpenFileDlg);
            this.tabDialogs.Location = new System.Drawing.Point(4, 22);
            this.tabDialogs.Name = "tabDialogs";
            this.tabDialogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabDialogs.Size = new System.Drawing.Size(599, 425);
            this.tabDialogs.TabIndex = 3;
            this.tabDialogs.Text = "Dialogs";
            this.tabDialogs.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Panel";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PictureBox";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(341, 28);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(183, 158);
            this.picBox.TabIndex = 10;
            this.picBox.TabStop = false;
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlColor.Location = new System.Drawing.Point(181, 244);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(194, 75);
            this.pnlColor.TabIndex = 8;
            // 
            // edtFileName
            // 
            this.edtFileName.Location = new System.Drawing.Point(181, 198);
            this.edtFileName.Name = "edtFileName";
            this.edtFileName.Size = new System.Drawing.Size(384, 20);
            this.edtFileName.TabIndex = 7;
            // 
            // btnColorDlg
            // 
            this.btnColorDlg.Location = new System.Drawing.Point(19, 163);
            this.btnColorDlg.Name = "btnColorDlg";
            this.btnColorDlg.Size = new System.Drawing.Size(140, 23);
            this.btnColorDlg.TabIndex = 4;
            this.btnColorDlg.Text = "btnColorDlg";
            this.btnColorDlg.UseVisualStyleBackColor = true;
            this.btnColorDlg.Click += new System.EventHandler(this.btnColorDlg_Click);
            // 
            // btnFontDlg
            // 
            this.btnFontDlg.Location = new System.Drawing.Point(19, 134);
            this.btnFontDlg.Name = "btnFontDlg";
            this.btnFontDlg.Size = new System.Drawing.Size(140, 23);
            this.btnFontDlg.TabIndex = 3;
            this.btnFontDlg.Text = "btnFontDlg";
            this.btnFontDlg.UseVisualStyleBackColor = true;
            this.btnFontDlg.Click += new System.EventHandler(this.btnFontDlg_Click);
            // 
            // btnFolderBrowseDlg
            // 
            this.btnFolderBrowseDlg.Location = new System.Drawing.Point(19, 105);
            this.btnFolderBrowseDlg.Name = "btnFolderBrowseDlg";
            this.btnFolderBrowseDlg.Size = new System.Drawing.Size(140, 23);
            this.btnFolderBrowseDlg.TabIndex = 2;
            this.btnFolderBrowseDlg.Text = "btnFolderBrowseDlg";
            this.btnFolderBrowseDlg.UseVisualStyleBackColor = true;
            this.btnFolderBrowseDlg.Click += new System.EventHandler(this.btnFolderBrowseDlg_Click);
            // 
            // btnSaveFileDlg
            // 
            this.btnSaveFileDlg.Location = new System.Drawing.Point(19, 76);
            this.btnSaveFileDlg.Name = "btnSaveFileDlg";
            this.btnSaveFileDlg.Size = new System.Drawing.Size(140, 23);
            this.btnSaveFileDlg.TabIndex = 1;
            this.btnSaveFileDlg.Text = "btnSaveFileDlg";
            this.btnSaveFileDlg.UseVisualStyleBackColor = true;
            this.btnSaveFileDlg.Click += new System.EventHandler(this.btnSaveFileDlg_Click);
            // 
            // btnOpenFileDlg
            // 
            this.btnOpenFileDlg.Location = new System.Drawing.Point(19, 47);
            this.btnOpenFileDlg.Name = "btnOpenFileDlg";
            this.btnOpenFileDlg.Size = new System.Drawing.Size(140, 23);
            this.btnOpenFileDlg.TabIndex = 0;
            this.btnOpenFileDlg.Text = "btnOpenFileDlg";
            this.btnOpenFileDlg.UseVisualStyleBackColor = true;
            this.btnOpenFileDlg.Click += new System.EventHandler(this.btnOpenFileDlg_Click);
            // 
            // tabDataGridView
            // 
            this.tabDataGridView.Controls.Add(this.Grid);
            this.tabDataGridView.Location = new System.Drawing.Point(4, 22);
            this.tabDataGridView.Name = "tabDataGridView";
            this.tabDataGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataGridView.Size = new System.Drawing.Size(599, 425);
            this.tabDataGridView.TabIndex = 5;
            this.tabDataGridView.Text = "DataGridView";
            this.tabDataGridView.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 3);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(593, 419);
            this.Grid.TabIndex = 0;
            // 
            // tabWebBrowser
            // 
            this.tabWebBrowser.Controls.Add(this.webBrowser1);
            this.tabWebBrowser.Controls.Add(this.panel1);
            this.tabWebBrowser.Location = new System.Drawing.Point(4, 22);
            this.tabWebBrowser.Name = "tabWebBrowser";
            this.tabWebBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tabWebBrowser.Size = new System.Drawing.Size(599, 425);
            this.tabWebBrowser.TabIndex = 6;
            this.tabWebBrowser.Text = "WebBrowser";
            this.tabWebBrowser.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 35);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(593, 387);
            this.webBrowser1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.edtUrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(447, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(39, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // edtUrl
            // 
            this.edtUrl.Location = new System.Drawing.Point(5, 3);
            this.edtUrl.Name = "edtUrl";
            this.edtUrl.Size = new System.Drawing.Size(426, 20);
            this.edtUrl.TabIndex = 0;
            this.edtUrl.Text = "http://www.google.com";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.mnuContext;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Windows Forms controls demo";
            this.notifyIcon1.Visible = true;
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit2});
            this.mnuContext.Name = "contextMenuStrip1";
            this.mnuContext.Size = new System.Drawing.Size(93, 26);
            // 
            // mnuExit2
            // 
            this.mnuExit2.Name = "mnuExit2";
            this.mnuExit2.Size = new System.Drawing.Size(92, 22);
            this.mnuExit2.Text = "Exit";
            this.mnuExit2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 522);
            this.Controls.Add(this.Pager);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.Pager.ResumeLayout(false);
            this.tabMostCommon.ResumeLayout(false);
            this.tabMostCommon.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabOther.ResumeLayout(false);
            this.tabOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabRichTextBox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtFontSize)).EndInit();
            this.tabListAndTreeView.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabDialogs.ResumeLayout(false);
            this.tabDialogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.tabDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.tabWebBrowser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnuContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TabControl Pager;
        private System.Windows.Forms.TabPage tabMostCommon;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem mnuExit2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.MaskedTextBox edtMask;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabListAndTreeView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.TreeView TV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tabDialogs;
        private System.Windows.Forms.Button btnColorDlg;
        private System.Windows.Forms.Button btnFontDlg;
        private System.Windows.Forms.Button btnFolderBrowseDlg;
        private System.Windows.Forms.Button btnSaveFileDlg;
        private System.Windows.Forms.Button btnOpenFileDlg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TextBox edtFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabRichTextBox;
        private System.Windows.Forms.TabPage tabDataGridView;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TabPage tabWebBrowser;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox edtUrl;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox Editor;
        private System.Windows.Forms.CheckBox chBold;
        private System.Windows.Forms.ComboBox cboFontColor;
        private System.Windows.Forms.NumericUpDown edtFontSize;
        private System.Windows.Forms.CheckBox chUnderline;
        private System.Windows.Forms.CheckBox chItalic;
        private System.Windows.Forms.Label label4;
    }
}

