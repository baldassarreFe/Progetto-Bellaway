using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DomoticaPrototipo
{
    public partial class SegnaleDialog : Form
    {
        public SegnaleDialog()
        {
            InitializeComponent();
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Message
        {
            get { return _messaggio.Text; }
            set { _messaggio.Text = value;}
        }

     
    }
}
