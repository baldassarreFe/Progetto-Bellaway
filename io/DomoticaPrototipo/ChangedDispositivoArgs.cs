using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    public class ChangedDispositivoArgs:EventArgs
    {
        private readonly IDispositivoRemoto _dispositivo;
        private readonly string _changeType;
        public ChangedDispositivoArgs(IDispositivoRemoto dispositivo, string changeType)
        {
            _dispositivo = dispositivo;
            _changeType = changeType;
        }
        public IDispositivoRemoto Dispositivo
        {
            get { return _dispositivo; }
        }
        public string ChangeType
        {
            get { return _changeType; }
        }

    }
}
