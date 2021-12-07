using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_4
{
    class DBLLinear
    {
      
       public static void Main(string[] args)
        {

            Console.WriteLine("Enter a number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("DblLinear("+a+")"+"="+DblLinear(a));
            Console.ReadKey();
        }
        public static int DblLinear(int n)
        {
            List<int> result = new List<int>(new int[] { 1 });
            List<int> arr = new List<int>(new int[] { 1 });
            List<int> arr2 = new List<int>();
            int i = 0;
            while (Math.Pow(2, i++) < n)
            {
                arr2.Clear();
                arr2.AddRange(arr.Select(s => 2 * s + 1));
                arr2.AddRange(arr.Select(s => 3 * s + 1));
                arr.Clear();
                arr.AddRange(arr2.Distinct());
                result.AddRange(arr.OrderBy(s => s));

            }
            return result.Distinct().OrderBy(s => s).ToList()[n];
        }

    }
}
