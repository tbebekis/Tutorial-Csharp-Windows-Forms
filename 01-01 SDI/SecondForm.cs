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
        public SecondForm()
        {
            InitializeComponent();
        }

        static int Counter = 0;

        private void btnCreateForm_Click(object sender, EventArgs e)
        {
            Form Form = new ThirdForm();
            Form.Owner = this;
            Form.Text = "ThirdForm " + Counter.ToString();
            Counter++;
            Form.Show();
        }
    }
}
