using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.DietCalculator
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
            
        }

        public override WeeklyMenu NewMenu()
        {
            
        }
    }
}
