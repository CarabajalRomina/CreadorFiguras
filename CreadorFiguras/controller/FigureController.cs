using CreadorFiguras.model;
using CreadorFiguras.interfaces;

namespace CreadorFiguras.controller
{
    internal class FigureController: IController
    {
        private readonly static IController figureController = new FigureController();
        private readonly List<IFiguras> Figuras = new();

        private FigureController(){}

        public static IController GetController()
        {
            return figureController;
        }

       public void AddFigure(IFiguras figure)
        {
            Figuras.Add(figure);
        }

       public List<IFiguras> GetFigures() { 
            return Figuras;
        }

        public IFiguras crearCirculo(double radio)
        {
            return new Circle(radio);
        }

        public IFiguras crearCuadrado(double lado)
        {
            return new Square(lado);
        }

        public IFiguras crearTrianguloEscaleno(double bse,double ladoA, double ladoB)
        {
            return new Scalene(ladoA, ladoB, bse);
        }

        public IFiguras crearTrianguloEquilatero(double lado)
        {
            return new Equilateral(lado);
        }

        public IFiguras crearTrianguloIsosceles(double lado, double bse)
        {
            return new Isosceles(bse,lado);
        }

        public string GetFigura(IFiguras figura)
        {
            return figura.GetFigura();
        }
    }
}
