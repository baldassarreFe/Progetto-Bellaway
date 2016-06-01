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
                if (value == null || value == "")
                    throw new ArgumentException();
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
                if (value == null || value == "")
                    throw new ArgumentException();
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
                DateTime novecento = new DateTime(1900, 1, 1);
                DateTime now = DateTime.Today;
                if (value.CompareTo(novecento) < 0 || value.CompareTo(now) > 0)
                    throw new ArgumentException();
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
                if (value > 250 || value < 30)
                    throw new ArgumentException();
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
                if (value < 110 || value > 230)
                    throw new ArgumentException();
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
                if (value > 24 * 7 || value < 0)
                    throw new ArgumentException();
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
                if (value > 24 * 7 || value < 0)
                    throw new ArgumentException();
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