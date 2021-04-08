using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar cantidad de pisos de la piramide");
            int cantidadPisos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidadPisos; i++)
                imprimirPisoX(i, cantidadPisos);
            Console.ReadKey();
        }
        static void imprimirPisoX(int piso, int pisosTotales)
        {
            int ancho = (piso - 1) * 2 + 1;
            string caracter = "*";
            string vacio = " ";

            for (int i = 0; i < pisosTotales - piso; i++)
                Console.Write(vacio);

            for (int i = 0; i < ancho; i++)
                Console.Write(caracter);
            Console.WriteLine();

        }
    }
}
