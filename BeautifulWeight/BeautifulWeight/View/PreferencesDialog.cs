using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BeautifulWeight.View
{
    public partial class PreferencesDialog : Form
    {
        public PreferencesDialog()
        {
            InitializeComponent();
        }


        public Panel ButtonPanel
        {
            get
            {
                return _buttonPanel;
            }
        }

        public RadListView PreferencesList
        {
            get
            {
                return _preferencesList;
            }
        }
    }
}
