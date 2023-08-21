namespace Prcatica_3
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
            txtNumero = new TextBox();
            txtCaracter = new TextBox();
            label2 = new Label();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(272, 37);
            label1.TabIndex = 0;
            label1.Text = "Digite un numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(45, 59);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(272, 27);
            txtNumero.TabIndex = 1;
            // 
            // txtCaracter
            // 
            txtCaracter.Location = new Point(45, 170);
            txtCaracter.Name = "txtCaracter";
            txtCaracter.Size = new Size(272, 27);
            txtCaracter.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 120);
            label2.Name = "label2";
            label2.Size = new Size(272, 37);
            label2.TabIndex = 2;
            label2.Text = "Digite una letra o caracter";
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidar.Location = new Point(141, 203);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(82, 43);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(369, 296);
            Controls.Add(btnValidar);
            Controls.Add(txtCaracter);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private TextBox txtCaracter;
        private Label label2;
        private Button btnValidar;
    }
}