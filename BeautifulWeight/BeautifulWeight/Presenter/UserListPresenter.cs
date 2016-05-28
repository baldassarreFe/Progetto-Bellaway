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

namespace BeautifulWeight.Presenter
{
    class UserListPresenter
    {
        private UserProfileManager _userProfileManager;
        private readonly BeautifulUI _form;

        internal UserProfileManager UserProfileManager
        {
            get
            {
                return _userProfileManager;
            }

            set
            {
                _userProfileManager = value;
            }
        }

        public UserListPresenter(BeautifulUI ui)
        {
            if (ui == null)
                throw new ArgumentNullException("control");
            _userProfileManager = UserProfileManager.GetInstance();
            _form = ui;

            foreach (UserProfile up in _userProfileManager.AllUsers)
            {
                UserStrip us = new UserStrip();
                us.Nome = up.Details.Name;
                us.Cognome = up.Details.Surname;
                us.Parent = _form.UsersListView;
                us.AutoSize = true;
                us.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                us.Width = us.Parent.Width;
                int counter = _form.UsersListView.Controls.Count - 1;
                int height = _form.UsersListView.Controls[0].Height;
                us.Location = new Point(0, counter * height);
                _form.UsersListView.Controls.Add(us);
            }

        }

        protected void OnModelChanged(object sender, EventArgs e)
        {

        }

        private void ClickHandler(object sender, EventArgs e)
        {
            
        }
    }
}
