using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rightAlignedStairCase
{
    internal class Staircase
    {
        public static string step(int n, int m) // Method for creating the steps
        {
            string stair = "";
            for (int i = 1; i <= m; i++) // For loop for adding the space
            {
                stair += ' ';
            }
            for (int j = 1; j <= n; j++) //For loop for adding the character step
            {
                stair += '#';
            }
            return stair;
        }
        public static void staircase(int n) //Method for building the staircase
        {
            for (int i = 1; i <= n; i++) // For loop to set each step counts
            {
                Console.WriteLine(step(i, n - i));
            }
        }
    }
}
