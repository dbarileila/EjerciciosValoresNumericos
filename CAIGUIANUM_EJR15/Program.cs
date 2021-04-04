using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIANUM_EJR15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite un ingreso al usuario y determine si puede ser interpretado como un valor numérico.

            bool bl = false;

            do
            {
                Console.Write("Ingrese un valor numérico: ");
                string ingreso = Console.ReadLine();

                if (int.TryParse(ingreso, out int salida))
                {
                    Console.WriteLine($"Usted ingreso el número {ingreso} ");
                    break;
                }
                else
                {
                    Console.WriteLine("Usted no ingreso un valor numérico.");
                }

            } while (bl == false);

            Console.ReadKey();
        }
    }
}
