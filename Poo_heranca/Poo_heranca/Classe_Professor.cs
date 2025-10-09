using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_heranca
{
    internal class Classe_Professor:Classe_Pessoa
    {
        public string disciplina;
        public double salario;

        public void exibir()
        {
            System.Windows.Forms.MessageBox.Show("Nome: " + nome + "\nIdade: " + idade.ToString() + "\nSalário:" + salario.ToString() + "\nDisciplina:" + disciplina);
        }
    }
}
