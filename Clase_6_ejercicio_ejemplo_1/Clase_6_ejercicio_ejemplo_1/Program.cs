using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_ejercicio_ejemplo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            String linea;
            Console.Write("Ingrese el sueldo: ");
            linea = Console.ReadLine();
            sueldo=float.Parse(linea);
            if (sueldo > 3000) 
            {
                Console.Write("Esta persona debe abonar impuestos");
            }
            Console.ReadKey();
        }
    }
}
