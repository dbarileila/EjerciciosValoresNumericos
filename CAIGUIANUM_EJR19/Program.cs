using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIANUM_EJR19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de un número al usuario y presente la parte entera.
            bool seguir = true;
            while (seguir)
            {
                Console.Write("Ingrese un número decimal: ");
                string ingreso = Console.ReadLine();

                if (!double.TryParse(ingreso, out double salida))
                {
                    Console.WriteLine("Usted no ingreso un número decimal.");

                }
                else
                {
                    Console.WriteLine($"Número ingresado: {salida}");
                    Console.WriteLine($"Número redondeado: {Math.Round(salida)}");
                    Console.WriteLine();
                    Console.WriteLine("¿Desea ingresar otro número? (S/N)");
                    var tecla = Console.ReadKey(intercept: true);
                    seguir = tecla.Key == ConsoleKey.S;
                }

            }

        }
    }
}
