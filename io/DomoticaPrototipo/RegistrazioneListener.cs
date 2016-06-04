using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DomoticaPrototipo
{
    public class RegistrazioneListener
    {
        public event EventHandler<ChangedDispositivoArgs> Registrazione;
        
        public void OnTimedEvent(object sender, EventArgs args)
        {
            DispositivoRemoto remote = new DispositivoRemoto("TempoTest12","Tapparella",100,"temptest231","TempoTest");
            remote.Funzionalita.Add(new FunzionalitaAlzaAbbassa());
            remote.Stati.Add(new StatusAlzaAbbassa(5, remote.Funzionalita[0].Parametri[0]));
           
            Registrazione(this,new ChangedDispositivoArgs(remote,"add"));
            ((Timer)sender).Enabled = false;
        }
    }
}
