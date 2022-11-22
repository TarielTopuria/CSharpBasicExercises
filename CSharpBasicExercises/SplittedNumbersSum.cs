using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class SplittedNumbersSum
    {
        public static void splittedNumberSum(int number)
        {
            string numberString = number.ToString();
            int result = 0;
            int someNumber;
            for (int i = 0; i < numberString.Length; i++)
            {
                someNumber = (int)char.GetNumericValue(numberString[i]);
                result = result + someNumber;
            }
            Console.WriteLine(result);
        }
    }
}
