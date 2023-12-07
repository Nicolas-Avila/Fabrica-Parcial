namespace Parcial
{
    partial class FormProcesando
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            aceptar = new Button();
            negar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Agregar Barniz";
            // 
            // aceptar
            // 
            aceptar.Location = new Point(22, 73);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(75, 23);
            aceptar.TabIndex = 1;
            aceptar.Text = "Si";
            aceptar.UseVisualStyleBackColor = true;
            aceptar.Click += aceptar_Click;
            // 
            // negar
            // 
            negar.Location = new Point(137, 73);
            negar.Name = "negar";
            negar.Size = new Size(75, 23);
            negar.TabIndex = 2;
            negar.Text = "no";
            negar.UseVisualStyleBackColor = true;
            negar.Click += negar_Click;
            // 
            // FormProcesando
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 120);
            ControlBox = false;
            Controls.Add(negar);
            Controls.Add(aceptar);
            Controls.Add(label1);
            Name = "FormProcesando";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Procesando";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button aceptar;
        private Button negar;
    }
}