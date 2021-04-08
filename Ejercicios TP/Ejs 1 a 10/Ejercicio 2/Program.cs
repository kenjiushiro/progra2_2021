using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool esNumeroPositivo;

            Console.WriteLine("Ingresar numero:");
            esNumeroPositivo = int.TryParse(Console.ReadLine(), out numero) && numero > 0;

            while (!esNumeroPositivo)
            {
                Console.WriteLine("ERROR! Reingresar numero:");
                esNumeroPositivo = int.TryParse(Console.ReadLine(), out numero) && numero > 0;
            };

            Console.WriteLine("El cuadrado es " + Math.Pow(numero, 2));
            Console.WriteLine("El cubo es " + Math.Pow(numero, 3));
            Console.ReadKey();
        }
    }
}
