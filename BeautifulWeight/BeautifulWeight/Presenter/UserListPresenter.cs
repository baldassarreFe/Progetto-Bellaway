﻿using BeautifulWeight.Model;
using BeautifulWeight.Users;
using BeautifulWeight.Versions;
using BeautifulWeight.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BeautifulWeight.Presenter
{
    class UserListPresenter : Presenter
    {
        private BeautifulPresenter _bpresenter;
        private readonly RadListView _listView;


        public RadListView UsersListView
        {
            get
            {
                return _listView;
            }
        }

        public UserListPresenter(RadListView listView, BeautifulPresenter pres)
        {
            if (listView == null)
                throw new ArgumentNullException("control");
            _listView = listView;
            _listView.VisualItemCreating += UsersListView_VisualItemCreating;
            _listView.VisualItemFormatting += UsersListView_VisualItemFormatting;
            _listView.SelectedItemChanged += UsersListView_SelectedItemChanged;
            _listView.DataSource = UserProfileManager.AllUsers;
            UserProfileManager.UserAdded += UserAddedHandler;
            UserProfileManager.UserRemoved += UserRemovedHandler;
            _bpresenter = pres;
        }

        private void UsersListView_SelectedItemChanged(object sender, EventArgs e)
        {
            if (UsersListView.CurrentItem != null)
                _bpresenter.CurrentUser = (UserProfile)UsersListView.CurrentItem.DataBoundItem;
        }

        private void UsersListView_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            if (e.VisualItem.Current)
            {
                e.VisualItem.NumberOfColors = 1;
                e.VisualItem.BackColor = Color.Orange;
                e.VisualItem.BorderColor = Color.Orange;
            }
            else
            {
                e.VisualItem.NumberOfColors = 1;
                e.VisualItem.BackColor = Color.Aqua;
                e.VisualItem.BorderColor = Color.Aqua;
            }
        }

        private void UsersListView_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            if (UsersListView.ViewType == ListViewType.ListView)
            {
                e.VisualItem = new UserStripVisualItem2();
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
            UsersListView.Refresh();
        }
    }
}
