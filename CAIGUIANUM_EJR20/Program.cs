using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIANUM_EJR20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de 2 números al usuario y determine el mayor.
            string ingreso1;
            string ingreso2;
            
            bool seguir = true;
            while (seguir)
            {
                Console.Write("Ingrese un número: ");
                ingreso1 = Console.ReadLine();
                if (!double.TryParse(ingreso1, out double salida1))
                {
                    Console.WriteLine("No ingreso un número.");
                }

                Console.Write("Ingrese otro número: ");
                ingreso2 = Console.ReadLine();
                if (!double.TryParse(ingreso2, out double salida2))
                {
                    Console.WriteLine("No ingreso un número.");
                }

                Console.WriteLine($"El número mayor es {Math.Max(salida1, salida2)}");

                Console.WriteLine("¿Desea ingresar otro número? (S/N)");
                var tecla = Console.ReadKey(intercept: true);
                seguir = tecla.Key == ConsoleKey.S;
            }

            Console.ReadKey();

        }
    }
}
