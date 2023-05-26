using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreadorFiguras.model
{
    internal class Scalene: Triangle
    {
        double sideA { get; set; }
        double sideB { get; set; }
        double bse { get; set; }
        double perimetro { get; set; }
        double surface { get; set; }
        double heigth { get; set; }
        double semiPerimetro { get; set; }

        public Scalene(double sideA, double sideB, double bse)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.bse = bse;
            this.perimetro = GetPerimetro();
            this.surface = GetSurface();
            this.heigth = GetHeigth();
            this.semiPerimetro = calculateSemiPerimetro();

        }

        public override double GetHeigth()
        {
            return (2 * Math.Sqrt(semiPerimetro * (semiPerimetro - bse) * (semiPerimetro - sideA) * (semiPerimetro - sideB)) / bse);
        }

        public override double GetPerimetro()
        {
            return sideA + sideB + bse;
        }

        public override double GetSurface()
        {
            return bse * heigth / 2;
        }

        public override string GetFigura()
        {
            return "Triangulo Escaleno:" + "\n" +  $"   Base = {bse}cm" + "\n" + $"   Lado A = {sideA}cm" + "\n" + $"   Lado B = {sideB}cm" + "\n" + $"   Perimetro = {perimetro.ToString("F1")}cm" + "\n" + $"   Superficie = {surface.ToString("F1")}cm^2" + "\n" + $"   Altura = {heigth.ToString("F1")}cm";
        }

        private double calculateSemiPerimetro()
        {
            return (bse + sideA + sideB) / 2;
        }
    }
}
