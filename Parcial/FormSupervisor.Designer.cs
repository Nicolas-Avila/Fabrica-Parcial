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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(317, 260);
            button1.Name = "button1";
            button1.Size = new Size(152, 61);
            button1.TabIndex = 0;
            button1.Text = "Mostrar Informacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(317, 327);
            button2.Name = "button2";
            button2.Size = new Size(152, 60);
            button2.TabIndex = 1;
            button2.Text = "Llenar stock";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            button3.Location = new Point(317, 124);
            button3.Name = "button3";
            button3.Size = new Size(152, 62);
            button3.TabIndex = 3;
            button3.Text = "Fabricar productos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(317, 83);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
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
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(319, 192);
            button5.Name = "button5";
            button5.Size = new Size(150, 62);
            button5.TabIndex = 6;
            button5.Text = "Ver materiales";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FormSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(818, 457);
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
    }
}