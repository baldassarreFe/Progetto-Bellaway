using System.Collections.Generic;
using BeautifulWeight.DietCalculators;
using BeautifulWeight.Kitchen;
using BeautifulWeight.Users;
using BeautifulWeight.Versions;
using DateTime = System.DateTime;
using System.Xml;
using BeautifulWeight.Menu;

namespace BeautifulWeight.Persistence.Xml
{
    class XmlPersistence : UserProfilePersistor, KitchenPersistor, VersionPersistor
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
            LoadIngredientsFromXml("../../Resources/Ingredients.xml");

            _dishes = new HashSet<Dish>();
            LoadDishesFromXml("../../Resources/Dishes.xml");

            _profiles = new List<UserProfile>();
            LoadProfilesFromXml("../../Resources/Users.xml");
        }

        private void LoadProfilesFromXml(string filename)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(filename);
            XmlNodeList usersNodes = xml.SelectNodes("/users/user");

            foreach (XmlElement userNode in usersNodes)
            {
                UserProfile up = new UserProfile();
                PersonalDetails pd = new PersonalDetails();
                foreach(XmlElement detail in userNode.SelectNodes("/personaldetails/*"))
                {
                    var propertyInfo = pd.GetType().GetProperty(detail.LocalName);
                    if (propertyInfo != null)
                    {
                        propertyInfo.SetValue(pd, System.Convert.ChangeType(detail.InnerText, propertyInfo.PropertyType));
                    }
                }
                up.Details = pd;

                up.Goal = (Goal) System.Enum.Parse(typeof(Goal), userNode.SelectSingleNode("/goal").InnerText, true);

                List<Ingredient> preferences = new List<Ingredient>();
                foreach (XmlElement ingredientNode in userNode.SelectNodes("/preferences/ingredient"))
                {
                    preferences.Add(ingredientNode.InnerText);
                }
                up.Preferences = preferences;

                WeeklyMenu wm = new WeeklyMenu(userNode.SelectSingleNode("/menu").Attributes["dietCalculator"].InnerText);
                foreach (XmlElement dayNode in userNode.SelectNodes("/menu/day"))
                {
                    preferences.Add(dayNode.InnerText);
                    DailyMenu dm = wm[(System.DayOfWeek)System.Enum.Parse(typeof(System.DayOfWeek), dayNode.Attributes["day"].InnerText, true)];
                    foreach(XmlElement mealNode in dayNode.SelectNodes("/meal"))
                    {

                        string name = mealNode.Attributes["name"].InnerText;
                        string hour = mealNode.Attributes["hour"].InnerText;
                        string minute = mealNode.Attributes["minute"].InnerText;
                        DateTime time = new DateTime(2000,1,1,int.Parse(hour),int.Parse(minute),0);
                        List<Serving> servings = new List<Serving>();

                        foreach(XmlElement servingNode in mealNode.SelectNodes("/serving"))
                        {
                            Dish dish = null;
                            // una ricerca migliore??
                            foreach (Dish d in _dishes)
                            {
                                if (d.Name == servingNode.Attributes["quantity"].InnerText)
                                {
                                    dish = d;
                                    break;
                                }
                            }
                            int quantity = int.Parse(servingNode.Attributes["quantity"].InnerText);
                            servings.Add(new Serving(dish, quantity));
                        }

                        NonEmptyList<Serving> nonEmpty = new NonEmptyList<Serving>(servings[0]);
                        for (int i = 1; i < servings.Count; i++)
                        {
                            nonEmpty.Add(servings[i]);
                        }
                        dm.Meals.Add(new Meal(name, time, nonEmpty));
                    }
                }
                up.Diet = wm;

                _profiles.Add(up);
            }
        }

        private void LoadIngredientsFromXml(string filename)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(filename);
            XmlNodeList ingredientNodes = xml.SelectNodes("/ingredients/ingredient");

            foreach (XmlElement ingredientNode in ingredientNodes)
            {
                string name = ingredientNode.InnerText;
                _ingredients.Add(name);
            }
        }

        private void LoadDishesFromXml(string filename)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(filename);
            XmlNodeList dishesNodes = xml.SelectNodes("/dishes/dish");

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
