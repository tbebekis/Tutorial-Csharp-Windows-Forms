using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


/*  
 
    Windows messages  
    Windows and the NativeWindow class
 
 
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        const int WM_CHAR = 258;
        const int WM_LBUTTONDOWN = 513;
        CustomWindow customWindow;


        /// <summary>
        /// Gets the low-order word of Value
        /// </summary>
        static public int LoWord(int Value)
        {
            return (Value & 0xFFFF);
        }
        /// <summary>
        /// Gets the high-order word of Value
        /// </summary>
        static public int HiWord(int Value)
        {
            return ((Value >> 16) & 0xFFFF);
        }
         

        public MainForm()
        {
            InitializeComponent();

            new MessageFilter(this);

            customWindow = new CustomWindow(this);
        }

        protected override void WndProc(ref Message m)
        {
            /* cracks the WM_LBUTTONDOWN (left mouse button down) message and 
               writes the click coordinates on the form */
            if (m.Msg == WM_LBUTTONDOWN)
            {
                using (Graphics g = Graphics.FromHwnd(this.Handle))
                {
                    float x = (float)LoWord((int)m.LParam);
                    float y = (float)HiWord((int)m.LParam);
                    string S = string.Format("x = {0}, y = {1}", x, y);
                    g.DrawString(S, this.Font, SystemBrushes.WindowText, x, y);
                }
            }

            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomWindow.PostMessage(customWindow.Handle, CustomWindow.UM_TEST, 0, 0);
        }
    }




    /* swallows any WM_CHAR message carrying the character a, sent to this application */
    public class MessageFilter : IMessageFilter
    {
        const int WM_CHAR = 258;
        MainForm form;

        public MessageFilter(MainForm Form)
        {
            form = Form;
            Application.AddMessageFilter(this);
        }

        public bool PreFilterMessage(ref Message m)
        {
            if ((m.Msg == WM_CHAR) && ((int)m.WParam == (int)'a'))
                return true;
 
            return false;
        } 
    }




    /* A NativeWindow descendant which uses the UM_TEST custom message */
    public class CustomWindow : NativeWindow
    {
        static public readonly int WM_USER  = 0x0400;
        static public readonly int UM_TEST = WM_USER + 1;

        [DllImport("user32.dll")]
        public static extern int PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        MainForm form;

        public CustomWindow(MainForm Form)
        {
            form = Form;  
            this.CreateHandle(new CreateParams());
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == UM_TEST)
            {
                form.listBox1.Items.Add(DateTime.Now.ToLongTimeString());
            }

            base.WndProc(ref m);
        }
    }
}
