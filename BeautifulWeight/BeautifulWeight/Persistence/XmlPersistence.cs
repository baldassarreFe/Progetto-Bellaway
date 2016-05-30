using System.Collections.Generic;
using BeautifulWeight.DietCalculators;
using BeautifulWeight.Kitchen;
using BeautifulWeight.Users;
using BeautifulWeight.Versions;
using DateTime = System.DateTime;
using System.Xml;

namespace BeautifulWeight.Persistence.Xml
{
    class XmlPersistence : UserProfileLoader, UserProfileSaver, KitchenLoader, VersionLoader, VersionSaver, DietLoader
    {
        private static XmlPersistence _persistence = new XmlPersistence();
        private ISet<UserProfile> _profiles;
        private ISet<Dish> _dishes;
        private ISet<Ingredient> _ingredients;
        private Version _version;

        private XmlPersistence()
        {
            _version = StandardVersion.GetInstance();

            _ingredients = new HashSet<Ingredient>();
            LoadIngredientsFromXml("Resources/Ingredients.xml");

            _dishes = new HashSet<Dish>();
            LoadDishesFromXml("Resources/Dishes.xml");

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

        private void LoadDishesFromXml(string filename)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(filename);
            XmlNodeList ingredientNodes = xml.SelectNodes("/dishes/dish");

            foreach (XmlElement ingredientNode in ingredientNodes)
            {
                string name = ingredientNode.InnerText;
                _ingredients.Add(name);
            }
        }

        private void LoadIngredientsFromXml(string filename)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(filename);
            XmlNodeList dishesNodes = xml.SelectNodes("/ingredients/ingredient");

            foreach (XmlElement dishNode in dishesNodes)
            {
                string name = dishNode.Attributes["name"].Value;
                double carbohydrates = XmlConvert.ToDouble(dishNode.Attributes["carbohydrates"].Value);
                double calories = XmlConvert.ToDouble(dishNode.Attributes["calories"].Value);
                double proteins = XmlConvert.ToDouble(dishNode.Attributes["proteins"].Value);
                double fats = XmlConvert.ToDouble(dishNode.Attributes["fats"].Value);

                XmlNodeList ingredientNodes = dishNode.SelectNodes("/ingredient");
                List<Ingredient> ingredients = new List<Ingredient>();
                foreach (XmlElement ingredientNode in ingredientNodes)
                {
                    Ingredient ingredient = ingredientNode.InnerText;
                    ingredients.Add(name);
                }
                NonEmptyList<Ingredient> nonEmpty = new NonEmptyList<Ingredient>(ingredients[0]);
                for (int i = 1; i < ingredients.Count; i++)
                {
                    nonEmpty.Add(ingredients[i]);
                }

                _dishes.Add(new Dish(name, calories, proteins, fats, carbohydrates, nonEmpty));
            }
        }

        public ISet<Dish> LoadDishes()
        {
            return _dishes;
        }

        internal static XmlPersistence GetInstance()
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
