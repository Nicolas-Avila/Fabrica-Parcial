namespace Parcial
{
    partial class FormActualizar
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
            nombre = new TextBox();
            apellido = new TextBox();
            actualizar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.Location = new Point(144, 105);
            nombre.Name = "nombre";
            nombre.Size = new Size(100, 23);
            nombre.TabIndex = 0;
            // 
            // apellido
            // 
            apellido.Location = new Point(144, 177);
            apellido.Name = "apellido";
            apellido.Size = new Size(100, 23);
            apellido.TabIndex = 1;
            // 
            // actualizar
            // 
            actualizar.Location = new Point(144, 239);
            actualizar.Name = "actualizar";
            actualizar.Size = new Size(100, 34);
            actualizar.TabIndex = 2;
            actualizar.Text = "Actualizar";
            actualizar.UseVisualStyleBackColor = true;
            actualizar.Click += actualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(155, 77);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(155, 149);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGoldenrodYellow;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(146, 22);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 5;
            label3.Text = "Actualizar";
            // 
            // FormActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(399, 371);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(actualizar);
            Controls.Add(apellido);
            Controls.Add(nombre);
            Name = "FormActualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormActualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombre;
        private TextBox apellido;
        private Button actualizar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}