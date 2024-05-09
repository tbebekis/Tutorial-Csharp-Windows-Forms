using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Diagnostics;


/*  
# World-ready applications

    * The notion of culture and the CultureInfo class
    * Invariant, neutral and specific cultures
    * Culture hierarchy
    * Application culture
          o CurrentUICulture
          o CurrentCulture
    * User overrides
    * RegionInfo class
    * Custom cultures and the CultureAndRegionInfoBuilder class
    * "There Ain't No Such Thing As Plain Text" (as Joel Spolsky said)
          o ASCII
          o OEM character sets
          o ANSI code pages
          o Double-byte and Multi-byte character sets
          o Unicode
          o Encodings
    * Encoding class
          o Encoding and decoding operations
    * About CLR strings and characters
    * TextInfo class
    * String comparison
          o Comparison operations use the culture of the current thread
          o Three different ways of comparing and sorting strings
    * NumberFormatInfo class
    * DateTimeFormatInfo class
    * Calendar class
 
 
 */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.CurrentCulture = new CultureInfo("de-DE");

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");

            MessageBox.Show(Application.CurrentCulture.Name);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encoding enc = Encoding.GetEncoding("windows-1253");
            MessageBox.Show(enc.EncodingName);
            MessageBox.Show(enc.GetType().FullName);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Encoding SourceEnc = Encoding.Unicode;
            Encoding DestEnc = Encoding.GetEncoding("windows-1253");

            string SourceString = "test string";
            byte[] SourceBytes = SourceEnc.GetBytes(SourceString);
            byte[] DestBytes = Encoding.Convert(SourceEnc, DestEnc, SourceBytes);
            string DestString = DestEnc.GetString(DestBytes);

            MessageBox.Show(DestString);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string S = "this is a sample text";

            string S2 = Application.CurrentCulture.TextInfo.ToTitleCase(S) + Environment.NewLine +
                        Application.CurrentCulture.TextInfo.ToLower(S) + Environment.NewLine +
                        Application.CurrentCulture.TextInfo.ToUpper(S);

            MessageBox.Show(S2);
        }

        
    }
}
