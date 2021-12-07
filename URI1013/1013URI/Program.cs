using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1013URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s, temp;
            int[] values = new int[2];
            for (int i = 0; i <= 2; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    a = values[i];
                }
                else if (i == 1)
                {
                    b = values[i];
                }
                else
                {
                    s = values[i];
                }

            }
            
        }
    }
}
