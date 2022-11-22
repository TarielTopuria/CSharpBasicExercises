using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class StartingLetterClass
    {
        public static bool StartingLetter(string txt, string letter)
        {
            char[] myChar = new char[txt.Length];

            for (int i = 0; i < txt.Length; i++)
            {
                myChar[i] = txt[i];
            }

            string stringLetter = myChar[0].ToString().ToUpper();
            string finalLetter = letter.ToUpper();

            if (stringLetter.Equals(finalLetter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
