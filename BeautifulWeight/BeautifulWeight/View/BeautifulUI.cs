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
            SingleProfileModel model = new SingleProfileModel();
            UserPresenter ulpresenter = new UserPresenter(this.UsersListView, this.AggiungiButton, model);
            PersonalDetailsPresenter pdpresenter = new PersonalDetailsPresenter(this.ProfilePanel, this.ProfileMenuPanel, model);
            VersionPresenter vpresenter = new VersionPresenter(this.VersionLabel);
            MenuPresenter mpresenter = new MenuPresenter(this.DietUpperPanel,this.DietPanel,this.DietButtonsPanel,model);
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


        public RadPanel DietMenuPanel
        {
            get
            {
                return _dietButtonsPanel;
            }

            set
            {
                _dietButtonsPanel = value;
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
        public Panel ProfilePanel
        {
            get
            {
                return _profilePanel;
            }

            set
            {
                _profilePanel = value;
            }
        }


        public RadPanel DietUpperPanel
        {
            get
            {
                return _dietUpperPanel;
            }

            set
            {
                _dietUpperPanel = value;
            }
        }

        public RadPanel DietPanel
        {
            get
            {
                return _dietPanel;
            }

            set
            {
                _dietPanel = value;
            }
        }

        public RadPanel DietButtonsPanel
        {
            get
            {
                return _dietButtonsPanel;
            }

            set
            {
                _dietButtonsPanel = value;
            }
        }
    }
}
