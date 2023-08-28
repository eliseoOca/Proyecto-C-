using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            String linea;
            Console.Write("Ingrese el primer Numero: ");
            linea = Console.ReadLine();
            num1=int.Parse(linea);
            Console.Write("Ingrese el segundo Numero: ");
            linea=Console.ReadLine();
            num2= int.Parse(linea);
            Console.Write("Ingrese el tercer Numero: ");
            linea= Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 > num2)
            {
                if (num1> num3)
                {
                    Console.Write(num1);
                }
                else
                {
                    Console.Write(num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.Write(num2);
                }
                else
                {
                    Console.Write(num3);
                }
            }
            Console.ReadKey();
           
        }
    }
}
