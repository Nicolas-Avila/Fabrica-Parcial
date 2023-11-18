namespace Parcial
{
    partial class FormNewSupervisor
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
            cuadroSupervisor = new DataGridView();
            Borrar = new Button();
            Actualizar = new Button();
            nombre = new TextBox();
            apellido = new TextBox();
            CrearOperario = new Button();
            Supervisor = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)cuadroSupervisor).BeginInit();
            SuspendLayout();
            // 
            // cuadroSupervisor
            // 
            cuadroSupervisor.BackgroundColor = Color.Cornsilk;
            cuadroSupervisor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cuadroSupervisor.Location = new Point(43, 113);
            cuadroSupervisor.Name = "cuadroSupervisor";
            cuadroSupervisor.RowTemplate.Height = 25;
            cuadroSupervisor.Size = new Size(367, 158);
            cuadroSupervisor.TabIndex = 0;
            // 
            // Borrar
            // 
            Borrar.Location = new Point(167, 294);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(109, 41);
            Borrar.TabIndex = 1;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // Actualizar
            // 
            Actualizar.Location = new Point(167, 356);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(109, 41);
            Actualizar.TabIndex = 2;
            Actualizar.Text = "Actualizar";
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Click += Actualizar_Click;
            // 
            // nombre
            // 
            nombre.Location = new Point(588, 157);
            nombre.Name = "nombre";
            nombre.Size = new Size(100, 23);
            nombre.TabIndex = 3;
            // 
            // apellido
            // 
            apellido.Location = new Point(588, 248);
            apellido.Name = "apellido";
            apellido.Size = new Size(100, 23);
            apellido.TabIndex = 4;
            // 
            // CrearOperario
            // 
            CrearOperario.Location = new Point(579, 322);
            CrearOperario.Name = "CrearOperario";
            CrearOperario.Size = new Size(109, 41);
            CrearOperario.TabIndex = 5;
            CrearOperario.Text = "Crear Supervisor";
            CrearOperario.UseVisualStyleBackColor = true;
            CrearOperario.Click += CrearOperario_Click;
            // 
            // Supervisor
            // 
            Supervisor.AutoSize = true;
            Supervisor.BackColor = Color.LightGoldenrodYellow;
            Supervisor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Supervisor.Location = new Point(323, 30);
            Supervisor.Name = "Supervisor";
            Supervisor.Size = new Size(141, 37);
            Supervisor.TabIndex = 6;
            Supervisor.Text = "Supervisor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(589, 113);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(589, 205);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 8;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(554, 70);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 9;
            label3.Text = "Nuevo Supervisor";
            // 
            // FormNewSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Supervisor);
            Controls.Add(CrearOperario);
            Controls.Add(apellido);
            Controls.Add(nombre);
            Controls.Add(Actualizar);
            Controls.Add(Borrar);
            Controls.Add(cuadroSupervisor);
            Name = "FormNewSupervisor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNewSupervisor";
            Load += FormNewSupervisor_Load;
            ((System.ComponentModel.ISupportInitialize)cuadroSupervisor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView cuadroSupervisor;
        private Button Borrar;
        private Button Actualizar;
        private TextBox nombre;
        private TextBox apellido;
        private Button CrearOperario;
        private Label Supervisor;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}