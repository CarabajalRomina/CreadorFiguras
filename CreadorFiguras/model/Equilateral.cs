using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreadorFiguras.model
{
    internal class Equilateral: Triangle
    {
        double bse { get; set; }
        double surface { get; set; }
        double perimetro { get; set; }
        double heigth { get; set; }


        public Equilateral(double bse)
        {
            this.bse = bse;
            this.heigth = GetHeigth();
            this.surface = GetSurface();
            this.perimetro = GetPerimetro();
        }

        public override double GetHeigth()
        {
            return (Math.Sqrt(3) * bse) / 2;
        }

        public override double GetPerimetro()
        {
            return bse * 3;
        }

        public override double GetSurface()
        {
            return heigth * (bse / 2);
        }

        public override string GetFigura()
        {
            return " Triangulo Equilatero:" + "\n" + $"  Lado A, B y base = {bse}cm " + "\n" + $"   Perimetro = {perimetro.ToString("F1")}cm" + "\n" + $"   Superficie = {surface.ToString("F1")}cm^2" + "\n" + $"   Altura ={heigth.ToString("F1")}cm";

        }
    }
}

