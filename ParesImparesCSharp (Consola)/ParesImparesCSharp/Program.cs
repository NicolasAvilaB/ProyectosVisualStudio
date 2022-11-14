using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesImparesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double n;    
            Console.WriteLine("Ingrese Numero");
            num1 = double.Parse(Console.ReadLine());

            if (num1 % 2 != 0)
            {
                Console.WriteLine("El numero " + num1 + " es impar");
                            }
            else
            {
                Console.WriteLine("El numero " + num1 + " es par");
            }
            Console.ReadLine();
        }
    }
}
