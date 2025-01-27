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
        private static char stairCaseComponent; //Private declaration of the character that compose the stairs

        public static int NumValue // Getters and Setters
        {
            get { return numValue; }
            set { numValue = value; }
        }

        public static char StairCaseComponent
        {
            get { return stairCaseComponent; }
            set { stairCaseComponent = value; }
        }

        public static int getIntValue() // Get User Input of Max Value
        {
            Console.Write("Enter Max Staircase step: ");
            int NumValue = Convert.ToInt32(Console.ReadLine());
            return NumValue;
        }

        public static char getCharValue() // Get User Input of Character
        {
            Console.Write("Enter Character for Staircase: ");
            char StairCaseComponent = Convert.ToChar(Console.Read());
            return StairCaseComponent;
        }
    }
}
