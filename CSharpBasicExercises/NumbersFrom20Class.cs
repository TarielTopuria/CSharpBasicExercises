using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class NumbersFrom20Class
    {
        public static int NumbersFrom20(int firstNumber, int secondNumber)
        {
            int firstNumberAbsolute = Math.Abs(firstNumber - 20);
            int secondNumberAbsolute = Math.Abs(secondNumber - 20);

            if (firstNumberAbsolute == secondNumberAbsolute)
            {
                return 0;
            }
            else if (firstNumberAbsolute < secondNumberAbsolute)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
