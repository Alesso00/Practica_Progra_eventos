namespace Calcular_el_interes_compuesto
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMonto = new TextBox();
            txtPorcentaje = new TextBox();
            lblResultado = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(377, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(304, 31);
            label1.TabIndex = 0;
            label1.Text = "Calcular interes compuesto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(211, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el monto inicial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 196);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(191, 25);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el porcentaje";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 64);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(681, 25);
            label4.TabIndex = 3;
            label4.Text = "Formula: interescompuesto = montoInicial + (montoInicial ∗ (porcentaje/100))";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(100, 142);
            txtMonto.Margin = new Padding(4, 4, 4, 4);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(170, 31);
            txtMonto.TabIndex = 4;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(100, 240);
            txtPorcentaje.Margin = new Padding(4, 4, 4, 4);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(170, 31);
            txtPorcentaje.TabIndex = 5;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(100, 401);
            lblResultado.Margin = new Padding(4, 0, 4, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(145, 25);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "El resultado es: ";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(100, 312);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(131, 51);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1100, 562);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(txtPorcentaje);
            Controls.Add(txtMonto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMonto;
        private TextBox txtPorcentaje;
        private Label lblResultado;
        private Button btnCalcular;
    }
}