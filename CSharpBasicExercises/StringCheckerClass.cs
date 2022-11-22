using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class StringCheckerClass
    {
        public static bool StringChecker(string txt)
        {
            bool result = false;
            char[] myChars = new char[txt.Length];
            for (int i = 0; i < txt.Length; i++)
            {
                myChars[i] = txt[i];
            }

            string firstChar = myChars[0].ToString().ToUpper();
            string secondChar = myChars[1].ToString().ToUpper();

            if (firstChar.Equals("w") || firstChar.Equals("W"))
            {
                if (firstChar.Equals(secondChar))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
