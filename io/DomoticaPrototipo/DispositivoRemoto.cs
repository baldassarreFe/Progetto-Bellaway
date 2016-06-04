using System;
using System.Collections.Generic;


namespace DomoticaPrototipo
{
    public class DispositivoRemoto : IDispositivoRemoto
    {
        private string _nome;
        private string _tipo;
        private string _produttore;
        private string _seriale;
        private int _consumo;

        private List<IFunzionalita> _funzionalita=new List<IFunzionalita>();
        private List<IStatus> _stati = new List<IStatus>();

        public DispositivoRemoto(string nome, string tipo, int consumo,string seriale,string produttore)
        {
            _nome = nome;
            _tipo = tipo;
            _consumo = consumo;
            _seriale = seriale;
            _produttore = produttore;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
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
    }
}
