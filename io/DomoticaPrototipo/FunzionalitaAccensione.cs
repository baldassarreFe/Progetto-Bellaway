using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    class FunzionalitaAccensione : Funzionalita
    {
        public FunzionalitaAccensione()
        {
            _parametri = new List<Parametro>();
            _label = "Accensione";
            Parametro param = new Parametro(TipoParametro.Boolean, false, false, "Acceso");
            StatusAccensione status = new StatusAccensione(5, param);
            //controllare l'aggiornamento del riferimento param.Status?
            param.Status = status;
            InformazioniInterfaccia infoInterfaccia = new InformazioniInterfaccia(VistaParametro.CheckBox, "Acceso");
            param.InfoInterfaccia = infoInterfaccia;
            _parametri.Add(param);
        }
        public override void Method()
        {
            //niente, i valori sono aggiornati in locale dal control
        }
    }
}
