using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            double numero;
            double maximo = double.MinValue;
            double minimo = double.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresar Numero:\n");
                numero = double.Parse(Console.ReadLine());
                suma += numero;

                if (numero > maximo)
                    maximo = numero;

                if (numero < minimo)
                    minimo = numero;

            }
            Console.WriteLine(String.Format("El mayor es {0}", maximo));
            Console.WriteLine(String.Format("El minimo es {0}", minimo));
            Console.WriteLine(String.Format("El promedio es {0}", suma / 5));
            Console.ReadKey();
        }
    }
}
