﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0]);
            b= double.Parse(values[1]);
            c = double.Parse(values[2]);
            if (a >= (b + c) || b >= (a + c) || c >= (a + b))
             Console.WriteLine(   "NAO FORMA TRIANGULO");
            else if (a * a == (b * b + c * c) || b * b == (a * a + c * c) || c * c == (a * a + b * b))
                Console.WriteLine("TRIANGULO RETANGULO" );
            else if (a * a > (b * b + c * c) || b * b > (a * a + c * c) || c * c > (a * a + b * b))
                Console.WriteLine("TRIANGULO OBTUSANGULO" );
            else if (a * a < (b * b + c * c) || b * b < (a * a + c * c) || c * c < (a * a + b * b))
                Console.WriteLine("TRIANGULO ACUTANGULO") ;
            if (a == b && a == c)
                Console.WriteLine("TRIANGULO EQUILATERO" );
            if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
                Console.WriteLine("TRIANGULO ISOSCELES" );
            Console.ReadKey();

        }
    }
}
