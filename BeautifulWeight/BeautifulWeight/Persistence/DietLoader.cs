using BeautifulWeight.DietCalculators;
using System.Collections.Generic;

namespace BeautifulWeight.Persistence
{
    public interface DietLoader
    {
        ISet<DietCalculator> loadDiets();
    }
}