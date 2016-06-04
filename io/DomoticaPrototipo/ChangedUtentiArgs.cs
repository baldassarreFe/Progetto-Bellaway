using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    class ChangedUtentiArgs:EventArgs
    {
        private readonly Utente _utente; 
        public ChangedUtentiArgs(Utente utente)
        {
            _utente = utente;
        }
        public Utente Utente
        {
            get { return _utente; }
        }

    }
}
