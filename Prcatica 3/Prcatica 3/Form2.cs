using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prcatica_3
{
    public partial class Form2 : Form
    {
        Calculadora objeto1 = new Calculadora(2, 8);


        public Form2()
        {
            InitializeComponent();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El resultado de la suma es: "+objeto1.suma().ToString());
            MessageBox.Show("El resultado de la resta es: " + objeto1.resta().ToString());
            MessageBox.Show("El resultado de la division es: " + objeto1.division().ToString());
            MessageBox.Show("El resultado de la multiplicacion es: " + objeto1.multiplicacion().ToString());


        }
    }
}
