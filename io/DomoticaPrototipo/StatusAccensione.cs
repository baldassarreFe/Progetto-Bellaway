using System;
using System.Collections.Generic;


namespace DomoticaPrototipo
{
    class StatusAccensione : Status
    {
        private Random _random=new Random();
        public StatusAccensione(int intervalloAggiornamento,Parametro parametro)
        {
            _intervalloAggiornamento = intervalloAggiornamento;
            _parametro = parametro;
        }
        public override void GetStatus()
        {
            if (_random.Next(2) == 1)
                _parametro.Valore = true;
            else
                _parametro.Valore = false;
        }
        private void OnTimedEvent(object sender, EventArgs args)
        {
            GetStatus();
        }
    }
}
