﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5___Estructura_de_programacion_secuensial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, producto;
            String linea;
            Console.Write("Ingrese primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            suma = num1 + num2;
            producto = num1 * num2;
            Console.Write("La suma de los dos valores es: ");
            Console.WriteLine(suma);
            Console.Write("El producto de los dos valores es: ");
            Console.Write(producto);
            Console.ReadKey();
        }
    }
}
