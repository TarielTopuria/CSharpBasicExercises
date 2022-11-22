using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class CharReplacerClass
    {
        public static void CharReplacer(string phrase)
        {
            char[] myChar = new char[phrase.Length];
            for (int i = 0; i < phrase.Length; i++)
            {
                myChar[i] = phrase[i];
            }
            char firstLetter = myChar[0];
            myChar[0] = myChar[myChar.Length - 1];
            myChar[myChar.Length - 1] = firstLetter;
            Console.WriteLine(myChar);
        }
    }
}
