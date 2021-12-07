using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1047g
{
    class Program
    {
        static void Main(string[] args)
        {
            int init_hour, init_min, final_hour, final_min;

            int dif;

            string[] values = Console.ReadLine().Split(' ');
            init_hour = int.Parse(values[0]);
            final_hour  = int.Parse(values[1]);
            init_min = int.Parse(values[2]);
            final_min = int.Parse(values[3]);

            dif = ((init_min * 60) + final_min) - ((init_hour * 60) + final_hour);
            if (dif <= 0) 
                dif += 24 * 60;
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", dif / 60, dif % 60);
            Console.ReadKey();
        }
    }
}
