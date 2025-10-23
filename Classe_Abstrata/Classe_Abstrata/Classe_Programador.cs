using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata
{
    internal class Classe_Programador:Classe_Funcionario
    {
        public override void Reajustar()
        {
            salario += 1000;
        }

    }
}
