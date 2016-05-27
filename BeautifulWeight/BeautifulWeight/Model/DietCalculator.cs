using BeautifulWeight.Menu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.DietCalculators
{
    public abstract class DietCalculator
    {
        public abstract string Description { get; }
        public abstract WeeklyMenu NewMenu();
        public abstract Serving GetEquivalent(Serving serving);
    }

    public static class DietCalculatorLoader
    {
        private static IEnumerable<DietCalculator> _loadedDietCalculators;

        public static IEnumerable<DietCalculator> LoadedDietCalculators
        {
            get
            {
                if (_loadedDietCalculators == null)
                {
                    load();
                }
                return _loadedDietCalculators;
            }
        }

        private static void load()
        {
            // Check if user has access to requested .dll
            IEnumerable<String> dllFiles = Directory.EnumerateFiles("../Calculators", "*.dll");
            foreach (string dllFile in dllFiles)
            {
                Assembly DLL = Assembly.LoadFrom(dllFile);
                _loadedDietCalculators = from type in DLL.GetTypes()
                                         where typeof(DietCalculator).IsAssignableFrom(type)
                                         select (DietCalculator)Activator.CreateInstance(type);
            }
        }
    }
}
