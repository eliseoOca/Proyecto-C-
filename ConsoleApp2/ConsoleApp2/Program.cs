using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  x, n; 
            float altura, suma, promedio;
            string linea;

            Console.Write("Ingrese la cantidad de alturas: ");
            linea = Console.ReadLine();
            n=int.Parse(linea);
            x = 1;
            suma = 0;

             while (x <= n)
            {
                Console.Write("Ingrese las alturas de las porsonas");
                linea= Console.ReadLine();
                altura = float.Parse(linea);
                suma = suma + altura;
                x = x + 1;

            }
            promedio = suma / n;
            Console.Write("el promedio de las alturas es: ");
            Console.Write(promedio);
            Console.ReadKey();
        }
    }
}
