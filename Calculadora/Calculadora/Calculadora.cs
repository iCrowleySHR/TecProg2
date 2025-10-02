using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        public double Somar(double x, double y)
        {
            return x + y;
        }

        public double Subtrair(double x, double y) 
        { 
            return x - y;
        }

        public double Multiplicar(double x, double y)
        {
            return x * y;
        }

        public double Dividir(double x, double y) 
        {
            if (y ==  0) {
                return 0;
            }
            else
            {
                return x / y;
            }    
        }

        public double Imc(double x, double y)
        {
            return (x / (y * y));
        }

      
    }
}
