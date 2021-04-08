using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingresar numero: ");
                Console.ReadLine();
                Console.WriteLine("Seguir ingresando numeros? (S/N) ");
            } while (Validacion.ValidaS_N(char.Parse(Console.ReadLine())));
            
        }
    }
}
