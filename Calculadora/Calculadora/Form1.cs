using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Calculadora calculadora = new Calculadora();
        double valor1, valor2;  

        public Form1()
        {
            InitializeComponent();
        }

        private void entradaDados()
        {
            valor1 = Convert.ToDouble(textValue1.Text);
            valor2 = Convert.ToDouble(textValue2.Text);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            entradaDados();
            labelResultado.Text = calculadora.Subtrair(valor1, valor2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            entradaDados();
            labelResultado.Text = calculadora.Multiplicar(valor1, valor2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            entradaDados();
            labelResultado.Text = calculadora.Dividir(valor1, valor2).ToString();
        }

        private void btnImc_Click(object sender, EventArgs e)
        {
            entradaDados();
            labelResultado.Text = calculadora.Imc(valor1, valor2).ToString();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            entradaDados();
            labelResultado.Text = calculadora.Somar(valor1, valor2).ToString();
        }
        
 
    }
}
