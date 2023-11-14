namespace Parcial
{
    partial class FormNewOperario
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
            cuadroOperario = new DataGridView();
            Borrar = new Button();
            Actualizar = new Button();
            nombre = new TextBox();
            apellido = new TextBox();
            CrearOperario = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)cuadroOperario).BeginInit();
            SuspendLayout();
            // 
            // cuadroOperario
            // 
            cuadroOperario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cuadroOperario.Location = new Point(30, 78);
            cuadroOperario.Name = "cuadroOperario";
            cuadroOperario.RowTemplate.Height = 25;
            cuadroOperario.Size = new Size(349, 146);
            cuadroOperario.TabIndex = 0;
            // 
            // Borrar
            // 
            Borrar.Location = new Point(129, 269);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(141, 52);
            Borrar.TabIndex = 1;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // Actualizar
            // 
            Actualizar.Location = new Point(129, 358);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(141, 52);
            Actualizar.TabIndex = 2;
            Actualizar.Text = "Actualizar";
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Click += Actualizar_Click;
            // 
            // nombre
            // 
            nombre.Location = new Point(537, 126);
            nombre.Name = "nombre";
            nombre.Size = new Size(100, 23);
            nombre.TabIndex = 3;
            // 
            // apellido
            // 
            apellido.Location = new Point(537, 201);
            apellido.Name = "apellido";
            apellido.Size = new Size(100, 23);
            apellido.TabIndex = 4;
            // 
            // CrearOperario
            // 
            CrearOperario.Location = new Point(517, 298);
            CrearOperario.Name = "CrearOperario";
            CrearOperario.Size = new Size(140, 52);
            CrearOperario.TabIndex = 5;
            CrearOperario.Text = "Crear Operario";
            CrearOperario.UseVisualStyleBackColor = true;
            CrearOperario.Click += CrearOperario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(333, 26);
            label1.Name = "label1";
            label1.Size = new Size(122, 37);
            label1.TabIndex = 6;
            label1.Text = "Operario";
            // 
            // FormNewOperario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(CrearOperario);
            Controls.Add(apellido);
            Controls.Add(nombre);
            Controls.Add(Actualizar);
            Controls.Add(Borrar);
            Controls.Add(cuadroOperario);
            Name = "FormNewOperario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNewOperario";
            Load += FormNewOperario_Load;
            ((System.ComponentModel.ISupportInitialize)cuadroOperario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView cuadroOperario;
        private Button Borrar;
        private Button Actualizar;
        private TextBox nombre;
        private TextBox apellido;
        private Button CrearOperario;
        private Label label1;
    }
}