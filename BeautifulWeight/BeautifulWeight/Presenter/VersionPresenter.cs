using BeautifulWeight.Versions;
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
        private readonly Control _control;

        public VersionManager VersionManager
        {
            get { return _versionManager; }
            set
            {
                if (value != _versionManager)
                {
                    if (_versionManager != null)
                    {
                        //  Deregistrazione
                        _versionManager.VersionChanged -= OnModelChanged;
                    }
                    _versionManager = value;
                    if (_versionManager != null)
                    {
                        //  Registrazione
                        _versionManager.VersionChanged += OnModelChanged;
                        OnModelChanged(_versionManager, EventArgs.Empty);
                    }
                }
            }
        }

        public VersionPresenter(Control control)
        {
            if (control == null)
                throw new ArgumentNullException("control");
            _control = control;
            _control.Click += ClickHandler;
        }

        protected void OnModelChanged(object sender, EventArgs e)
        {
            _control.Text = "La versione corrente è: " + _versionManager.CurrentVersion.Description;
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show("UPGRADA ZIO");
            // TODO per bene
        }
    }
}
