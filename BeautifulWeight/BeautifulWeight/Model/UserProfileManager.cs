using BeautifulWeight.Persistence;
using BeautifulWeight.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Model
{
    class UserProfileManager
    {

        private IList<UserProfile> _allUsers;
        private static UserProfileManager _instance;

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
        }

        public void Remove(UserProfile up)
        {
            _allUsers.Remove(up);
        }

        public static UserProfileManager GetInstance()
        {
            if (_instance == null)
                _instance = new UserProfileManager();
            return _instance;
        }
    }
}
