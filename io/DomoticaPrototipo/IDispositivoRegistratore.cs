using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    public interface IDispositivoRegistratore
    {
        void Registra(IDispositivoRemoto dispositivo);
    }
}
