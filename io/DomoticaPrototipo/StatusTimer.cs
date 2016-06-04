using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    class StatusTimer:Status
    {
        public StatusTimer(int intervalloAggiornamento,Parametro parametro)
        {
            _intervalloAggiornamento = intervalloAggiornamento;
            _parametro = parametro;
        }
        public override void GetStatus()
        {
            if((int)_parametro.Valore>0)
                _parametro.Valore = ((int)_parametro.Valore) - 1;
        }
       public override void OnTimedEvent (object sender, EventArgs args)
        {
            GetStatus();
        }
    }
}
