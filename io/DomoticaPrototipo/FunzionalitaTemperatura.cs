using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    class FunzionalitaTemperatura:Funzionalita
    {
         public FunzionalitaTemperatura()
        {
            _parametri = new List<Parametro>();
            _label = "Accensione";
            Parametro param = new Parametro(TipoParametro.Double, 0, false, "Temperatura");
            //controllare l'aggiornamento del riferimento param.Status?
            param.Status = new StatusTemperatura(30,param);
            InformazioniInterfaccia infoInterfaccia = new InformazioniInterfaccia(VistaParametro.TextBox, "Temperatura");
            param.InfoInterfaccia = infoInterfaccia;
            _parametri.Add(param);
        }
        public override void Method()
        {
            //niente... credo
        }
    }
}
