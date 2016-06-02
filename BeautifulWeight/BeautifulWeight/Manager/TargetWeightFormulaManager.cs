using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using BeautifulWeight.Persistence;
using BeautifulWeight.Model;

namespace BeautifulWeight.Versions
{
    class TargetWeightFormulaManager : Manager
    {
        private TargetWeightFormula _formula;

        public TargetWeightFormula Formula
        {
            get
            {
                if (_formula == null)
                    _formula = new KeyesFormula();
                return _formula;
            }
        }
    }
}
