using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestBS23
{
    class Program
    {
        static void Main(string[] args)
        {
             long hi = 1000000000000000000L;
            long x, y, z;
            string[] str = Console.ReadLine().Split(' ');
            x = long.Parse(str[0]);
            y = long.Parse(str[1]);
            z = long.Parse(str[2]);


            long lo = 0, ans = -1;
            while (lo <= hi)
            { 

                long mid = (lo + hi) / 2;
                long week = mid / 7;
                bool flag = false;

                for (int i = 0; i < 7; i++)
                {

                    long b = x - week * 3, r = y - week * 2, g = z - week * 2;
                    int idx = i;
                    int remDay = (int)(mid % 7);
                    remDay--;
                    while (remDay!=0)
                    {
                        if (idx == 0) r--;
                        else if (idx == 1) b--;
                        else if (idx == 2) b--;
                        else if (idx == 3) r--;
                        else if (idx == 4) g--;
                        else if (idx == 5) b--;
                        else g--;

                        idx = (idx + 1) % 7;
                        remDay--;
                    }

                    if (b >= 0 && r >= 0 && g >= 0) flag = true;

                }
              
                if (flag)
                {
                    ans = mid;
                    lo = mid + 1;
                }
                else { hi = mid - 1; }
            }
            Console.WriteLine(  ans);
        }
      
        //private static bool check(long now)
        //{
         
        //    long week = now / 7;
        //    bool flag = false;

        //    for (int i = 0; i < 7; i++)
        //    {
                
        //        long b = x - week * 3, r = y - week * 2, g = z - week * 2;
        //        int idx = i;
        //        int remDay = (int)(now % 7);
        //        remDay--;
        //        while(remDay)
        //        {
        //            if (idx == 0) r--;
        //            else if (idx == 1) b--;
        //            else if (idx == 2) b--;
        //            else if (idx == 3) r--;
        //            else if (idx == 4) g--;
        //            else if (idx == 5) b--;
        //            else g--;

        //            idx = (idx + 1) % 7;
        //        }

        //        if (b >= 0 && r >= 0 && g >= 0) flag = true;
                
        //    }
        //    return flag;
        //}
    
   
        
    }
}
