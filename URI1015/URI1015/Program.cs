using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1015
{
    class Program
    {
        static void Main(string[] args)
        {

        

            double x1, x2, y1, y2,p1,p2, dist;

            string[] values = Console.ReadLine().Split(' ');
            x1 = double.Parse(values[0]);
            y1 = double.Parse(values[1]);

            string[] values2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(values2[0]);
            y2 = double.Parse(values2[1]);
            p1 = x2 - x1;
            p2 = y2 - y1;
            dist = Math.Sqrt((p1 * p1) + (p2 * p2));
            Console.WriteLine("{0}", dist.ToString("0.0000"));
            Console.ReadKey();
        }
    }
}
