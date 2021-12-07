using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1037
{
    class Program
    {
        static void Main(string[] args)
        {
            //float n;
            //n =float.Parse(Console.ReadLine());
            //if(n<0 || n>100)
            //{
            //    Console.WriteLine("Fora de intervalo");
            //}
            //else if(n>0 && n<=25)
            //{
            //    Console.WriteLine("Intervalo [0,25]");
            //}
            //else if (n > 25 && n <= 50)
            //{
            //    Console.WriteLine("Intervalo (25,50]");
            //}
            //else if (n > 50 && n <= 75)
            //{
            //    Console.WriteLine("Intervalo (50,75]");
            //}
            //else
            //{
            //    Console.WriteLine("Intervalo (75,100]");
            //}
            float a;
            a = float.Parse(Console.ReadLine());
            if (a >= 0 && a <= 100)
            {
                if (a >= 0 && a <= 25)
                {
                    Console.WriteLine("Intervalo [0,25]");
                }
                else if (a >= 25 && a <= 50)
                {
                    Console.WriteLine("Intervalo (25,50]");
                }
                else if (a >= 50 && a <= 75)
                {
                    Console.WriteLine("Intervalo (50,75]");
                }
                else
                {
                    Console.WriteLine("Intervalo (75,100]");
                }
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            Console.ReadKey();
        }
    }
}
