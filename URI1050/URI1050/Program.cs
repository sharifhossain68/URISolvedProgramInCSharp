using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int N =Convert.ToInt32( Console.ReadLine());
            if(N==61)
            {
                Console.WriteLine("Brasilia");
            }
            else if(N==71)
                {
                Console.WriteLine("Salvador");
            }
            else if (N == 11)
                {
                Console.WriteLine("Sao Paulo");
            }
            else if (N == 21)
                {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (N == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }
            else if (N == 19)
            {
                Console.WriteLine("Campinas");
            }
            else if (N == 27)
            {
                Console.WriteLine("Vitoria");
            }
            else if (N == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
            Console.ReadKey();
        }
        
    }
}
