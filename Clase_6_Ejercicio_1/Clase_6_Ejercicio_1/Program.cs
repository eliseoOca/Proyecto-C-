using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, diferencia, producto, division;
            String linea;
            Console.Write("Ingrese primer valor: ");
            linea = Console.ReadLine(); 
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            
            if(num1 > num2) 
            {
                suma = num1 + num2;
                Console.Write("La suma de los dos valores es : ");
                Console.WriteLine(suma);
                diferencia = num1 - num2;
                Console.Write("La diferencia de los dos valores es : ");
                Console.WriteLine(diferencia);
            }
            else
            {
                    producto = num1 * num2;
                    Console.Write("El producto de los dos valores es: ");
                    Console.WriteLine(producto);
                    division= num1 / num2;
                    Console.Write("La division de los dos valores es: ");
                    Console.WriteLine(division);    
                
            }
            Console.ReadLine();

        }
    }
}
