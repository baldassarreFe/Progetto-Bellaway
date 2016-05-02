using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Kitchen
{
    class Ingredient
    {
    private readonly string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }

    class Dish
    {
        private readonly string _name;
        private readonly double _calories;
        private readonly double _proteins;
        private readonly double _fats;
        private readonly double _carbohydrates;
        private readonly NonEmptyList<Ingredient> _ingredients;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Calories
        {
            get
            {
                return _calories;
            }
        }

        public double Proteins
        {
            get
            {
                return _proteins;
            }
        }

        public double Fats
        {
            get
            {
                return _fats;
            }
        }

        public double Carbohydrates
        {
            get
            {
                return _carbohydrates;
            }
        }

        public NonEmptyList<Ingredient> Ingredients
        {
            get
            {
                return _ingredients;
            }
        }
    }
}
