using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            String linea;
            Console.Write("Ingrese primer nro: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo nro: ");
            linea= Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese el tercer nro: ");
            linea=Console.ReadLine();
            num3= int.Parse(linea);

            if(num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.Write("Alguno o todos  los numeros es menor a 10: ");
                Console.WriteLine(num1 + "-" + num2 + "-" + num3);
            }
            else
            {
                Console.Write("Todos los numero son mayores a 10: ");
                Console.WriteLine(num1 + "-" + num2 + "-" + num3);
            }
            Console.ReadKey();
        }
    }
}
