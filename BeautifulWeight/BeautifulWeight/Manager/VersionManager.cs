using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using BeautifulWeight.Persistence;
using BeautifulWeight.Model;

namespace BeautifulWeight.Versions
{
    class VersionManager : Manager
    {
        private IEnumerable<Version> _allVersions;
        private Version _version;
        public event EventHandler VersionChanged;

        public Version CurrentVersion
        {
            get
            {
                if (_version == null)
                    _version = PersistenceProvider.getPersistor<Persistence.VersionPersistor>().LoadVersion();
                return _version;
            }

            private set
            {
                _version = value;
                FireVersionChanged();
            }
        }

        private void FireVersionChanged()
        {
            if (VersionChanged != null)
                VersionChanged(this, EventArgs.Empty);
        }

        public IEnumerable<Version> AllVersions
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
                               where typeof(Version).IsAssignableFrom(type) && !type.IsAbstract
                               select (Version)Activator.CreateInstance(type);
                return _allVersions;
            }
        }

        public bool Allows(Feature feature)
        {
            return CurrentVersion.Allows(feature);
        }

        public bool ChangeVersion(Version version, Code code)
        {
            if (version.IsCodeValid(code))
            {
                CurrentVersion = version;
                return true;
            }
            else
                return false;
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
