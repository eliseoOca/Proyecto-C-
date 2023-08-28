using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5_Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, producto;
            String linea;
            Console.Write("Ingrese el primero Numero: ");
            linea = Console.ReadLine(); 
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo Numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese el tercer Numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.Write("Ingrese el cuarto Numero: ");
            linea= Console.ReadLine();
            num4 = int.Parse(linea);
            suma = num1 + num2;
            producto = num3 * num4;
            Console.Write("La suma de los dos primero Numeros es : ");
            Console.WriteLine(suma);
            Console.Write("El producto de los dos ultimos Numero es : ");
            Console.Write(producto);
            Console.ReadKey();

        }
    }
}
