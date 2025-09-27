using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Practice
{
    public class Multidimensional_Iteration
    {
        public static void Main(string[] args)
        {
            // Declaration and Initialization with Multidimensional Array
            int[][,] arr = new int[2][,] {
            new int[, ] { { 1, 3 }, { 5, 7 } },
            new int[, ] { { 0, 2 }, { 4, 6 }, { 8, 10 } }
        };
            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].GetLength(0); j++)
                {
                    for (int k = 0; k < arr[i].GetLength(1); k++)
                    {
                        Console.Write("arr[" + i + "][" + j + ", " + k + "] => " + arr[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
