using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    public interface IStatus
    {
         void GetStatus();
         int IntervalloAggiornamento{get;set;}
         Parametro Parametro{get;set;}
         void OnTimedEvent(object sender, EventArgs args);
        
    }
}
