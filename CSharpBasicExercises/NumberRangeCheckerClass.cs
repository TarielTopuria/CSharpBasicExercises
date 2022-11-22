using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class NumberRangeCheckerClass
    {
        public static void NumberRangeChecker(int number)
        {
            if (number >= 20 && number <= 100)
            {
                Console.WriteLine("Number is in the range of 20 and 100");
            }
            else
            {
                Console.WriteLine("Number is out of the range of 20 and 100");
            }
        }
    }
}
