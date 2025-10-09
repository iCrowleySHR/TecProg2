using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_heranca
{
    internal  class Classe_Pessoa
    {

        public string nome;
        public int idade;


        public string resultado(int idade)
        {
            if (idade >= 18)
            {
                return "Maior de idade";
            }
            else
            {
                return "Menor de idade";
            }
        }

    }
}
