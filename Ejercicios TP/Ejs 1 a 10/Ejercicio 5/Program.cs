using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar numero maximo para buscar centros numericos");
            int numeroMaximo = int.Parse(Console.ReadLine());

            printCentrosNumericos(numeroMaximo);

        }
        static void printCentrosNumericos(int numeroMaximo)
        {
            for (int i = 2; i <= numeroMaximo; i++)
                if (esCentroNumerico(i))
                    Console.WriteLine(String.Format("{0} es centro numerico", i));
            Console.ReadKey();
        }
        static bool esCentroNumerico(int numero)
        {
            int sumaIzquierda = getSumaIzquierda(numero);
            int sumaDerecha = getSumaDerechaHasta(numero, sumaIzquierda);

            return sumaIzquierda == sumaDerecha;
        }
        static int getSumaIzquierda(int numero)
        {
            int suma = 0;
            for (int i = 1 ; i < numero; i++)
                suma += i;
            return suma;
        }
        static int getSumaDerechaHasta(int numero, int numeroMaximo)
        {
            int suma = 0;
            int i = numero + 1;
            while (suma < numeroMaximo)
            {
                suma += i;
                i++;
            }
            return suma;
        }

    }
}
