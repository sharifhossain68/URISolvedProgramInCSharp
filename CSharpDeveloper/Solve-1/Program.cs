using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] int2Darray = new int[2, 3]{
                                       { 1, 2, 3},
                                        { 4, 5, 6}}; 
            int i = 0;
            int noOfRows = int2Darray.GetLength(0);           
            int noOfColumns = int2Darray.GetLength(1);   
            int[] OneDimensionalArray = new int[noOfRows * noOfColumns];
            
            for (int y = 0; y < noOfColumns; y++)
            {
                for (int x = 0; x < noOfRows; x++)
                {
                    OneDimensionalArray[i] = int2Darray[x, y];
                    i++;
                }
            }            
            Console.WriteLine("1D Array Elements : ");
            foreach (int item in OneDimensionalArray)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
    
}
