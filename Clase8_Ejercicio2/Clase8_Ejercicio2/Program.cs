using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, suma, multiplica;
            String linea;
            Console.Write("Ingrese primer valor: ");
            linea = Console.ReadLine();
            num1=int.Parse(linea);
            Console.Write("Ingrese el segundo valor: ");
            linea=Console.ReadLine();
            num2=int.Parse(linea);
            Console.Write("Ingrese el tercer valor: ");
            linea = Console.ReadLine();
            num3=int.Parse(linea);

            if(num1 == num2 && num1 == num3 && num2 == num3)
            {
                suma = num1 + num2;
                multiplica = suma * num3;
                Console.Write("La suma de los dos primeros numero y multiplicado por el tercer Nro: ");
                Console.WriteLine(num1+ "+" + num2+ "=" + suma + "*" + num3 + "=" + multiplica);
                
            }
            else
            {
                Console.Write("Los nros ingresados con coinciden :");
                Console.Write(num1 + "-" + num2 + "-" + num3);
            }
            Console.ReadLine();
        }
    }
}
