using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f, n, altura, basetri, superficie, cantidad;
            String linea;
            cantidad = 0;
            Console.Write("Ingrese cantidad de triangulos: ");
            linea = Console.ReadLine();
            n=int.Parse(linea);

            for (f = 1; f <= n; f++)
            {
                Console.Write("Ingrese la altura: ");
                linea=Console.ReadLine();
                altura=int.Parse(linea);
                Console.Write("Ingrese la base: ");
                linea = Console.ReadLine();
                basetri=int.Parse(linea);
                superficie = basetri * altura / 2;
                Console.Write("La madida del triangulo es: ");
                Console.WriteLine(superficie);
                if (superficie > 12)
                {
                    cantidad=cantidad + 1;
                }
            }
            Console.Write("La cantidad de triángulos con superficie superior a 12 son: ");
            Console.Write(cantidad);
            Console.ReadKey();
        }
    }
}
