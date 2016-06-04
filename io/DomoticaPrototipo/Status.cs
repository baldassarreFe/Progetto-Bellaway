using System;
using System.Collections.Generic;


namespace DomoticaPrototipo
{
    public class Status :IStatus
    {
        protected int _intervalloAggiornamento;
        protected  Parametro _parametro;
     
        public int IntervalloAggiornamento
        {
            get { return _intervalloAggiornamento; }
            set { _intervalloAggiornamento = value; }
        }
        public Parametro Parametro
        {
            get { return _parametro; }
            set { _parametro = value; }
        }
        public virtual void GetStatus()
        {
            //Dummy
            //Teoricamente, richiede lo stato al dispositivo remoto e aggiorna il valore di parametro
        }
        public virtual void OnTimedEvent(object sender, EventArgs args)
        {
           //Dummy
        }

    }
}
