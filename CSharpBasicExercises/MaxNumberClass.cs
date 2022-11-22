using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class MaxNumberClass
    {
        public static int maxNumber(int firsNumber, int secondNumber, int thirdNumber)
        {
            int result = 0;
            int[] myArray = { firsNumber, secondNumber, thirdNumber };

            for (int i = 0; i < myArray.Length; i++)
            {
                if (result < myArray[i])
                {
                    result = myArray[i];
                }
            }

            return result;
        }
    }
}
