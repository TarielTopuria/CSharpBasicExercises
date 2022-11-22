using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class MultiplicationTableClass
    {
        public static void MultiplicationTable(int x)
        {
            for (int y = 0; y <= 10; y++)
            {
                Console.WriteLine($"{x} * {y} = {x * y}");
            }
        }
    }
}
