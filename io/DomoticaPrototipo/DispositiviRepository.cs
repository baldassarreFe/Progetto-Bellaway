using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    class DispositiviRepository
    {
         private readonly List<IDispositivo> _dispositivi;

        private static DispositiviRepository _instance;

        public event EventHandler<ChangedDispositivoArgs> Changed;

        private DispositiviRepository()
        {
            _dispositivi = new List<IDispositivo>();
        }
        public static DispositiviRepository GetInstance()
        {
            if (_instance == null)
                _instance = new DispositiviRepository();
            return _instance;
        }
        public void ChangeCustomize(IDispositivo dispositivo, string newPosition, string newDescription, string newAlias)
        {
            foreach (IDispositivo i in _dispositivi)
                if (i.Equals(dispositivo))
                {
                    i.Posizione = newPosition;
                    i.Alias = newAlias;
                    i.Descrizione = newDescription;
                }
            OnChanged(dispositivo, "change");
        }
        protected void OnChanged(IDispositivo dispositivo, string changeType)
        {
            Changed(this, new ChangedDispositivoArgs(dispositivo, changeType));
        }
        public void Add(IDispositivo dispositivo)
        {
            _dispositivi.Add(dispositivo);
            OnChanged(dispositivo,"add");
        }
        
        public List<IDispositivo> Dispositivi
        {
            get { return _dispositivi; }
        }

        public List<string> getDeviceTypes()
        {
            List<string> res = new List<string>();

            foreach (IDispositivo d in Dispositivi)
            {
                bool exist = false;

                foreach (string t in res)
                {
                    exist = d.Tipo.Equals(t);
                }

                if (!exist)
                {
                    res.Add(d.Tipo);
                }
            }

            return res;
        }
    }
}
