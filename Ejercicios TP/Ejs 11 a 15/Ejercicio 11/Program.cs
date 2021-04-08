using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimo = 101;
            int maximo = -101;
            int suma = 0;
            int numero;

            for(int i=0; i < 10 ; i++)
            {
                numero = pedirNumero();
                if (numero > maximo)
                    maximo = numero;
                if (numero < minimo)
                    minimo = numero;
                suma += numero;
            }
            Console.WriteLine(String.Format("El minimo es {0}", minimo));
            Console.WriteLine(String.Format("El maximo es {0}", maximo));
            Console.WriteLine(String.Format("El promedio es {0}", suma / 10));
            Console.ReadKey();
        }
        static int pedirNumero()
        {
            Console.WriteLine("Ingresar numero entre -100 y 100");
            int numero = int.Parse(Console.ReadLine());
            int minimo = -100;
            int maximo = 100;

            while (!Validacion.Validar(numero, minimo, maximo))
            {
                Console.WriteLine("Error! Ingresar numero entre -100 y 100");
                numero = int.Parse(Console.ReadLine());
            }
            return numero;

        }

    }
}
