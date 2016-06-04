using System;
using System.Collections.Generic;


namespace DomoticaPrototipo
{
    public interface IDispositivoRemoto
    {
         string Nome { get; set; }
         string Tipo { get; set; }
         string Produttore { get; set; }
         string Seriale { get; set; }
         int Consumo { get; set; }
        List<IFunzionalita> Funzionalita
        {
            get;
            set;
        }

        List<IStatus> Stati
        {
            get;
            set;
        }
      

    }
}
