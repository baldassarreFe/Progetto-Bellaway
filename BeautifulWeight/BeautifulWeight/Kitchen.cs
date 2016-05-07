using BeautifulWeight.Persistence;
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
        private static Dictionary<String, Ingredient> dictionary;

        public Ingredient(string name)
        {
            this._name = name.ToLower();
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public static explicit operator Ingredient(string name)
        {
            if (dictionary == null)
            {
                MockPersistence persistence = MockPersistence.GetInstance();
                foreach (Ingredient i in persistence.LoadIngredients())
                {
                    dictionary.Add(i.Name, i);
                }
            }
            if (!dictionary.ContainsKey(name.ToLower()))
                throw new ArgumentException("Ingredient not found");
            return dictionary[name.ToLower()];
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

        public Dish(string name, double calories, double proteins, double fats, double carbohydrates, NonEmptyList<Ingredient> ingredients) 
        {
            _name = name;
            _calories = calories;
            _proteins = proteins;
            _fats = fats;
            _carbohydrates = carbohydrates;
            _ingredients = ingredients;
        }

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
