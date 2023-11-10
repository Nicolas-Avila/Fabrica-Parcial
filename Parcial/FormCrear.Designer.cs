namespace Parcial
{
    partial class FormCrear
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
            CrearSillas = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            mesas = new GroupBox();
            sillas = new GroupBox();
            CrearMesa = new Button();
            CrearTodo = new Button();
            VerMaterial = new Button();
            label1 = new Label();
            Cerrar = new Button();
            mesas.SuspendLayout();
            sillas.SuspendLayout();
            SuspendLayout();
            // 
            // CrearSillas
            // 
            CrearSillas.Location = new Point(560, 292);
            CrearSillas.Name = "CrearSillas";
            CrearSillas.Size = new Size(142, 38);
            CrearSillas.TabIndex = 0;
            CrearSillas.Text = "Crear sillas";
            CrearSillas.UseVisualStyleBackColor = true;
            CrearSillas.Click += CrearSillas_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(54, 43);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(135, 29);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Silla de metal";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(38, 90);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(151, 29);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Silla de madera";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(37, 43);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(146, 29);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Mesa de metal";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(37, 90);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(162, 29);
            radioButton4.TabIndex = 8;
            radioButton4.Text = "Mesa de madera";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // mesas
            // 
            mesas.BackColor = SystemColors.ControlDark;
            mesas.Controls.Add(radioButton3);
            mesas.Controls.Add(radioButton4);
            mesas.FlatStyle = FlatStyle.Flat;
            mesas.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            mesas.ForeColor = SystemColors.ButtonHighlight;
            mesas.Location = new Point(54, 116);
            mesas.Name = "mesas";
            mesas.RightToLeft = RightToLeft.No;
            mesas.Size = new Size(229, 148);
            mesas.TabIndex = 9;
            mesas.TabStop = false;
            mesas.Text = "Mesas";
            // 
            // sillas
            // 
            sillas.Controls.Add(radioButton1);
            sillas.Controls.Add(radioButton2);
            sillas.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            sillas.ForeColor = SystemColors.ButtonHighlight;
            sillas.Location = new Point(513, 116);
            sillas.Name = "sillas";
            sillas.RightToLeft = RightToLeft.Yes;
            sillas.Size = new Size(229, 148);
            sillas.TabIndex = 10;
            sillas.TabStop = false;
            sillas.Text = "Sillas";
            // 
            // CrearMesa
            // 
            CrearMesa.Location = new Point(91, 292);
            CrearMesa.Name = "CrearMesa";
            CrearMesa.Size = new Size(142, 38);
            CrearMesa.TabIndex = 11;
            CrearMesa.Text = "Crear mesas";
            CrearMesa.UseVisualStyleBackColor = true;
            CrearMesa.Click += CrearMesa_Click;
            // 
            // CrearTodo
            // 
            CrearTodo.Location = new Point(336, 175);
            CrearTodo.Name = "CrearTodo";
            CrearTodo.Size = new Size(125, 44);
            CrearTodo.TabIndex = 12;
            CrearTodo.Text = "Crear el par";
            CrearTodo.UseVisualStyleBackColor = true;
            CrearTodo.Click += CrearTodo_Click;
            // 
            // VerMaterial
            // 
            VerMaterial.Location = new Point(336, 318);
            VerMaterial.Name = "VerMaterial";
            VerMaterial.Size = new Size(125, 44);
            VerMaterial.TabIndex = 13;
            VerMaterial.Text = "Ver materiales";
            VerMaterial.UseVisualStyleBackColor = true;
            VerMaterial.Click += VerMaterial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(270, 40);
            label1.Name = "label1";
            label1.Size = new Size(254, 39);
            label1.TabIndex = 14;
            label1.Text = "Construir productos";
            // 
            // Cerrar
            // 
            Cerrar.BackColor = Color.RosyBrown;
            Cerrar.Location = new Point(54, 389);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(84, 33);
            Cerrar.TabIndex = 15;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // FormCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(Cerrar);
            Controls.Add(label1);
            Controls.Add(VerMaterial);
            Controls.Add(CrearTodo);
            Controls.Add(CrearMesa);
            Controls.Add(sillas);
            Controls.Add(mesas);
            Controls.Add(CrearSillas);
            Name = "FormCrear";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear";
            mesas.ResumeLayout(false);
            mesas.PerformLayout();
            sillas.ResumeLayout(false);
            sillas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CrearSillas;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox mesas;
        private GroupBox sillas;
        private Button CrearMesa;
        private Button CrearTodo;
        private Button VerMaterial;
        private Label label1;
        private Button Cerrar;
    }
}