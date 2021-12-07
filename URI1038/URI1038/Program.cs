using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            float price = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
           
                if(x==1 )
                {                 
                   price = (float)(4.00 * y);
                }
                else if(x == 2)
                {                
                  price = (float)(4.50 * y);
                }
                else if (x == 3)
                {                
                   price = (float)(5.00 * y);
                }
        
                else if (x == 4)
                {                  
                   price = (float)(2.00 * y);
                }

                else if (x == 5)
                {
                   price = (float) (1.50 * y);
                 }
                
            Console.WriteLine("Total : R$ {0}", price.ToString("0.00"));
            Console.ReadKey();
           
        }
    }
}
