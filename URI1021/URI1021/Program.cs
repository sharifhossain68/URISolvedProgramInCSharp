using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1021
{
    class Program
    {
        static void Main(string[] args)
        {

            double input;
            int a, b, c, d, e, f, g, h, i, j, k, n, l;
            input=Convert.ToDouble( Console.ReadLine());
            n =Convert.ToInt32( input*100);
            a = n / 10000; n = n % 10000;
            b = n / 5000; n = n % 5000;
            c = n / 2000; n = n % 2000;
            d = n / 1000; n = n % 1000;
            e = n / 500; n = n % 500;
            f = n / 200; n = n % 200;
            g = n / 100; n = n % 100;
            h = n / 50; n = n % 50;
            i = n / 25; n = n % 25;
            j = n / 10; n = n % 10;
            k = n / 5; n = n % 5;
            l = n;
            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", a);
            Console.WriteLine("{0} nota(s) de R$ 50.00", b);
            Console.WriteLine("{0} nota(s) de R$ 20.00", c);
            Console.WriteLine("{0} nota(s) de R$ 10.00", d);
            Console.WriteLine("{0} nota(s) de R$ 5.00", e);
            Console.WriteLine("{0} nota(s) de R$ 2.00", f);
            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", g);
            Console.WriteLine("{0} moeda(s) de R$ 0.50", h);
            Console.WriteLine("{0} moeda(s) de R$ 0.25", i);
            Console.WriteLine("{0} moeda(s) de R$ 0.10", j);
            Console.WriteLine("{0} moeda(s) de R$ 0.05", k);
            Console.WriteLine("{0} moeda(s) de R$ 0.01", l);
            Console.ReadKey();
        }
    }
}
