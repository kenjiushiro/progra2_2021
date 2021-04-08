using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Validacion
    {
        /// <summary>
        /// valor: dato a validar
        /// min y max: rango en el cual deberá estar la variable valor.
        /// </summary>
        /// <param name="valor">dato a validar</param>
        /// <param name="min">rango en el cual deberá estar la variable valor.</param>
        /// <param name="max">rango en el cual deberá estar la variable valor.</param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            return (valor <= max && valor >= min);
        }
        public static bool ValidaS_N(char c)
        {
            return c == 'S';
        }
    }
}
