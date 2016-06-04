using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    class FunzionalitaCuoci : Funzionalita
    {
        public FunzionalitaCuoci()
        {
            _parametri = new List<Parametro>();
            _label = "Cucina";
            Limitato param = new Limitato(TipoParametro.Int, 0, false, "Timer",0,30*60);
            //controllare l'aggiornamento del riferimento param.Status?
            InformazioniInterfaccia infoInterfaccia = new InformazioniInterfaccia(VistaParametro.TimerBox, "Timer");
            param.InfoInterfaccia = infoInterfaccia;
            _parametri.Add(param);
            List<object> validValues = new List<object>();
            validValues.Add(1);
            validValues.Add(2);
            validValues.Add(3);
            Discreto discreto = new Discreto(TipoParametro.Int, 1, false, "Potenza", validValues);
            infoInterfaccia = new InformazioniInterfaccia(VistaParametro.DropList, "Potenza");
            discreto.InfoInterfaccia = infoInterfaccia;
            _parametri.Add(discreto);
        }
        public override void Method()
        {
            //niente... credo
        }
    }
}
