using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    class Calendario
    {
        private readonly List<Azione> _azioni;

        private static Calendario _instance;

        public event EventHandler Changed;

        private Calendario()
        {
            _azioni = new List<Azione>();
        }
        public static Calendario GetInstance()
        {
            if (_instance == null)
                _instance = new Calendario();
            return _instance;
        }
        public void ProgrammaAzione(Azione azione)
        {
            if(DateTime.Compare(azione.DateTime,DateTime.Now)>0)//controllo già avvenuto, in teoria....
                 _azioni.Add(azione);
            OnChanged();
        }
        public void ProgrammaAzioneSettimanale(AzioneSettimanale azione)
        {
            DateTime date = DateTime.Now;
            DateTime dt = new DateTime(date.Year, date.Month, date.Day, azione.DateTime.Hour, azione.DateTime.Minute, azione.DateTime.Second);
            azione.DateTime = dt;
            while (!azione.DateTime.DayOfWeek.Equals(azione.Giorno) )
            {
                //Devo Cambiare la componente data.
                azione.DateTime = azione.DateTime.AddDays(1);
            }
            for (int i = 0; i < 5; i++)
            {
                _azioni.Add(azione);
                azione = new AzioneSettimanale(azione.DateTime.AddDays(7), azione.Utente, azione.Dispositivo, azione.Funzionalita, azione.Giorno);
            }
            OnChanged();
        }
        public void RimuoviAzione(Azione azione)
        {
            _azioni.Remove(azione);
            OnChanged();
        }

        protected void OnChanged()
        {
            if (Changed!=null)
             Changed(this, null);
        }
        public List<Azione> Azioni
        {
            get { return _azioni; }
        }
        public List<AzioneSettimanale> AzioniSettimanali
        {
            get
            {
                List<AzioneSettimanale> result = new List<AzioneSettimanale>();
                foreach (Azione a in _azioni)
                    if (a is AzioneSettimanale)
                        result.Add((AzioneSettimanale)a);
                return result;
            }
        }
        public void Load(ICalendarioPersister persister)
        {
            foreach (Azione a in persister.GetLoader().LoadAzioni())
                _azioni.Add(a);
        }
        public void Save(ICalendarioPersister persister)
        {
            persister.Save();
        }

        public List<Azione> Search(DateTime date, IDispositivo dispositivo, String tipo)
        {
            if (dispositivo != null && tipo != null && !dispositivo.Tipo.Equals(tipo))
            {
                throw new ArgumentException("Dispositivo e tipo dispositivo non compatibili");
            }

            List<Azione> res = new List<Azione>();

            foreach (Azione a in _azioni)
            {
                if (CheckDate(a, date) && CheckDispositivo(a, dispositivo) && CheckTipo(a, tipo))
                {
                    Console.Out.Write(a.Funzionalita+" - ");
                    

                    res.Add(a);
                }
            }

            return res;
        }

        private bool CheckDate(Azione azione, DateTime date)
        {
            return date == null || azione.DateTime.Date.Equals(date.Date);
        }

        private bool CheckDispositivo(Azione azione, IDispositivo dispositivo)
        {
            return dispositivo == null || azione.Dispositivo.Equals(dispositivo);
        }

        private bool CheckTipo(Azione azione, String tipo)
        {
            return tipo == null || azione.Dispositivo.Tipo.Equals(tipo);
        }
    }
}
