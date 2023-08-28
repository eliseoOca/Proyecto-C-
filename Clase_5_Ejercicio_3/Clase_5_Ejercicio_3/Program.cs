using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5_Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, promedio;
            string linea;
            Console.Write("Ingrese primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese tercer valor: ");
            linea= Console.ReadLine();
            num3 = int.Parse(linea);
            Console.Write("Ingrese cuarto valor: ");
            linea=Console.ReadLine();
            num4 = int.Parse(linea);
            suma = num1 + num2 + num3 + num4;
            promedio =suma/4;
            Console.Write("La suma de todos los valores es: ");
            Console.WriteLine(suma);
            Console.Write("El promedio de la suma es : ");
            Console.Write(promedio);
            Console.ReadKey();
        }
    }
}
