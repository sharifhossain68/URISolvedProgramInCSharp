using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, years, months, days;
            n = Convert.ToInt32(Console.ReadLine());
             years = n / 365;
             months = (n % 365) / 30;
             days= (n % 365) %30;
            Console.WriteLine("{0} ano(s)"+"\n"+ "{1} mes(es)"+"\n"+ "{2} dia(s)",years,months,days);
            Console.ReadKey();
        }
    }
}
