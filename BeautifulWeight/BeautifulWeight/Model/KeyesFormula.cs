using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautifulWeight.Users;

namespace BeautifulWeight.Model
{
    class KeyesFormula : TargetWeightFormula
    {
        public double calculate(Sex sex, int height_cm)
        {
            double height_m = height_cm * 1.0 / 100;
            double factor = Math.Pow(height_m, 2);
            double mul = (sex == Sex.MALE) ? 22.1 : 20.6;
            return factor * mul;
        }
    }
}
