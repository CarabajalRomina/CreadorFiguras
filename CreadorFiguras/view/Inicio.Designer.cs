namespace CreadorFiguras.view
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            llblTitulo = new Label();
            lblFiguras = new Label();
            lblTipoTriangulo = new Label();
            lblBase = new Label();
            lblLadoA = new Label();
            lblLadoB = new Label();
            pnlDatosFigura = new Panel();
            btnCrear = new Button();
            txtLadoB = new TextBox();
            txtLadoA = new TextBox();
            txtRadio = new TextBox();
            txtBase = new TextBox();
            lblRadio = new Label();
            cmbFigura = new ComboBox();
            cmbTipoTriangulo = new ComboBox();
            gpbDatosFigura = new GroupBox();
            lblDatosFigura = new Label();
            btnHistorialFigura = new Button();
            pnlDatosFigura.SuspendLayout();
            gpbDatosFigura.SuspendLayout();
            SuspendLayout();
            // 
            // llblTitulo
            // 
            llblTitulo.AutoSize = true;
            llblTitulo.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            llblTitulo.ForeColor = Color.Maroon;
            llblTitulo.Location = new Point(46, 31);
            llblTitulo.Name = "llblTitulo";
            llblTitulo.Size = new Size(639, 44);
            llblTitulo.TabIndex = 0;
            llblTitulo.Text = "Creador de figuras geometricas";
            // 
            // lblFiguras
            // 
            lblFiguras.AutoSize = true;
            lblFiguras.Location = new Point(163, 93);
            lblFiguras.Name = "lblFiguras";
            lblFiguras.Size = new Size(136, 25);
            lblFiguras.TabIndex = 1;
            lblFiguras.Text = "Elija una figura: ";
            // 
            // lblTipoTriangulo
            // 
            lblTipoTriangulo.AutoSize = true;
            lblTipoTriangulo.Location = new Point(163, 145);
            lblTipoTriangulo.Name = "lblTipoTriangulo";
            lblTipoTriangulo.Size = new Size(207, 25);
            lblTipoTriangulo.TabIndex = 2;
            lblTipoTriangulo.Text = "Elija el tipo de triangulo: ";
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(17, 32);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(57, 25);
            lblBase.TabIndex = 3;
            lblBase.Text = "Base: ";
            // 
            // lblLadoA
            // 
            lblLadoA.AutoSize = true;
            lblLadoA.Location = new Point(17, 74);
            lblLadoA.Name = "lblLadoA";
            lblLadoA.Size = new Size(77, 25);
            lblLadoA.TabIndex = 4;
            lblLadoA.Text = "Lado A: ";
            // 
            // lblLadoB
            // 
            lblLadoB.AutoSize = true;
            lblLadoB.Location = new Point(17, 115);
            lblLadoB.Name = "lblLadoB";
            lblLadoB.Size = new Size(75, 25);
            lblLadoB.TabIndex = 5;
            lblLadoB.Text = "Lado B: ";
            // 
            // pnlDatosFigura
            // 
            pnlDatosFigura.Controls.Add(btnCrear);
            pnlDatosFigura.Controls.Add(txtLadoB);
            pnlDatosFigura.Controls.Add(txtLadoA);
            pnlDatosFigura.Controls.Add(txtRadio);
            pnlDatosFigura.Controls.Add(txtBase);
            pnlDatosFigura.Controls.Add(lblRadio);
            pnlDatosFigura.Controls.Add(lblBase);
            pnlDatosFigura.Controls.Add(lblLadoB);
            pnlDatosFigura.Controls.Add(lblLadoA);
            pnlDatosFigura.Location = new Point(46, 190);
            pnlDatosFigura.Name = "pnlDatosFigura";
            pnlDatosFigura.Size = new Size(291, 234);
            pnlDatosFigura.TabIndex = 6;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.RosyBrown;
            btnCrear.ForeColor = Color.Black;
            btnCrear.Location = new Point(59, 177);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(161, 34);
            btnCrear.TabIndex = 11;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(93, 115);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(150, 31);
            txtLadoB.TabIndex = 10;
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(93, 74);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(150, 31);
            txtLadoA.TabIndex = 9;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(93, 32);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(150, 31);
            txtRadio.TabIndex = 8;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(93, 32);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(150, 31);
            txtBase.TabIndex = 7;
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(17, 32);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(62, 25);
            lblRadio.TabIndex = 6;
            lblRadio.Text = "Radio:";
            // 
            // cmbFigura
            // 
            cmbFigura.FormattingEnabled = true;
            cmbFigura.Location = new Point(318, 93);
            cmbFigura.Name = "cmbFigura";
            cmbFigura.Size = new Size(240, 33);
            cmbFigura.TabIndex = 7;
            cmbFigura.SelectedIndexChanged += cmbFigura_SelectedIndexChanged;
            // 
            // cmbTipoTriangulo
            // 
            cmbTipoTriangulo.FormattingEnabled = true;
            cmbTipoTriangulo.Location = new Point(376, 142);
            cmbTipoTriangulo.Name = "cmbTipoTriangulo";
            cmbTipoTriangulo.Size = new Size(182, 33);
            cmbTipoTriangulo.TabIndex = 8;
            cmbTipoTriangulo.SelectedIndexChanged += cmbTipoTriangulo_SelectedIndexChanged;
            // 
            // gpbDatosFigura
            // 
            gpbDatosFigura.Controls.Add(lblDatosFigura);
            gpbDatosFigura.Location = new Point(376, 190);
            gpbDatosFigura.Name = "gpbDatosFigura";
            gpbDatosFigura.Size = new Size(360, 234);
            gpbDatosFigura.TabIndex = 9;
            gpbDatosFigura.TabStop = false;
            gpbDatosFigura.Text = "Datos de Figura";
            // 
            // lblDatosFigura
            // 
            lblDatosFigura.AutoSize = true;
            lblDatosFigura.Location = new Point(4, 38);
            lblDatosFigura.Name = "lblDatosFigura";
            lblDatosFigura.Size = new Size(0, 25);
            lblDatosFigura.TabIndex = 0;
            // 
            // btnHistorialFigura
            // 
            btnHistorialFigura.Location = new Point(624, 150);
            btnHistorialFigura.Name = "btnHistorialFigura";
            btnHistorialFigura.Size = new Size(112, 34);
            btnHistorialFigura.TabIndex = 10;
            btnHistorialFigura.Text = "Historial FIguras";
            btnHistorialFigura.UseVisualStyleBackColor = true;
            btnHistorialFigura.Click += btnHistorialFigura_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(755, 450);
            Controls.Add(btnHistorialFigura);
            Controls.Add(gpbDatosFigura);
            Controls.Add(cmbTipoTriangulo);
            Controls.Add(cmbFigura);
            Controls.Add(pnlDatosFigura);
            Controls.Add(lblTipoTriangulo);
            Controls.Add(lblFiguras);
            Controls.Add(llblTitulo);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            pnlDatosFigura.ResumeLayout(false);
            pnlDatosFigura.PerformLayout();
            gpbDatosFigura.ResumeLayout(false);
            gpbDatosFigura.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label llblTitulo;
        private Label lblFiguras;
        private Label lblTipoTriangulo;
        private Label lblBase;
        private Label lblLadoA;
        private Label lblLadoB;
        private Panel pnlDatosFigura;
        private Label lblRadio;
        private Button btnCrear;
        private TextBox txtLadoB;
        private TextBox txtLadoA;
        private TextBox txtRadio;
        private TextBox txtBase;
        private ComboBox cmbFigura;
        private ComboBox cmbTipoTriangulo;
        private GroupBox gpbDatosFigura;
        private Label lblDatosFigura;
        private Button btnHistorialFigura;
    }
}