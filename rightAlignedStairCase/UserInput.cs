using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rightAlignedStairCase
{
    public static class UserInput
    {
        private static int numValue; //Private declaration for staircase max value

        public static int NumValue // Getters and Setters
        {
            get { return numValue; }
            set { numValue = value; }
        }

        public static int getIntValue() // Get User Input of Max Value
        {
            Console.Write("Enter Max Staircase step: ");
            int NumValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return NumValue;
        }
    }
}
