using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    public class SegnaleArgs:EventArgs
    {
        private readonly string _message;
        private readonly IDispositivoRemoto _dispositivo;
        public SegnaleArgs(string message, IDispositivoRemoto dispositivo)
        {
            _message = message;
            _dispositivo = dispositivo;
        }
        public string Message
        {
            get { return _message; }
        }

        public IDispositivoRemoto Dispositivo
        {
            get { return _dispositivo; }
        }

    }
}
