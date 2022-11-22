using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class NumberSwapperClass
    {
        public static void NumberSwapper(int x, int y)
        {
            Console.WriteLine($"Before swap x = {x}");
            Console.WriteLine($"Before swap y = {y}");
            int z = x;
            x = y;
            y = z;
            Console.WriteLine($"After swap x = {x}");
            Console.WriteLine($"After swap y = {y}");
        }
    }
}
