using static ClassLibraryTiempos.Tiempos;

namespace Practica_4
{
    partial class Practica
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
            cboxHoraInicio = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            btnGuardar = new Button();
            txtMateria = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cboxAmPm = new ComboBox();
            label2 = new Label();
            cboxHoraFin = new ComboBox();
            listMaterias = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboxHoraInicio
            // 
            cboxHoraInicio.BackColor = Color.White;
            cboxHoraInicio.ForeColor = SystemColors.WindowText;
            cboxHoraInicio.FormattingEnabled = true;
            cboxHoraInicio.Location = new Point(432, 68);
            cboxHoraInicio.Margin = new Padding(3, 4, 3, 4);
            cboxHoraInicio.Name = "cboxHoraInicio";
            cboxHoraInicio.Size = new Size(335, 28);
            cboxHoraInicio.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(432, 19);
            label1.Name = "label1";
            label1.Size = new Size(336, 35);
            label1.TabIndex = 1;
            label1.Text = "Hora de inicio";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtMateria);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboxAmPm);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboxHoraFin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboxHoraInicio);
            panel1.Location = new Point(24, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 342);
            panel1.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.MediumAquamarine;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(318, 239);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(163, 48);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(34, 68);
            txtMateria.Margin = new Padding(3, 4, 3, 4);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(335, 27);
            txtMateria.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 19);
            label4.Name = "label4";
            label4.Size = new Size(336, 31);
            label4.TabIndex = 6;
            label4.Text = "Nombre de la materia";
            // 
            // label3
            // 
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(432, 119);
            label3.Name = "label3";
            label3.Size = new Size(336, 35);
            label3.TabIndex = 5;
            label3.Text = "A.M/P.M";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboxAmPm
            // 
            cboxAmPm.FormattingEnabled = true;
            cboxAmPm.Location = new Point(432, 168);
            cboxAmPm.Margin = new Padding(3, 4, 3, 4);
            cboxAmPm.Name = "cboxAmPm";
            cboxAmPm.Size = new Size(335, 28);
            cboxAmPm.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 119);
            label2.Name = "label2";
            label2.Size = new Size(336, 35);
            label2.TabIndex = 3;
            label2.Text = "Hora de fin";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboxHoraFin
            // 
            cboxHoraFin.FormattingEnabled = true;
            cboxHoraFin.Location = new Point(34, 168);
            cboxHoraFin.Margin = new Padding(3, 4, 3, 4);
            cboxHoraFin.Name = "cboxHoraFin";
            cboxHoraFin.Size = new Size(335, 28);
            cboxHoraFin.TabIndex = 2;
            // 
            // listMaterias
            // 
            listMaterias.BackColor = SystemColors.InactiveCaption;
            listMaterias.FormattingEnabled = true;
            listMaterias.ItemHeight = 20;
            listMaterias.Location = new Point(24, 380);
            listMaterias.Margin = new Padding(3, 4, 3, 4);
            listMaterias.Name = "listMaterias";
            listMaterias.ScrollAlwaysVisible = true;
            listMaterias.Size = new Size(797, 204);
            listMaterias.TabIndex = 3;
            // 
            // Practica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(843, 596);
            Controls.Add(listMaterias);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Practica";
            Text = "Horarios";
            Load += Practica_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboxHoraInicio;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private ComboBox cboxAmPm;
        private Label label2;
        private ComboBox cboxHoraFin;
        private Button btnGuardar;
        private TextBox txtMateria;
        private Label label4;
        private ListBox listMaterias;
    }
}