using CreadorFiguras.controller;
using CreadorFiguras.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreadorFiguras.interfaces;

namespace CreadorFiguras.view
{
    public partial class HistorialFigurasView : Form
    {
        IController figureController = FigureController.GetController();
        List<IFiguras> figuras;
        public HistorialFigurasView()
        {
            InitializeComponent();
            figuras = ((FigureController)figureController).GetFigures();
            mostrarFIguras();

        }

        public void mostrarFIguras()
        {
            Console.WriteLine(figuras.Count);
            foreach (IFiguras e in figuras)
            {
                lstbHistorial.Items.Add(e.GetFigura());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            this.Close();
            ini.Show();
        }
    }
}
