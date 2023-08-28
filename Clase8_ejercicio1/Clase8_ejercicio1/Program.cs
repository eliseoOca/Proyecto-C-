using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;
            String linea;
            Console.Write("Ingrese nro de dia: ");
            linea = Console.ReadLine();
            dia=int.Parse(linea);
            Console.Write("Ingrese nro del mes: ");
            linea=Console.ReadLine();
            mes=int.Parse(linea);
            Console.Write("Ingrese nro del año: ");
            linea = Console.ReadLine();
            año=int.Parse(linea);

            if(dia==24 && mes == 12)
            {
                Console.Write("Esta fecha corresponde a Navidad: ");
                Console.WriteLine(dia + "/" + mes + "/" + año);
            }
            else
            {
                Console.Write("Esta fecha no corresponde a navidad: ");
                Console.WriteLine(dia + "/" + mes + "/" + año);
            }
            Console.ReadLine();
        }
    }
}
