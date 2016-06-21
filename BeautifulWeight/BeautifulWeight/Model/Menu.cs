using BeautifulWeight.Kitchen;
using BeautifulWeight.DietCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

    public class Meal : IEnumerable<Serving>
    {
        private readonly string _name;
        private readonly DateTime _time;
        private readonly NonEmptyList<Serving> _servings;

        public Meal(string name, DateTime time, NonEmptyList<Serving> servings)
        {
            _name = name;
            _time = time;
            _servings = servings;
        }

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

        public IEnumerator<Serving> GetEnumerator()
        {
            return ((IEnumerable<Serving>)Servings).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Serving>)Servings).GetEnumerator();
        }
    }

    public class DailyMenu : IEnumerable<Meal>
    {
        private readonly DayOfWeek _day;
        private readonly List<Meal> _meals;

        public DailyMenu(DayOfWeek day)
        {
            _day = day;
            _meals = new List<Meal>();
        }

        public DailyMenu(int day) : this((DayOfWeek) day)
        {
        }

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

        public IEnumerator<Meal> GetEnumerator()
        {
            return ((IEnumerable<Meal>)Meals).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Meal>)Meals).GetEnumerator();
        }
    }

    public class WeeklyMenu : IEnumerable<DailyMenu>
    {
        private readonly DailyMenu[] _dailyMenus;
        private readonly string _dietCalculatorType;

        public DailyMenu this[DayOfWeek day]
        {
            get
            {
                return _dailyMenus[(int) day];
            }
        }

        public WeeklyMenu(string dietCalculatorType)
        {
            _dietCalculatorType = dietCalculatorType;
            _dailyMenus = new DailyMenu[7];
            for (int i = 0; i<_dailyMenus.Length; i++)
            {
                _dailyMenus[i] = new DailyMenu(i);
            }
        }

        public WeeklyMenu(DietCalculator dietCalculator) : this(dietCalculator.GetType().AssemblyQualifiedName)
        {
        }

        public WeeklyMenu(WeeklyMenu other)
        {
            this._dietCalculatorType = other._dietCalculatorType;
            this._dailyMenus = new DailyMenu[7];
            Array.Copy(other._dailyMenus, this._dailyMenus, other._dailyMenus.Length);
        }

        public DietCalculator DietCalculator
        {
            get
            {
                // si può fare di meglio
                return DietCalculatorLoader.LoadedDietCalculators.FirstOrDefault(dc => dc.GetType().AssemblyQualifiedName == _dietCalculatorType);
            }
        }

        public IEnumerable<DailyMenu> DailyMenus
        {
            get
            {
                return _dailyMenus;
            }
        }

        public IEnumerator<DailyMenu> GetEnumerator()
        {
            return ((IEnumerable<DailyMenu>)DailyMenus).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<DailyMenu>)DailyMenus).GetEnumerator();
        }
    }
}
