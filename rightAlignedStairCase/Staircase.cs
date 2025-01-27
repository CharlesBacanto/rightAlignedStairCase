using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rightAlignedStairCase
{
    internal class Staircase
    {
        public static string step(int n, int m)
        {
            string stair = "";
            for (int i = 1; i <= m; i++)
            {
                stair += ' ';
            }
            for (int j = 1; j <= n; j++)
            {
                stair += '#';
            }
            return stair;
        }
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(step(i, n - i));
            }
        }
    }
}
