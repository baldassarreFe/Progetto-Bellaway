using System;
using System.Collections.Generic;


namespace DomoticaPrototipo
{
    public interface ICalendarioLoader
    {
         List<Azione> LoadAzioni();
    }
}
