using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lessons
{
    public partial class PersonUserControl : UserControl
    {
        public PersonUserControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return gboBox.Text; }
            set { gboBox.Text = value; }
        }

        public string PersonName
        {
            get { return edtName.Text; }
            set { edtName.Text = value; }
        }

        public string Phone
        {
            get { return edtPhone.Text; }
            set { edtPhone.Text = value; }
        }

        public string EMail
        {
            get { return edtEMail.Text; }
            set { edtEMail.Text = value; }
        }
    }
}
