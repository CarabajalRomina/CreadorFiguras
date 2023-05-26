using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreadorFiguras.interfaces
{
    internal interface IController
    {
        public static abstract IController GetController();
    }
}
