using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautifulWeight.View
{
    public partial class UserStrip: UserControl
    {

        public string Nome
        {
            get
            {
                return _nomeLabel.Text;
            }

            set
            {
                _nomeLabel.Text = value;
            }
        }

        public string Cognome
        {
            get
            {
                return _cognomeLabel.Text;
            }

            set
            {
                _cognomeLabel.Text = value;
            }
        }

        public UserStrip()
        {
            InitializeComponent();
        }
  
    }
}
