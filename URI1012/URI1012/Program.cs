using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1012
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("TRIANGULO: {0}", ((a * c) / 2).ToString("0.000"));
            Console.WriteLine("CIRCULO: {0}", (c * c * 3.141590).ToString("0.000"));
            Console.WriteLine("TRAPEZIO: {0}", (((a + b) / 2) * c).ToString("0.000"));
            Console.WriteLine("QUADRADO: {0}", (b * b).ToString("0.000"));
            Console.WriteLine("RETANGULO: {0}", (a * b).ToString("0.000"));
            Console.ReadKey();
        }       
            
    }
}
