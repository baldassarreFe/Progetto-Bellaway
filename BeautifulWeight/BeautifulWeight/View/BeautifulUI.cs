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
using Telerik.WinControls.UI;

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
            VersionPresenter vpres = new VersionPresenter(this);
            vpres.VersionManager = VersionManager.GetInstance();
            UserListPresenter ulpres = new UserListPresenter(this);
        }


        public SplitPanel Users
        {
            get
            {
                return _users;
            }

            set
            {
                _users = value;
            }
        }

        public SplitPanel Profile
        {
            get
            {
                return _profile;
            }

            set
            {
                _profile = value;
            }
        }

        public SplitPanel Diet
        {
            get
            {
                return _diet;
            }

            set
            {
                _diet = value;
            }
        }

        public RadListView UsersListView
        {
            get
            {
                return _usersListView;
            }

            set
            {
                _usersListView = value;
            }
        }

        public RadPanel UsersMenuPanel
        {
            get
            {
                return _usersMenuPanel;
            }

            set
            {
                _usersMenuPanel = value;
            }
        }

        public RadPanel ProfileMenuPanel
        {
            get
            {
                return _profileMenuPanel;
            }

            set
            {
                _profileMenuPanel = value;
            }
        }

        public RadListView DietListView
        {
            get
            {
                return _dietListView;
            }

            set
            {
                _dietListView = value;
            }
        }

        public RadPanorama DietSelectionMenu
        {
            get
            {
                return _dietSelectionMenu;
            }

            set
            {
                _dietSelectionMenu = value;
            }
        }

        public RadPanel DietMenuPanel
        {
            get
            {
                return _dietMenuPanel;
            }

            set
            {
                _dietMenuPanel = value;
            }
        }

        public RadButton AggiungiButton
        {
            get
            {
                return _aggiungiButton;
            }

            set
            {
                _aggiungiButton = value;
            }
        }

        public RadButton NewDietButton
        {
            get
            {
                return _newDietButton;
            }

            set
            {
                _newDietButton = value;
            }
        }

        public RadButton DeleteDietButton
        {
            get
            {
                return _deleteDietButton;
            }

            set
            {
                _deleteDietButton = value;
            }
        }

        public RadStatusStrip VersionStatusStrip
        {
            get
            {
                return _versionStatusStrip;
            }

            set
            {
                _versionStatusStrip = value;
            }
        }
        public Label VersionLabel
        {
            get
            {
                return _versionLabel;
            }

            set
            {
                _versionLabel = value;
            }
        }

    }
}
