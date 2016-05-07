using BeautifulWeight.Kitchen;
using BeautifulWeight.DietCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Menu
{
    class Serving
    {
        private readonly int _quantity;
        private readonly Dish _dish;

        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }

        internal Dish Dish
        {
            get
            {
                return _dish;
            }
        }
    }

    class Meal
    {
        private readonly string _name;
        private readonly DateTime _time;
        private readonly NonEmptyList<Serving> _servings;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public DateTime Time
        {
            get
            {
                return _time;
            }
        }

        NonEmptyList<Serving> Servings
        {
            get
            {
                return _servings;
            }
        }
    }

    class DailyMenu
    {
        private readonly DayOfWeek _day;
        private readonly List<Meal> _meals;

        public DayOfWeek Day
        {
            get
            {
                return _day;
            }
        }

        internal List<Meal> Meals
        {
            get
            {
                return _meals;
            }
        }
    }

    class WeeklyMenu
    {
        private readonly DailyMenu[] _dailyMenu;
        private readonly DietCalculator _dietCalculator;

        public DailyMenu this[DayOfWeek day]
        {
            get
            {
                return _dailyMenu[(int) day];
            }
        }

        public DietCalculator DietCalculator
        {
            get
            {
                return _dietCalculator;
            }
        }
    }
}
