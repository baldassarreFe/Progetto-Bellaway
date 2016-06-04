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
    public partial class AboutForm :Form
    {
        public AboutForm()
        {
            InitializeComponent();
            _textEaster.Select();//cursore posizionato automaticamente sulla textBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _textEaster_TextChanged(object sender, EventArgs e)
        {
            if(sender is TextBox)
                if (((TextBox)sender).Text.Equals("30lplease"))
                {
                    _pictureEaster.Image = DomoticaPrototipo.Properties.Resources.easterEgg;
                    
                }
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

    }
}
