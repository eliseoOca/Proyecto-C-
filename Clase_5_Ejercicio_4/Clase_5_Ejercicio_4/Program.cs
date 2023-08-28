using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5_Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float precio, cantidad, total;
            String linea;
            Console.Write("Ingrese el precio del articulo: ");
            linea = Console.ReadLine();
            precio = float.Parse(linea);
            Console.Write("Ingrese cantidad de Articulo/os: ");
            linea = Console.ReadLine();
            cantidad = float.Parse(linea);
            total = precio * cantidad;
            Console.Write("La suma total a pagar es: "+"$");
            Console.Write(total);
            Console.ReadKey();
        }

        }
    }

