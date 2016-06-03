using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Persistence
{

    public interface Persistor
    {
    }

    public static class PersistenceManager
    {
        private static List<Persistor> _persistors;

        static PersistenceManager() {
            _persistors = new List<Persistor>();
            _persistors.Add(MockPersistence.GetInstance());
        }

        public static T getPersistenceManager<T>() where T:Persistor
        {
            IEnumerable<T> result = _persistors.OfType<T>();
            return (T)result.FirstOrDefault();
        }
    }
}
