using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Versions
{
    public abstract class Version : IComparable<Version>
    {
        private int _numericId;
        public abstract string Description { get; }
        public abstract bool Allows(Feature feature);
        public abstract bool IsCodeValid(Code code);

        protected Version(int numericId)
        {
            this._numericId = numericId;
        }

        public int CompareTo(Version v)
        {
            return this._numericId - v._numericId;
        }

    }

    class StandardVersion : Version
    {
        private static Version _instance;
        private StandardVersion() : base(0) { }

        public static Version GetInstance()
        {
            if (_instance == null)
                _instance = new StandardVersion();
            return _instance;
        }

        override public string Description
        {
            get
            {
                return "StandardVersion";
            }
        }

        override public bool Allows(Feature feature)
        {
            return false;
        }

        override public bool IsCodeValid(Code code)
        {
            return true;
        }
    }

    class PremiumVersion : Version
    {
        private static Version _instance;
        private PremiumVersion() : base(1000) { }

        public static Version GetInstance()
        {
            if (_instance == null)
                _instance = new PremiumVersion();
            return _instance;
        }

        override public string Description
        {
            get
            {
                return "PremiumVersion";
            }
        }

        override public bool Allows(Feature feature)
        {
            return true;
        }

        override public bool IsCodeValid(Code code)
        {
            throw new NotImplementedException();
        }
    }

    public enum Feature
    {
        ADD_USER, CHANGE_GOAL, CHANGE_PREFERENCES, CHANGE_SERVING, VIEW_NEXT_MEAL
    }
}
