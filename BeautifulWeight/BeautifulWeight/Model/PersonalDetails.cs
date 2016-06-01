using System;

namespace BeautifulWeight.Users
{
    public struct PersonalDetails
    {
        private string _name;
        private string _surname;
        private DateTime _birthdate;
        private int _weight;
        private int _height;
        private Sex _sex;
        private int _workHours;
        private Load _workLoad;
        private int _sportHours;
        private Load _sportLoad;

        public PersonalDetails(string name, string surname, DateTime birthdate, int weight, int height, Sex sex, int workHours, Load workLoad, int sportHours, Load sportLoad)
        {
            _name = name;
            _surname = surname;
            _birthdate = birthdate;
            _weight = weight;
            _height = height;
            _sex = sex;
            _workHours = workHours;
            _workLoad = workLoad;
            _sportHours = sportHours;
            _sportLoad = sportLoad;
        }
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

        public int WorkHours
        {
            get
            {
                return _workHours;
            }

            set
            {
                _workHours = value;
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

        public Load SportLoad
        {
            get
            {
                return _sportLoad;
            }

            set
            {
                _sportLoad = value;
            }
        }

    }
}