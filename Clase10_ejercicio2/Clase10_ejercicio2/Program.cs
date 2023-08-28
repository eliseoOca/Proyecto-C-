using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10_ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f, n, suma;
            String linea;
            suma = 0;
            for (f = 1; f <= 10; f++)
            {
                Console.Write("Ingreselos numeros: ");
                linea = Console.ReadLine();
                n=int.Parse(linea);
                if (f > 5)
                {
                    suma=suma+n;

                }
            }
            Console.Write("");
        }
    }
}
