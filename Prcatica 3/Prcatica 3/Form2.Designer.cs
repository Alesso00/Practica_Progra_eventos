namespace Prcatica_3
{
    partial class Form2
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
            btnprocesar = new Button();
            SuspendLayout();
            // 
            // btnprocesar
            // 
            btnprocesar.BackColor = Color.SkyBlue;
            btnprocesar.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnprocesar.Location = new Point(12, 21);
            btnprocesar.Name = "btnprocesar";
            btnprocesar.Size = new Size(434, 257);
            btnprocesar.TabIndex = 0;
            btnprocesar.Text = "Procesar";
            btnprocesar.UseVisualStyleBackColor = false;
            btnprocesar.Click += btnprocesar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(466, 295);
            Controls.Add(btnprocesar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnprocesar;
    }
}