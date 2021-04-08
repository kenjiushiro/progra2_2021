
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar numero entero a transformar en binario");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("El numero {0} en binario es {1}", numero, Conversor.DecimalBinario(numero)));

            Console.WriteLine();

            Console.WriteLine("Ingresar numero binario a transformar en entero");
            string binario = Console.ReadLine();
            Console.WriteLine(String.Format("El numero {0} en decimal es {1}", binario, Conversor.BinarioDecimal(binario)));

            Console.ReadKey();
        }
    }
}
