using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar año inicial");
            int anioInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar año final");
            int anioFinal= int.Parse(Console.ReadLine());

            printearAniosBisiestosEntre(anioInicial, anioFinal);


        }
        static void printearAniosBisiestosEntre(int inicio, int fin)
        {
            for (int i = inicio; i <= fin; i++)
                if (esBisiesto(i))
                    Console.WriteLine(String.Format("{0} es bisiesto", i));
            Console.ReadKey();
        }
        static bool esBisiesto(int anio)
        {
            bool multiploDe4 = anio % 4 == 0;
            bool multiploDe100 = anio % 100 == 0;
            bool multiploDe400 = anio % 400 == 0;

            return (multiploDe4 && (!multiploDe100 || multiploDe400));
        }

    }
}
