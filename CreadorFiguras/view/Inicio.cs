using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreadorFiguras.controller;
using CreadorFiguras.interfaces;
using CreadorFiguras.model;


namespace CreadorFiguras.view
{
    public partial class Inicio : Form
    {
        List<string> figuras = new List<string>
            { "Cuadrado", "Circulo", "Triangulo" };
        List<string> tipoTriangulos = new List<string>
            { "Isosceles", "Escaleno", "Equilatero" };
        IController figureControl = FigureController.GetController();
        IFiguras fig;




        public Inicio()
        {
            InitializeComponent();
            lblTipoTriangulo.Hide();
            cmbTipoTriangulo.Hide();
            lblRadio.Hide();
            txtRadio.Hide();
            cargarCmb(cmbFigura, figuras);
            cargarCmb(cmbTipoTriangulo, tipoTriangulos);
            desabilitarTxt(txtRadio, txtLadoB, txtLadoA, txtBase);
        }

        private void cargarCmb(ComboBox cmb, List<string> list)
        {
            foreach (string e in list)
            {
                cmb.Items.Add(e);
            }
        }

        private void desabilitarTxt(TextBox txtRadio, TextBox txtLadoB, TextBox txtLadoA, TextBox txtBase)
        {
            txtLadoA.Enabled = false;
            txtLadoB.Enabled = false;
            txtBase.Enabled = false;
        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTipoTriangulo.Visible = false;
            cmbTipoTriangulo.Visible = false;
            lblDatosFigura.Text = "";


            switch (cmbFigura.SelectedItem)
            {
                case "Cuadrado":
                    txtBase.Visible = true;
                    txtBase.Enabled = true;
                    lblRadio.Visible = false;
                    txtRadio.Visible = false;
                    lblLadoA.Visible = false;
                    txtLadoA.Visible = false;
                    lblLadoB.Visible = false;
                    txtLadoB.Visible = false;
                    break;

                case "Circulo":
                    lblRadio.Visible = true;
                    txtRadio.Visible = true;
                    txtRadio.Enabled = true;
                    txtBase.Visible = false;
                    lblLadoA.Visible = false;
                    txtLadoA.Visible = false;
                    lblLadoB.Visible = false;
                    txtLadoB.Visible = false;
                    break;

                case "Triangulo":
                    lblTipoTriangulo.Visible = true;
                    cmbTipoTriangulo.Visible = true;
                    cmbTipoTriangulo_SelectedIndexChanged(sender, e);
                    break;


            }
        }

        private void cmbTipoTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbTipoTriangulo.SelectedItem)
            {
                case "Isosceles":
                    lblBase.Visible = true;
                    txtBase.Visible = true;
                    txtBase.Enabled = true;
                    lblLadoA.Visible = true;
                    txtLadoA.Enabled = true;
                    txtLadoA.Visible = true;
                    lblLadoB.Visible = false;
                    txtLadoB.Visible = false;
                    lblRadio.Visible = false;
                    txtRadio.Visible = false;
                    break;

                case "Equilatero":
                    lblBase.Visible = true;
                    txtBase.Visible = true;
                    txtBase.Enabled = true;
                    lblLadoA.Visible = false;
                    txtLadoA.Visible = false;
                    lblLadoB.Visible = false;
                    txtLadoB.Visible = false;
                    lblRadio.Visible = false;
                    txtRadio.Visible = false;
                    break;

                case "Escaleno":
                    lblBase.Visible = true;
                    txtBase.Enabled = true;
                    txtBase.Visible = true;
                    lblLadoA.Visible = true;
                    txtLadoA.Visible = true;
                    txtLadoA.Enabled = true;
                    lblLadoB.Visible = true;
                    txtLadoB.Visible = true;
                    txtLadoB.Enabled = true;
                    lblRadio.Visible = false;
                    txtRadio.Visible = false;
                    break;
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            {
                switch (cmbFigura.SelectedItem)
                {
                    case "Cuadrado":
                        fig = ((FigureController)figureControl).crearCuadrado(Convert.ToDouble(txtBase.Text));
                        AgregarYMostrarFigura();
                        break;

                    case "Circulo":
                        fig = ((FigureController)figureControl).crearCirculo(Convert.ToDouble(txtRadio.Text));
                        AgregarYMostrarFigura();
                        break;

                    case "Triangulo":
                        switch (cmbTipoTriangulo.SelectedItem)
                        {
                            case "Isosceles":
                                fig = ((FigureController)figureControl).crearTrianguloIsosceles(Convert.ToDouble(txtLadoA.Text), Convert.ToDouble(txtBase.Text));
                                AgregarYMostrarFigura();
                                break;

                            case "Equilatero":
                                fig = ((FigureController)figureControl).crearTrianguloEquilatero(Convert.ToDouble(txtBase.Text));
                                AgregarYMostrarFigura();
                                break;

                            case "Escaleno":
                                fig = ((FigureController)figureControl).crearTrianguloEscaleno(Convert.ToDouble(txtBase.Text), Convert.ToDouble(txtLadoA.Text), Convert.ToDouble(txtLadoB.Text));
                                AgregarYMostrarFigura();
                                break;
                        }
                        break;
                };
            }
        }


        private void AgregarYMostrarFigura()
        {
            ((FigureController)figureControl).AddFigure(fig);
            lblDatosFigura.Text = ((FigureController)figureControl).GetFigura(fig);
        }

        private void btnHistorialFigura_Click(object sender, EventArgs e)
        {
            HistorialFigurasView histoview = new HistorialFigurasView();
            histoview.Show();
            this.Hide();
        }
    }
}



