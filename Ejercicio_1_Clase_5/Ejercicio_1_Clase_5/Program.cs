using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Clase_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado, perimetro;
            String linea;
            Console.Write("Ingrese el lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado * 4;
            Console.Write("El perimetro del cuadrado es: ");
            Console.Write(perimetro);
            Console.ReadKey();
           

        }
    }
}
