using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simp_eCal
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float c, res;

           
            string[] s = Console.ReadLine().Split(' ');
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            c = float.Parse(s[2]);
            res = b * c;
            string[] str = Console.ReadLine().Split(' ');
            a = int.Parse(str[0]);
            b = int.Parse(str[1]);
            c = float.Parse(str[2]);
            res += b * c;
            Console.WriteLine("VALOR A PAGAR: R$ {0}", res.ToString("0.00"));

            Console.ReadKey();
        }
    }
}
