using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,x, sueldo, combran1, cobran2, importe;
            String linea;
            Console.Write("Ingresar cantidad de empleados");
            linea = Console.ReadLine();
            n=int.Parse(linea);
            x = 1;
            cobran2 = 0;
            combran1 = 0;
            importe = 0;
            while (x <= n)
            {
                Console.Write("Ingrese los sueldos: ");
                linea=Console.ReadLine();
                sueldo=int.Parse(linea);
                importe = importe + sueldo;

                if(sueldo >= 100 && sueldo <= 300)
                {
                    combran1++;
                }
                else
                {
                    if (sueldo > 300)
                    {
                        cobran2++;
                    }
                }
                x=x+1;
            }
            Console.Write("Los sueldo entre 100 y 300 son: ");
            Console.WriteLine(combran1);
            Console.Write("Los sueldo mayores a 300 son: ");
            Console.WriteLine(cobran2);
            Console.Write("El total de sueldos en monto es: ");
            Console.Write(importe);
            Console.ReadKey();
        }
    }
}
