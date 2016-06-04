using System;
using System.Collections.Generic;


namespace DomoticaPrototipo
{
    public class Parametro
    {
        private TipoParametro _tipo;
        private object _valore;
        private bool _opzionale;
        private string _nome;
        private InformazioniInterfaccia _infoInterfaccia;
        private IStatus _status;

        public Parametro(TipoParametro tipo, object valore, bool opzionale, string nome)
        {
            _tipo = tipo;
            _valore = valore;
            _opzionale = opzionale;
            _nome = nome;
        }

        public InformazioniInterfaccia InfoInterfaccia
        {
            get { return _infoInterfaccia; }
            set { _infoInterfaccia = value; }
        }

        public IStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public TipoParametro Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public object Valore
        {
            get { return _valore; }
            set { _valore = value; }
        }

        public bool Opzionale
        {
            get { return _opzionale; }
            set { _opzionale = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
