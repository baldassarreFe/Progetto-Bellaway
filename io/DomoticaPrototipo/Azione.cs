using System;


namespace DomoticaPrototipo
{
    public class Azione
    {
        private DateTime _dateTime;
        private Utente _utente;
        private IDispositivo _dispositivo;
        private IFunzionalita _funzionalita;
        public Azione(DateTime dateTime, Utente utente, IDispositivo dispositivo, IFunzionalita funzionalita)
        {
            _dateTime = dateTime;
            _utente = utente;
            _dispositivo = dispositivo;
            _funzionalita = funzionalita;
        }

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }
        public Utente Utente
        {
            get { return _utente; }
            set { _utente = value; }
        }
        public IDispositivo Dispositivo
        {
            get { return _dispositivo; }
            set { _dispositivo = value; }
        }
        public IFunzionalita Funzionalita
        {
            get { return _funzionalita; }
            set { _funzionalita = value; }
        }
    }
}
