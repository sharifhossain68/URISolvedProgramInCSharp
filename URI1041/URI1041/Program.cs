using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1041
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            string[] s = Console.ReadLine().Split(' ');
            x = float.Parse(s[0]);
            y = float.Parse(s[1]);
            if(x==0 && y==0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x>0 && y>0)
            {
                Console.WriteLine("Q1");
            }
               else if (x>0&& y<0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else 
            {
                Console.WriteLine("Q2");
            }
            Console.ReadKey();
        }
    }
}
