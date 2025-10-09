using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_heranca
{
    internal class Classe_Aluno:Classe_Pessoa
    {
        public int nro_matricula;
        public string curso;


         public void exibir()
        {
            System.Windows.Forms.MessageBox.Show("Nome: " + nome + "\nIdade: " + idade.ToString() + "\nMatrícula:" + nro_matricula.ToString() + "\nCurso:" + curso);
        }
    }
}
