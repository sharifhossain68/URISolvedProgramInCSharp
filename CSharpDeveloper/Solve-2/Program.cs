using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_2
{
    class Program
    {
        static void Main(string[] args)
        {
             string msg = "hello world";
             msg = msg.Replace(" ", string.Empty);
            while (msg.Length > 0)
            {
                Console.Write(msg[0] + " : ");
                int count = 0;
                for (int j = 0; j < msg.Length; j++)
                {
                    if (msg[0] == msg[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                msg = msg.Replace(msg[0].ToString(), string.Empty);
            }
            Console.ReadKey();
        }
    }
}
