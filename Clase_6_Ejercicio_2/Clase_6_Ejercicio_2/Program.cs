using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, promedio;
            String linea;
            Console.Write("Ingrese nota 1: ");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);
            Console.Write("Ingrese nota 2: ");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);
            Console.Write("Ingrese nota 3: ");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);
            promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio>= 7) 
            {
                Console.Write("Promocionado");
            }
            Console.ReadKey();
        }
    }
}
