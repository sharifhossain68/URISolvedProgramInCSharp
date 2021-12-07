using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1011
{
    class Program
    {
        static void Main(string[] args)
        {

            double R, v,pi = 3.14159;
            R = Convert.ToDouble(Console.ReadLine());
            v = ((4 / 3.0) * pi * (R * R * R));
            Console.WriteLine("VOLUME = {0}", v.ToString("0.000"));
            Console.ReadKey();



        }
    }
}
