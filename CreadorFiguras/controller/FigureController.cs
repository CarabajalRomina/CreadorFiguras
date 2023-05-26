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

       public string GetFigura(IFiguras figura)
        {
           return figura.GetFigura();
        }
    }
}
