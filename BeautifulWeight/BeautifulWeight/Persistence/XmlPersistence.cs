using System.Collections.Generic;
using BeautifulWeight.DietCalculators;
using BeautifulWeight.Kitchen;
using BeautifulWeight.Users;
using BeautifulWeight.Versions;
using DateTime = System.DateTime;
using System.Xml;

namespace BeautifulWeight.Persistence.Xml
{
    class XmlPersistence : UserProfilePersistor, KitchenPersistor, VersionPersistor, DietPersistor
    {
        private static XmlPersistence _persistence = new XmlPersistence();
        private IList<UserProfile> _profiles;
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

            _profiles = new List<UserProfile>();
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

        public IList<UserProfile> LoadProfiles()
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
