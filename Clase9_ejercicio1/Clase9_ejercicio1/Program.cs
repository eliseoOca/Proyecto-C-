using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int notas, mayores, menores,x;
            string linea;
            x = 1;
            mayores = 0;
            menores = 0;
            
            while (x <= 10)
            {
                Console.Write("Ingrese las notas del alumno: ");
                linea = Console.ReadLine();
                notas = int.Parse(linea);
                if (notas >= 7 || notas == 7)
                {
                    mayores = mayores + 1;
                }
                else
                {
                    if (notas < 7)
                    {
                        menores=menores + 1;
                    }
                    
                }
                x = x + 1;
            }
            
            Console.Write("Las notas iguales o mayores a 7: ");
            Console.WriteLine(mayores);
            Console.Write("Las notas menores a 7: ");
            Console.Write(menores);
            Console.ReadKey();  
        }
    }
}
