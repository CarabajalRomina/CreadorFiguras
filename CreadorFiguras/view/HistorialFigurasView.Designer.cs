namespace CreadorFiguras.view
{
    partial class HistorialFigurasView
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
            btnVolver = new Button();
            lstbHistorial = new ListBox();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(790, 23);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 34);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lstbHistorial
            // 
            lstbHistorial.FormattingEnabled = true;
            lstbHistorial.ItemHeight = 25;
            lstbHistorial.Location = new Point(12, 70);
            lstbHistorial.Name = "lstbHistorial";
            lstbHistorial.Size = new Size(890, 429);
            lstbHistorial.TabIndex = 2;
            // 
            // HistorialFigurasView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 529);
            Controls.Add(lstbHistorial);
            Controls.Add(btnVolver);
            Name = "HistorialFigurasView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HistorialFigurasView";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private ListBox lstbHistorial;
    }
}