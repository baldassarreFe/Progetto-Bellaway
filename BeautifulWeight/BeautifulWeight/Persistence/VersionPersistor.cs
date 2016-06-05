using BeautifulWeight.Versions;

namespace BeautifulWeight.Persistence
{
    public interface VersionPersistor : Persistor
    {
        Version LoadVersion();
        void SaveVersion(Version version);
    }
}
