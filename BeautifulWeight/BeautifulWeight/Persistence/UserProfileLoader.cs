using BeautifulWeight.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Persistence
{
    interface UserProfileLoader : Persistor
    {
        ISet<UserProfile> LoadProfiles();
    }
}
