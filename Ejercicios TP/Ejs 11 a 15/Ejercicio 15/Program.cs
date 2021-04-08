using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            double numero1;
            double numero2;
            char operacion;

            do
            {
                Console.WriteLine("Ingresar numero 1");
                numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar numero 2");
                numero2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar operacion");
                operacion = char.Parse(Console.ReadLine());
                Console.WriteLine(String.Format("El resultado es {0}", Calculadora.Calcular(numero1, numero2, operacion)));

                Console.WriteLine("Seguir ingresando operaciones?");
                continuar = char.Parse(Console.ReadLine());
            } while (Validacion.ValidaS_N(continuar));
        }
    }
}
