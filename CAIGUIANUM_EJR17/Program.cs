using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIANUM_EJR17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Solicite el ingreso de dos números al usuario y presente la suma, la resta, 
             * la multiplicación, la división, el resto, el primero elevado a la potencia del segundo.
             */
            Console.Write("Ingrese un número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            

            Console.Write("Ingrese otro número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

         
            int division = num1 / num2;
            //suma
            Console.WriteLine($"Suma: {num1 + num2}");
            //resta
            Console.WriteLine($"Resta: {num1 - num2}");
            //multiplicación
            Console.WriteLine($"Multiplicación: {num1 * num2}");
            //división
            Console.WriteLine($"División: {division}");
            //resto
            Console.WriteLine($"Resto: {Math.DivRem(num1, num2, out int res)}");
            //el primero elevado a la potencia del segundo     
            Console.WriteLine($"Potencia: {Math.Pow(num1, num2)}");

            Console.ReadKey();



        }


     
        
    }


}
