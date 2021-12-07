using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = Convert.ToDouble(Console.ReadLine());
            if (salary <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salary >= 2000.01 && salary <= 3000.00)
            {
                Console.WriteLine("R$ {0}", ((salary - 2000.00) * 0.08).ToString("0.00"));
            }
            else if (salary >= 3000.01 && salary <= 4500.00)
            {
                Console.WriteLine("R$ {0}", (((salary - 3000.00) * 0.18 + 1000.00 * 0.08)).ToString());
            }
            else if (salary >= 4500.01)
            {
                Console.WriteLine("R$ {0}", ((((salary - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08)).ToString()));
            }
            Console.ReadKey();
        }
    }
}
