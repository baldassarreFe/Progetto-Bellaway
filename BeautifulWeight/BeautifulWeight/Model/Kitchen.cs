using BeautifulWeight.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Kitchen
{
    public class Ingredient
    {
        private readonly string _name;
        private static ISet<Ingredient> set;

        static Ingredient() 
        {
            MockPersistence persistence = MockPersistence.GetInstance();
            set = new HashSet<Ingredient>();
            // persistence.LoadIngredients();
        }

        private Ingredient(string name)
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

        // TODO lo mettiamo internal perchè il gestore di persistenza che li crea è dentro questo assembly?
        public static implicit operator Ingredient(string name)
        {
            Ingredient result = set.SingleOrDefault(ing => ing.Name == name.ToLower());
            if (result == null) {
                result = new Ingredient(name.ToLower());
                set.Add(result);
            }
            return result;
        }
    }

    public class Dish
    {
        private readonly string _name;
        private readonly double _calories;
        private readonly double _proteins;
        private readonly double _fats;
        private readonly double _carbohydrates;
        private readonly NonEmptyList<Ingredient> _ingredients;

        internal Dish(string name, double calories, double proteins, double fats, double carbohydrates, NonEmptyList<Ingredient> ingredients)
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
