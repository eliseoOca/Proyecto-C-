using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7_ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int preguntas, respuestas, porcetanje;
            String linea;
            Console.Write("Ingrese la cantidad total de preguntas del examen: ");
            linea = Console.ReadLine();
            preguntas=int.Parse(linea);
            Console.Write("Ingrese la cantidad total de preguntas contestadas correctamente: ");
            linea=Console.ReadLine();
            respuestas=int.Parse(linea);

            porcetanje=respuestas * 100 / preguntas;

            if (porcetanje >= 90)
            {
                Console.Write("Nivel maximo: ");
                Console.Write(porcetanje);
            }
            else
            {
                if (porcetanje >= 75)
                {
                    Console.Write("Nivel medio: ");
                    Console.Write(porcetanje);
                }
                else
                {
                    if (porcetanje >= 50)
                    {
                        Console.Write("Nivel regular: ");
                        Console.Write(porcetanje);
                    }
                    else
                    {
                        Console.Write("Fuera de nivel: ");
                        Console.Write(porcetanje);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
