using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_Ejecicio_Ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            String linea;
            Console.Write("Ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1=int.Parse(linea);
            Console.Write("Ingrese el segundo valor: ");
            linea=Console.ReadLine();
            num2 = int.Parse(linea);
            if (num1 > num2) 
            {
                Console.Write("El mayor es: ");
                Console.Write(num1);
            }
            else 
            {
                Console.Write("El mayor es: ");
                Console.Write(num2);
            }
            Console.ReadKey();
        }
    }
}
