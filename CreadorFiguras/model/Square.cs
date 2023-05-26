using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreadorFiguras.interfaces;

namespace CreadorFiguras.model
{
    internal class Square: IFiguras
    {
        double sides { get; set; }
        double perimetro { get; set; }
        double surface { get; set; }

        public Square(double sides)
        {
            this.sides = sides;
            perimetro = GetPerimetro();
            surface = GetSurface();
        }

        public string GetFigura()
        {
            return "Cuadrado:"+ "\n" + $" Tamaño de lados = {sides}cm" + "\n" + $" Perimetro = {perimetro}cm"+ "\n" + $" Superficie = {surface}cm^2";
        }

        public double GetPerimetro()
        {
            return sides * 4;
        }

        public double GetSurface()
        {
            return Math.Pow(sides, 2);
        }
    }
}
