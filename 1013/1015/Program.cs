using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1, x2, y1, y2, dist;

            //scanf("%lf %lf %lf %lf", &x1, &y1, &x2, &y2);
            x1 = Convert.ToDouble(Console.ReadLine());
            y1  = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            dist = Math.Sqrt(x2 - x1) + Math.Sqrt(y2 - y1);

            Console.WriteLine("{0}", dist.ToString("0.0000"));
            Console.ReadKey();

        }
    }
}
