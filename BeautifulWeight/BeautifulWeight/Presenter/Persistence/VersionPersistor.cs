using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Persistence
{
    public interface VersionPersistor : Persistor
    {
        Versions.Version LoadVersion();
        void SaveVersion();
    }
}
