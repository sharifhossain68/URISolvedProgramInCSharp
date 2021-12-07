using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double p;
            a=Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            p = (a * b) / 12.00;
            Console.WriteLine("{0}",p.ToString("00.000"));
            Console.ReadKey();
        }
    }
}
