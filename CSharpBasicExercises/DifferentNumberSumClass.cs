using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class DifferentNumberSumClass
    {
        public static int DifferentNumberSum(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                return (firstNumber + secondNumber) * 3;
            }
            else
            {
                return firstNumber + secondNumber;
            }
        }
    }
}
