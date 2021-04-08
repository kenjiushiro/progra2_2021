using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroMaximo;
            Console.WriteLine("Ingresar numero limite: ");
            numeroMaximo = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroMaximo; i++)
                if (EsPrimo(i))
                    Console.WriteLine(String.Format("{0} es primo", i));

            Console.ReadKey();
        }

        static bool EsPrimo(int numero)
        {
            for (int i = 2; i <= numero/2; i++)
                if (numero % i == 0)
                    return false;

            return true;
        }
    }
}
