namespace Parcial
{
    partial class MostrarOperario
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
            label1 = new Label();
            cuadroOperario = new DataGridView();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)cuadroOperario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(301, 31);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 0;
            label1.Text = "Operadores en Linea";
            label1.Click += label1_Click;
            // 
            // cuadroOperario
            // 
            cuadroOperario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cuadroOperario.Location = new Point(12, 75);
            cuadroOperario.Name = "cuadroOperario";
            cuadroOperario.RowTemplate.Height = 25;
            cuadroOperario.Size = new Size(776, 124);
            cuadroOperario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(288, 229);
            label2.Name = "label2";
            label2.Size = new Size(215, 30);
            label2.TabIndex = 2;
            label2.Text = "Cantidad de productos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 134);
            dataGridView1.TabIndex = 3;
            // 
            // MostrarOperario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(cuadroOperario);
            Controls.Add(label1);
            Name = "MostrarOperario";
            Text = "Lista operarios";
            ((System.ComponentModel.ISupportInitialize)cuadroOperario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView cuadroOperario;
        private Label label2;
        private DataGridView dataGridView1;
    }
}