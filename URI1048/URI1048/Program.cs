using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary,money_Earned, parcentage;
           

            salary = Convert.ToDouble(Console.ReadLine());
            if(salary>=0 && salary<=400.00)
            {
                parcentage = 15;
                money_Earned = salary * parcentage / 100;
                salary = salary+ money_Earned;
               
            }
            else if(salary>=400.01 && salary <= 800.00)
            {
                parcentage = 12;
                money_Earned = salary * parcentage / 100;
                salary = salary + money_Earned;
            }
            else if ( salary>=800.01 &&  salary <= 1200.00)
            {
                parcentage = 10;
                money_Earned = salary * parcentage / 100;
                salary = salary + money_Earned;
            }
            else if (salary>=1200.01 && salary <= 2000.00)
            {
                parcentage = 7;
                money_Earned = salary * parcentage / 100;
                salary = salary + money_Earned;
            }
            else 
            {
                parcentage = 4;
                money_Earned = salary * parcentage / 100;
                salary = salary + money_Earned;
            }
            Console.WriteLine("New Salary : {0}", salary.ToString("0.00"));
            Console.WriteLine("Money earned : {0}", money_Earned.ToString("0.00"));
            Console.WriteLine("In percentage : {0} %", parcentage);
            Console.ReadKey();
        }
    }
}
