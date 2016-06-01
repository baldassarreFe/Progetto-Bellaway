using BeautifulWeight.Persistence;
using BeautifulWeight.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Model
{
    public class UserProfileManager
    {

        private IList<UserProfile> _allUsers;
        private static UserProfileManager _instance;

        public event EventHandler UserRemoved;
        public event EventHandler UserAdded;

        public IEnumerable<UserProfile> AllUsers
        {
            get
            {
                if (_allUsers != null)
                    return _allUsers;
                _allUsers = PersistenceManager.getPersistenceManager<UserProfilePersistor>().LoadProfiles();
                return _allUsers;
            }
        }

        public UserProfile NewUser()
        {
            return new UserProfile();
        }

        public void Add(UserProfile up)
        {
            _allUsers.Add(up);
            OnAdded();
        }

        public void Remove(UserProfile up)
        {
            _allUsers.Remove(up);
            OnRemoved();
        }

        private void OnRemoved()
        {
            if (UserRemoved!=null)
                UserRemoved(this, EventArgs.Empty);
        }

        private void OnAdded()
        {
            if (UserAdded != null)
                UserAdded(this, EventArgs.Empty);
        }

        public static UserProfileManager GetInstance()
        {
            if (_instance == null)
                _instance = new UserProfileManager();
            return _instance;
        }
    }
}
