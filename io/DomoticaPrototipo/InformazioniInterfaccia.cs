using System;
using System.Collections.Generic;


namespace DomoticaPrototipo
{
    public class InformazioniInterfaccia
    {
        private VistaParametro _tipo;
        private string _etichetta;

        public InformazioniInterfaccia(VistaParametro tipo, string etichetta)
        {
            _tipo = tipo;
            _etichetta = etichetta;
        }

        public VistaParametro Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string Etichetta
        {
            get { return _etichetta; }
            set { _etichetta = value; }
        }
    }
}
