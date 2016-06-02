using BeautifulWeight.DietCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautifulWeight.Menu;
using BeautifulWeight.Persistence;

namespace BeautifilBeautifulWeight.DietCalculators
{
    public class PointDietCalculator : DietCalculator
    {
        private readonly KitchenPersistor kl;

        public PointDietCalculator()
        {
            kl = PersistenceManager.getPersistenceManager<KitchenPersistor>();
        }

        public string Description
        {
            get
            {
                return "Point diet";
            }
        }

        public Serving GetEquivalent(Serving serving)
        {
            Serving s = new Serving(kl.LoadDishes().First(), 100);
            return s; 
            // TODO da chi li prendo i piatti disponibili, ci vuole un service provider di applicazione
            // che mi dia il KitchenLoader giusto
        }

        public bool IsCompatibleWith(Goal goal)
        {
            switch (goal)
            {
                case Goal.DEFINITION: return true;
                case Goal.MAINTAINANCE: return true;
                default: return false;
            }
        }

        public WeeklyMenu NewMenu()
        {
            throw new NotImplementedException();
        }
    }
}
