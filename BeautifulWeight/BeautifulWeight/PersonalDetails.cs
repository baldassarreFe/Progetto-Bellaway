using System;

namespace BeautifulWeight.Users
{
    internal struct PersonalDetails
    {
        private string _name;
        private string _surname;
        private System.DateTime _birthdate;
        private int _weight;
        private int _height;
        private Sex _sex;
        private int _workHours;
        private Load _workLoad;
        private int _sportHours;
        private Load sportLoad;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return _birthdate;
            }

            set
            {
                _birthdate = value;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                _weight = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public Sex Sex
        {
            get
            {
                return _sex;
            }

            set
            {
                _sex = value;
            }
        }

        public Load WorkLoad
        {
            get
            {
                return _workLoad;
            }

            set
            {
                _workLoad = value;
            }
        }

        public int SportHours
        {
            get
            {
                return _sportHours;
            }

            set
            {
                _sportHours = value;
            }
        }

        internal Load SportLoad
        {
            get
            {
                return sportLoad;
            }

            set
            {
                sportLoad = value;
            }
        }
    }
}