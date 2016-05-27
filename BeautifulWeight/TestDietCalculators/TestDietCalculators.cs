using BeautifulWeight.DietCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautifulWeight.Menu;

namespace BeautifilBeautifulWeight.DietCalculators
{
    class PointDietCalculator : DietCalculator
    {
        public override string Description
        {
            get
            {
                return "Point diet";
            }
        }

        public override Serving GetEquivalent(Serving serving)
        {
            Serving s = new Serving(null, 1);
            return s; 
            // TODO da chi li prendo i piatti disponibili, ci vuole un service provider di applicazione
            // che mi dia il KitchenLoader giusto
        }

        public override WeeklyMenu NewMenu()
        {
            throw new NotImplementedException();
        }
    }
}
