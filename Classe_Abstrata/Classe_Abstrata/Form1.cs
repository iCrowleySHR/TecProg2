using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Abstrata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReajustar_Click(object sender, EventArgs e)
        {
            Classe_Programador P1 = new Classe_Programador();
            Classe_Designer D1 = new Classe_Designer();
            Classe_DesenvolvedorWeb DW = new Classe_DesenvolvedorWeb();

            string nome;
            decimal salario;

            nome=textBoxNome.Text;
            salario=decimal.Parse(textBoxSalario.Text);

            if (radioButtonDesigner.Checked)
            {
                D1.salario= salario;
                D1.nome= nome;

                D1.Reajustar();
                labelResultado.Text=D1.salario.ToString("C");

            }
            if (radioButtonDesenvolvedorWeb.Checked)
            {
                DW.salario = salario;
                DW.nome = nome;

                DW.Reajustar();
                labelResultado.Text = DW.salario.ToString("C");

            }
            if(radioButtonProgramador.Checked)
            {
                P1.salario = salario;
                P1.nome = nome;

                P1.Reajustar();
                labelResultado.Text = P1.salario.ToString("C");
            }

        }

    }
}
