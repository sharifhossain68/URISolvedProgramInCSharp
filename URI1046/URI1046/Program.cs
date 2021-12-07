using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int start_time, end_time;
            string[] times = Console.ReadLine().Split(' ');
            start_time = int.Parse(times[0]);
            end_time = int.Parse(times[1]);
            if (start_time==end_time)
            {
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", 24 - start_time + end_time);
            }
            else if(start_time<=end_time)
            {
                Console.WriteLine("O JOGO DUROU {0} HORA(S)",end_time - start_time);
            }
            else
            {
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", 24 - start_time + end_time);

            }
            Console.ReadKey();

        }
    }
}
