using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreadorFiguras.interfaces;

namespace CreadorFiguras.model
{
    internal class Circle:IFiguras
    {
        int id = 0;
        double radio{ get; set; }
        double perimetro{ get; set; }
        double surface{ get; set; }

        public Circle(double radio)
        {
            this.radio = radio;
            this.perimetro = GetPerimetro();
            this.surface = GetSurface();
        }

        public string GetFigura()
        {
            return $" Circulo:" + "\n" + $"  Radio = {radio}" + "\n" + $"  Perimetro = {perimetro.ToString("F1")}cm" + "\n" + $"  Superficie = {surface.ToString("F1")}cm";
        }

        public double GetPerimetro()
        {
            return 2 * Math.PI * radio;
        }

        public double GetSurface()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
