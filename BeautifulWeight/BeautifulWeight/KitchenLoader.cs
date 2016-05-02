using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Persistence
{
    interface KitchenLoader
    {
        ISet<Ingredient> LoadIngredients();
        ISet<Dish> LoadDishes();
    }
}
