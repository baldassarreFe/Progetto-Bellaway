using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    public interface IDispositivo : IDispositivoRemoto
    {
        string Alias { get; set; }
        string Descrizione { get; set; }
        string Posizione { get; set; }
        bool IsCollegato();
    }
}
