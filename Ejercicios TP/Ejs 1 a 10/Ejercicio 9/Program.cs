using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar cantidad de pisos de la piramide");
            int cantidadPisos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidadPisos; i++)
                imprimirPisoX(i);
            Console.ReadKey();
        }
        static void imprimirPisoX(int piso)
        {
            int ancho = (piso - 1) * 2 + 1;
            string caracter = "*";

            for (int i = 0; i < ancho; i++)
                Console.Write(caracter);
            Console.WriteLine();

        }
    }
}
