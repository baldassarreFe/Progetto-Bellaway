using BeautifulWeight.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.DietCalculators
{
    interface DietCalculator
    {
        string Description { get; }
        WeeklyMenu NewMenu();
        Serving GetEquivalent(Serving serving);
    }
}
