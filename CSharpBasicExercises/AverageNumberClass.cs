using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class AverageNumberClass
    {
        public static void AverageNumber(int x, int y, int z, int l)
        {
            double result = (double)(x + y + z + l) / 4;
            Console.WriteLine($"Average number is: {result}");
        }
    }
}
