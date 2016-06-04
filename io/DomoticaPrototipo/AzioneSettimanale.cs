using System;
using System.Collections.Generic;


namespace DomoticaPrototipo
{
    class AzioneSettimanale:Azione
    {
        DayOfWeek _giorno;
        public AzioneSettimanale(DateTime dateTime, Utente utente, IDispositivo dispositivo, IFunzionalita funzionalita,DayOfWeek giorno)
            : base(dateTime,utente,dispositivo,funzionalita)
        {
            _giorno = giorno;
        }
        public DayOfWeek Giorno
        {
            get { return _giorno; }
            set { _giorno = value; }
        }
    }
}
