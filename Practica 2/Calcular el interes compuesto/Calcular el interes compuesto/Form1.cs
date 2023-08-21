namespace Calcular_el_interes_compuesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            /*Calcular el interes compuesto de un monto inicial, tomando a consideracion que:
– Debe existir un monto inicial
– Debe existir un porcentaje
• El interes compuesto se calcula de la siguiente manera:
interescompuesto = montoInicial + (montoInicial ∗ (porcentaje/100))
Mostrar el resultado en un label*/

            double monto = double.Parse(txtMonto.Text), porcentaje = double.Parse(txtPorcentaje.Text);

            double interesCompuesto = monto + (monto * (porcentaje / 100));
            lblResultado.Text = "El interés compuesto es: "+ interesCompuesto ;




        }
    }
}