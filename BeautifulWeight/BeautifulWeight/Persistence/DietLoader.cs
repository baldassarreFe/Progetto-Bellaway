using BeautifulWeight.DietCalculators;
using System.Collections.Generic;

namespace BeautifulWeight.Persistence
{
    internal interface DietLoader
    {
        ISet<DietCalculator> loadDiets();
    }
}