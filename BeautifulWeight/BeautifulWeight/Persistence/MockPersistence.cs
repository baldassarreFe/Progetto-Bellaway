using BeautifulWeight.Versions;

namespace BeautifulWeight.Persistence.Xml
{
    public class MockPersistence : VersionPersistor
    {
        private Version _version;

        public MockPersistence()
        {
            _version = new StandardVersion();
        }

        public Versions.Version LoadVersion()
        {
            return _version;
        }

        public void SaveVersion(Versions.Version version)
        {
            // NOP
        }
    }
}
