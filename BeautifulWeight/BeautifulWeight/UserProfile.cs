using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Users
{
    class UserProfile
    {
        private List<Ingredient> _preferences;
        private Goal _goal;
        private WeeklyMenu _diet;
        private PersonalDetails _details;

        public List<Ingredient> Preferences
        {
            get
            {
                return _preferences;
            }

            set
            {
                _preferences = value;
            }
        }

        public Goal Goal
        {
            get
            {
                return _goal;
            }

            set
            {
                _goal = value;
            }
        }

        public WeeklyMenu Diet
        {
            get
            {
                return _diet;
            }

            set
            {
                _diet = value;
            }
        }

        public PersonalDetails Details
        {
            get
            {
                return _details;
            }

            set
            {
                _details = value;
            }
        }
    }
}
