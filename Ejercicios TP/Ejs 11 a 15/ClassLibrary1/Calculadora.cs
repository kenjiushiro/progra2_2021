using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculadora
    {
        public static double Calcular(double numero1, double numero2, char operacion)
        {
            switch (operacion)
            {
                case '+':
                    return numero1 + numero2;
                case '-':
                    return numero1 - numero2;
                case '*':
                    return numero1 * numero2;
                case '/':
                    return Validar(numero2) ? numero1 / numero2 : 0;
                default:
                    return 0;
            }
        }
        private static bool Validar(double numero)
        {
            return numero != 0;
        }
    }
}
