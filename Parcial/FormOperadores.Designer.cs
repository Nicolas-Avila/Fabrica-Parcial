namespace Parcial
{
    partial class FormOperadores
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
            mesas.SuspendLayout();
            sillas.SuspendLayout();
            SuspendLayout();
            // 
            // Crear
            // 
            Crear.Location = new Point(512, 270);
            Crear.Name = "Crear";
            Crear.Size = new Size(104, 36);
            Crear.TabIndex = 0;
            Crear.Text = "Crear sillas";
            Crear.UseVisualStyleBackColor = true;
            Crear.Click += Crear_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(54, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(95, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Silla de metal";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(44, 59);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(105, 19);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Silla de madera";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(37, 34);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(102, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Mesa de metal";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(37, 59);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(112, 19);
            radioButton4.TabIndex = 8;
            radioButton4.Text = "Mesa de madera";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // mesas
            // 
            mesas.Controls.Add(radioButton3);
            mesas.Controls.Add(radioButton4);
            mesas.Location = new Point(176, 122);
            mesas.Name = "mesas";
            mesas.Size = new Size(199, 100);
            mesas.TabIndex = 9;
            mesas.TabStop = false;
            mesas.Text = "Mesa";
            // 
            // sillas
            // 
            sillas.Controls.Add(radioButton1);
            sillas.Controls.Add(radioButton2);
            sillas.Location = new Point(445, 105);
            sillas.Name = "sillas";
            sillas.Size = new Size(195, 117);
            sillas.TabIndex = 10;
            sillas.TabStop = false;
            sillas.Text = "Silla";
            // 
            // button1
            // 
            button1.Location = new Point(202, 270);
            button1.Name = "button1";
            button1.Size = new Size(104, 36);
            button1.TabIndex = 11;
            button1.Text = "Crear mesas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(363, 270);
            button2.Name = "button2";
            button2.Size = new Size(98, 34);
            button2.TabIndex = 12;
            button2.Text = "Crear el par";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(641, 383);
            button3.Name = "button3";
            button3.Size = new Size(127, 33);
            button3.TabIndex = 13;
            button3.Text = "Ver materiales";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormOperadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sillas);
            Controls.Add(mesas);
            Controls.Add(Crear);
            Name = "FormOperadores";
            Text = "Operario";
            FormClosing += FormOperadores_FormClosing;
            mesas.ResumeLayout(false);
            mesas.PerformLayout();
            sillas.ResumeLayout(false);
            sillas.PerformLayout();
            ResumeLayout(false);
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
    }
}