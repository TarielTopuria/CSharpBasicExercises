using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class PalindromeStringClass
    {
        public static bool palindromePhrase(string txt)
        {
            char[] chars = txt.ToCharArray();
            char[] reversedChars = new char[txt.Length];
            int counter = 0;
            bool result = false;

            for (int i = txt.Length - 1; i >= 0; i--)
            {
                reversedChars[counter] = chars[i];
                counter++;
            }

            string firstString = string.Join("", chars).ToUpper();
            string secondString = string.Join("", reversedChars).ToUpper();

            if (firstString.Equals(secondString))
            {
                result = true;
            }

            return result;

        }
    }
}
