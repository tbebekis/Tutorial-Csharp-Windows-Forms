using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  
    Keyboard input
 
    KeyPress event
    Form.KeyPreview property
    The KeyCrack helper class
 */
namespace Lessons
{
    public partial class MainForm : Form
    { 
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        
        /* prevents writing numbers in any control, if the KeyPreview is true */
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.KeyChar) != -1;
        }
    }
    
}



namespace Lessons
{
    /// <summary>
    /// A static class for cracking Keys enum values
    /// </summary>
    static public class KeyCrack
    {
        /// <summary>
        /// returns true if Alt is in K
        /// </summary>
        static public bool AltIn(Keys K)
        {
            return ((K & Keys.Alt) == Keys.Alt);
        }
        /// <summary>
        /// Returns true if Control is in K
        /// </summary>
        static public bool ControlIn(Keys K)
        {
            return ((K & Keys.Control) == Keys.Control);
        }
        /// <summary>
        /// Returns true if Shift is in K
        /// </summary>
        static public bool ShiftIn(Keys K)
        {
            return ((K & Keys.Shift) == Keys.Shift);
        }
        /// <summary>
        /// Returns the Keys enum constant of K, excluding modifiers, if any
        /// </summary>
        static public Keys CodeOf(Keys K)
        {
            Keys Mask = K & Keys.KeyCode;
            if (!Enum.IsDefined(typeof(Keys), (int)Mask))
                return Keys.None;

            return Mask;
        }
        /// <summary>
        /// Returns true if CodeKey == K excluding any modifiers from K
        /// </summary>
        static public bool CodeIs(Keys K, Keys CodeKey)
        {
            return CodeOf(K) == CodeKey;
        }
        /// <summary>
        /// Returns the modifier constants of K, that is the combination of modifier keys (CTRL, SHIFT, and ALT)
        /// </summary>
        static public Keys ModifiersOf(Keys K)
        {
            return K & Keys.Modifiers;
        }
        /// <summary>
        /// Returns true if K contains modifiers keys
        /// </summary>
        static public bool ContainsModifiers(Keys K)
        {
            return ModifiersOf(K) != Keys.None;
        }
        /// <summary>
        /// Returns true if K contains any non modifier key
        /// </summary>
        static public bool ContainsCode(Keys K)
        {
            return CodeOf(K) != Keys.None;
        }
        /// <summary>
        /// Returns the integer representation of K 
        /// </summary>
        static public int Value(Keys K)
        {
            return (int)(K & Keys.KeyCode);
        }
        /// <summary>
        /// Returns a string representation of K
        /// </summary>
        static public string ToString(Keys K)
        {
            string Res = "";

            if (AltIn(K))
                Res = Res + "Alt, ";

            if (ControlIn(K))
                Res = Res + "Control, ";

            if (ShiftIn(K))
                Res = Res + "Shift, ";

            if (Res.EndsWith(", "))
                Res = Res.Substring(0, Res.Length - 2);

            if (Res != "")
                Res = "(" + Res + ") + " + CodeOf(K).ToString();
            else
                Res = CodeOf(K).ToString();

            return Res;
        }
        /// <summary>
        /// Returns true if K is a Function key (F1 to F24)
        /// </summary>
        static public bool IsFunctionKey(Keys K)
        {
            return ((K & Keys.F1) == Keys.F1)
             || ((K & Keys.F2) == Keys.F2)
             || ((K & Keys.F3) == Keys.F3)
             || ((K & Keys.F4) == Keys.F4)
             || ((K & Keys.F5) == Keys.F5)
             || ((K & Keys.F6) == Keys.F6)
             || ((K & Keys.F7) == Keys.F7)
             || ((K & Keys.F8) == Keys.F8)
             || ((K & Keys.F9) == Keys.F9)
             || ((K & Keys.F10) == Keys.F10)
             || ((K & Keys.F11) == Keys.F11)
             || ((K & Keys.F12) == Keys.F12)
             || ((K & Keys.F13) == Keys.F13)
             || ((K & Keys.F14) == Keys.F14)
             || ((K & Keys.F15) == Keys.F15)
             || ((K & Keys.F16) == Keys.F16)
             || ((K & Keys.F17) == Keys.F17)
             || ((K & Keys.F18) == Keys.F18)
             || ((K & Keys.F19) == Keys.F19)
             || ((K & Keys.F20) == Keys.F20)
             || ((K & Keys.F21) == Keys.F21)
             || ((K & Keys.F22) == Keys.F22)
             || ((K & Keys.F23) == Keys.F23)
             || ((K & Keys.F24) == Keys.F24)
             ;
        }
        /// <summary>
        /// Returns true if K is a control key 
        /// </summary>
        static public bool IsContolKey(Keys K)
        {
            return
                  ((K & Keys.None) == Keys.None)
       || ((K & Keys.Return) == Keys.Return)
       || ((K & Keys.Escape) == Keys.Escape)
       || ((K & Keys.Insert) == Keys.Insert)
       || ((K & Keys.Delete) == Keys.Delete)
       || ((K & Keys.Back) == Keys.Back)
       || ((K & Keys.Home) == Keys.Home)
       || ((K & Keys.End) == Keys.End)
       || ((K & Keys.PageUp) == Keys.PageUp)
       || ((K & Keys.PageDown) == Keys.PageDown)
       || ((K & Keys.Up) == Keys.Up)
       || ((K & Keys.Down) == Keys.Down)
       || ((K & Keys.Left) == Keys.Left)
       || ((K & Keys.Right) == Keys.Right)
       || ((K & Keys.Pause) == Keys.Pause)
               ;

        }

    }

}