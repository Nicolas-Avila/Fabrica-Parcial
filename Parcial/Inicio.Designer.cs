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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnSupervisor = new Button();
            btnOperario = new Button();
            noche = new Button();
            ((System.ComponentModel.ISupportInitialize)id).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.Location = new Point(55, 58);
            nombre.Name = "nombre";
            nombre.Size = new Size(100, 23);
            nombre.TabIndex = 0;
            // 
            // apellido
            // 
            apellido.Location = new Point(55, 112);
            apellido.Name = "apellido";
            apellido.Size = new Size(100, 23);
            apellido.TabIndex = 1;
            // 
            // aceptar
            // 
            aceptar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            aceptar.Location = new Point(31, 216);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(147, 35);
            aceptar.TabIndex = 2;
            aceptar.Text = "Ingresar";
            aceptar.UseVisualStyleBackColor = true;
            aceptar.Click += aceptar_Click_1;
            // 
            // id
            // 
            id.Location = new Point(55, 166);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(68, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGoldenrodYellow;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(311, 19);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 6;
            label2.Text = "Inicio de secion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(68, 84);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 7;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(91, 138);
            label4.Name = "label4";
            label4.Size = new Size(28, 25);
            label4.TabIndex = 8;
            label4.Text = "Id";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(aceptar);
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(nombre);
            groupBox1.Controls.Add(apellido);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(279, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 303);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // btnSupervisor
            // 
            btnSupervisor.Location = new Point(408, 388);
            btnSupervisor.Name = "btnSupervisor";
            btnSupervisor.Size = new Size(133, 47);
            btnSupervisor.TabIndex = 10;
            btnSupervisor.Text = "Secion supervisor";
            btnSupervisor.UseVisualStyleBackColor = true;
            // 
            // btnOperario
            // 
            btnOperario.Location = new Point(222, 388);
            btnOperario.Name = "btnOperario";
            btnOperario.Size = new Size(133, 47);
            btnOperario.TabIndex = 11;
            btnOperario.Text = "Secion operario";
            btnOperario.UseVisualStyleBackColor = true;
            // 
            // noche
            // 
            noche.Location = new Point(580, 143);
            noche.Name = "noche";
            noche.Size = new Size(105, 97);
            noche.TabIndex = 12;
            noche.Text = "button1";
            noche.UseVisualStyleBackColor = true;
            noche.Click += noche_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(802, 478);
            Controls.Add(noche);
            Controls.Add(btnOperario);
            Controls.Add(btnSupervisor);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tu fabrica";
            ((System.ComponentModel.ISupportInitialize)id).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombre;
        private TextBox apellido;
        private Button aceptar;
        private NumericUpDown id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnSupervisor;
        private Button btnOperario;
        private Button noche;
    }
}