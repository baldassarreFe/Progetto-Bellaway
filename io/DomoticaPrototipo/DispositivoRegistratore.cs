using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    class DispositivoRegistratore : IDispositivoRegistratore
    {
        public void Registra(IDispositivoRemoto dispositivo)
        {
            Dispositivo disp = new Dispositivo(dispositivo);
            disp.Collegato = true;
            DispositiviRepository.GetInstance().Add(disp);
        }
        public void Registrazione(object sender, ChangedDispositivoArgs args)
        {
            Registra(args.Dispositivo);
        }
    }
}
