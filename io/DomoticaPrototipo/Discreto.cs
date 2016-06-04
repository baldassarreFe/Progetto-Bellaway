using System;
using System.Collections.Generic;

namespace DomoticaPrototipo
{
    public class Discreto : Parametro
    {
        private List<object> _validValues;
        public Discreto(TipoParametro tipo, object valore, bool opzionale, string nome, List<object> validValues)
            : base(tipo, valore, opzionale, nome)
        {
            _validValues = validValues;
        }
        public List<object> ValidValues
        {
            get { return _validValues; }
            set { _validValues = value; }
        }
    }
}
