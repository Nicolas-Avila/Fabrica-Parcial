namespace Parcial
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nombre = new TextBox();
            apellido = new TextBox();
            aceptar = new Button();
            id = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)id).BeginInit();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.Location = new Point(338, 76);
            nombre.Name = "nombre";
            nombre.Size = new Size(100, 23);
            nombre.TabIndex = 0;
            // 
            // apellido
            // 
            apellido.Location = new Point(338, 129);
            apellido.Name = "apellido";
            apellido.Size = new Size(100, 23);
            apellido.TabIndex = 1;
            // 
            // aceptar
            // 
            aceptar.Location = new Point(327, 236);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(122, 55);
            aceptar.TabIndex = 2;
            aceptar.Text = "TOCAME";
            aceptar.UseVisualStyleBackColor = true;
            aceptar.Click += aceptar_Click_1;
            // 
            // id
            // 
            id.Location = new Point(327, 183);
            id.Name = "id";
            id.Size = new Size(120, 23);
            id.TabIndex = 4;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(id);
            Controls.Add(aceptar);
            Controls.Add(apellido);
            Controls.Add(nombre);
            Load += Inicio_Load;
            Name = "Inicio";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)id).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombre;
        private TextBox apellido;
        private Button aceptar;
        private NumericUpDown id;
    }
}