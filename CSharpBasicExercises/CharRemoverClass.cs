using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class CharRemoverClass
    {
        public static void CharRemover(string phrase, int index)
        {
            string NewPhrase = phrase.Remove(index) + phrase.Substring(index + 1);
            Console.WriteLine(NewPhrase);
        }
    }
}
