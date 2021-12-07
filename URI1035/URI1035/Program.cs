using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            a =int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            if(b>c && d>a && (a+b)<(c+d)&&c>0 && d>0 && (a % 2 == 0))
            {
                Console.WriteLine("Accepted values");
            }
            else
            {
                Console.WriteLine("Values not accepted");
            }
            Console.ReadKey();
        }
    }
}
