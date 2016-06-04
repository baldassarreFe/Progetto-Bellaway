using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomoticaPrototipo
{
    public class Limitato : Parametro
    {
        private IComparable _min;
        private IComparable _max;

        public Limitato(TipoParametro tipo, object valore, bool opzionale, string nome, IComparable min, IComparable max)
            : base(tipo, valore, opzionale, nome)
        {
            _min = min;
            _max = max;
        }

        public IComparable Min
        {
            get { return _min; }
            set { _min = value; }
        }

        public IComparable Max
        {
            get { return _max; }
            set { _max = value; }
        }
    }
}
