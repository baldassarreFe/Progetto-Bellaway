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
    public partial class MealStrip : UserControl
    {
        public MealStrip()
        {
            InitializeComponent();
        }

        public string Pasto
        {
            get
            {
                return _mealNameLabel.Text;
            }

            set
            {
                _mealNameLabel.Text = value;
            }
        }
    }
}
