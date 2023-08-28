using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7_ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            String linea;
            Console.Write("Ingresa un numero: ");
            linea = Console.ReadLine();
            num=int.Parse(linea);

            if (num > 0)
            {
                Console.Write("El nunmero ingresado es positivo: ");
                Console.Write(num);
            }
            else
            {
                if (num == 0)
                {
                    Console.Write("El numero ingrasado es nulo: ");
                    Console.Write(num);
                }
                else
                {
                    Console.Write("El numero ingresado es negativo: ");
                    Console.Write(num);
                }
            }
            Console.ReadKey();

        }
    }
}
