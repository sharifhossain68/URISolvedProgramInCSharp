using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string[] str = Console.ReadLine().Split(' ');
            a = int.Parse(str[0]);
            b = int.Parse(str[1]);
         
            if(b%a==0 || a%b==0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
            Console.ReadKey();
        }
    }
}
