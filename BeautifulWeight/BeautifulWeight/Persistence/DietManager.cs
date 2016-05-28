using BeautifulWeight.DietCalculators;
using System.Collections.Generic;

namespace BeautifulWeight.Persistence
{
    public interface DietManager
    {
        ISet<DietCalculator> loadDiets();
    }
}