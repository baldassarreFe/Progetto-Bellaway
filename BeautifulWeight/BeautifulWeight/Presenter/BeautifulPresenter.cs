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
    class BeautifulPresenter
    {

        private UserProfile _currentUser;
        private BeautifulUI _form;
        private AddUserPresenter _addUserPresenter;
        private PersonalDetailsPresenter _personalDetailsPresenter;
        private UserListPresenter _userListPresenter;
        private VersionPresenter _versionPresenter;

        public UserProfileManager UserProfileManager
        {
            get
            {
                return UserProfileManager.GetInstance();
            }
        }

        public VersionManager VersionManager
        {
            get
            {
                return VersionManager.GetInstance();
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
                _personalDetailsPresenter.UserChangedHandler(_currentUser);
            }
        }

        public BeautifulPresenter(BeautifulUI ui)
        {
            if (ui == null)
                throw new ArgumentNullException("control");
            _form = ui;

            //_addUserPresenter = new AddUserPresenter(_form);
            _personalDetailsPresenter = new PersonalDetailsPresenter(_form);
            _userListPresenter = new UserListPresenter(_form);
            _versionPresenter = new VersionPresenter(_form);
        }


    }
}
