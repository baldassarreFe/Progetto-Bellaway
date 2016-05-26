using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Version
{
    class VersionManager
    {
        private Version _version;
        public bool Allows(Feature feature)
        {
            return _version.Allows(feature);
        }

        
        private abstract partial class Version
        {
            public abstract string Description { get; }
            public abstract bool Allows(Feature feature);
        }
    }

}
