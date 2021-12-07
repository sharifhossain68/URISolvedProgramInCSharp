using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1043
{
    class Program
    {
        static void Main(string[] args)
        {

            float a, b, c, area, perimeterTringle;
            string[] str = Console.ReadLine().Split(' ');
            a = float.Parse(str[0]);
            b = float.Parse(str[1]);
            c = float.Parse(str[2]);

            if(a<(b+c)&&b<(c+a)&&c<(a+b))
            {
                perimeterTringle = a + b + c;
                Console.WriteLine("Perimetro = {0}", perimeterTringle.ToString("0.0"));
            }
            else
            {
                area = ((a + b) * c / 2);
                Console.WriteLine("Area = {0}", area.ToString("0.0"));
            }
            Console.ReadKey();
        }
    }
}
