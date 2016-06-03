using BeautifulWeight.Model;
using BeautifulWeight.Versions;
using BeautifulWeight.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautifulWeight.Presenter
{
    class VersionPresenter
    {
        private readonly Label _label;

        internal VersionManager VersionManager
        {
            get
            {
                return ManagerProvider.getManager<VersionManager>();
            }
        }

        public Label VersionLabel
        {
            get
            {
                return _label;
            }
        }

        public VersionPresenter(Label versionLabel)
        {
            if (versionLabel == null)
                throw new ArgumentNullException("control");
            _label = versionLabel;
            VersionLabel.Click += ClickHandler;
            VersionManager.VersionChanged += OnModelChanged;
            OnModelChanged(null, null);
        }

        protected void OnModelChanged(object sender, EventArgs e)
        {
            VersionLabel.Text = VersionManager.CurrentVersion.Description;
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            VersionDialog dialog = new VersionDialog();
            dialog.ShowDialog();
        }
    }
}
