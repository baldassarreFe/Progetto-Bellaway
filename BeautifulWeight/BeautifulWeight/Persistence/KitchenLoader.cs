using BeautifulWeight.Kitchen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Persistence
{
    interface KitchenLoader
    {
        IList<Ingredient> LoadIngredients();
        ISet<Dish> LoadDishes();
    }
}
