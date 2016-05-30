using BeautifulWeight.Model;
using BeautifulWeight.Users;
using BeautifulWeight.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautifulWeight.Presenter
{
    class PersonalDetailsPresenter
    {
        private BeautifulUI _form;

        public UserProfileManager UserProfileManager
        {
            get
            {
                return UserProfileManager.GetInstance();
            }
        }

        public PersonalDetailsPresenter(BeautifulUI ui)
        {
            if (ui == null)
                throw new ArgumentNullException("control");
            _form = ui;      
        }


        public void UserChangedHandler(UserProfile user)
        {
            paint(user.Details);
        }

        private void paint(PersonalDetails personalDetails)
        {
            TableLayoutPanel _detailsPanel = new TableLayoutPanel();
            foreach (PropertyInfo pi in personalDetails.GetType().GetProperties())
            {
                Label name = new Label();
                name.Text = pi.Name;
                Label value = new Label();
                value.Text = (String) pi.GetValue(personalDetails);
            }
        }
    }
}
