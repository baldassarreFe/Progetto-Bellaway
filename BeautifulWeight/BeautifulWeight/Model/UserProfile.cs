﻿using BeautifulWeight.DietCalculators;
using BeautifulWeight.Kitchen;
using BeautifulWeight.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Users
{
    public class UserProfile
    {
        private List<Ingredient> _preferences;
        private Goal _goal;
        private WeeklyMenu _diet;
        private PersonalDetails _details;

        public UserProfile(UserProfile other)
        {
            _preferences = new List<Ingredient>(other._preferences);
            _goal = other._goal;
            _diet = new WeeklyMenu(other._diet);
            _details = new PersonalDetails(other._details);
        }

        public UserProfile() {
            _details = new PersonalDetails();
            _preferences = new List<Ingredient>();
        }

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

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(UserProfile))
                return false;
            UserProfile up = (UserProfile)obj;
            return (Details.Name == up.Details.Name && Details.Surname == up.Details.Surname);
        }

        
    }

    public enum Goal
    {
        WEIGHT_LOSS, MASS_GAIN, MAINTAINANCE, DEFINITION
    }
}
