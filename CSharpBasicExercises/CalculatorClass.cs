using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class CalculatorClass
    {
        public static void calculator(int x, int y)
        {
            Console.WriteLine($"sum: {x + y}");
            Console.WriteLine($"substract: {x - y}");
            Console.WriteLine($"multiply: {x * y}");
            Console.WriteLine($"divide: {x / y}");
        }
    }
}
