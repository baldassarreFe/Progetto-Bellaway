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
        private VersionManager _versionManager;
        private readonly BeautifulUI _form;

        internal VersionManager VersionManager
        {
            get
            {
                return _versionManager;
            }

            set
            {
                _versionManager = value;
            }
        }

        public VersionPresenter(BeautifulUI form)
        {
            if (form == null)
                throw new ArgumentNullException("control");
            _form = form;
            _form.VersionLabel.Click += ClickHandler;
            _versionManager = VersionManager.GetInstance();
            _versionManager.VersionChanged += OnModelChanged;
            OnModelChanged(_versionManager, EventArgs.Empty);
        }

        protected void OnModelChanged(object sender, EventArgs e)
        {
            _form.VersionLabel.Text = _versionManager.CurrentVersion.Description;
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show("UPGRADA ZIO");
            // TODO per bene
        }
    }
}
