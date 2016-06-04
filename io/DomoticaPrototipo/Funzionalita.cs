using System;
using System.Collections.Generic;


namespace DomoticaPrototipo
{
    class Funzionalita : IFunzionalita
    {
        protected string _label;
        protected List<Parametro> _parametri;
        public virtual void Method()
        {
        }
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        public List<Parametro> Parametri
        {
            get { return _parametri; }
            set { _parametri = value; }
        }
    }
}
