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
        IController figureController = FigureController.GetController();
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
                        if (!String.IsNullOrEmpty(txtBase.Text) && Convert.ToDouble(txtBase.Text) > 0)
                        {
                            fig = new Square(Convert.ToDouble(txtBase.Text));
                            AgregarYMostrarFigura();

                        }
                        else MessageBox.Show("Ingrese un valor en el campo vacio mayor a 0");


                        break;

                    case "Circulo":
                        if (!String.IsNullOrEmpty(txtRadio.Text) && Convert.ToDouble(txtRadio.Text) > 0)
                        {
                            fig = new Circle(Convert.ToDouble(txtRadio.Text));
                            AgregarYMostrarFigura();
                        }
                        else MessageBox.Show("Ingrese un valor en el campo vacio mayor a 0");



                        break;

                    case "Triangulo":

                        switch (cmbTipoTriangulo.SelectedItem)
                        {
                            case "Isosceles":
                                if (!String.IsNullOrEmpty(txtLadoA.Text) && !String.IsNullOrEmpty(txtBase.Text)
                                    && Convert.ToDouble(txtBase.Text) > 0 && Convert.ToDouble(txtLadoA.Text) > 0
                                    && Convert.ToDouble(txtLadoA.Text) != Convert.ToDouble(txtBase.Text)
                                    )
                                {
                                    fig = new Isosceles(Convert.ToDouble(txtBase.Text), Convert.ToDouble(txtLadoA.Text));
                                    AgregarYMostrarFigura();
                                }
                                else MessageBox.Show("Ingrese valores en los campos vacios, asegurese que los valores sean distintos y mayores a 0");

                                break;

                            case "Equilatero":
                                if (!String.IsNullOrEmpty(txtBase.Text) && Convert.ToDouble(txtBase.Text) > 0)
                                {
                                    fig = new Equilateral(Convert.ToDouble(txtBase.Text));
                                    AgregarYMostrarFigura();
                                }
                                else MessageBox.Show("Ingrese un valor en el campo vacio mayor a 0");


                                break;

                            case "Escaleno":
                                if (!String.IsNullOrEmpty(txtLadoA.Text) && !String.IsNullOrEmpty(txtBase.Text) && !String.IsNullOrEmpty(txtLadoB.Text)
                                    && Convert.ToDouble(txtLadoA.Text) > 0 && Convert.ToDouble(txtLadoB.Text) > 0 && Convert.ToDouble(txtBase.Text) > 0
                                    && Convert.ToDouble(txtLadoA.Text) != Convert.ToDouble(txtBase.Text)
                                    && Convert.ToDouble(txtBase.Text) != Convert.ToDouble(txtLadoB.Text)
                                    && Convert.ToDouble(txtLadoA.Text) != Convert.ToDouble(txtLadoB.Text)
                                    )
                                {
                                    fig = new Scalene(Convert.ToDouble(txtLadoA.Text), Convert.ToDouble(txtLadoB.Text), Convert.ToDouble(txtBase.Text));
                                    AgregarYMostrarFigura();
                                }
                                else MessageBox.Show("Ingrese valores en los campos vacios, asegurese que los valores sean distintos y mayores a 0");

                                break;
                        }
                        break;
                };
            }


        }


        private void AgregarYMostrarFigura()
        {
            ((FigureController)figureController).AddFigure(fig);
            lblDatosFigura.Text = ((FigureController)figureController).GetFigura(fig);
        }

        private void btnHistorialFigura_Click(object sender, EventArgs e)
        {
            HistorialFigurasView histoview = new HistorialFigurasView();
            histoview.Show();
            this.Hide();
            
        }
    }
}



