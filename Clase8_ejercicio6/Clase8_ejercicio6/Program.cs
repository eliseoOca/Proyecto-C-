using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  antiguedad ;
            float aumento, sueldo, totalPagar;
            String linea;
            Console.Write("Ingrese el sueldo: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            Console.Write("Ingrese la Antiguedad: ");
            linea= Console.ReadLine();
            antiguedad = int.Parse(linea);

            if (sueldo < 500 && antiguedad > 10)
            {
                aumento = sueldo * 0.20f;
                totalPagar = sueldo + aumento;
                Console.Write("Sueldo a pagar: ");
                Console.Write(totalPagar);
            }
            else
            {
                if (sueldo < 500)
                {
                     aumento = sueldo * 0.05f;
                     totalPagar = sueldo + aumento;
                    Console.Write("Sueldo a pagar:");
                    Console.Write(totalPagar);
                }
                else
                {
                    Console.Write("Sueldo a pagar:");
                    Console.Write(sueldo);
                }
            }
            Console.ReadKey();
        }
    }
}
