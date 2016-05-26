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

        public override string Description
        {
            get
            {
                return "Point Diet";
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
