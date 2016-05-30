using BeautifulWeight.DietCalculators;
using System.Collections.Generic;

namespace BeautifulWeight.Persistence
{
    public interface DietPersistor
    {
        ISet<DietCalculator> loadDiets();
    }
}