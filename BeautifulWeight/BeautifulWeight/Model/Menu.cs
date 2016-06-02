using BeautifulWeight.Kitchen;
using BeautifulWeight.DietCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Menu
{
    public class Serving
    {
        private readonly int _quantity;
        private readonly Dish _dish;

        public Serving(Dish dish, int quantity)
        {
            if (dish == null || quantity <= 0)
                throw new ArgumentException();
            _dish = dish;
            _quantity = quantity;
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }

        public Dish Dish
        {
            get
            {
                return _dish;
            }
        }
    }

    public class Meal
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

        public NonEmptyList<Serving> Servings
        {
            get
            {
                return _servings;
            }
        }
    }

    public class DailyMenu
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

        public List<Meal> Meals
        {
            get
            {
                return _meals;
            }
        }
    }

    public class WeeklyMenu
    {
        private readonly DailyMenu[] _dailyMenu;
        private readonly String _dietCalculatorType;

        public DailyMenu this[DayOfWeek day]
        {
            get
            {
                return _dailyMenu[(int) day];
            }
        }

        public WeeklyMenu(string dietCalculatorType)
        {
            _dietCalculatorType = dietCalculatorType;
            _dailyMenu = new DailyMenu[7];
        }

        public WeeklyMenu(DietCalculator dietCalculator) : this(dietCalculator.GetType().AssemblyQualifiedName)
        {
        }

        public DietCalculator DietCalculator
        {
            get
            {
                // si può fare di meglio
                return DietCalculatorLoader.LoadedDietCalculators.FirstOrDefault(dc => dc.GetType().AssemblyQualifiedName == _dietCalculatorType);
            }
        }
    }
}
