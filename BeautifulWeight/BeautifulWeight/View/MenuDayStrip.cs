using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautifulWeight.View
{
    public partial class MenuDayStrip : UserControl
    {
        public MenuDayStrip()
        {
            InitializeComponent();
        }

        public string Giorno
        {
            get
            {
                return _dayLabel.Text;
            }

            set
            {
                _dayLabel.Text = value;
            }
        }
    }
}
