using System;
using System.Collections.Generic;

namespace DomoticaPrototipo
{
    class UtentiRepository
    {
        private readonly List<Standard> _utenti;
        private readonly Amministratore _admin;

        private static UtentiRepository _instance;

        public event EventHandler<ChangedUtentiArgs> Changed;

        private UtentiRepository()
        {
            _utenti= new List<Standard>();
            _admin = new Amministratore("admin", "admin", "admin");
        }
        public static UtentiRepository GetInstance()
        {
            if (_instance == null)
                _instance = new UtentiRepository();
            return _instance;
        }
        public Utente Login(string username, string password)
        {
            foreach (Standard utente in _utenti)
                if (utente.Username.Equals(username) && utente.isPassword(password))
                    return utente;
            if (_admin.Nome.Equals(username) && _admin.isPassword(password))
                return _admin;
            return null;
        }
        public void Add(Standard utente)
        {
            _utenti.Add(utente);
          //  OnChanged(utente);
        }
        protected void OnChanged(Standard utente)
        {
         //   Changed(this, new ChangedUtentiArgs(utente));
        }
        public List<Standard> StandardList
        {
            get { return _utenti; }
        }
    }
}
