using BeautifulWeight.Persistence;
using BeautifulWeight.Presenter;
using BeautifulWeight.Versions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautifulWeight.View
{
    public partial class BeautifulUI : Telerik.WinControls.UI.RadForm
    {
        public BeautifulUI()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            VersionPresenter vpres = new VersionPresenter(_versionLabel);
            vpres.VersionManager = VersionManager.GetInstance();
        }

    }
}
