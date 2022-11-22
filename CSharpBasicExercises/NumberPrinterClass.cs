using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class NumberPrinterClass
    {
        public static void numberPrinter(int number)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{number} {number} {number} {number}");
                Console.WriteLine($"{number}{number}{number}{number}");
            }
        }
    }
}
