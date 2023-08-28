using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;
            while (x <= 500)
            {
                Console.Write(x);
                Console.Write(" - ");
                x = x + 1;
            }
            Console.ReadKey();

        }
    }
}
