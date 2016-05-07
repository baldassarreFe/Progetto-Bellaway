using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautifulWeight.Kitchen;
using BeautifulWeight.Users;

namespace BeautifulWeight.Persistence
{
    class MockPersistence : UserProfileLoader, UserProfileSaver, KitchenLoader, VersionLoader, VersionSaver
    {
        private static MockPersistence _persistence = new MockPersistence();
        private ISet<UserProfile> _profiles;
        private ISet<Dish> _dishes;
        private ISet<Ingredient> _ingredients;
        private Version _version;

        private MockPersistence()
        {
            _ingredients = new HashSet<Ingredient>();
            _ingredients.Add(new Ingredient("nasello"));
            _ingredients.Add(new Ingredient("maiale"));
            _ingredients.Add(new Ingredient("pasta"));
            _ingredients.Add(new Ingredient("cipolla"));
            _ingredients.Add(new Ingredient("pomodorini"));
            _ingredients.Add(new Ingredient("ragù di carne"));
            _ingredients.Add(new Ingredient("pollo"));
            _ingredients.Add(new Ingredient("tacchino"));
            _ingredients.Add(new Ingredient("vitello"));
            _ingredients.Add(new Ingredient("maionese"));
            _ingredients.Add(new Ingredient("tonno"));
            _ingredients.Add(new Ingredient("capperi"));
            _ingredients.Add(new Ingredient("mozzarella"));
            _ingredients.Add(new Ingredient("salsiccia"));
            _ingredients.Add(new Ingredient("patate"));
            _ingredients.Add(new Ingredient("seppia"));
            _ingredients.Add(new Ingredient("calamaro"));
            _ingredients.Add(new Ingredient("gambero"));
            _ingredients.Add(new Ingredient("pane"));
            _ingredients.Add(new Ingredient("insalata"));
            _ingredients.Add(new Ingredient("pomodoro"));
            _ingredients.Add(new Ingredient("scamorza"));
            _ingredients.Add(new Ingredient("formaggio"));
            _ingredients.Add(new Ingredient("grana"));
            _ingredients.Add(new Ingredient("Cipolla"));
            _ingredients.Add(new Ingredient("Origano"));
            _ingredients.Add(new Ingredient("Paprica"));
            _ingredients.Add(new Ingredient("Prezzemolo"));
            _ingredients.Add(new Ingredient("Prezzemolo"));
            _ingredients.Add(new Ingredient("Pastinaca"));
            _ingredients.Add(new Ingredient("pentole patty"));
            _ingredients.Add(new Ingredient("Piselli"));
            _ingredients.Add(new Ingredient("Peperoni"));
            _ingredients.Add(new Ingredient("pimento"));
            _ingredients.Add(new Ingredient("fagioli Pinto"));
            _ingredients.Add(new Ingredient("pianta"));
            _ingredients.Add(new Ingredient("Patata"));
            _ingredients.Add(new Ingredient("Zucca"));
            _ingredients.Add(new Ingredient("Viola Salsify"));
            _ingredients.Add(new Ingredient("radicchio"));
            _ingredients.Add(new Ingredient("Ravanello"));
            _ingredients.Add(new Ingredient("peperoncino"));
            _ingredients.Add(new Ingredient("rabarbaro"));
            _ingredients.Add(new Ingredient("Tuberi"));
            _ingredients.Add(new Ingredient("rosmarino"));
            _ingredients.Add(new Ingredient("fagioli rampicanti"));
            _ingredients.Add(new Ingredient("rapa svedese"));
            _ingredients.Add(new Ingredient("rapa svedese"));
            _ingredients.Add(new Ingredient("saggio"));
            _ingredients.Add(new Ingredient("salsify"));
            _ingredients.Add(new Ingredient("Scalogno"));
            _ingredients.Add(new Ingredient("Scalogno"));
            _ingredients.Add(new Ingredient("SIUM SISARUM"));
            _ingredients.Add(new Ingredient("piselli Snap"));
            _ingredients.Add(new Ingredient("fagioli di soia"));
            _ingredients.Add(new Ingredient("zucca spaghetti"));
            _ingredients.Add(new Ingredient("Spinaci"));
            _ingredients.Add(new Ingredient("Cipollotto"));
            _ingredients.Add(new Ingredient("Schiacciare"));
            _ingredients.Add(new Ingredient("zucche"));
            _ingredients.Add(new Ingredient("svedese"));
            _ingredients.Add(new Ingredient("Patata dolce"));
            _ingredients.Add(new Ingredient("Mais dolce"));
            _ingredients.Add(new Ingredient("pepe Tabasco"));
            _ingredients.Add(new Ingredient("Taro"));
            _ingredients.Add(new Ingredient("Tat soi"));
            _ingredients.Add(new Ingredient("Timo"));
            _ingredients.Add(new Ingredient("Pomodoro"));
            _ingredients.Add(new Ingredient("tuberi"));
            _ingredients.Add(new Ingredient("Rapa"));
            _ingredients.Add(new Ingredient("Rapa"));
            _ingredients.Add(new Ingredient("Wasabi"));
            _ingredients.Add(new Ingredient("Castagna d'acqua"));
            _ingredients.Add(new Ingredient("Crescione"));
            _ingredients.Add(new Ingredient("ravanello bianco"));
            _ingredients.Add(new Ingredient("patata dolce"));
            _ingredients.Add(new Ingredient("Zucchine"));


            _dishes = new HashSet<Dish>();
            NonEmptyList<Ingredient> ingredients = new NonEmptyList<Ingredient>();
            ingredients.Add((Ingredient)"pasta");
            ingredients.Add((Ingredient)"ragù di carne");
            _dishes.Add(new Dish("Pasta al ragù alla bolognese", 406, 15.43, 3.23, 76.61, ingredients));
            ingredients = new NonEmptyList<Ingredient>();
            ingredients.Add((Ingredient)"nasello");
            ingredients.Add((Ingredient)"cipolla");
            ingredients.Add((Ingredient)"pomodorini");
            _dishes.Add(new Dish("Nasello alla cipolla con pomodorini", 234, 17.31, 1.52, 23.35, ingredients));
            ingredients = new NonEmptyList<Ingredient>();
            ingredients.Add((Ingredient)"carne di maiale");
            _dishes.Add(new Dish("Braciola di maiale", 217, 24.28, 12.67, 0, ingredients));
            ingredients = new NonEmptyList<Ingredient>();
            ingredients.Add((Ingredient)"gambero");
            ingredients.Add((Ingredient)"pane");
            _dishes.Add(new Dish("Spiedini di gamberi", 217, 24.28, 12.67, 0, ingredients));
            ingredients = new NonEmptyList<Ingredient>();
            ingredients.Add((Ingredient)"seppia");
            ingredients.Add((Ingredient)"pane");
            _dishes.Add(new Dish("Spiedini di seppie", 217, 24.28, 12.67, 0, ingredients));
            ingredients = new NonEmptyList<Ingredient>();
            ingredients.Add((Ingredient)"salsiccia");
            ingredients.Add((Ingredient)"patate");
            _dishes.Add(new Dish("Salsiccia al forno con patate", 436, 24.28, 12.67, 0, ingredients));

            _profiles = new HashSet<UserProfile>();
            PersonalDetails details = new PersonalDetails("Pippo", "Giovannini", new DateTime(1994, 10, 11), 120, 178, Sex.MALE, 40, Load.LIGHT, 1, Load.LIGHT);
            List<Ingredient> preferences = new List<Ingredient>();
            preferences.Add((Ingredient)"pasta");
            preferences.Add((Ingredient)"maiale");
            preferences.Add((Ingredient)"pane");
            _profiles.Add(new UserProfile(preferences,DietCalculators.Goal.WEIGHT_LOSS, null, details));

            // TODO: manca version
        }

        public ISet<Dish> LoadDishes()
        {
            return _dishes;
        }

        internal static MockPersistence GetInstance()
        {
            return _persistence;            
        }

        public ISet<Ingredient> LoadIngredients()
        {            
            return _ingredients;
        }

        public ISet<UserProfile> LoadProfiles()
        {
            return _profiles;
        }

        public Version LoadVersion()
        {
            return _version;
        }

        public void SaveProfiles()
        {
            // NOP
        }

        public void SaveVersion()
        {
            // NOP
        }
    }
}
