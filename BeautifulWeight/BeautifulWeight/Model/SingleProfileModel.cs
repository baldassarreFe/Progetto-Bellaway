using BeautifulWeight.Model;
using BeautifulWeight.Users;
using BeautifulWeight.Versions;
using BeautifulWeight.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Presenter
{
    public class SingleProfileModel
    {
        private readonly UserProfileManager _userProfileManager;
        private UserProfile _currentUser;
        private UserProfile _temp;
        public event EventHandler UserRemoved;
        public event EventHandler UserAdded;
        public event EventHandler UserUpdated;
        public event EventHandler CurrentUserChanged;
        
        // composizione e melega
        private UserProfileManager UserProfileManager
        {
            get
            {
                return _userProfileManager;
            }
        }

        public IEnumerable<UserProfile> AllUsers
        {
            get
            {
                return UserProfileManager.AllUsers;
            }
        }

        public UserProfile CurrentUser
        {
            get
            {
                return _currentUser;
            }

            set
            {
                _currentUser = value;
                FireCurrentUserChanged();
            }
        }

        public SingleProfileModel()
        {
            _userProfileManager = ManagerProvider.getManager<UserProfileManager>();
            _userProfileManager.UserAdded += _userProfileManager_UserAdded;
            _userProfileManager.UserRemoved += _userProfileManager_UserRemoved;
            _userProfileManager.UserUpdated += _userProfileManager_UserUpdated;
        }

        private void _userProfileManager_UserUpdated(object sender, EventArgs e)
        {
            if (UserUpdated != null)
                UserUpdated(this, EventArgs.Empty);
            FireCurrentUserChanged();
        }

        private void _userProfileManager_UserRemoved(object sender, EventArgs e)
        {
            if (UserRemoved != null)
                UserRemoved(this, EventArgs.Empty);
            if (!UserProfileManager.AllUsers.Contains(CurrentUser))
                CurrentUser = null;
        }

        private void _userProfileManager_UserAdded(object sender, EventArgs e)
        {
            if (UserAdded != null)
                UserAdded(this, EventArgs.Empty);
            FireCurrentUserChanged();
        }

        private void FireCurrentUserChanged()
        {
            if (CurrentUserChanged != null)
                CurrentUserChanged(this, EventArgs.Empty);
        }

        public void NewUser()
        {
            CurrentUser = new UserProfile();
        }

        public void DeleteUser()
        {
            UserProfileManager.Remove(CurrentUser);
        }

        public void StartModify()
        {
            _temp = new UserProfile(CurrentUser);
        }

        public void StopModify(bool save)
        {
            if (save)
            {
                UserProfileManager.Add(CurrentUser);
            }
            else
            {
                CurrentUser = _temp;
            }
            _temp = null;
        }

    }
}
