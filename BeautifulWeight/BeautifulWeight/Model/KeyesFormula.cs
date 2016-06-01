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
        public double calculate(PersonalDetails pd)
        {
            double height_m = pd.Height * 1.0 / 100;
            double factor = Math.Pow(height_m, 2);
            double mul = (pd.Sex == Sex.MALE) ? 22.1 : 20.6;
            return factor * mul;
        }
    }
}
