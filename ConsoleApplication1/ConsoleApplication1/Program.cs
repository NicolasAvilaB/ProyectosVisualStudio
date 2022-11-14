using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String cad = "";
            double c = 1;
            int sel, q, u = 1;
            Console.WriteLine("elige una opcion\n");
            Console.WriteLine("1. Mostrar los 20 primeros cubos\n");
            Console.WriteLine("2. Mostrar los cubos que tengan hasta 4 digitos\n");
            Console.WriteLine("3. Mostrar los cubos que exactamente tengan 4 digitos\n");
            sel = Convert.ToInt32(Console.ReadLine());
            if (sel == 1)
            {
                for (q = 1; q < 21; q++)
                    cad = cad + " " + Math.Pow(q, 3);

            }
            if (sel == 2)
            {
                while (c < 10000)
                {
                    cad = cad + " " + c;
                    u++;
                    c = Math.Pow(u, 3);
                }
            }
            if (sel == 3)
            {
                while (c < 10000)
                {
                    if (c >= 1000)
                        cad = cad + " " + c;

                    u++;
                    c = Math.Pow(u, 3);
                }
            }
            Console.WriteLine(cad);
            Console.ReadLine();

        }
    }
}
