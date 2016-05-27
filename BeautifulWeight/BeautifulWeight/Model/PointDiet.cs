using BeautifulWeight.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.DietCalculators
{
    class PointDiet : DietCalculator
    {
        public PointDiet()
        {

        }

        public string Description
        {
            get
            {
                return "Point Diet";
            }
        }

        public Serving GetEquivalent(Serving serving)
        {
            // tornare un piatto equivalente a quello dato, considerando eventuali preferenze
            throw new NotImplementedException();
        }

        public WeeklyMenu NewMenu()
        {
            throw new NotImplementedException();
        }
    }
}
