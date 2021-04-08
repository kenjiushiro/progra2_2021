using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float importeAPagar = 0;
            do
            {
                importeAPagar += pedirInputYCalcularPrecio();
            } while (seguirCargando());

            Console.WriteLine(String.Format("El importe total a pagar es {0}", importeAPagar));
            Console.ReadKey();
        }
        static bool seguirCargando()
        {
            string respuesta;
            do
            {
                Console.WriteLine("Seguir cargando sueldos? S/N");
                respuesta = Console.ReadLine().ToLower();

            } while(respuesta != "s" && respuesta != "n");

            return respuesta == "s";
        }
        static float pedirInputYCalcularPrecio()
        {
            Console.WriteLine("Ingresar valor por hora: ");
            float precio = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar nombre: ");
            Console.ReadLine();

            Console.WriteLine("Ingresar antigüedad (años): ");
            int antiguedad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());

            float descuento = 0.13F;
            float importeBruto = horasTrabajadas * precio + antiguedad * 150;
            float importeNeto = importeBruto * (1 - descuento);

            return importeNeto;
        }
    }
}
