using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, termino;
            x = 1;
            termino = 11;
            while (x <= 25)
            {
                Console.Write(termino);
                Console.Write(" - ");
                x = x + 1;
                termino = termino + 11;
            }
            Console.ReadKey();
        }
    }
}
