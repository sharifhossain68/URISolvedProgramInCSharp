using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary, value, TOTAL;
            string name;
            name = Console.ReadLine();
            salary =Convert.ToDouble( Console.ReadLine());
            value = Convert.ToDouble( Console.ReadLine());
         

            TOTAL = salary + value * .15;
            Console.WriteLine("TOTAL = R$ {0}", TOTAL.ToString("0.00"));
            Console.ReadKey();
       
        }
    }
}
