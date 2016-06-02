using BeautifulWeight.Model;
using BeautifulWeight.Versions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Model
{

    public interface Manager
    {
    }

    public static class ManagerProvider
    {
        private static List<Manager> _managers;

        static ManagerProvider() {
            _managers = new List<Manager>();
            _managers.Add(new KitchenManager());
            _managers.Add(new UserProfileManager());
            _managers.Add(new VersionManager());
            _managers.Add(new TargetWeightFormulaManager());
        }

        public static T getModelManager<T>() where T:Manager
        {
            IEnumerable<T> result = _managers.OfType<T>();
            return (T)result.FirstOrDefault();
        }
    }
}
