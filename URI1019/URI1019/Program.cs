using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int h,m,s,n;
            n=Convert.ToInt32(Console.ReadLine());
            h=n/3600;
            m=n%3600/60;
            s=n%60;
            Console.WriteLine("{0}:{1}:{2}", h, m,s);
            Console.ReadKey();
        }
    }
}
