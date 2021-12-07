using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d,avg;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            avg = (a + b + c + d) / 4;
            Console.WriteLine("Average: {0}", avg.ToString("0.0"));
            if (avg >= 7.0)
            {
                Console.WriteLine("Approved Student");
            }
            else if(avg>=5.0 && avg<=6.9)
            {
                Console.WriteLine("In exam student");
            }
            else
            {
                Console.WriteLine("Reproved Student");
            }
            double exmScore=double.Parse(Console.ReadLine());
            Console.WriteLine("Exam score: {0}", exmScore);
            avg = (avg + exmScore) / 2;
             if (avg >5.0 )
            {
                Console.WriteLine("Approved student");
            }
            else
            {
                Console.WriteLine("Reproved student");
            }
            Console.ReadKey();
        }
    }
}
