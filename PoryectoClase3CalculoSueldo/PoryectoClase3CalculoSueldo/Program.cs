using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoryectoClase3CalculoSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            string linea;
            Console.WriteLine("Ingrese Horas trabajadas por el operario:");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);
            Console.WriteLine("Ingrese el pago por hora:");
            linea= Console.ReadLine();
            costoHora = float.Parse(linea);
            sueldo = horasTrabajadas * costoHora;
            Console.WriteLine("El sueldo total del operario es:");
            Console.WriteLine(sueldo); 
            Console.ReadLine();
        }
    }
}
