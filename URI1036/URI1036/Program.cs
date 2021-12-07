using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,r;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            r = Math.Sqrt((b * b) - 4 * a * c);
            if((b * b) - 4 * a * c<0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = {0}",((-b+r)/(2*a)).ToString("0.00000"));
                Console.WriteLine("R2 = {0}",((-b-r)/(2*a)).ToString("0.00000"));
            }
            Console.ReadKey();

        }
    }
}
