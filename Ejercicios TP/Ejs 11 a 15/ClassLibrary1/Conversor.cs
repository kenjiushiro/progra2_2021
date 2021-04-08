using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            int exponente = 0;
            const int numeroBase = 2;
            string numeroBinario = string.Empty;

            while (Math.Pow(numeroBase, exponente) < numero)
                exponente += 1;

            int potencia;

            for(int i = exponente; i >= 0 ; i--)
            {
                potencia = (int)Math.Pow(2, i);
                if(potencia <= numero)
                {
                    numero -= potencia;
                    numeroBinario += "1";
                }
                else
                    numeroBinario += "0";
            }
            return numeroBinario;
        }
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static int BinarioDecimal(string numeroBinario)
        {
            const int numeroBase = 2;

            numeroBinario = Reverse(numeroBinario);
            int numeroDecimal = 0;

            for (int i = numeroBinario.Length - 1; i >= 0 ; i--)
                if (numeroBinario[i] == '1')
                    numeroDecimal += (int)Math.Pow(numeroBase, i);

            return numeroDecimal;
        }
    }
}
