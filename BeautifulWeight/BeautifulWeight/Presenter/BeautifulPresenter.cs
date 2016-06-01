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
        public event EventHandler UserChanged;
        public event EventHandler UserRemoved;
        public event EventHandler UserAdded;


        public UserProfile CurrentUser
        {
            get
            {
                return _currentUser;
            }

            set
            {
                if (value == null)
                    UserRemoved(this, EventArgs.Empty);
                _currentUser = value;
                if (value != null)
                    UserChanged(this, EventArgs.Empty);
            }
        }

        public BeautifulPresenter(BeautifulUI ui)
        {
            if (ui == null)
                throw new ArgumentNullException("control");
            _form = ui;

            //_addUserPresenter = new AddUserPresenter(_form, this);
            _personalDetailsPresenter = new PersonalDetailsPresenter(_form, this);
            _userListPresenter = new UserListPresenter(_form, this);
            _versionPresenter = new VersionPresenter(_form);

        }

    }
}
