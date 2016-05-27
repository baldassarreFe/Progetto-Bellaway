using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using BeautifulWeight.Persistence;

namespace BeautifulWeight.Versions
{
    class VersionManager
    {
        private IEnumerable<Version> _allVersions;
        private static VersionManager _instance;
        private Version _version;
        public event EventHandler VersionChanged;

        internal Version CurrentVersion
        {
            get
            {
                if (_version == null)
                    _version = PersistenceManager.getPersistenceManager<VersionLoader>().LoadVersion();
                return _version;
            }

            private set
            {
                _version = value;
                if (VersionChanged != null)
                    VersionChanged(this, EventArgs.Empty);
            }
        }

        IEnumerable<Version> AllVersions
        {
            get
            {
                if (_allVersions != null)
                    return _allVersions;

                //_allVersions = new List<Version>();
                //foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
                //{
                //    if (typeof(Version).IsAssignableFrom(t))
                //        _allVersions.Add((Version)t.GetMethod("GetInstance").Invoke(null, null));
                //}

                _allVersions = from type in Assembly.GetExecutingAssembly().GetTypes()
                               where typeof(Version).IsAssignableFrom(type)
                               select (Version)type.GetMethod("GetInstance").Invoke(null, null);
                return _allVersions;
            }
        }

        public bool Allows(Feature feature)
        {
            return _version.Allows(feature);
        }

        public void ChangeVersion(Version version, Code code)
        {
            if (version.IsCodeValid(code))
                CurrentVersion = version;
        }

        public static VersionManager GetInstance()
        {
            if (_instance == null)
                _instance = new VersionManager();
            return _instance;
        }

    }

    public struct Code
    {
        private readonly string campo1;
        private readonly string campo2;
        private readonly string campo3;
        private readonly string campo4;

        public Code(string campo1, string campo2, string campo3, string campo4)
        {
            // TODO controllo parametri
            this.campo1 = campo1;
            this.campo2 = campo2;
            this.campo3 = campo3;
            this.campo4 = campo4;
        }

        public string Campo1
        {
            get
            {
                return campo1;
            }
        }

        public string Campo2
        {
            get
            {
                return campo2;
            }
        }

        public string Campo3
        {
            get
            {
                return campo3;
            }
        }

        public string Campo4
        {
            get
            {
                return campo4;
            }
        }
    }

}
