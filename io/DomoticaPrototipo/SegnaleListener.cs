using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DomoticaPrototipo
{
    public class SegnaleListener
    {
        public event EventHandler<SegnaleArgs> Segnalato;
        
        public void OnTimedEvent(object sender, EventArgs args)
        {
            //Testing
            Segnalato(this,new SegnaleArgs("Attenzione! Errore circuito",DispositiviRepository.GetInstance().Dispositivi[0]));
            ((Timer)sender).Enabled = false;
        }
    }
}
