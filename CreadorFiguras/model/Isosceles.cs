using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreadorFiguras.model
{
    internal class Isosceles: Triangle
    {
        double sideA { get; set; }
        double bse { get; set; }
        double heigth { get; set; }
        double perimetro { get; set; }
        double surface { get; set; }

        public Isosceles( double bse, double sideA)
        {
            this.sideA = sideA;
            this.bse = bse;
            this.heigth = GetHeigth();
            this.surface = GetSurface();
            this.perimetro = GetPerimetro();
           
        }

        public override double GetHeigth()
        {
            return Math.Sqrt(Math.Pow(sideA, 2) - (Math.Pow(bse/2, 2)));
        }

        public override double GetPerimetro()
        {
            return bse + sideA*2;
        }

        public override double GetSurface()
        {
            return bse * heigth/2;
        }

        public override string GetFigura()
        {
            return "Triangulo Isosceles:" + "\n" + $"   Base = {bse}cm" + "\n" + $"   Lados A Y B= {sideA}cm" + "\n" +  $"   Perimetro = {perimetro.ToString("F1")} cm" + "\n" + $"   Superficie = {surface.ToString("F1")} cm^2" + "\n" + $"   Altura = {heigth.ToString("F1")}cm";
        }
    }
}
