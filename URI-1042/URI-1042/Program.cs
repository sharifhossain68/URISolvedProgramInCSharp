using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, min, mid, max; 
            string[] s = Console.ReadLine().Split(' ');

          
           a= int.Parse(s[0]);
           b= int.Parse(s[1]);
           c= int.Parse(s[2]);
          
            
            if (a < b && a < c)
            {
                min = a;
                if (b < c)
                {
                    mid = b;
                    max = c;
                }
                else
                {
                    mid = c;
                    max = b;
                }
            }
            else if (b < a && b < c)
            {
                min = b;
                if (a < c)
                {
                    mid = a;
                    max = c;
                }
                else
                {
                    mid = c;
                    max = a;
                }
            }
            else
            {
                min = c;
                if (a < b)
                {
                    mid = a;
                    max = b;
                }
                else
                {
                    mid = b;
                    max = a;
                }
            }
           
            Console.WriteLine("{0}\n{1}\n{2}\n\n{3}\n{4}\n{5}", min, mid, max, a, b, c);
            Console.ReadKey();



        }
    }
}
