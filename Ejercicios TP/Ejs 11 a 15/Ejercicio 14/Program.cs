using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar lado del cuadrado");
            double lado = double.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("El area del cuadrado es {0}", CalculoDeArea.CalcularCuadrado(lado)));

            Console.WriteLine("Ingresar base del triangulo");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar altura del triangulo");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("El area del triangulo es {0}", CalculoDeArea.CalcularTriangulo(baseTriangulo, altura)));

            Console.WriteLine("Ingresar radio del circulo");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("El area del circulo es {0}", CalculoDeArea.CalcularCirculo(radio)));

            Console.ReadKey();

        }
    }
}
