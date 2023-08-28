using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            String linea;
            Console.Write("Ingrese Coordenada x: ");
            linea = Console.ReadLine();
            x=int.Parse(linea);
            Console.Write("Ingrese Coordenada y: ");
            linea=Console.ReadLine();
            y = int.Parse(linea);

            if (x > 0 && y > 0)
            {
                Console.Write("la Posicion primer cuadrante");
            }
            else
            {
                if(x < 0 && y > 0)
                {
                    Console.Write("la Posicion segundo cuadrante");
                }
                else
                {
                    if(x < 0 && y < 0)
                    {
                        Console.Write("la Posicion pertenece al tercer cuadrante");
                    }
                    else
                    {
                        Console.Write("la Posicion pertenece al cuarto cuadrante");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
