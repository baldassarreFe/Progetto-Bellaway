using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    class FunzionalitaAlzaAbbassa : Funzionalita
    {
        public FunzionalitaAlzaAbbassa()
        {
            _parametri = new List<Parametro>();
            _label = "Alza/Abbassa";
            Parametro param = new Parametro(TipoParametro.Void, null, false, "Abbassato");
            InformazioniInterfaccia infoInterfaccia = new InformazioniInterfaccia(VistaParametro.Button, "Alza");
            param.InfoInterfaccia = infoInterfaccia;
            _parametri.Add(param);
        }
        public override void Method()
        {
            //Teoricamente, significa che è stato premuto il bottone "Alza" o "Abbassa"
            if (_parametri[0].Nome.Equals("Abbassato"))
            {
                _parametri[0].Nome = "Alzato";
                _parametri[0].InfoInterfaccia.Etichetta = "Abbassa";
            }
            else
            {
                _parametri[0].Nome = "Abbassato";
                _parametri[0].InfoInterfaccia.Etichetta = "Alza";
            }
        }
    }
}
