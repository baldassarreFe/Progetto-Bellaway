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
                _ingredients = PersistenceManager.getPersistenceManager<KitchenPersistor>().LoadIngredients();
                return _ingredients;
            }
        }
    }
}
