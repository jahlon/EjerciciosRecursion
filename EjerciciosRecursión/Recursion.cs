using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRecursión
{
    internal class Recursion
    {
        public static void ImprimirNumerosNaturalesHasta(int n)
        {
            if (n > 0)
            {
                ImprimirNumerosNaturalesHasta(n - 1);
                Console.Write($"{n}\t");
            }
        }

        public static void ImprimirNumerosDesdeNHasta1(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n}\t");
                ImprimirNumerosDesdeNHasta1(n - 1);
            }
        }

        public static int SumarPrimeroNNaturales(int n)
        {
            if (n > 0)
            {
                return n + SumarPrimeroNNaturales(n - 1);
            }
            else
            {
                return 0;
            }
        }

        public static void ImprimirDigitosDelNumero(int numero)
        {
            if (numero > 0)
            {
                ImprimirDigitosDelNumero(numero / 10);
                Console.Write($"{numero % 10} ");
            }
        }

        public static int ContarDigitosEnNumero(int numero)
        {
            if(numero > 0)
            {
                return 1 + ContarDigitosEnNumero(numero / 10);
            }
            return 0;
        }

        public static void ImprimirNumerosParesEnRango(int inf, int sup)
        {
            if (inf % 2 == 1)
                inf += 1;

            if (inf < sup)
            {
                Console.Write($"{inf} ");
                ImprimirNumerosParesEnRango(inf + 2, sup);
            }
        }

        public static bool EsPalindromo(string palabra)
        {
            if (palabra.Length <= 1)
                return true;
            else
            {
                if (palabra[0] != palabra[palabra.Length - 1])
                    return false;
                else
                    return EsPalindromo(palabra.Substring(1, palabra.Length - 2));
            }
        }

        public static int Factorial(int numero)
        {
            if (numero == 0)
                return 1;

            return numero * Factorial(numero - 1);
        }

        public static int ElevarNumeroAPotencia(int numero, int potencia)
        {
            if (potencia == 0)
                return 1;

            return numero * ElevarNumeroAPotencia(numero, potencia - 1);
        }
    }
}
