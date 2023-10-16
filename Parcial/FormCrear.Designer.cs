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
            Crear = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            mesas = new GroupBox();
            sillas = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            mesas.SuspendLayout();
            sillas.SuspendLayout();
            SuspendLayout();
            // 
            // Crear
            // 
            Crear.Location = new Point(560, 292);
            Crear.Name = "Crear";
            Crear.Size = new Size(142, 38);
            Crear.TabIndex = 0;
            Crear.Text = "Crear sillas";
            Crear.UseVisualStyleBackColor = true;
            Crear.Click += Crear_Click;
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
            // button1
            // 
            button1.Location = new Point(91, 292);
            button1.Name = "button1";
            button1.Size = new Size(142, 38);
            button1.TabIndex = 11;
            button1.Text = "Crear mesas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(336, 175);
            button2.Name = "button2";
            button2.Size = new Size(125, 44);
            button2.TabIndex = 12;
            button2.Text = "Crear el par";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(336, 318);
            button3.Name = "button3";
            button3.Size = new Size(125, 44);
            button3.TabIndex = 13;
            button3.Text = "Ver materiales";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            // button4
            // 
            button4.BackColor = Color.RosyBrown;
            button4.Location = new Point(54, 389);
            button4.Name = "button4";
            button4.Size = new Size(84, 33);
            button4.TabIndex = 15;
            button4.Text = "Cerrar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FormCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sillas);
            Controls.Add(mesas);
            Controls.Add(Crear);
            Name = "FormCrear";
            Text = "Operario";
            FormClosing += FormOperadores_FormClosing;
            mesas.ResumeLayout(false);
            mesas.PerformLayout();
            sillas.ResumeLayout(false);
            sillas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Crear;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox mesas;
        private GroupBox sillas;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
    }
}