using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomoticaPrototipo
{
    public interface IFunzionalita
    {
         void Method();
         string Label{get;set;}
        List<Parametro> Parametri{get;set;}
    }
}
