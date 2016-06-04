using System;
using System.Collections.Generic;
using System.Xml;

namespace DomoticaPrototipo
{
    class CalendarioPersister:ICalendarioLoader,ICalendarioPersister,ICalendarioSaver
    {
        //Persister dummy, non utilizza xml
        //private readonly XmlDocument _xmlDocument;
        //private string _fileName;
        //private readonly XmlWriter _xmlWriter;
        public ICalendarioLoader GetLoader()
        {
            return this;
        }
        public void Save()
        {
            SaveCalendario();
        }
        public List<Azione> LoadAzioni()
        {
            //LoadAzione dummy
            List<Azione> result = new List<Azione>();
            DateTime date=DateTime.Now.AddDays(1);
            result.Add(new Azione(date,UtentiRepository.GetInstance().StandardList[0],DispositiviRepository.GetInstance().Dispositivi[0],DispositiviRepository.GetInstance().Dispositivi[0].Funzionalita[0]));
            date.AddDays(1);
            date.AddHours(12);
            result.Add(new Azione(date, UtentiRepository.GetInstance().StandardList[2], DispositiviRepository.GetInstance().Dispositivi[1], DispositiviRepository.GetInstance().Dispositivi[1].Funzionalita[0]));

            return result;
        }
        public void SaveCalendario()
        {
            //dummy!
        }
    }
}
