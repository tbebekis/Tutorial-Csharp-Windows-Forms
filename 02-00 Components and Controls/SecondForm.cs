using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lessons
{
    public partial class SecondForm : Form
    {
        Button button;
        public SecondForm()
        {
            InitializeComponent();

            button = new Button();
            button.Parent = this;
            button.Click += new EventHandler(button_Click);

            button.Left = 10;
            button.Top = 10;
            button.Text = "Click me!";
        }

        void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi there!");
        }
    }
}
