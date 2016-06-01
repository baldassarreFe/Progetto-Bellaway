using BeautifulWeight.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Model
{
    interface TargetWeightFormula
    {
        double calculate(PersonalDetails pd);
    }
}
