using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DomoticaPrototipo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            UtentiRepository.GetInstance().Add(new Standard("Marco", "Marco Passerini", "password"));
            UtentiRepository.GetInstance().Add(new Standard("Federico", "Federico Gava", "password"));
            UtentiRepository.GetInstance().Add(new Standard("Jacopo", "Jacopo Ameli", "password"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogInDialog login = new LogInDialog();
            Application.Run(login);
            if (login.LoggedIn!=null)
             Application.Run(new MainForm(login.LoggedIn));
        }
    }
}
