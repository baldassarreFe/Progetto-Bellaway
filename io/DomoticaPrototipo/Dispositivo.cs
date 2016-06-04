using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    public class Dispositivo : IDispositivo
    {
        private string _nome;
        private string _tipo;
        private string _produttore;
        private string _seriale;
        private int _consumo;
      

        private string _alias="";
        private string _descrizione="";
        private string _posizione="";

        private List<IFunzionalita> _funzionalita= new List<IFunzionalita>();
        private List<IStatus> _stati= new List<IStatus>();

        //Prototipo
        private bool _collegato=false;

        public Dispositivo(IDispositivoRemoto dispositivoRemoto)
        {
            _nome = dispositivoRemoto.Nome;
            _tipo = dispositivoRemoto.Tipo;
            _consumo = dispositivoRemoto.Consumo;
            _seriale = dispositivoRemoto.Seriale;
            _produttore = dispositivoRemoto.Produttore;
            _stati=dispositivoRemoto.Stati;
            _funzionalita=dispositivoRemoto.Funzionalita;
            _alias=_nome;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }
        public string Posizione
        {
            get { return _posizione; }
            set { _posizione = value; }
        }
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string Produttore
        {
            get { return _produttore; }
            set { _produttore = value; }
        }

        public string Seriale
        {
            get { return _seriale; }
            set { _seriale = value; }
        }

        public int Consumo
        {
            get { return _consumo; }
            set { _consumo = value; }
        }

        public List<IFunzionalita> Funzionalita
        {
            get {return _funzionalita;}
            set { _funzionalita = value; }
        }

        public List<IStatus> Stati
        {
            get { return _stati; }
            set { _stati  = value; }
        }

        public override string ToString()
        {
            return _alias;
        }

        public bool IsCollegato()
        {
            //Comportamento prototipo
            return _collegato;
        }
        //Comportamento Prototipo...
        public bool Collegato
        {
            get { return _collegato; }
            set { _collegato = value; }
        }
    }
    
}
