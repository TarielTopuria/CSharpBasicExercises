using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class TempConverterClass
    {
        public static void TempConverter(double celsius)
        {
            double fahrenheit = (celsius * 1.8) + 32;
            double kelvin = celsius + 273.15;
            Console.WriteLine($"{celsius} Celsius is {fahrenheit} Fahrenheit");
            Console.WriteLine($"{celsius} Celsius is {kelvin} Kelvin");
        }
    }
}
