using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            printNumerosPerfectos(4);
        }
        static void printNumerosPerfectos(int cantidadMaxima)
        {
            int numerosPerfectosCount = 0;

            for (int i = 2; numerosPerfectosCount < cantidadMaxima; i++)
                if (esNumeroPerfecto(i))
                {
                    numerosPerfectosCount += 1;
                    Console.WriteLine(String.Format("{0} es numero perfecto", i));
                }
            Console.ReadKey();
        }
        static bool esNumeroPerfecto(int numero)
        {
            List<int> divisores = getDivisoresDe(numero);
            int suma = divisores.Sum();
            return suma == numero;
        }
        static List<int> getDivisoresDe(int numero)
        {
            List<int> divisores = new List<int>();

            for (int i = 1; i <= numero / 2; i++)
                if (esDivisorDe(numero, i))
                    divisores.Add(i);

            return divisores;
        }

        static bool esDivisorDe(int numeroBase, int divisor)
        {
            return numeroBase % divisor == 0;
        }
    }
}
