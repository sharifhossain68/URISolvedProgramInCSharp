using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            n = Convert.ToInt32(Console.ReadLine());
            while (n!=0)
            {
               
                int[] a =new int[n];
                for (int o = 0; o < n; o++) {
                    a[o] = Convert.ToInt32(Console.ReadLine());
                  }


               int m= a.Length + n
                Array.Sort(a,m);
                ll ans = 0;
                for (i = 0; i < n; i++)
                {
                    ll x = a[i] * 2;

                    ll up = upper_bound(a + i + 1, a + n, x) - (a + 1 + i);

                    ans += up;
                }
                cout << ans << endl;
            }
    }
}
