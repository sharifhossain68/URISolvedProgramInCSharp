using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1008Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER, hours;
            double amount, SALARY;
            NUMBER = Convert.ToInt32(Console.ReadLine());
            hours = Convert.ToInt32(Console.ReadLine());
            amount = Convert.ToDouble(Console.ReadLine());
            SALARY = hours * amount;

            Console.WriteLine("NUMBER = {0}", NUMBER);
          
            Console.WriteLine("SALARY = U$ {0}", SALARY.ToString("0.00"));

        
        }
    }
}
