using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar año de nacimiento");
            int anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar mes de nacimiento");
            int mes= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar dia de nacimiento");
            int dia = int.Parse(Console.ReadLine());

            printearDiasDesde(dia, mes, anio);
        }
        static void printearDiasDesde(int dia, int mes, int anio)
        {
            Console.WriteLine(String.Format("Pasaron {0} dias", contarDiasDesde(dia, mes, anio)));
            Console.ReadKey();
        }
        static bool esBisiesto(int anio)
        {
            bool multiploDe4 = anio % 4 == 0;
            bool multiploDe100 = anio % 100 == 0;
            bool multiploDe400 = anio % 400 == 0;

            return (multiploDe4 && (!multiploDe100 || multiploDe400));
        }
        static int contarDiasDesde(int dia, int mes, int anio)
        {
            DateTime hoy = DateTime.Now;

            if (esFechaFutura(dia, mes, anio))
                return 0;
            if (anio == hoy.Year)
                return contarDiasEnEsteAnio(dia, mes, anio);
            return contarDiasDeAniosPasados(dia, mes, anio);
        }
        static int contarDiasEnEsteAnio(int dia, int mes, int anio)
        {
            DateTime hoy = DateTime.Now;
            int cantidadDias = 0;

            if (mes == hoy.Month)
                return hoy.Day - dia;

            cantidadDias += contarDiasHastaPrincipioDeMes(hoy.Day);
            cantidadDias += contarDiasHastaFinDeMes(dia, mes, anio);

            for (int i = mes + 1; i < hoy.Month; i++)
                cantidadDias += diasEnMes(i, anio);
            return cantidadDias;
        }
        static int contarDiasDeAniosPasados(int dia, int mes, int anio)
        {
            DateTime hoy = DateTime.Now;
            int cantidadDias = 0;
            cantidadDias += contarDiasDesdePrincipioDeAnio();
            cantidadDias += contarDiasHastaFinDeAnio(dia, mes, anio);

            for (int i = anio + 1; i < hoy.Year; i++)
                cantidadDias += diasEnAnio(i);
            return cantidadDias;
        }
        static bool esFechaFutura(int dia, int mes, int anio)
        {
            DateTime hoy = DateTime.Now;
            bool anioFuturo = anio > hoy.Year;
            bool esteAnio = anio == hoy.Year;
            bool mesFuturo = mes > hoy.Month;
            bool esteMes = mes == hoy.Month;
            bool diaFuturo = dia > hoy.Day;

            return ( anioFuturo || (esteAnio && mesFuturo) ||(esteAnio && esteMes && diaFuturo));

        }
        static int contarDiasDesdePrincipioDeAnio()
        {
            DateTime hoy = DateTime.Now;
            return contarDiasEnEsteAnio(1, 1, hoy.Year);
        }
        static int contarDiasHastaFinDeAnio(int dia, int mes, int anio)
        {
            DateTime hoy = DateTime.Now;
            int cantidadDias = 0;
            cantidadDias += contarDiasHastaFinDeMes(dia, mes, anio);
            for (int i = mes +1; i <= 12;  i++)
                cantidadDias += diasEnMes(i, hoy.Year);
            return cantidadDias;
        }
        static int contarDiasHastaFinDeMes(int dia, int mes, int anio)
        {
            return diasEnMes(mes, anio) - dia + 1; 
        }
        static int contarDiasHastaPrincipioDeMes(int dia)
        {
            return dia;
        }
        static int diasEnMes(int mes, int anio)
        {
            switch (mes)
            {
                case 2:
                    return esBisiesto(anio) ? 29 : 28;
                case 11:
                case 4:
                case 6:
                case 9:
                    return 30;
                default:
                    return 31;
            }
        }
        static int diasEnAnio(int anio)
        {
            return esBisiesto(anio) ? 366 : 365;
        }
    }
}
