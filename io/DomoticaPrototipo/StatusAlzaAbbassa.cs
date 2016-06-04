using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    class StatusAlzaAbbassa : Status
    {
        public StatusAlzaAbbassa(int intervalloAggiornamento,Parametro parametro)
        {
            _intervalloAggiornamento = intervalloAggiornamento;
            _parametro = parametro;
        }
        public override void GetStatus()
        {
            //Teoricamente il sistema interpreta il parametro void e ricava il nome
        }
       public override void OnTimedEvent (object sender, EventArgs args)
        {
            GetStatus();
        }
    }
}
