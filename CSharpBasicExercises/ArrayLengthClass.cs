using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class ArrayLengthClass
    {
        public static int arrayLength(params int[] arr)
        {
            int length = 0;

            foreach (int i in arr)
            {
                length++;
            }

            return length;
        }
    }
}
