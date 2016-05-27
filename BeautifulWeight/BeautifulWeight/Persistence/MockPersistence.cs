using System.Collections.Generic;
using BeautifulWeight.DietCalculators;
using BeautifulWeight.Kitchen;
using BeautifulWeight.Users;
using BeautifulWeight.Versions;
using DateTime = System.DateTime;

namespace BeautifulWeight.Persistence
{
    class MockPersistence : UserProfileLoader, UserProfileSaver, KitchenLoader, VersionLoader, VersionSaver, DietLoader
    {
        private static MockPersistence _persistence = new MockPersistence();
        private ISet<UserProfile> _profiles;
        private ISet<Dish> _dishes;
        private ISet<Ingredient> _ingredients;
        private Version _version;

        private MockPersistence()
        {
            _version = StandardVersion.GetInstance();

            _ingredients = new HashSet<Ingredient>();
            _ingredients.Add("nasello");
            _ingredients.Add("maiale");
            _ingredients.Add("pasta");
            _ingredients.Add("cipolla");
            _ingredients.Add("pomodorini");
            _ingredients.Add("ragù di carne");
            _ingredients.Add("pollo");
            _ingredients.Add("tacchino");
            _ingredients.Add("vitello");
            _ingredients.Add("maionese");
            _ingredients.Add("tonno");
            _ingredients.Add("capperi");
            _ingredients.Add("mozzarella");
            _ingredients.Add("salsiccia");
            _ingredients.Add("patate");
            _ingredients.Add("seppia");
            _ingredients.Add("calamaro");
            _ingredients.Add("gambero");
            _ingredients.Add("pane");
            _ingredients.Add("insalata");
            _ingredients.Add("pomodoro");
            _ingredients.Add("scamorza");
            _ingredients.Add("formaggio");
            _ingredients.Add("grana");
            _ingredients.Add("Cipolla");
            _ingredients.Add("Origano");
            _ingredients.Add("Paprica");
            _ingredients.Add("Prezzemolo");
            _ingredients.Add("Pastinaca");
            _ingredients.Add("Piselli");
            _ingredients.Add("Peperoni");
            _ingredients.Add("pimento");
            _ingredients.Add("fagioli");
            _ingredients.Add("pianta");
            _ingredients.Add("Patata");
            _ingredients.Add("Zucca");
            _ingredients.Add("radicchio");
            _ingredients.Add("Ravanello");
            _ingredients.Add("peperoncino");
            _ingredients.Add("rabarbaro");
            _ingredients.Add("Tuberi");
            _ingredients.Add("rosmarino");
            _ingredients.Add("rapa");
            _ingredients.Add("saggio");
            _ingredients.Add("Scalogno");
            _ingredients.Add("piselli");
            _ingredients.Add("soia");
            _ingredients.Add("zucca");
            _ingredients.Add("Spinaci");
            _ingredients.Add("Cipollotto");
            _ingredients.Add("Schiacciare");
            _ingredients.Add("zucche");
            _ingredients.Add("svedese");
            _ingredients.Add("Patata dolce");
            _ingredients.Add("Mais");
            _ingredients.Add("pepe");
            _ingredients.Add("Timo");
            _ingredients.Add("Pomodoro");
            _ingredients.Add("tuberi");
            _ingredients.Add("Rapa");
            _ingredients.Add("Rapa");
            _ingredients.Add("Wasabi");
            _ingredients.Add("Castagna");
            _ingredients.Add("Crescione");
            _ingredients.Add("ravanello bianco");
            _ingredients.Add("patata dolce");
            _ingredients.Add("Zucchine");


            _dishes = new HashSet<Dish>();
            NonEmptyList<Ingredient> ingredients = new NonEmptyList<Ingredient>("pasta");
            ingredients.Add("ragù di carne");
            _dishes.Add(new Dish("Pasta al ragù alla bolognese", 406, 15.43, 3.23, 76.61, ingredients));
            ingredients = new NonEmptyList<Ingredient>("nasello");
            ingredients.Add("cipolla");
            ingredients.Add("pomodorini");
            _dishes.Add(new Dish("Nasello alla cipolla con pomodorini", 234, 17.31, 1.52, 23.35, ingredients));
            ingredients = new NonEmptyList<Ingredient>("carne di maiale");
            _dishes.Add(new Dish("Braciola di maiale", 217, 24.28, 12.67, 0, ingredients));
            ingredients = new NonEmptyList<Ingredient>("gambero");
            ingredients.Add("pane");
            _dishes.Add(new Dish("Spiedini di gamberi", 217, 24.28, 12.67, 0, ingredients));
            ingredients = new NonEmptyList<Ingredient>("seppia");
            ingredients.Add("pane");
            _dishes.Add(new Dish("Spiedini di seppie", 217, 24.28, 12.67, 0, ingredients));
            ingredients = new NonEmptyList<Ingredient>("salsiccia");
            ingredients.Add("patate");
            _dishes.Add(new Dish("Salsiccia al forno con patate", 436, 24.28, 12.67, 0, ingredients));

            _profiles = new HashSet<UserProfile>();
            PersonalDetails details = new PersonalDetails("Pippo", "Labamba", new DateTime(1994, 10, 11), 120, 178, Sex.MALE, 40, Load.LIGHT, 1, Load.LIGHT);
            List<Ingredient> preferences = new List<Ingredient>();
            preferences.Add("pasta");
            preferences.Add("maiale");
            preferences.Add("pane");
            _profiles.Add(new UserProfile(preferences,DietCalculators.Goal.WEIGHT_LOSS, null, details));
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
            return null;
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

        public ISet<DietCalculator> loadDiets()
        {
            return null;
        }
    }
}
