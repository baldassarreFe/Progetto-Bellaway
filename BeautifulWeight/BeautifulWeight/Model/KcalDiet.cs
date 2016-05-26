using BeautifulWeight.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.DietCalculators
{
    class KcalDiet : DietCalculator
    {
        public KcalDiet()
        {

        }

        public override string Description
        {
            get
            {
                return "Kcal Diet";
            }
        }

        public override Serving GetEquivalent(Serving serving)
        {
            throw new NotImplementedException();
        }

        public override WeeklyMenu NewMenu()
        {
            throw new NotImplementedException();
        }
    }
}
