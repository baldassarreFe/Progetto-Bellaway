using BeautifulWeight.Model;
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
    class UserListPresenter
    {
        private readonly BeautifulUI _form;
        private BeautifulPresenter _bpresenter;

        public UserProfileManager UserProfileManager
        {
            get
            {
                return UserProfileManager.GetInstance();
            }
        }

        public UserListPresenter(BeautifulUI ui, BeautifulPresenter pres)
        {
            if (ui == null)
                throw new ArgumentNullException("control");
            _form = ui;
            _form.UsersListView.VisualItemCreating += UsersListView_VisualItemCreating;
            _form.UsersListView.VisualItemFormatting += UsersListView_VisualItemFormatting;
            _form.UsersListView.DataSource = UserProfileManager.AllUsers;
            _bpresenter = pres;
            _bpresenter.UserRemoved += UserRemovedHandler;

            //repaint();

        }

        private void UsersListView_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            if (e.VisualItem.Selected)
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
            if (_form.UsersListView.ViewType == ListViewType.ListView)
            {
                e.VisualItem = new UserStripVisualItem2();
            }
        }

        //protected void OnModelChanged(object sender, EventArgs e)
        //{
        //    repaint();
        //}

        //public void ClickHandler(object sender, EventArgs e)
        //{
        //    UserStrip selectedUs = (UserStrip) ((Control)sender).Tag;
        //    foreach (UserStrip us in _form.UsersListView.Controls.OfType<UserStrip>())
        //    {
        //        us.BackColor = Color.White;
        //        us.ProfileImg.BackColor = Color.White;
        //        us.ProfileDetails.BackColor = Color.White;
        //    }
        //    selectedUs.BackColor = Color.Yellow;
        //    selectedUs.ProfileImg.BackColor = Color.Yellow;
        //    selectedUs.ProfileDetails.BackColor = Color.Yellow;
        //    UserProfile up = (UserProfile) selectedUs.Tag;


        //    // TODO: chiamare metodi sui presenter di centro e destra
        //}

        //private void repaint()
        //{
        //    foreach (UserProfile up in UserProfileManager.AllUsers)
        //    {
        //        UserStrip us = new UserStrip();
        //        us.Nome = up.Details.Name;
        //        us.Cognome = up.Details.Surname;
        //        us.Parent = _form.UsersListView;
        //        us.AutoSize = true;
        //        us.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        //        us.Width = us.Parent.Width;

        //        setClickAndTag(us, us);

        //        us.Tag = up;

        //        int counter = _form.UsersListView.Controls.Count - 1;
        //        int height = _form.UsersListView.Controls[0].Height;
        //        us.Location = new Point(0, counter * height);
        //        _form.UsersListView.Controls.Add(us);
        //    }
        //}

        //private void setClickAndTag(Control control, UserStrip us)
        //{
        //    foreach (Control c in control.Controls)
        //    {
        //        c.Tag = us;
        //        c.Click += ClickHandler;
        //        setClickAndTag(c, us);
        //    }
        //}

        private void UserRemovedHandler(object sender, EventArgs e)
        {
            UserProfileManager.Remove(_bpresenter.CurrentUser);
            repaint();
        }
    }
}
