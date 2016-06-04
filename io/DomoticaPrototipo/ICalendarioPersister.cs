using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    public interface ICalendarioPersister
    {
         ICalendarioLoader GetLoader();
         void Save();
    }
}
