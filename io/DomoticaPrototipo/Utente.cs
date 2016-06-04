using System;
using System.Collections.Generic;


namespace DomoticaPrototipo
{
    public abstract class Utente
    {
        protected string _username;
        protected string _password;
        protected string _nome;

        protected Utente(string username,string nome,string password)
        {
            _username = username;
            _nome = nome;
            _password = password;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public void setPassword(string oldPassword, string newPassword)
        {
            if (isPassword(oldPassword))
                _password = newPassword;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public bool isPassword(string password)
        {
            return password.Equals(_password);
        }
    }
}
