using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01_TecProg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            inputIdade.Clear();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int idade;

            if (int.TryParse(inputIdade.Text, out idade))
            {
                if (idade >= 18)
                {
                    inputIdade.Clear();
                    MessageBox.Show("Maior de idade");
                }
                else
                {
                    inputIdade.Clear();
                    MessageBox.Show("Menor de idade");
                }
            }
            else
            {
                inputIdade.Clear();
                MessageBox.Show("Valor diferente de inteiro no campo idade");
            }
        }

    }
}
