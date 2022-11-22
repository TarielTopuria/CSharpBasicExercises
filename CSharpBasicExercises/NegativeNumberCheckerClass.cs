using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class NegativeNumberCheckerClass
    {
        public static Boolean NegativeNumberChecker(int firtNumber, int secondNumber)
        {
            if (firtNumber >= 0 && secondNumber >= 0)
            {
                return false;
            }
            else if (firtNumber < 0 && secondNumber < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
