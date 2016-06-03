using System;
using BeautifulWeight.Users;

namespace BeautifulWeight.Model
{
    class KeyesFormula : TargetWeightFormula
    {
        public string Description
        {
            get
            {
                return "Formula di Keyes";
            }
        }

        public double Calculate(PersonalDetails pd)
        {
            double height_m = pd.Height * 1.0 / 100;
            double factor = Math.Pow(height_m, 2);
            double mul = (pd.Sex == Sex.MALE) ? 22.1 : 20.6;
            return factor * mul;
        }
        
    }
}
