using BeautifulWeight.Persistence.Xml;
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

    public static class PersistenceProvider
    {
        private static List<Persistor> _persistors;

        static PersistenceProvider() {
            _persistors = new List<Persistor>();
            _persistors.Add(new XmlPersistence());
        }

        public static T getPersistor<T>() where T:Persistor
        {
            IEnumerable<T> result = _persistors.OfType<T>();
            return (T)result.FirstOrDefault();
        }
    }
}
