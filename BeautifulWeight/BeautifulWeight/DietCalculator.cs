using BeautifulWeight.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.DietCalculators
{
    abstract class DietCalculator
    {
        public abstract string Description { get; }
        public abstract WeeklyMenu NewMenu();
        public abstract Serving GetEquivalent(Serving serving);
    }
}
