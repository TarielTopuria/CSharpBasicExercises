using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class oddStringClass
    {
        public static string oddString(string txt)
        {
            char[] chars = new char[txt.Length];

            for (int i = 0; i < txt.Length; i++)
            {
                if (i % 2 != 0)
                {
                    chars[i] = (char)txt[i];
                }
            }

            return string.Join("", chars);
        }
    }
}
