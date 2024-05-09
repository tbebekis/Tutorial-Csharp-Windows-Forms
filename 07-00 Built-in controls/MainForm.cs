using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Data.Common;


/*  
    Windows Forms built-in controls and components  
    
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitializeControls();

        }
        
        DataTable table = new DataTable("Person");

        void InitializeControls()
        {
            /* initialize date-time and status text */
            lblDateTime.Text = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString();
            lblStatus.Text = Pager.SelectedTab.Text;

            /* load an rtf file to a RichTextBox */
            if (File.Exists(@"..\..\Windows Forms.rtf"))
                Editor.LoadFile(@"..\..\Windows Forms.rtf");

            /* initialize ListView */
            LV.BeginUpdate();
            LV.Clear();
            LV.Columns.Add("Column A");
            LV.Columns.Add("Column B");

            ListViewItem LVI;

            for (int i = 0; i < 5; i++)
            {
                LVI = LV.Items.Add(i.ToString());
                LVI.SubItems.Add(LVI.Text + "-sub");
            }
            LV.EndUpdate();


            /* initialize TreeView */
            TV.BeginUpdate();
            TV.Nodes.Clear();

            for (int i = 0; i < 3; i++)
            {
                TV.Nodes.Add("i " + i.ToString());
                for (int j = 0; j < 3; j++)
                {
                    TV.Nodes[i].Nodes.Add("j " + j.ToString());
                    for (int k = 0; k < 3; k++)
                    {
                        TV.Nodes[i].Nodes[j].Nodes.Add("k " + k.ToString());
                    }
                }
            }
            TV.EndUpdate();



            table.Columns.Add("ID", typeof(System.Int32));
            table.Columns.Add("Name", typeof(System.String));


            for (int i = 0; i < 5; i++)
            {
                table.Rows.Add(new object[] { i, "Person " + i.ToString() });
            }

            Grid.DataSource = table;

            /* RichTextBox settings */
            chBold.CheckedChanged += new EventHandler(AnyRichTextBoxSettingChanged);
            chItalic.CheckedChanged += new EventHandler(AnyRichTextBoxSettingChanged);
            chUnderline.CheckedChanged += new EventHandler(AnyRichTextBoxSettingChanged);

            edtFontSize.ValueChanged += new EventHandler(AnyRichTextBoxSettingChanged);
            cboFontColor.SelectedIndexChanged += new EventHandler(AnyRichTextBoxSettingChanged);

            cboFontColor.SelectedIndex = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString();
        }

        private void Pager_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage != null)
                lblStatus.Text = e.TabPage.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(2000, "Tip Title", "Hi there!", ToolTipIcon.Info);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.Enabled = false;
                try
                {
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 100;
                    progressBar1.Step = 1;

                    for (int i = progressBar1.Minimum; i < progressBar1.Maximum; i++)
                    {
                        progressBar1.PerformStep();
                        Application.DoEvents();
                        Thread.Sleep(20);
                    }

                    progressBar1.Value = 0;
                }
                finally
                {
                    button.Enabled = true;
                }
            }
        }

        private void btnOpenFileDlg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Dlg = new OpenFileDialog())
            {
                Dlg.Title = "Select image";
                Dlg.InitialDirectory = @"C:\";
                Dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                Dlg.CheckFileExists = true;
                Dlg.CheckPathExists = true;

                if (Dlg.ShowDialog() == DialogResult.OK)
                {
                    picBox.Load(Dlg.FileName);

                    // alternatively
                    // picBox.Image = Image.FromFile(Dlg.FileName);
                }                    
            }
        }
        
        private void btnSaveFileDlg_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog Dlg = new SaveFileDialog())
            {
                Dlg.Title = "Save file";
                Dlg.InitialDirectory = @"C:\";
                Dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (Dlg.ShowDialog() == DialogResult.OK)
                    edtFileName.Text = Dlg.FileName;
            }
        }

        private void btnFolderBrowseDlg_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog Dlg = new FolderBrowserDialog())
            {
                Dlg.Description = "Select a folder"; 
                Dlg.ShowNewFolderButton = true;

                if (Dlg.ShowDialog() == DialogResult.OK)
                    edtFileName.Text = Dlg.SelectedPath;
            }
        }

        private void btnFontDlg_Click(object sender, EventArgs e)
        {
            using (FontDialog Dlg = new FontDialog())
            {
                if (Dlg.ShowDialog() == DialogResult.OK)
                    edtFileName.Font = Dlg.Font;
            }
        }

        private void btnColorDlg_Click(object sender, EventArgs e)
        {
            using (ColorDialog Dlg = new ColorDialog())
            {
                Dlg.AllowFullOpen = true;
                Dlg.FullOpen = true;
                Dlg.AnyColor = true;

                if (Dlg.ShowDialog() == DialogResult.OK)
                    pnlColor.BackColor = Dlg.Color;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(edtUrl.Text);
        }

        void AnyRichTextBoxSettingChanged(object sender, EventArgs e)
        {
 
            FontStyle FS = FontStyle.Regular;

            if (chBold.Checked)
                FS = FS | FontStyle.Bold;

            if (chItalic.Checked)
                FS = FS | FontStyle.Italic;

            if (chUnderline.Checked)
                FS = FS | FontStyle.Underline;

            Editor.SelectionFont = new Font(Editor.SelectionFont.FontFamily.Name, Convert.ToSingle(edtFontSize.Value), FS);
            Editor.SelectionColor = Color.FromName(cboFontColor.Text);
        }


 


    }
}
