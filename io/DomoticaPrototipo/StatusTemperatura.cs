using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    class StatusTemperatura:Status
    {
        private Random _random=new Random();
        public StatusTemperatura(int intervalloAggiornamento,Parametro parametro)
        {
            _intervalloAggiornamento = intervalloAggiornamento;
            _parametro = parametro;
        }
        public override void GetStatus()
        {
            //_parametro.Valore = _random.NextDouble()*50;
        }
        private void OnTimedEvent(object sender, EventArgs args)
        {
            GetStatus();
        }
    }
}
