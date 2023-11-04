namespace Parcial
{
    partial class FormSupervisor
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            CrearSupervisor = new Button();
            CrearOperario = new Button();
            nombre = new TextBox();
            apellido = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(537, 260);
            button1.Name = "button1";
            button1.Size = new Size(152, 61);
            button1.TabIndex = 0;
            button1.Text = "Mostrar Informacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += masInfo_Click;
            // 
            // button2
            // 
            button2.Location = new Point(537, 327);
            button2.Name = "button2";
            button2.Size = new Size(152, 60);
            button2.TabIndex = 1;
            button2.Text = "Llenar stock";
            button2.UseVisualStyleBackColor = true;
            button2.Click += rellenar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(267, 33);
            label1.Name = "label1";
            label1.Size = new Size(277, 37);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido supervisor";
            // 
            // button3
            // 
            button3.Location = new Point(535, 124);
            button3.Name = "button3";
            button3.Size = new Size(152, 62);
            button3.TabIndex = 3;
            button3.Text = "Fabricar productos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += productos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(535, 80);
            label2.Name = "label2";
            label2.Size = new Size(164, 28);
            label2.TabIndex = 4;
            label2.Text = "Que desea hacer?";
            // 
            // button4
            // 
            button4.BackColor = Color.RosyBrown;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(31, 402);
            button4.Name = "button4";
            button4.Size = new Size(99, 34);
            button4.TabIndex = 5;
            button4.Text = "Cerrar Secion";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Cerrar_Click;
            // 
            // button5
            // 
            button5.Location = new Point(537, 192);
            button5.Name = "button5";
            button5.Size = new Size(150, 62);
            button5.TabIndex = 6;
            button5.Text = "Ver materiales";
            button5.UseVisualStyleBackColor = true;
            button5.Click += verMaterial_Click;
            // 
            // CrearSupervisor
            // 
            CrearSupervisor.Location = new Point(122, 308);
            CrearSupervisor.Name = "CrearSupervisor";
            CrearSupervisor.Size = new Size(100, 41);
            CrearSupervisor.TabIndex = 7;
            CrearSupervisor.Text = "Crear Supervisor";
            CrearSupervisor.UseVisualStyleBackColor = true;
            CrearSupervisor.Click += CrearSupervisor_Click_1;
            // 
            // CrearOperario
            // 
            CrearOperario.Location = new Point(247, 308);
            CrearOperario.Name = "CrearOperario";
            CrearOperario.Size = new Size(100, 41);
            CrearOperario.TabIndex = 8;
            CrearOperario.Text = "Crear Operario";
            CrearOperario.UseVisualStyleBackColor = true;
            CrearOperario.Click += CrearOperario_Click;
            // 
            // nombre
            // 
            nombre.Location = new Point(175, 177);
            nombre.Name = "nombre";
            nombre.Size = new Size(122, 23);
            nombre.TabIndex = 9;
            // 
            // apellido
            // 
            apellido.Location = new Point(175, 260);
            apellido.Name = "apellido";
            apellido.Size = new Size(122, 23);
            apellido.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(158, 142);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 11;
            label3.Text = "Ingrese el Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(158, 219);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 12;
            label4.Text = "Ingrese el Apllido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(161, 95);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 13;
            label5.Text = "Crear Trabajador";
            // 
            // FormSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(818, 457);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(apellido);
            Controls.Add(nombre);
            Controls.Add(CrearOperario);
            Controls.Add(CrearSupervisor);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormSupervisor";
            Text = "Supervisor";
            FormClosing += FormSupervisor_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Label label2;
        private Button button4;
        private Button button5;
        private Button CrearSupervisor;
        private Button CrearOperario;
        private TextBox nombre;
        private TextBox apellido;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}