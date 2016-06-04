using System;
using System.Collections.Generic;


namespace DomoticaPrototipo
{
    public class Standard : Utente
    {
        public Standard(string username,string nome,string password) : base(username,nome,password)
        {  }

        public void setPasswordAdmin(string adminUsername,string adminPassword, string newPassword)
        {
            if (UtentiRepository.GetInstance().Login(adminUsername, adminPassword) is Amministratore)
                _password = newPassword;
        }
    }
}
