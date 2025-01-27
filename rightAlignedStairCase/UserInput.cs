using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rightAlignedStairCase
{
    public static class UserInput
    {
        private static int numValue;

        public static int NumValue
        {
            get { return numValue; }
            set { numValue = value; }
        }

        public static int getIntValue()
        {   
            int NumValue = Convert.ToInt32(Console.ReadLine());
            return NumValue;
        }
    }
}
