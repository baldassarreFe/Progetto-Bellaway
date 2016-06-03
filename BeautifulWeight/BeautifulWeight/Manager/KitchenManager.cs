using BeautifulWeight.Kitchen;
using BeautifulWeight.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Model
{
    public class KitchenManager : Manager
    {
        private ISet<Ingredient> _ingredients;

        public IEnumerable<Ingredient> Ingredients
        {
            get
            {
                if (_ingredients != null)
                    return _ingredients;
                _ingredients = PersistenceProvider.getPersistor<KitchenPersistor>().LoadIngredients();
                return _ingredients;
            }
        }

        private ISet<Dish> _dishes;

        public IEnumerable<Dish> Dishes
        {
            get
            {
                if (_dishes != null)
                    return _dishes;
                _dishes = PersistenceProvider.getPersistor<KitchenPersistor>().LoadDishes();
                return _dishes;
            }
        }
    }
}
