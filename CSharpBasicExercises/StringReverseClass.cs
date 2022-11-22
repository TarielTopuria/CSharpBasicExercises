using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class StringReverseClass
    {
        public static string StringReverse(string txt)
        {
            char[] myChar = new char[txt.Length];
            int start = 0;
            char[] resultString = new char[txt.Length];

            for (int i = 0; i < txt.Length; i++)
            {
                myChar[i] = txt[i];
            }

            for (int i = myChar.Length - 1; i >= 0; i--)
            {
                resultString[start] = myChar[i];
                start++;
            }

            string result = string.Join("", resultString);

            return result;
        }
    }
}
