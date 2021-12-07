using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            if (str=="vertebrado")
            {
                
                if (str2=="ave")
                {
                    
                    if (str3=="carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                       
                    
                }
                else
                {
                   
                    if (str3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                   else
                    {
                        Console.WriteLine("vaca");
                    }
                   
                }
            }
            else 
            {
                
                if (str2 == "inseto")
                {
                   
                    if (str3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
               else
                {
                    
                    if (str3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }

                }
            }
            Console.ReadKey();
        }
       
    }
}
