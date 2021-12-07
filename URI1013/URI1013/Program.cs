using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp,a, b, s;
            string[] values = Console.ReadLine().Split(' ');

            a = int.Parse(values[0]);
            b= int.Parse(values[1]);
            s = int.Parse(values[2]);

            tmp = a;
            if (a < b || a < s)
            {
                if (b < s)
                {
                    tmp = s;
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
