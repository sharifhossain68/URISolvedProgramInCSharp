using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, tmp;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            tmp = a;
            if (a < b || a < c)
            {
                if (b < c)
                {
                    tmp = c;
                }
                else
                {
                    tmp = b;
                }
            }

            Console.WriteLine("{0} eh o maior", tmp);
            Console.ReadKey();
        }
    }
}
