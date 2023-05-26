using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreadorFiguras.interfaces;

namespace CreadorFiguras.model
{
    internal abstract class Triangle: IFiguras, IHeigth
    {
        public abstract double GetPerimetro();
        public abstract double GetSurface();
        public abstract double GetHeigth();
        public abstract string GetFigura();
    }
}
