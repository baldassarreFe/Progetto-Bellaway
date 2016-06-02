using BeautifulWeight.Model;
using BeautifulWeight.Users;
using BeautifulWeight.Versions;
using BeautifulWeight.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BeautifulWeight.Presenter
{
    class UserPresenter : Presenter
    {
        private readonly RadListView _listView;
        private readonly RadButton _addUserButton;

        public RadListView UsersListView
        {
            get
            {
                return _listView;
            }
        }

        public RadButton AddUserButton
        {
            get
            {
                return _addUserButton;
            }
        }

        public UserPresenter(RadListView listView, RadButton addUserButton, SingleProfileModel model) : base(model)
        {
            if (listView == null)
                throw new ArgumentNullException("control");
            _listView = listView;
            _listView.VisualItemCreating += UsersListView_VisualItemCreating;
            _listView.VisualItemFormatting += UsersListView_VisualItemFormatting;
            _listView.CurrentItemChanged += UsersListView_CurrentItemChanged;

            _addUserButton = addUserButton;
            _addUserButton.Click += AddUserHandler;

            UpdateList();

            Model.UserAdded += UserAddedHandler;
            Model.UserRemoved += UserRemovedHandler;
            Model.UserUpdated += UserUpdatedHandler;
        }

        private void UserUpdatedHandler(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UsersListView_CurrentItemChanged(object sender, EventArgs e)
        {
            if (UsersListView.CurrentItem != null)
                Model.CurrentUser = (UserProfile)UsersListView.CurrentItem.DataBoundItem;
        }

        private void UsersListView_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            if (e.VisualItem.Current)
            {
                e.VisualItem.NumberOfColors = 1;
                e.VisualItem.BackColor = Color.Aqua;
                e.VisualItem.BorderColor = Color.Aqua;
            }
            else
            {
                e.VisualItem.NumberOfColors = 1;
                e.VisualItem.BackColor = Color.LightBlue;
                e.VisualItem.BorderColor = Color.LightBlue;
            }
        }

        private void UsersListView_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            if (UsersListView.ViewType == ListViewType.ListView)
            {
                e.VisualItem = new UserStripVisualItem();
            }
        }

        public void UserRemovedHandler(object sender, EventArgs e)
        {
            UpdateList();
        }

        public void UserAddedHandler(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {
            UsersListView.DataSource = null;
            try
            {
                UsersListView.DataSource = Model.AllUsers;
            }
            catch (Exception)
            {
                // ignore
            }
            UsersListView.CurrentItem = null;
        }

        private void AddUserHandler(object sender, EventArgs e)
        {
            Model.NewUser();
        }
    }
}
